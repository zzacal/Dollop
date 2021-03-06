﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dollop.Models
{
    public class Album
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public List<MediaAlbum> MediaAlbum { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.MinValue;
        public DateTime UpdatedDate { get; set; } = DateTime.MinValue;
        public DateTime DeletedDate { get; set; } = DateTime.MinValue;
    }
}
