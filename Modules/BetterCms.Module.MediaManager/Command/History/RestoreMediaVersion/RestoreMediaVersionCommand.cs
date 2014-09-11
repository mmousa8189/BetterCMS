﻿using System;
using System.Linq;

using BetterCms.Core.DataAccess.DataContext.Fetching;
using BetterCms.Core.Mvc.Commands;

using BetterCms.Module.MediaManager.Models;
using BetterCms.Module.MediaManager.Models.Extensions;
using BetterCms.Module.MediaManager.Services;
using BetterCms.Module.Root.Mvc;

namespace BetterCms.Module.MediaManager.Command.History.RestoreMediaVersion
{
    public class RestoreMediaVersionCommand : CommandBase, ICommand<Guid, bool>
    {
        private IMediaImageService imageService;

        public RestoreMediaVersionCommand(IMediaImageService imageService)
        {
            this.imageService = imageService;
        }

        public bool Execute(Guid mediaHistoryItemId)
        {
            var imageToRevert = Repository
                .AsQueryable<MediaImage>(i => i.Id == mediaHistoryItemId)
                .Fetch(f => f.Original)
                .FirstOrDefault();

            if (imageToRevert != null)
            {
                var currentOriginal = Repository
                .AsQueryable<MediaImage>(i => imageToRevert.Original != null && i.Id == imageToRevert.Original.Id)
                .Fetch(f => f.Original)
                .FirstOrDefault();

                if (currentOriginal != null)
                {
                    var newOriginalImage = imageService.MakeAsOriginal(imageToRevert, currentOriginal);
                    Events.MediaManagerEvents.Instance.OnMediaRestored(newOriginalImage);
                }

                return true;
            }
            
            var versionToRevert = Repository.AsQueryable<Media>(p => p.Id == mediaHistoryItemId).Fetch(f => f.Original).First();

            var original = versionToRevert.Original;

            if (original != null)
            {
                UnitOfWork.BeginTransaction();
                Repository.Save(original.CreateHistoryItem());
                versionToRevert.CopyDataTo(original);
                original.Original = null;
                original.PublishedOn = DateTime.Now;
                Repository.Save(original);
                UnitOfWork.Commit();

                Events.MediaManagerEvents.Instance.OnMediaRestored(original);

                return true;
            }

            return false;
        }
    }
}