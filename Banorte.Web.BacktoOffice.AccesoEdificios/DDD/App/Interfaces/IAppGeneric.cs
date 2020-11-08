using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Interfaces
{
    public interface IAppGeneric<T> where T : class
    {
        void Add(T Objeto);

        void Update(T Objeto);

        void Delete(T Objeto);

        T GetById(int Id);

        IList<T> List();
    }
}