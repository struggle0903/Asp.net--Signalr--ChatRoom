using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Threading.Tasks;

namespace SignalrStudy.Models
{
    public class ContextDbData : DbContext
    {
        public ContextDbData() : base("name=TestChatRoom")
        {}

        public virtual DbSet<Users> listUsers { get; set; } 
        public virtual DbSet<MessageContext> listMessageContext { get; set; }
        public virtual DbSet<ChatRoom> listChatRoom { get; set; }
        

    }
}