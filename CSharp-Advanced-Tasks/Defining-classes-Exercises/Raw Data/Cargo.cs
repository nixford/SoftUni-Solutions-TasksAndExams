﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Cargo
    {
        private int weight;
        private string type;

        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }
        public int Weight
        {
            get
            {
                return this.weight;
            }
            set 
            {
                this.weight = value;
            }
        }
        public string Type
        {
            get 
            {
                return this.type;
            }
            set 
            {
                this.type = value;
            }
        }
    }
}
