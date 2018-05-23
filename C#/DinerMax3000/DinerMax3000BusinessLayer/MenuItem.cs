﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000.Business
{
    public class MenuItem
    {
        public string Title;
        public string Description;
        public double Price
        {
            // returns the price.
            get{return _price;}
            // tests value set.
            set
            {
                if(value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ApplicationException("You cannot have free or negative valued items.");
                }
            }
        }

        // shadow property of Price
        private double _price;
    }
}