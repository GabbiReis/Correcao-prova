using H1Store.Catalogo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.Interfaces
{
    public interface ICartaService 
    {
        Task<IEnumerable<CartaViewModel>> ObterTodos();

        void Adicionar(NovaCartaViewModel novaCartaViewModel);
    }
}
