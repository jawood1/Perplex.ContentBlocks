﻿using System;
#if NET5_0 || NET7_0
using Umbraco.Cms.Core.Models.PublishedContent;
#elif NET472
using Umbraco.Core.Models.PublishedContent;
#endif


namespace Perplex.ContentBlocks.Rendering
{
    public interface IContentBlockViewModelFactory<TContent> : IContentBlockViewModelFactory where TContent : IPublishedElement
    {
        IContentBlockViewModel<TContent> Create(TContent content, Guid id, Guid definitionId, Guid layoutId);
    }
}
