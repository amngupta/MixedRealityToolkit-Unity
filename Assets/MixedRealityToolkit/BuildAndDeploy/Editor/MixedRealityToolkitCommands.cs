﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;

namespace MixedRealityToolkit.Build
{
    /// <summary>
    /// Implements functionality for building HoloLens applications
    /// </summary>
    public static class MixedRealityToolkitCommands
    {
        /// <summary>
        /// Do a build configured for the HoloLens, returns the error from BuildPipeline.BuildPlayer
        /// </summary>
        [Obsolete("Use BuildDeployTools.BuildSLN")]
        public static bool BuildSLN()
        {
            return BuildDeployTools.BuildSLN(BuildDeployPrefs.BuildDirectory, false);
        }
    }
}