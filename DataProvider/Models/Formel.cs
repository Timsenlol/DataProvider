using System.Collections.Generic;

namespace SkillAndEntityVerwalter.Models
{
    public class Formel
    {
        public decimal BaseValue { get; set; }
        public IList<Change> Changes;
        public override string ToString()
        {
            string value = BaseValue.ToString();
            foreach (var change in Changes)
            {
                value += " + (";
                value += change.ToString() +")";
            }

          
            return value; 
        }
    }
}