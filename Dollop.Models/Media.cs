﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dollop.Models
{
    public class Media
    {
        public Guid Id { get; set; }
        public Album Album { get; set; }
        public User User { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public MediaType Type { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.MinValue;
        public DateTime UpdatedDate { get; set; } = DateTime.MinValue;
        public DateTime DeletedDate { get; set; } = DateTime.MinValue;
    }

    public enum MediaType
    {
        Image,
        Video,
        Audio,
        Text
    }
}
