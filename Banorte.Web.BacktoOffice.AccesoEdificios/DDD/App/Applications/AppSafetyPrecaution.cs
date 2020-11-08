using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Interfaces;
using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Applications
{
    public class AppSafetyPrecaution:IAppSafetyPrecaution
    {
        DDD.Domain.Interfaces.ISafetyPrecaution myContext;

        public AppSafetyPrecaution(DDD.Domain.Interfaces.ISafetyPrecaution _mycontext)
        {
            myContext = _mycontext;
        }
        public void Add(SafetyPrecaution Objeto)
        {
            myContext.Add(Objeto);
        }

        public void Delete(SafetyPrecaution Objeto)
        {
            myContext.Delete(Objeto);
        }

        public SafetyPrecaution GetById(int Id)
        {
            return myContext.GetById(Id);
        }

        public IList<SafetyPrecaution> List()
        {
            return myContext.List();
        }

        public void Update(SafetyPrecaution Objeto)
        {
            myContext.Update(Objeto);
        }
    }
}