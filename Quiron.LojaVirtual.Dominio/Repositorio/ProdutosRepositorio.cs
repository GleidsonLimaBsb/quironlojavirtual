using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiron.LojaVirtual.Dominio.Entidade;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        //Cria-se uma variável para referenciar o Entity
        private readonly EfDbContext _context = new EfDbContext();

        //Cria-se um metodo/propriedade 
        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }


    }
}
