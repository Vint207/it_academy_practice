using System;
using System.Collections.Generic;

namespace Lecture10
{
    class Motorcycle : Engine
    {
        internal static List<Motorcycle> listMoto = new List<Motorcycle>();
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
    }
}
