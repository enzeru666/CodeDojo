﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace EverCraft
{
    public class Actions
    {
        public int Result { get; set; }

        public void SkillCheck()
        {
            Result = 15;
        }
    }
}
