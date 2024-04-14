using System;
using System.Collections.Generic;

namespace DataProvider.Models
{
    public class Player : Entity
    {
     
        public List<Gear> Gear { get;}
        public Player(Entity baseEntity) : base()
        {
            ermittelRessourcen();
            Gear = new List<Gear>(); 
        }

        public void AddGearToPlayer(Gear gear)
        {
            Gear.Add(gear);
            
        }
    }
}