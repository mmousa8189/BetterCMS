﻿using System;

using BetterCms.Core.Models;
using BetterCms.Module.Api.Extensions;
using BetterCms.Module.Api.Infrastructure;
using BetterCms.Module.Api.Operations.Pages.Sitemaps.Sitemap.Nodes;
using BetterCms.Module.Api.Operations.Pages.Sitemaps.Sitemap.Nodes.Node;

using NHibernate;

using NUnit.Framework;

namespace BetterCms.Test.Module.Api.Pages.Sitemaps.Nodes
{
    [TestFixture]
    public class NodesTests : ApiCrudIntegrationTestBase<
        SaveNodeModel, SitemapNodeModel,
        PostSitemapNodeRequest, PostSitemapNodeResponse,
        GetNodeRequest, GetNodeResponse,
        PutNodeRequest, PutNodeResponse,
        DeleteNodeRequest, DeleteNodeResponse>
    {
        private int updatedSitemapEventCount;

        private Guid SitemapId { get; set; }

        [Test]
        public void Should_CRUD_Node_Successfully()
        {
            // Attach to events
            Events.SitemapEvents.Instance.SitemapUpdated += Instance_SitemapUpdated;
            Events.SitemapEvents.Instance.SitemapNodeCreated += Instance_EntityCreated;
            Events.SitemapEvents.Instance.SitemapNodeUpdated += Instance_EntityUpdated;
            Events.SitemapEvents.Instance.SitemapNodeDeleted += Instance_EntityDeleted;

            RunApiActionInTransaction(
                (api, session) =>
                    {
                        var sitemap = this.TestDataProvider.CreateNewSitemap();
                        session.SaveOrUpdate(sitemap);
                        session.Flush();
                        SitemapId = sitemap.Id;

                        Run(session, api.Pages.SitemapNew.Nodes.Post, api.Pages.SitemapNew.Node.Get, api.Pages.SitemapNew.Node.Put, api.Pages.SitemapNew.Node.Delete);
                    });

            Assert.AreEqual(3, updatedSitemapEventCount, "Updated sitemap events fired count");

            // Detach from events
            Events.SitemapEvents.Instance.SitemapNodeCreated -= Instance_EntityCreated;
            Events.SitemapEvents.Instance.SitemapNodeUpdated -= Instance_EntityUpdated;
            Events.SitemapEvents.Instance.SitemapNodeDeleted -= Instance_EntityDeleted;
        }

        void Instance_SitemapUpdated(Events.SingleItemEventArgs<BetterCms.Module.Pages.Models.Sitemap> args)
        {
            updatedSitemapEventCount++;
        }

        protected override SaveNodeModel GetCreateModel(ISession session)
        {
            return new SaveNodeModel
                       {
                           Title = TestDataProvider.ProvideRandomString(MaxLength.Name),
                           Url = TestDataProvider.ProvideRandomString(MaxLength.Url),
                           PageId = null,
                           DisplayOrder = 1,
                           Macro = TestDataProvider.ProvideRandomString(MaxLength.Text),
                           Translations = new SaveNodeTranslation[0],
                           UsePageTitleAsNodeTitle = false,
                           ParentId = null
                       };
        }

        protected override GetNodeRequest GetGetRequest(SaveResponseBase saveResponseBase)
        {
            return new GetNodeRequest
                       {
                           SitemapId = this.SitemapId,
                           NodeId = saveResponseBase.Data.Value
                       };
        }

        protected override PostSitemapNodeRequest GetCreateRequest(SaveNodeModel model)
        {
            var request = base.GetCreateRequest(model);
            request.SitemapId = this.SitemapId;
            return request;
        }

        protected override PutNodeRequest GetUpdateRequest(GetNodeResponse getResponse)
        {
            var request = getResponse.ToPutRequest();
            request.Data.Title = this.TestDataProvider.ProvideRandomString(MaxLength.Name);
            return request;
        }

        protected override DeleteNodeRequest GetDeleteRequest(GetNodeResponse getResponse)
        {
            var request = base.GetDeleteRequest(getResponse);
            request.SitemapId = getResponse.Data.SitemapId;
            return request;
        }

        protected override void OnAfterGet(GetNodeResponse getResponse, SaveNodeModel saveModel)
        {
            base.OnAfterGet(getResponse, saveModel);

            Assert.AreEqual(getResponse.Data.Title, saveModel.Title);
            Assert.AreEqual(getResponse.Data.Url, saveModel.Url);
            Assert.AreEqual(getResponse.Data.DisplayOrder, saveModel.DisplayOrder);
            Assert.AreEqual(getResponse.Data.Macro, saveModel.Macro);
            Assert.AreEqual(getResponse.Data.UsePageTitleAsNodeTitle, saveModel.UsePageTitleAsNodeTitle);
            Assert.AreEqual(getResponse.Data.PageId, saveModel.PageId);
            Assert.AreEqual(getResponse.Data.ParentId, saveModel.ParentId);
        }
    }
}