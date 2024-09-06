using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Models
{
    public class Entity
    {
        public Guid id { get; set; }
        // Passive EffektLeiste Player
        public List <PassivEffect> EffektLeistePlayer { get; set; }
        // Akitve OverTimeEffekte auf Player und Enemy => Buffs/Debuffs
        // Hier wird eine Tuple verwendet Item1 => Effect an sich
        // Item 3 => Runde in der commitet wurde
        public List<Tuple <Effect, int>> AktiveEffekte { get; set; }
        public string name { get; set; }
        public List<Guid> skills { get; set; }
        public byte[] image { get; set; }
        public Physical Physical { get; set; }
        public Magic Magic { get; set; }
        public decimal Luck { get; set; }
        public List<Gear> Gear { get;}
        public Entity()
        {
            id = Guid.NewGuid();
            skills = new List<Guid>();
            Gear = new List<Gear>(); 
        }
        public void AddGearToEntity(Gear gear)
        {
            Gear.Add(gear);
        }
    }
}