using System;
using System.Collections.Generic;

namespace EternalQuest
{
    class ChecklistGoal : Goal
    {
        public int Value { get; private set; }
        public int Target { get; private set; }
        private int _count = 0;
        public ChecklistGoal(string name, int value, int target)
        {
            Name = name;
            Value = value;
            Target = target;
        }

        public override void RecordEvent()
        {
            _count++;
            Score += Value;
            if (_count == Target)
            {
                Score += 500;
            }
        }

        public override bool IsComplete()
        {
            return _count >= Target;
        }

        public override string GetStatus()
        {
            return $"Completed {_count}/{Target} times";
        }
    }
}