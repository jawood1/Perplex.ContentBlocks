﻿#if NET5_0 || NET7_0
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services;
#elif NET472
using Umbraco.Core.Models;
using Umbraco.Core.Services;
#endif


namespace Perplex.ContentBlocks.Providers
{
    public class DocumentTypeAliasProvider : IDocumentTypeAliasProvider
    {
        private readonly IContentService _contentService;

        public DocumentTypeAliasProvider(IContentService contentService)
        {
            _contentService = contentService;
        }

        public string GetDocumentTypeAlias(int pageId)
        {
            IContent content = _contentService.GetById(pageId);
            if (content == null)
            {
                return null;
            }

            return content.ContentType?.Alias;
        }
    }
}
