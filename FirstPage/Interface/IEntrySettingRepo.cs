using FirstPage.Models;

namespace FirstPage.Interface
{
    public interface IEntrySettingRepo : IGenericRepo<GET_ENTRY_SETTINGResult>
    {
        IEnumerable<GET_ENTRY_SETTINGResult> GetResultWithEntrySetting( );
       // IEnumerable<GET_ENTRY_SETTINGResult> GetResultWithEntrySetting(short? ENTRY_SETTING_ID, string LANG);

    }
}
