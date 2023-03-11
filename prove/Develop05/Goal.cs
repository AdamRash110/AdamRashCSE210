using System;
using System.Collections.Generic;

namespace EternalQuest
{
    abstract class Goal
    {
        public string Name { get; set; }
        public int Score { get; protected set; }
        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetStatus();
    }
}