﻿using System;

namespace todostiv.Common.Models
{
    internal class Todo
    {
        public DateTime CreatedTime { get; set; }

        public string TaskDescription { get; set; }

        public bool IsCompleted { get; set; }

    }

}
