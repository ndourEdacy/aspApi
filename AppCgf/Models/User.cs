using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppCgf.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string MotPass { get; set; }
    }
}