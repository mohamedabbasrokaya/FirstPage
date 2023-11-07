using AutoMapper;
using FirstPage.Models;
using FirstPage.Models.ViewModel;

namespace FirstPage.Mapper
{
    public class SettingMapper:Profile
    {
        public SettingMapper()
        {
            CreateMap<GET_ENTRY_SETTINGResult, Get_Entry_SettingViewModel>()
                
                .ReverseMap();
        }
    }
}
