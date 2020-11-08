using System;
using System.Collections.Generic;
using System.Text;

namespace Banorte.Web.BacktoOffice.Domain.Interfaces.Generics
{
    public interface IGeneric<T> where T : class
    {
        void Add(T Objeto);

        void Update(T Objeto);

        void Delete(T Objeto);

        T GetById(int Id);

        IList<T> List();

    }
}
