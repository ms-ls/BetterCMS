﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OpenGraphIntegrationModuleDescriptor.cs" company="Devbridge Group LLC">
// 
// Copyright (C) 2015,2016 Devbridge Group LLC
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
// </copyright>
// 
// <summary>
// Better CMS is a publishing focused and developer friendly .NET open source CMS.
// 
// Website: https://www.bettercms.com 
// GitHub: https://github.com/devbridge/bettercms
// Email: info@bettercms.com
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using Autofac;

using BetterCms.Core.Modules;

using BetterCms.Events;

using BetterCms.Module.OpenGraphIntegration.Projections;
using BetterCms.Module.Pages.Helpers.Extensions;

using BetterModules.Core.Dependencies;
using BetterModules.Core.Web.Web;

namespace BetterCms.Module.OpenGraphIntegration
{
    public class OpenGraphIntegrationModuleDescriptor : CmsModuleDescriptor
    {
        internal const string ModuleName = "opengraph_integration";

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Name
        {
            get
            {
                return ModuleName;
            }
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public override string Description
        {
            get
            {
                return "The Open Graph integration module for Better CMS.";
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenGraphIntegrationModuleDescriptor"/> class
        /// </summary>
        /// <param name="configuration">The configuration</param>
        public OpenGraphIntegrationModuleDescriptor(ICmsConfiguration configuration)
            : base(configuration)
        {
            RootEvents.Instance.PageRendering += Events_PageRendering;
        }

        /// <summary>
        /// Add google analytics script accessor to Page.
        /// </summary>
        /// <param name="args">The args.</param>
        private void Events_PageRendering(PageRenderingEventArgs args)
        {
            IHttpContextAccessor httpContextAccessor;

            using (var container = ContextScopeProvider.CreateChildContainer())
            {
                httpContextAccessor = container.Resolve<IHttpContextAccessor>();
            }

            var openGraphMetaTitle = new OpenGraphMetaDataProjection("title", args.RenderPageData.PageData.Title);
            AddMetaDataIfNotExistsInArgs(args, openGraphMetaTitle);

            var openGraphMetaUrl = new OpenGraphMetaDataProjection("url", httpContextAccessor.MapPublicPath(args.RenderPageData.PageData.PageUrl));
            AddMetaDataIfNotExistsInArgs(args, openGraphMetaUrl);

            var pageModel = args.RenderPageData.GetPageModel();

            if (pageModel.MainImage != null)
            {
                var openGraphImage = new OpenGraphMetaDataProjection("image", pageModel.MainImage.PublicUrl);
                AddMetaDataIfNotExistsInArgs(args, openGraphImage);
            }
            else
            {
                if (pageModel.FeaturedImage != null)
                {
                    var openGraphImage = new OpenGraphMetaDataProjection("image", pageModel.FeaturedImage.PublicUrl);
                    AddMetaDataIfNotExistsInArgs(args, openGraphImage);
                }
                else if (pageModel.SecondaryImage != null)
                {
                    var openGraphImage = new OpenGraphMetaDataProjection("image", pageModel.SecondaryImage.PublicUrl);
                    AddMetaDataIfNotExistsInArgs(args, openGraphImage);
                }
            }

            if (!string.IsNullOrEmpty(pageModel.Description))
            {
                var openGraphDescription = new OpenGraphMetaDataProjection("description", pageModel.Description);
                AddMetaDataIfNotExistsInArgs(args, openGraphDescription);
            }
        }

        private void AddMetaDataIfNotExistsInArgs(PageRenderingEventArgs args, OpenGraphMetaDataProjection item)
        {
            if (!args.RenderPageData.Metadata.Contains(item))
            {
                args.RenderPageData.Metadata.Add(item);
            }
        }
    }
}