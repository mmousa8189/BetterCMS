﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Shared\Partial\Modal.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Partial/Modal.cshtml")]
    public partial class _Views_Shared_Partial_Modal_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_Partial_Modal_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-modal-template\"");

WriteLiteral(">\r\n    <div class=\"bcms-modal bcms-layer\" spellcheck=\"true\">\r\n        <div class=" +
"\"bcms-modal-body\">\r\n            <div class=\"bcms-modal-header\">\r\n               " +
" <div class=\"bcms-modal-title\">");

            
            #line 6 "..\..\Views\Shared\Partial\Modal.cshtml"
                                         Write(RootGlobalization.Message_Loading);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div class=\"bcms-modal-close\"> </div>\r\n            </div>" +
"\r\n            <div class=\"bcms-modal-content\">\r\n                <div class=\"bcms" +
"-loader\"></div>\r\n                <div class=\"bcms-modal-content-padded\" data-bin" +
"d=\"stopBinding: true\"></div>\r\n            </div>\r\n            <div class=\"bcms-m" +
"odal-footer\">\r\n                <div class=\"bcms-modal-footer-buttons\" style=\"flo" +
"at: left\" data-bind=\"foreach: buttons\">\r\n                    <div data-bind=\"tex" +
"t: title, css: css, click: click, visible: !disabled()\"></div>\r\n                " +
"</div>\r\n\r\n                <div class=\"bcms-modal-cmslogo\">\r\n                    " +
"<svg preserveAspectRatio=\"xMidYMid\" width=\"134\" height=\"34\" viewBox=\"0 0 134 34\"" +
">\r\n                        <g>\r\n                            <path fill=\"#30eeff\"" +
" fill-rule=\"evenodd\" d=\"M33.015,-0.012 L0.012,-0.012 L0.012,34.011 L33.015,34.01" +
"1 L33.015,-0.012 Z\" />\r\n                            <path fill=\"#2fb6d3\" fill-ru" +
"le=\"evenodd\" d=\"M12.410,12.738 L12.409,12.738 L0.013,34.013 L12.410,34.010 L12.4" +
"10,12.738 Z\" />\r\n                            <path fill=\"#ff3175\" fill-rule=\"eve" +
"nodd\" d=\"M12.416,34.012 L33.070,34.012 L33.070,12.756 L12.416,12.756 L12.416,34." +
"012 Z\" />\r\n                            <path fill=\"#af3075\" fill-rule=\"evenodd\" " +
"d=\"M12.410,34.009 L20.430,34.009 L25.399,26.107 L12.410,26.107 L12.410,34.009 Z\"" +
" />\r\n                            <path fill=\"#00a662\" fill-rule=\"evenodd\" d=\"M25" +
".399,12.755 L12.410,12.755 L12.410,26.107 L25.399,26.107 L25.399,12.755 Z\" />\r\n " +
"                           <path fill=\"#008057\" fill-rule=\"evenodd\" d=\"M17.731,1" +
"8.218 L17.730,18.218 L12.410,26.107 L17.731,26.107 L17.731,18.218 Z\" />\r\n       " +
"                     <path fill=\"#ffffff\" fill-rule=\"evenodd\" d=\"M25.399,18.222 " +
"L17.730,18.222 L17.730,26.108 L25.399,26.108 L25.399,18.222 Z\" />\r\n             " +
"               <path fill=\"#ffffff\" fill-rule=\"evenodd\" d=\"M126.824,17.968 C127." +
"121,18.156 127.497,18.318 127.951,18.456 C128.406,18.593 128.942,18.731 129.560," +
"18.868 C130.251,19.018 130.869,19.184 131.415,19.365 C131.960,19.547 132.426,19." +
"778 132.814,20.059 C133.202,20.340 133.499,20.685 133.705,21.091 C133.911,21.497" +
" 134.014,22.000 134.014,22.600 C134.014,23.213 133.899,23.744 133.669,24.195 C13" +
"3.439,24.645 133.117,25.020 132.705,25.320 C132.293,25.620 131.802,25.842 131.23" +
"3,25.986 C130.663,26.129 130.045,26.201 129.378,26.201 C127.354,26.201 125.627,2" +
"5.558 124.197,24.270 L124.815,23.201 C125.288,23.713 125.924,24.148 126.724,24.5" +
"04 C127.524,24.860 128.415,25.039 129.396,25.039 C130.427,25.039 131.233,24.848 " +
"131.814,24.467 C132.396,24.085 132.687,23.507 132.687,22.732 C132.687,22.319 132" +
".605,21.972 132.442,21.691 C132.278,21.410 132.033,21.166 131.705,20.959 C131.37" +
"8,20.753 130.969,20.575 130.478,20.425 C129.987,20.275 129.421,20.125 128.778,19" +
".975 C128.099,19.812 127.506,19.644 126.997,19.468 C126.488,19.293 126.060,19.07" +
"5 125.715,18.812 C125.370,18.549 125.109,18.234 124.933,17.865 C124.757,17.496 1" +
"24.670,17.043 124.670,16.505 C124.670,15.893 124.782,15.346 125.006,14.864 C125." +
"230,14.383 125.545,13.983 125.951,13.664 C126.357,13.345 126.842,13.101 127.406," +
"12.932 C127.969,12.764 128.590,12.679 129.269,12.679 C130.117,12.679 130.878,12." +
"814 131.551,13.082 C132.224,13.351 132.833,13.729 133.378,14.217 L132.778,15.267" +
" C132.414,14.842 131.926,14.498 131.315,14.236 C130.702,13.973 130.015,13.842 12" +
"9.251,13.842 C128.099,13.842 127.263,14.064 126.742,14.508 C126.221,14.952 125.9" +
"60,15.555 125.960,16.318 C125.960,16.718 126.030,17.046 126.169,17.302 C126.309," +
"17.559 126.527,17.780 126.824,17.968 ZM120.670,15.155 L115.961,23.613 L115.216,2" +
"3.613 L110.489,15.155 L110.489,26.089 L109.235,26.089 L109.235,12.773 L110.525,1" +
"2.773 L115.580,21.888 L120.634,12.773 L121.925,12.773 L121.925,26.089 L120.670,2" +
"6.089 L120.670,15.155 ZM98.535,23.322 C98.966,23.841 99.475,24.254 100.063,24.56" +
"0 C100.650,24.867 101.290,25.020 101.981,25.020 C102.344,25.020 102.717,24.973 1" +
"03.099,24.879 C103.481,24.785 103.850,24.635 104.208,24.429 C104.565,24.223 104." +
"896,23.967 105.199,23.660 C105.501,23.354 105.756,22.982 105.962,22.544 L107.017" +
",23.107 C106.810,23.607 106.520,24.048 106.144,24.429 C105.768,24.811 105.350,25" +
".132 104.890,25.395 C104.429,25.657 103.941,25.858 103.426,25.995 C102.911,26.13" +
"2 102.405,26.201 101.908,26.201 C101.023,26.201 100.211,26.001 99.472,25.601 C98" +
".732,25.201 98.096,24.679 97.563,24.035 C97.029,23.391 96.614,22.660 96.317,21.8" +
"41 C96.020,21.022 95.872,20.188 95.872,19.337 C95.872,18.537 96.008,17.740 96.28" +
"1,16.946 C96.554,16.152 96.951,15.443 97.472,14.817 C97.993,14.192 98.635,13.683" +
" 99.399,13.289 C100.163,12.895 101.029,12.698 101.999,12.698 C103.150,12.698 104" +
".132,12.967 104.944,13.504 C105.756,14.042 106.362,14.742 106.762,15.605 L105.74" +
"4,16.243 C105.538,15.805 105.290,15.436 104.999,15.136 C104.708,14.836 104.392,1" +
"4.592 104.053,14.405 C103.714,14.217 103.362,14.083 102.999,14.001 C102.635,13.9" +
"20 102.278,13.879 101.926,13.879 C101.150,13.879 100.465,14.042 99.872,14.367 C9" +
"9.278,14.692 98.778,15.117 98.372,15.642 C97.966,16.168 97.660,16.758 97.454,17." +
"415 C97.248,18.071 97.145,18.737 97.145,19.412 C97.145,20.150 97.269,20.856 97.5" +
"17,21.531 C97.766,22.207 98.105,22.804 98.535,23.322 ZM88.309,18.156 C87.691,18." +
"606 87.254,19.225 87.000,20.012 L87.000,26.089 L85.764,26.089 L85.764,16.318 L86" +
".927,16.318 L86.927,18.662 C87.254,17.974 87.685,17.402 88.218,16.946 C88.751,16" +
".490 89.327,16.261 89.945,16.261 C90.054,16.261 90.157,16.261 90.254,16.261 C90." +
"351,16.261 90.430,16.268 90.491,16.280 L90.491,17.443 C89.654,17.468 88.927,17.7" +
"05 88.309,18.156 ZM83.873,21.663 L75.783,21.663 C75.819,22.188 75.937,22.673 76." +
"137,23.116 C76.337,23.560 76.592,23.945 76.901,24.270 C77.210,24.595 77.567,24.8" +
"48 77.973,25.029 C78.379,25.211 78.813,25.301 79.273,25.301 C79.588,25.301 79.89" +
"8,25.257 80.201,25.170 C80.503,25.083 80.782,24.964 81.037,24.814 C81.291,24.663" +
" 81.519,24.479 81.719,24.260 C81.919,24.042 82.073,23.801 82.182,23.538 L83.255," +
"23.838 C83.109,24.201 82.903,24.529 82.637,24.823 C82.370,25.117 82.061,25.373 8" +
"1.710,25.592 C81.358,25.811 80.970,25.980 80.546,26.098 C80.122,26.217 79.685,26" +
".276 79.237,26.276 C78.546,26.276 77.910,26.142 77.328,25.873 C76.746,25.604 76." +
"243,25.235 75.819,24.767 C75.395,24.298 75.065,23.757 74.828,23.144 C74.592,22.5" +
"32 74.474,21.875 74.474,21.175 C74.474,20.488 74.592,19.841 74.828,19.234 C75.06" +
"5,18.628 75.395,18.096 75.819,17.640 C76.243,17.184 76.743,16.821 77.319,16.552 " +
"C77.895,16.283 78.528,16.149 79.219,16.149 C79.910,16.149 80.543,16.283 81.119,1" +
"6.552 C81.694,16.821 82.188,17.187 82.600,17.649 C83.012,18.112 83.334,18.643 83" +
".564,19.243 C83.794,19.843 83.909,20.481 83.909,21.156 C83.909,21.257 83.906,21." +
"356 83.900,21.456 C83.894,21.557 83.885,21.625 83.873,21.663 ZM82.373,19.253 C82" +
".173,18.821 81.919,18.449 81.610,18.137 C81.301,17.824 80.940,17.581 80.528,17.4" +
"05 C80.116,17.230 79.679,17.143 79.219,17.143 C78.758,17.143 78.322,17.230 77.91" +
"0,17.405 C77.498,17.581 77.137,17.824 76.828,18.137 C76.519,18.449 76.271,18.825" +
" 76.083,19.262 C75.895,19.700 75.783,20.175 75.746,20.687 L82.728,20.687 C82.691" +
",20.162 82.573,19.684 82.373,19.253 ZM72.838,25.958 C72.656,26.020 72.450,26.077" +
" 72.220,26.126 C71.989,26.176 71.747,26.201 71.492,26.201 C71.226,26.201 70.971," +
"26.164 70.729,26.089 C70.486,26.014 70.274,25.898 70.093,25.742 C69.911,25.586 6" +
"9.765,25.389 69.656,25.151 C69.547,24.914 69.493,24.639 69.493,24.326 L69.493,17" +
".330 L68.184,17.330 L68.184,16.318 L69.493,16.318 L69.493,13.017 L70.729,13.017 " +
"L70.729,16.318 L72.911,16.318 L72.911,17.330 L70.729,17.330 L70.729,23.970 C70.7" +
"53,24.332 70.874,24.598 71.092,24.767 C71.311,24.935 71.571,25.020 71.874,25.020" +
" C72.226,25.020 72.535,24.961 72.801,24.842 C73.068,24.723 73.238,24.639 73.310," +
"24.588 L73.638,25.620 C73.565,25.657 73.459,25.708 73.320,25.770 C73.180,25.833 " +
"73.020,25.895 72.838,25.958 ZM66.820,25.958 C66.638,26.020 66.432,26.077 66.202," +
"26.126 C65.972,26.176 65.729,26.201 65.475,26.201 C65.208,26.201 64.954,26.164 6" +
"4.711,26.089 C64.469,26.014 64.257,25.898 64.075,25.742 C63.893,25.586 63.748,25" +
".389 63.639,25.151 C63.530,24.914 63.475,24.639 63.475,24.326 L63.475,17.330 L62" +
".166,17.330 L62.166,16.318 L63.475,16.318 L63.475,13.017 L64.711,13.017 L64.711," +
"16.318 L66.893,16.318 L66.893,17.330 L64.711,17.330 L64.711,23.970 C64.735,24.33" +
"2 64.857,24.598 65.075,24.767 C65.293,24.935 65.554,25.020 65.857,25.020 C66.208" +
",25.020 66.517,24.961 66.784,24.842 C67.050,24.723 67.220,24.639 67.293,24.588 L" +
"67.620,25.620 C67.547,25.657 67.441,25.708 67.302,25.770 C67.163,25.833 67.002,2" +
"5.895 66.820,25.958 ZM61.239,21.663 L53.149,21.663 C53.185,22.188 53.303,22.673 " +
"53.503,23.116 C53.703,23.560 53.958,23.945 54.267,24.270 C54.576,24.595 54.933,2" +
"4.848 55.339,25.029 C55.745,25.211 56.178,25.301 56.639,25.301 C56.954,25.301 57" +
".263,25.257 57.566,25.170 C57.869,25.083 58.148,24.964 58.403,24.814 C58.657,24." +
"663 58.884,24.479 59.084,24.260 C59.284,24.042 59.439,23.801 59.548,23.538 L60.6" +
"21,23.838 C60.475,24.201 60.269,24.529 60.003,24.823 C59.736,25.117 59.427,25.37" +
"3 59.075,25.592 C58.724,25.811 58.336,25.980 57.912,26.098 C57.487,26.217 57.051" +
",26.276 56.603,26.276 C55.912,26.276 55.276,26.142 54.694,25.873 C54.112,25.604 " +
"53.609,25.235 53.185,24.767 C52.760,24.298 52.430,23.757 52.194,23.144 C51.958,2" +
"2.532 51.840,21.875 51.840,21.175 C51.840,20.488 51.958,19.841 52.194,19.234 C52" +
".430,18.628 52.760,18.096 53.185,17.640 C53.609,17.184 54.109,16.821 54.685,16.5" +
"52 C55.260,16.283 55.894,16.149 56.585,16.149 C57.275,16.149 57.909,16.283 58.48" +
"4,16.552 C59.060,16.821 59.554,17.187 59.966,17.649 C60.378,18.112 60.699,18.643" +
" 60.930,19.243 C61.160,19.843 61.275,20.481 61.275,21.156 C61.275,21.257 61.272," +
"21.356 61.266,21.456 C61.260,21.557 61.251,21.625 61.239,21.663 ZM59.739,19.253 " +
"C59.539,18.821 59.284,18.449 58.975,18.137 C58.666,17.824 58.305,17.581 57.894,1" +
"7.405 C57.481,17.230 57.045,17.143 56.585,17.143 C56.124,17.143 55.688,17.230 55" +
".276,17.405 C54.863,17.581 54.503,17.824 54.194,18.137 C53.885,18.449 53.636,18." +
"825 53.448,19.262 C53.260,19.700 53.149,20.175 53.112,20.687 L60.093,20.687 C60." +
"057,20.162 59.939,19.684 59.739,19.253 ZM50.312,22.657 C50.312,23.157 50.215,23." +
"616 50.021,24.035 C49.827,24.454 49.567,24.817 49.240,25.123 C48.912,25.429 48.5" +
"31,25.667 48.094,25.836 C47.658,26.004 47.191,26.089 46.694,26.089 L40.622,26.08" +
"9 L40.622,12.773 L46.822,12.773 C47.270,12.773 47.676,12.873 48.040,13.073 C48.4" +
"03,13.273 48.713,13.533 48.967,13.851 C49.222,14.170 49.418,14.533 49.558,14.939" +
" C49.697,15.346 49.767,15.755 49.767,16.168 C49.767,16.843 49.603,17.459 49.276," +
"18.015 C48.949,18.571 48.494,18.987 47.913,19.262 C48.652,19.487 49.237,19.906 4" +
"9.667,20.519 C50.097,21.131 50.312,21.844 50.312,22.657 ZM48.367,17.302 C48.476," +
"17.009 48.531,16.699 48.531,16.374 C48.531,16.036 48.479,15.717 48.376,15.417 C4" +
"8.273,15.117 48.128,14.858 47.940,14.639 C47.752,14.420 47.528,14.245 47.267,14." +
"114 C47.006,13.983 46.725,13.917 46.422,13.917 L41.877,13.917 L41.877,18.831 L46" +
".313,18.831 C46.628,18.831 46.922,18.762 47.194,18.624 C47.467,18.487 47.703,18." +
"306 47.903,18.081 C48.103,17.855 48.258,17.596 48.367,17.302 ZM48.876,21.485 C48" +
".767,21.178 48.613,20.910 48.413,20.678 C48.213,20.447 47.976,20.259 47.703,20.1" +
"15 C47.431,19.972 47.137,19.900 46.822,19.900 L41.877,19.900 L41.877,24.945 L46." +
"694,24.945 C47.022,24.945 47.331,24.876 47.622,24.738 C47.913,24.601 48.161,24.4" +
"17 48.367,24.185 C48.573,23.954 48.737,23.685 48.858,23.379 C48.979,23.073 49.04" +
"0,22.757 49.040,22.432 C49.040,22.107 48.985,21.791 48.876,21.485 Z\" />\r\n       " +
"                 </g>\r\n                    </svg>\r\n                </div>\r\n     " +
"       </div>\r\n        </div>\r\n    </div>\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
