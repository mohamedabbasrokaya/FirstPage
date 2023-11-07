using FirstPage.Interface;
using FirstPage.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstPage.Reposaitry
{
    public class EntrySettingRepo : GenericReposaitry<GET_ENTRY_SETTINGResult>, IEntrySettingRepo
    {
        public EntrySettingRepo(MohamedContext context) : base(context)
        {
            Context = context;
        }

        public MohamedContext Context { get; }

         public IEnumerable<GET_ENTRY_SETTINGResult> GetResultWithEntrySetting()
        {
          return Context.GET_ENTRY_SETTINGResultasync.ToList();
        }
        /*
        public IEnumerable<GET_ENTRY_SETTINGResult> GetResultWithEntrySetting(short? ENTRY_SETTING_ID, string LANG)
        {
            return Context.GET_ENTRY_SETTINGResultasync.ToList();

        }*/
        //  return Context.Results.Include(r => r.StudentNoNavigation).Include(r => r.CourceNoNavigation).ToList();

        // public IEnumerable<GET_ENTRY_SETTINGAsync> GetResultWithEntrySetting()
        //{
        //  Context.GET_ENTRY_SETTINGAsync.ToList();
        // }


    }

}

