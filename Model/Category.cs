﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Model
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<TaskItem> TaskItems { get; set; }
    }
}
