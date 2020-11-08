using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Interfaces;
using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Applications
{
    public class AppBuilding:IAppBuilding
    {
        DDD.Domain.Interfaces.IBuilding myContext;

        public AppBuilding(DDD.Domain.Interfaces.IBuilding _myContext) {
            myContext = _myContext;
        }

        public void Add(Building Objeto)
        {
            myContext.Add(Objeto);
        }

        public void Delete(Building Objeto)
        {
            myContext.Delete(Objeto);
        }

        public Building GetById(int Id)
        {
            return myContext.GetById(Id) ;
        }

        public IList<Building> List()
        {
            return myContext.List();
        }

        public void Update(Building Objeto)
        {
            myContext.Update(Objeto);
        }
    }
}