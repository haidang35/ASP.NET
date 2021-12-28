using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T2009M_NGUYENHAIDANG_PRACTICAL.Models
{
    public enum MessageType { 
        Success = 1,
        Failed = 2,
    }
    public class Message
    {
        public MessageType Type { get; set; }
        public string Content { get; set; }
    }
}