namespace DataProvider.Models
{
    public class Gear
    {
        public GearType type { get; set;  }
        public string note  { get; set; }
        public decimal strength { get; set; }
        public decimal luck { get; set; }
        public decimal agi { get; set; }
        public decimal intele { get; set; }
        public decimal magicTalent { get; set; }
        public decimal karma { get; set; }
        public decimal faith { get; set; }
        public PassivEffect PassivEffect { get; set; }
        
    }
}