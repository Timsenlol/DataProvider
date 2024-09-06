namespace DataProvider.Models
{
    public class Skill
    {
        public string name { get; set; }
        public string tooltip { get; set; }
        public SkillType type { get; set;  } 
        public Guid id { get; set; }
        public InitativWert InitativWert { get; set; }
        
        //Für Aktive Skills
        public IList<Effect> effects { get; set; }
        public ZoneEffect ZoneEffect { get; set; }
        public decimal cost { get; set; }
        public CostType costType { get; set;  }
        public byte[] skillImg { get; set;  }
        //Für Passive Skills
        public PassivEffect PassivEffect { get; set; }

        public Skill()
        {
            id = Guid.NewGuid();
        }

    }
}
