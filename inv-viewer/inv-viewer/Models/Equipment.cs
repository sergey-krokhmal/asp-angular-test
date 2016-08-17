using System;
using System.Collections.Generic;
using System.Linq;

namespace InvViewer.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string Name { get; set; }
        public decimal Count { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}