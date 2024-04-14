using System.Collections;
using System.Collections.Generic;
using DataProvider.Models;

namespace DataProvider.Data
{
    public interface DataService
    {
        IList<Skill> GetSkills(string dataSet);
        IList<Entity> GetEntities(string dataSet);
        void UpdateSkills(IList<Skill> skills, string dataSet );
        void UpdateEnitties(IList<Entity> entities, string dataSet);

        IList<string> GetDataSets(); 
        void UpdateDataSets(IList<string> dataSets);
    }
}