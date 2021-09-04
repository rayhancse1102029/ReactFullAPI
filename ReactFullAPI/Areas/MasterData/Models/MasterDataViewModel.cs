using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReactFullAPI.Data.Entity.MasterData;

namespace ReactFullAPI.Areas.MasterData.Models
{
    public class MasterDataViewModel
    {
        public int? id { get; set; }
        public string name { get; set; }

        public IEnumerable<Color> Colors { get; set; }
        public IEnumerable<Size> Sizes { get; set; }
    }
}
