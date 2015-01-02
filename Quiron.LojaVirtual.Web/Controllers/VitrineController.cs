using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {

        //Crio uma variável
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 3;
        
        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina = 1)
        {

            _repositorio = new ProdutosRepositorio();
            //var produtos = _repositorio.Produtos.Take(10); //Nesta linha o Take serve para trazer apenas 10 registros
            var produtos = _repositorio.Produtos    //Nesta linha retorno uma coleção de produtos
                .OrderBy(p => p.Descricao)         //Nessa linha orderno pelA Descrição
                .Skip((pagina - 1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina);

            return View(produtos);
        }
    }
}