using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public delegate bool DelegadoFiltrar<T>(T filtro);
    public delegate void EventoAleatorioHandler();
}
