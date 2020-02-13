﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;

namespace Microsoft.Health.Fhir.Core.Features.Security
{
    [TypeConverter(typeof(ResourceActionsConverter))]
    [Flags]
#pragma warning disable CA1028 // Enum Storage should be Int32
    public enum ResourceActions : ulong
#pragma warning restore CA1028 // Enum Storage should be Int32
    {
        None = 0,

        Read = 1,
        Create = 1 << 1,
        Update = 1 << 2,
        Write = Create | Update,
        Delete = 1 << 3,
        HardDelete = 1 << 4,
        Export = 1 << 5,
        ResourceValidate = 1 << 6,

        All = (ResourceValidate << 1) - 1,
    }
}
