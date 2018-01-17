﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using MixedRealityToolkit.InputModule.InputSources;
using System;
using UnityEngine.EventSystems;

namespace MixedRealityToolkit.InputModule.EventData
{
    [Obsolete("Use SourceEventData")]
    public class GamePadEventData : InputEventData
    {
        public string GamePadName { get; private set; }

        public GamePadEventData(EventSystem eventSystem) : base(eventSystem) { }

        public void Initialize(IInputSource source, uint sourceId, string gamePadName, object tag = null)
        {
            BaseInitialize(source, sourceId, tag);
            GamePadName = gamePadName;
        }
    }
}