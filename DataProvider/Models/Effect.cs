using System;

namespace SkillAndEntityVerwalter.Models
{
    public class Effect
    {
        public Guid id { get; set;  }

        public EffectType EffectType{ get; set; 
        }
        public Formel ChangeFormel { get; set; }
        public ChangeType changeType { get; set; }
        public int Dauer { get; set; }
        public int TickIntervall { get; set; }
        

        public Effect()
        {
            id = Guid.NewGuid();
            ChangeFormel = new Formel(); 
        }
    }
}