﻿using System;

namespace Models
{
    public class Latency
    {
        public readonly double Lag;
        public readonly double RoundTrip;
        public readonly DateTime PingTime;
        public readonly DateTime PongTime;
        public readonly DateTime CreatedAt;
        
        public Latency(long pingTime, long pongTime)
        {
            CreatedAt = DateTime.UtcNow;
            PingTime = new DateTime(pingTime);
            PongTime = new DateTime(pongTime);
            Lag = TimeSpan.FromTicks(pongTime - pingTime).TotalSeconds;
            RoundTrip = TimeSpan.FromTicks(DateTime.UtcNow.Ticks - pingTime).TotalSeconds;
        }
    }
}