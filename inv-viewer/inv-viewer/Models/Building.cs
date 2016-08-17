using System;
using System.Collections.Generic;
using System.Linq;

namespace InvViewer.Models
{
    public class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}