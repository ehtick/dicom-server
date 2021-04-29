﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace Microsoft.Health.Dicom.Core.Features.Reindex
{
    /// <summary>
    /// Representation of a extended query tag entry.
    /// </summary>
    public class ReindexInstanceResult
    {
        public bool Succeed { get; set; }

        public string ErrorMessage { get; set; }
    }
}
