﻿using BetterCms.Module.Api.Operations.Pages.Pages.Page.Contents;
using BetterCms.Module.Api.Operations.Pages.Pages.Page.Exists;
using BetterCms.Module.Api.Operations.Pages.Pages.Page.Properties;

namespace BetterCms.Module.Api.Operations.Pages.Pages.Page
{
    public interface IPageService
    {
        IPagePropertiesService Properties { get; }

        IPageContentsService Contents { get; }

        GetPageResponse Get(GetPageRequest request);

        PageExistsResponse Exists(PageExistsRequest request);
    }
}