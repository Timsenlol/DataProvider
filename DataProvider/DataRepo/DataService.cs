using System.Collections;
using System.Collections.Generic;
using DataProvider.Models;
using RoundCombatLib;

namespace DataProvider.DataRepo
{
    public interface DataService
    {
        IList<Skill> GetSkills(string dataSet);
        void UpdateSkills(IList<Skill> skills, string dataSet );
        MetaData GetMetaData();
        void UpdateMetaData(MetaData metaData);
        RoundCombatData GetRoundCombatData(Guid id);
        void updateRoundCombatData(RoundCombatData roundCombatData);

        IList<string> GetDataSets(); 
        void UpdateDataSets(IList<string> dataSets);
    }
}