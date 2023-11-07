using FirstPage.Interface;
using FirstPage.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstPage.Reposaitry
{

    public class GenericReposaitry<T> : IGenericRepo<T> where T : class
    {
        public MohamedContext Context { get; }

        public GenericReposaitry(MohamedContext Context)
        {
            this.Context = Context;
        }
        public async Task<T> GetAsync(int? id,string name)
        => await Context.Set<T>().FindAsync(id,name);

        public async Task<IEnumerable<T>> GetAllAsync()
        => await Context.Set<T>().ToListAsync();


    }
}
