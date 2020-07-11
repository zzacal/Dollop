using System;
using System.Collections.Generic;
using System.Text;

namespace Dollop.Models
{
    public class Media
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public MediaType Type { get; set; }
    }

    public enum MediaType
    {
        Image,
        Video,
        Audio,
        Text
    }
}
