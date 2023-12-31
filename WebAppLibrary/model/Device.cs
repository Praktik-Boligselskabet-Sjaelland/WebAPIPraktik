﻿namespace WebAppLibrary.model
{
    public class Device
    {
        private int _id;
        private string _name;
        private string _description;
        private int _effect;
        private decimal _runeTime;
        private double _runTimeHour;
        private decimal _hour = 3600;

        public Device()
        {
            _id = 0;
            _name = string.Empty;
            _description = string.Empty;
            _effect = 0;
        }

        public Device(int id, string name, string description, int effect, decimal runeTime, double runTimeHour)
        {
            _id = id;
            _name = name;
            _description = description;
            _effect = effect;
            _runeTime = runeTime;
            _runTimeHour = runTimeHour;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public int Effect
        {
            get => _effect;
            set => _effect = value;
        }

        public decimal RunTime
        {
            get => _runeTime;
            set => _runeTime = value;
        }

        public double RunTimeHour
        {
            get => _runTimeHour;
            set => _runTimeHour  = value;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(Effect)}: {Effect}, {nameof(RunTime)}: {RunTime}, {nameof(RunTimeHour)}: {RunTimeHour}";
        }
    }
}
