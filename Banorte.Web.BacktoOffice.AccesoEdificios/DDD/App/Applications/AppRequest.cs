using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Interfaces;
using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Applications
{
    public class AppRequest:IAppRequest
    {
        DDD.Domain.Interfaces.IRequest myContext;

        public AppRequest(DDD.Domain.Interfaces.IRequest _mycontext)
        {
            myContext = _mycontext;
        }
        public void Add(Request Objeto)
        {
            myContext.Add(Objeto);
        }

        public void Delete(Request Objeto)
        {
            myContext.Delete(Objeto);
        }

        public Request GetById(int Id)
        {
            return myContext.GetById(Id);
        }

        public IList<Request> List()
        {
            return myContext.List();
        }

        public void Update(Request Objeto)
        {
            myContext.Update(Objeto);
        }
    }
}