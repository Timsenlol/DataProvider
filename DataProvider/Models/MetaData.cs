namespace DataProvider.Models;

public class MetaData
{
    public decimal BaseStrength { get; set; }
    public decimal BaseInt { get; set; }
    public decimal BaseLuck{ get; set; }
    public decimal BaseAgi{ get; set; }
    public decimal BaseMagicDef{ get; set; }
    public decimal BaseMagicTalent{ get; set; }
    public decimal BaseDef{ get; set; }
    public decimal BaseFaith{ get; set; }
    public decimal BaseKarma{ get; set; }
    public decimal BaseCritMulti{ get; set; }
    public decimal BaseDeffUmwandlung{ get; set; }
    public decimal BaseMagicDefUmwandlung{ get; set; }
    public decimal BasePysicalSchaden{ get; set; }
    public decimal PysicalStrengthMuti{ get; set; }
    public decimal PysicalAgiMuti{ get; set; }
    public decimal MagicIntMuti{ get; set; }
    public decimal MagicTalentMuti{ get; set; }
    public long InitiativPunkte{ get; set; }
    public long FirstHitAgiSchwellwert { get; set; }
    public long FirstHitLuckSchwellwert { get; set; }
    public float FirstHitHardCap { get; set; }
    public float FirstHitSoftCap { get; set; }
}