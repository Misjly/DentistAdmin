using System;
using System.Collections.Generic;

namespace DentistAdmin.ServiceObjects
{
    [Serializable]
    public class Schedule
    {
        public List<int> FirstShiftDays { get; }
        public List<int> SecondShiftDays { get; }
        public TimeSpan FirstShiftBeginning { get; }
        public TimeSpan FirstShiftEnding { get; }
        public TimeSpan SecondShiftBeginning { get; }
        public TimeSpan SecondShiftEnding { get; }

        public Schedule(List<int> firstShiftDays, List<int> secondShiftDays,
            TimeSpan firstShiftBeginning, TimeSpan firstShiftEnding,
            TimeSpan secondShiftBeginning, TimeSpan secondShiftEnding)
        {
            FirstShiftDays = firstShiftDays;
            SecondShiftDays = secondShiftDays;
            FirstShiftBeginning = firstShiftBeginning;
            FirstShiftEnding = firstShiftEnding;
            SecondShiftBeginning = secondShiftBeginning;
            SecondShiftEnding = secondShiftEnding;
        }
    }
}
