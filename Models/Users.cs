using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalrStudy.Models
{
    public class Users
    {
        [Key]
        public int id { get; set; }

        public string LoginId { get; set; }
        
        public string Pwd { get; set; }

        public int status { get; set; }

        public ChatRoom chatRoom { get; set; }
    }
}