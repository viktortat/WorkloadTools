﻿using System;

namespace WorkloadTools
{

    public enum EventQueueType
    {
        MMF,
        Sqlite,
        LiteDB,
        BinarySerialized
    }

    public interface IEventQueue : IDisposable
    {
        int BufferSize { get; set; }

        bool TryDequeue(out WorkloadEvent result);
        void Enqueue(WorkloadEvent evt);
    }
}