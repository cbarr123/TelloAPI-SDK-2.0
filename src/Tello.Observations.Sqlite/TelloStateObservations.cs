﻿using Tello.Messaging;

namespace Tello.Observations.Sqlite
{
    [System.Diagnostics.DebuggerDisplay("{Id}:{GroupId} {Timestamp} - {Data}")]
    public sealed class TelloStateObservation : Observation
    {
        public TelloStateObservation() : base() { }

        public TelloStateObservation(int groupId, ITelloState telloState) : base(groupId, telloState.Timestamp)
        {
            Data = telloState.Data;
        }

        public string Data { get; set; }
    }
}
