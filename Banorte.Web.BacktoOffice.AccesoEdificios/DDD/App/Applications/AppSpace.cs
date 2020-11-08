using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Interfaces;
using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Applications
{
    public class AppSpace:IAppSpace
    {
        DDD.Domain.Interfaces.ISpace myContext;

        public AppSpace(DDD.Domain.Interfaces.ISpace _mycontext)
        {
            myContext = _mycontext;
        }
        public void Add(Space Objeto)
        {
            myContext.Add(Objeto);
        }

        public void Delete(Space Objeto)
        {
            myContext.Delete(Objeto);
        }

        public Space GetById(int Id)
        {
            return myContext.GetById(Id);
        }

        public IList<Space> List()
        {
            return myContext.List();
        }

        public void Update(Space Objeto)
        {
            myContext. Update(Objeto);
        }
    }
}