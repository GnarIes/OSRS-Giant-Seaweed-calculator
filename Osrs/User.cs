﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osrs
{
    public class User
    {
        private int level;
        private int experience;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }
    }
}
