using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReactFullAPI.Models.MasterData;

namespace ReactFullAPI.Areas.MasterData.Models
{
    public class GenderViewModel
    {

        public int id { get; set; }
        public string name { get; set; }


        public IEnumerable<Gender> genders { get; set; }
    }
}
