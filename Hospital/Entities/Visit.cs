﻿using System;

namespace Hospital.Entities
{
    public class Visit
    {
        public int Id { get; set; }

        public DateTime DateOfVisit { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Patient Patient { get; set; }


    }
}