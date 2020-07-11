using System;
using System.Collections.Generic;
using System.Text;

namespace Dollop.Models
{
    public class MediaAlbum
    {
        public Guid AlbumId { get; set; }
        public Album Album { get; set; }
        public Guid MediaItemId { get; set; }
        public MediaItem MediaItem { get; set; }
    }
}
