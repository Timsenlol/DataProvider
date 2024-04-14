using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAndEntityVerwalter.Models
{
    public class Entity
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public List<Guid> skills { get; set; }
        public int level { get; set; }
        public byte[] image { get; set; }
        public string note  { get; set; }
        public decimal strength { get; set; }
        public decimal luck { get; set; }
        public decimal agi { get; set; }
        public decimal intele { get; set; }
        public decimal MagicDef { get; set; }
        public decimal Def { get; set; }
        public decimal magicTalent { get; set; }
        public decimal karma { get; set; }
        public decimal faith { get; set; }
        //Ressourcen
        public decimal health { get; set; }
        public decimal mana { get; set; } 
        public decimal  rage { get; set;}
        public decimal energy { get; set;}
        public decimal stamina { get; set; }

        public Entity()
        {
            id = Guid.NewGuid();
            skills = new List<Guid>();
        }

        public void ermittelRessourcen()
        {
            health = strength * 10;
            mana = intele * 5;
            rage = strength * 2 + luck * 3;
            energy = agi * 4 + luck * 2;
            stamina = strength * 3 + agi * 2;
        }
    }
}