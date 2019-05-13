﻿using Repository.Sqlite;
using System;

namespace Tello.Observations.Sqlite
{
    [System.Diagnostics.DebuggerDisplay("{Id}:{GroupId} {Timestamp}")]
    public abstract class Observation : SqliteEntity, IObservation
    {
        public Observation()
            : this(0)
        {
        }

        public Observation(IObservationGroup group)
            : this((group ?? throw new ArgumentNullException(nameof(group))).Id)
        {
        }

        public Observation(int groupId)
            : this(
                  groupId, 
                  DateTime.UtcNow)
        {
        }

        public Observation(
            int groupId, 
            DateTime timestamp)
            : base()
        {
            GroupId = groupId;
            Timestamp = timestamp;
        }

        public Observation(IObservation observation)
            : base(observation)
        {
            GroupId = observation.GroupId;
            Timestamp = observation.Timestamp;
        }

        [SQLite.Indexed]
        public int GroupId { get; set; }

        [SQLite.Indexed]
        public DateTime Timestamp { get; set; }

        // this is just to put a human readable value in sqlite for debugging
        public string TimestampString
        {
            get => Timestamp.ToString("o");
            set { }
        }
    }
}
