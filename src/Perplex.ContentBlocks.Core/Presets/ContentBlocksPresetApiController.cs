﻿using Perplex.ContentBlocks.Presets;
using System.Collections.Generic;
#if NET5_0 || NET7_0
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.BackOffice.Controllers;
#elif NET472
using System.Web.Http;
using Umbraco.Web.WebApi;
#endif

namespace Perplex.ContentBlocks.Definitions
{
    public class ContentBlocksPresetApiController : UmbracoAuthorizedApiController
    {
        private readonly IContentBlocksPresetRepository _presetRepository;

        public ContentBlocksPresetApiController(IContentBlocksPresetRepository presetRepository)
        {
            _presetRepository = presetRepository;
        }

        [HttpGet]
        public IEnumerable<IContentBlocksPreset> GetAllPresets()
            => _presetRepository.GetAll();

        [HttpGet]
        public IContentBlocksPreset GetPresetForPage(string documentType, string culture)
            => _presetRepository.GetPresetForPage(documentType, culture);
    }
}
