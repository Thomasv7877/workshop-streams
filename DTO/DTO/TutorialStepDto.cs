﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.model
{
    public class TutorialStepDto
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int order { get; set; }
        public int duration { get; set; }
    }
}
