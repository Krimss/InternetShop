using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetShop.Models
{
    public class EFCategoryRepository:ICategoryRepository
    {
        private ApplicationDbContext context;
        public EFCategoryRepository(ApplicationDbContext ctx) => context = ctx;
        public IQueryable<Categorys> Categorys => context.Categorys;
    }
}
