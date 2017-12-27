using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalrStudy.Models
{
    public class ChatRoom
    {
        [Key]
        public string RoomId { get; set; }

        // 房间名称
        public string RoomName { get; set; }

        // 用户集合
        public List<Users> Users { get; set; }
    }
}