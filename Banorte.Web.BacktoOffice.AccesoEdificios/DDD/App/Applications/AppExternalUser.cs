using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Interfaces;
using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Applications
{
    public class AppExternalUser:IAppExternalUser
    {
        DDD.Domain.Interfaces.IExternalUser myContext;

        public AppExternalUser(DDD.Domain.Interfaces.IExternalUser _mycontext)
        {
            myContext = _mycontext;
        }
        public void Add(ExternalUser Objeto)
        {
            myContext.Add(Objeto);
        }

        public void Delete(ExternalUser Objeto)
        {
            myContext.Delete(Objeto);
        }

        public ExternalUser FindByUser(string user)
        {
            return myContext.FindByUser(user);
        }

        public ExternalUser GetById(int Id)
        {
            return myContext.GetById(Id);
        }

        public IList<ExternalUser> List()
        {
            return myContext.List();
        }

        public void Update(ExternalUser Objeto)
        {
            myContext.Update(Objeto) ;
        }
    }
}