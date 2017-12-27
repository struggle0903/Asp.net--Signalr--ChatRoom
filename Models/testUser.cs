using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalrStudy.Models
{
    public class testUser
    {
        [Key]
        public string ConnectionID { get; set; }
        public string Name { get; set; }
        public testUser(string name, string connectionId)
        {
            this.Name = name;
            this.ConnectionID = connectionId;
        }
    }
}