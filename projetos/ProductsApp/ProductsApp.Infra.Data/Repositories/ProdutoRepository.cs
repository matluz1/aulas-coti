using ProductsApp.Domain.Interfaces.Repositories;
using ProductsApp.Domain.Models;
using ProductsApp.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApp.Infra.Data.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto, Guid>, IProdutoRepository
    {
        public ProdutoRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
