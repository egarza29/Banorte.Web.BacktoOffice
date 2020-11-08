using System;
using System.Collections.Generic;
using System.Text;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Interfaces.Generics
{
    public interface IGeneric<T> where T : class
    {
        string ListName { get;}

        void Add(T Objeto);

        void Update(T Objeto);

        void Delete(T Objeto);

        T GetById(int Id);

        IList<T> List();

    }
}
