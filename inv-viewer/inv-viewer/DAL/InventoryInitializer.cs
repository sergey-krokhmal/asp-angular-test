using System;
using System.Collections.Generic;
using InvViewer.Models;

namespace InvViewer.DAL
{
    public class InventoryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<InventoryContext>
    {
        protected override void Seed(InventoryContext context)
        {
            var buildings = new List<Building>
            {
                new Building{Name="house 1"},
                new Building{Name="Building 1"}
            };
            buildings.ForEach(b => context.Buildings.Add(b));
            context.SaveChanges();

            var rooms = new List<Room>
            {
                new Room{BuildingId = 1, Name = "audit", Number = "100"},
                new Room{BuildingId = 1, Name = "audit", Number = "105"},
                new Room{BuildingId = 2, Name = "room", Number = "4"},
                new Room{BuildingId = 2, Name = "room", Number = "8"}
            };
            rooms.ForEach(r => context.Rooms.Add(r));
            context.SaveChanges();

            var equipments = new List<Equipment>
            {
                new Equipment{RoomId = 1, Name = "PC", Count = 2},
                new Equipment{RoomId = 2, Name = "PC", Count = 1},
                new Equipment{RoomId = 3, Name = "PC", Count = 4},
                new Equipment{RoomId = 3, Name = "Switch", Count = 1},
                new Equipment{RoomId = 4, Name = "PC", Count = 3}
            };
            equipments.ForEach(e => context.Equipments.Add(e));
            context.SaveChanges();
        }
    }
}