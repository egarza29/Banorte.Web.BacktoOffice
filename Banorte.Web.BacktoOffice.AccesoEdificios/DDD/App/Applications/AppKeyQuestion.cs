using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Interfaces;
using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Applications
{
    public class AppKeyQuestion:IAppKeyQuestion
    {
        DDD.Domain.Interfaces.IKeyQuestion myContext;

        public AppKeyQuestion(DDD.Domain.Interfaces.IKeyQuestion _mycontext)
        {
            myContext = _mycontext;
        }
        public void Add(KeyQuestion Objeto)
        {
            myContext.Add(Objeto);
        }

        public void Delete(KeyQuestion Objeto)
        {
            myContext.Delete(Objeto);
        }

        public KeyQuestion GetById(int Id)
        {
            return myContext.GetById(Id);
        }

        public IList<KeyQuestion> List()
        {
            return myContext.List();
        }

        public void Update(KeyQuestion Objeto)
        {
            myContext.Update(Objeto); 
        }
    }
}