﻿// ---------------------------------------------------------------
// Copyright (c) Hassan Habib All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;

namespace ADotNet.Models.Pipelines.Exceptions
{
    public class AdoServiceException : Exception
    {
        public AdoServiceException(Exception innerException)
            : base("Ado service exception occured, contact support.", innerException)
        {

        }
    }
}