using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoginEmpty.Models
{
    public class User
    {
        
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public string Introduce { get; set; }
    }
}