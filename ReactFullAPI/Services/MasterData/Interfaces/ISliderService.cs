using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReactFullAPI.Models.MasterData;
using ReactFullAPI.Data.Entity.MasterData;

namespace ReactFullAPI.Service.MasterData.Interfaces
{
    public interface ISliderService
    {
        Task<bool> SaveSlider(Slider slider);
        Task<IEnumerable<Slider>> GetAllSlider();
        Task<Slider> GetSliderById(int id);
        Task<bool> DeleteSliderById(int id);
        Task<bool> IsActive(int id);
        Task<IEnumerable<Slider>> GetAllActiveSlider();
    }
}
