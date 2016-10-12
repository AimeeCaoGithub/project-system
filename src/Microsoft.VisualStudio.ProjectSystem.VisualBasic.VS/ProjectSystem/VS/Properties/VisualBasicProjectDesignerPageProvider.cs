﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Threading.Tasks;

namespace Microsoft.VisualStudio.ProjectSystem.VS.Properties
{
    /// <summary>
    ///     Provides project designer property pages.
    /// </summary>
    [Export(typeof(IVsProjectDesignerPageProvider))]
    [AppliesTo(ProjectCapability.VisualBasic)]
    internal class VisualBasicProjectDesignerPageProvider : IVsProjectDesignerPageProvider
    {
        [ImportingConstructor]
        internal VisualBasicProjectDesignerPageProvider()
        {
        }

        public Task<IReadOnlyCollection<IPageMetadata>> GetPagesAsync()
        {
            return Task.FromResult<IReadOnlyCollection<IPageMetadata>>(
                new IPageMetadata[] {
                    VisualBasicProjectDesignerPage.Application,
                    VisualBasicProjectDesignerPage.References,
                    VisualBasicProjectDesignerPage.Debug,
            });
        }
    }
}
