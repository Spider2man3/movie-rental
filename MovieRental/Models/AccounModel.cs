﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class AccountModel
    {
        public Users User { get; set; }
        public bool Logged { get; set; }
    }
}