﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;

namespace AutoRest.Core.Logging
{
    /// <summary>
    /// Represents a path into an object stored in a file.
    /// </summary>
    public class FileObjectPath
    {
        public FileObjectPath(Uri filePath, ObjectPath objectPath)
        {
            FilePath = filePath;
            ObjectPath = objectPath;
        }

        public Uri FilePath { get; }

        public ObjectPath ObjectPath { get; }
    }
}
