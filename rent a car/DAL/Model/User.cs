using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Sifre { get; set; }
    }
}
