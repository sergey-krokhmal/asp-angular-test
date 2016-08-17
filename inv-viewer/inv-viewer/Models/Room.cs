using System;
using System.Collections.Generic;
using System.Linq;

namespace InvViewer.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int BuildingId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public virtual ICollection<Building> Buildings { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}