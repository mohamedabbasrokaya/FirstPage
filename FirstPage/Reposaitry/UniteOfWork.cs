using FirstPage.Interface;

namespace FirstPage.Reposaitry
{
    public class UniteOfWork : IUniteOfWork
    {
       
      
        public IEntrySettingRepo entrySettingRepo { get; set ; }
      
        public UniteOfWork(IEntrySettingRepo entrySettingRepo)
        {
            
           
            this.entrySettingRepo = entrySettingRepo;
            
        }
    }
    
}
