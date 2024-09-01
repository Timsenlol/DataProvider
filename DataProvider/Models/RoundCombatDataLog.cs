
using System;
using DataProvider.Models;

namespace RoundCombatLib
{
    //Stellt eine Aktion dar
    public class RoundCombatDataLog
    {
        public string TextEreignis { get; set; }
        public Skill AusgefuehrterSkill { get; set; } 
        // Player id des ausführenden Spielers
        public Guid PlayerID { get; set; }
        //Ist Player oder Enemy Target der Aktion   
        public TargetType Target { get; set;  }
        //Dierkter Schaden/Heal 
        public decimal HealthChange { get; set;}
        //Dirketer Change
        public decimal RessourcenChange { get; set; }
        //hinzugefügter Passiveffekt
        public PassivEffect AddedPassiv { get; set; }
        public CostType CostType { get; set; }
       
        
    }
}