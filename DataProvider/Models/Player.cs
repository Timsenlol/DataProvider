using System;
using System.Collections.Generic;

namespace DataProvider.Models
{
    public class Player
    {
        public Guid  Id { get; set; }
        public Entity ActiveHero { get; set; } 
    }
}