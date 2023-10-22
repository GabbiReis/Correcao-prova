using AutoMapper;
using H1Store.Catalogo.Application.ViewModels;
using H1Store.Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.AutoMapper
{
	public class ApplicationToDomain : Profile
	{
		public ApplicationToDomain()
		{
            CreateMap<CartaViewModel, Carta>()
                .ConstructUsing(c => new Carta(c.Nome, c.Endereco, c.Idade, c.Conteudo));

            CreateMap<NovaCartaViewModel, Carta>()
               .ConstructUsing(c => new Carta(c.Nome, c.Endereco, c.Idade, c.Conteudo));



        }
	}
}
