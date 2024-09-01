using System;
using System.Collections.Generic;
using DataProvider.Models;

namespace RoundCombatLib
{
    //Das Hauptdataobjekt auf dem gearbeitet wird.
    public class RoundCombatData
    {
        
        //Stellt alle bisher ausgeführten Aktionen dar
        public List<RoundCombatDataLog> Aktionen { get; set; }
        
        //aktueller PlayerState1
        public Player PlayerOne { get; set; }
        //aktueller PlayerState2
        public Player PlayerTwo { get; set; }
        // Variable die sagt, ob der Kampf vorbei ist
        public bool IsCombatOver { get; set; }
        public int AktuelleRunde { get; set; }
        
        public RoundCombatData(Player playerOne, Player playerTwo)
        {
            Aktionen = new List<RoundCombatDataLog>(); 
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
            AktuelleRunde = 0;  
        }

        public bool isValid()
        {
            return PlayerOne != null && PlayerTwo != null;
        }
    }
}