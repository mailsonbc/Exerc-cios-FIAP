﻿using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;
using Fiap.Web.AspNet3.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Web.AspNet3.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DataContext dataContext;
        public ProdutoRepository(DataContext ctx)
        {
            dataContext = ctx;
        }
        public IList<ProdutoModel> FindAll()
        {
            return dataContext.Produtos.ToList<ProdutoModel>();
        }

        public ProdutoModel? FindById(int id)
        {
            return dataContext.Produtos.Include(p => p.ProdutosLojas).ThenInclude(pl => pl.Loja).SingleOrDefault(p => p.ProdutoId == id);
        }
    }
}
