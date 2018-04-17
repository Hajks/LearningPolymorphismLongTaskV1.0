﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPolymorphismLongTaskV1._0
{
    abstract class Location
    {
        public Location(string name)
        {
            Name = name;
        }
        protected string Name { get; private set; }
        protected Location[] Exits;
        public virtual string Description
        {
            get
            {
                string description = "Stowisz w: " + Name + ". Widzisz wyjścia do następujących lokalizacji: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                        description += ",";
                }
                description += ".";
                return description;
               
            }
        }
    }
}