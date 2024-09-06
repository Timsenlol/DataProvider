namespace DataProvider.Models;

public class ZoneEffect : Effect
{
    public ZoneTyp Typ { get; set; }
    //Erhöhrung oder bei CC Procc Wahrscheinlichkeit
    public decimal Proz { get; set; }
    //HOT DOT
    public bool NeedChangeBerechnung()
    {
        return Typ == ZoneTyp.HOT || Typ == ZoneTyp.DOT;
    }
}