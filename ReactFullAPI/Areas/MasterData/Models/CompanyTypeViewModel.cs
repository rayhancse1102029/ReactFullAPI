using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReactFullAPI.Data.Entity.MasterData;

namespace ReactFullAPI.Areas.MasterData.Models
{
    public class CompanyTypeViewModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<CompanyType> CompanyTypes  { get; set; }
    }
}
