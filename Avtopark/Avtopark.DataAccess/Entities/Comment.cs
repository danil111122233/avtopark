﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtopark.DataAccess.Entities
{
    public class Comment: BaseEntity
    {
        public int Rating { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
