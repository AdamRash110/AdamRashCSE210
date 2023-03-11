using System;
using System.Collections.Generic;

namespace EternalQuest
{
    class EternalGoal : Goal
    {
        public int Value { get; private set; }
        public EternalGoal(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public override void RecordEvent()
        {
            Score += Value;
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetStatus()
        {
            return "In progress";
        }
    }
}