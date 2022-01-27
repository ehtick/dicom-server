﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace Microsoft.Health.Dicom.Core.Messages.WorkitemMessages
{
    public sealed class CancelWorkitemResponse
    {
        public CancelWorkitemResponse(WorkitemResponseStatus status)
        {
            Status = status;
        }

        public WorkitemResponseStatus Status { get; }
    }
}