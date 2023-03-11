using System;
using System.Collections.Generic;

namespace EternalQuest
{
    class SimpleGoal : Goal
    {
        public int Value { get; private set; }
        public SimpleGoal(string name, int value)
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
            return true;
        }

        public override string GetStatus()
        {
            return "Completed";
        }
    }
}