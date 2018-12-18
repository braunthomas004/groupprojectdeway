using System;
using System.Collections.Generic;

namespace rebuildone.Models
{
    public class Photos
    {
        public int ID { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool isProfilePic { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
    }
}