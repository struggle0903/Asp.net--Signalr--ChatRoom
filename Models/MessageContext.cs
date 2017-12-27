using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalrStudy.Models
{
    public class MessageContext
    {
        [Key]
        public int id { get; set; }
        public string context { get; set; }
        public string sendId { get; set; }
        public string receiveId { get; set; }
    }
}