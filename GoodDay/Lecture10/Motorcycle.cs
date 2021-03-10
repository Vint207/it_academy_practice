using System;

namespace Lecture10
{
    class Motorcycle
    {
        private int id;
        private string model = "0";
        private string creator = "0";
        private int year;
        private float stat = 0;

        public int Id { get { return id; } private set { id = value; } }
        public string Model { get { return model; } set { if (value != null) model = value; } }
        public string Creator { get { return creator; } set { if (value != null) creator = value; } }
        public int Year
        {
            get { return year; }
            set { DateTime time = new DateTime(); if (value == time.Year) year = value; else year = time.Year; }
        }
        public float Stat { get { return stat; } set { if (value <= 100) stat = value; } }

        internal Motorcycle() { Random rand = new Random(); id = rand.Next(10000, 99999); }

        internal class Engine
        {
            int volume = 125;
            int power = 50;

            public int Volume { get { return volume; } set { if (value >= 125 && value <= 3200) volume = value; } }
            public int Power { get { return power; } set { if (value >= 50 && value <= 300) power = value; } }
        }
    }
}
