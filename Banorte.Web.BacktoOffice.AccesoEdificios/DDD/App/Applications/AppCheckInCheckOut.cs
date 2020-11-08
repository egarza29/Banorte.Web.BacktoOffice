using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Interfaces;
using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Applications
{
    public class AppCheckInCheckOut:IAppCheckInCheckOut
    {
        DDD.Domain.Interfaces.ICheckInCheckOut myContext;

        public AppCheckInCheckOut(DDD.Domain.Interfaces.ICheckInCheckOut _mycontext)
        {
            myContext = _mycontext;
        }
        public void Add(CheckInCheckOut Objeto)
        {
            myContext.Add(Objeto);
        }

        public void Delete(CheckInCheckOut Objeto)
        {
            myContext.Delete(Objeto) ;
        }

        public CheckInCheckOut GetById(int Id)
        {
            return myContext.GetById(Id);
        }

        public IList<CheckInCheckOut> List()
        {
            return myContext.List();
        }

        public void Update(CheckInCheckOut Objeto)
        {
            myContext.Update(Objeto);
        }
    }
}