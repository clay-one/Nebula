﻿using Nebula.Queue;

namespace SampleJob
{
    public class SampleJobStep : IJobStep
    {
        public int Number { get; set; }
    }
}