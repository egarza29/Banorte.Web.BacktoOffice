using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Interfaces;
using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Applications
{
    public class AppTier:IAppTier
    {
        DDD.Domain.Interfaces.ITier myContext;

        public AppTier(DDD.Domain.Interfaces.ITier _mycontext)
        {
            myContext = _mycontext;
        }
        public void Add(Tier Objeto)
        {
            myContext.Add(Objeto);
        }

        public void Delete(Tier Objeto)
        {
            myContext.Delete(Objeto);
        }

        public Tier GetById(int Id)
        {
            return myContext.GetById(Id);
        }

        public IList<Tier> List()
        {
            return myContext.List();
        }

        public void Update(Tier Objeto)
        {
            myContext.Update(Objeto);
        }
    }
}