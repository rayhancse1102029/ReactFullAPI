using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReactFullAPI.Data.Entity.MasterData;

namespace ReactFullAPI.Areas.MasterData.Models
{
    public class BrandViewModel
    {
        public int? Id { get; set; }
        public string name { get; set; }
        public IFormFile img { get; set; }
        public IFormFile banner { get; set; }

        public IEnumerable<Brand> brands { get; set; }

    }
}
