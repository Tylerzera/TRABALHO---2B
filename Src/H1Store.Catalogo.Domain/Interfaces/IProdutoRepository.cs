﻿using H1Store.Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Domain.Interfaces
{
	public interface IProdutoRepository
	{
		IEnumerable<Produto> ObterTodos();
		Task<Produto> ObterPorId(int id);
		Task<IEnumerable<Produto>> ObterPorNome(string nomeProduto);
		Task Adicionar(Produto produto);
		Task Atualizar(Produto produto);
		Task Deletar(Produto produto);
		Task Ativar(Produto produto);
		Task Desativar(Produto produto);
		Task AlterarPreco(Produto produto, decimal valor);
		Task AtualizarEstoque(Produto produto, int quantidade);
	}
}
