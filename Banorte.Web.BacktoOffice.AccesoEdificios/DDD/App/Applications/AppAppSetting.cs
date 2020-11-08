using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities;
using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Applications
{
    public class AppAppSetting : IAppSetting
    {
        DDD.Domain.Interfaces.IAppSetting myContext;
        public string ListName { get => myContext.ListName; }

        public AppAppSetting(DDD.Domain.Interfaces.IAppSetting _mycontext) 
        {
            myContext = _mycontext;
        }

        public void Add(AppSetting Objeto)
        {
            myContext.Add(Objeto);
        }

        public void Delete(AppSetting Objeto)
        {
            myContext.Add(Objeto);
        }

        public AppSetting GetById(int Id)
        {
            return myContext.GetById(Id) ;
        }

        public IList<AppSetting> List()
        {
            return myContext.List();
        }

        public void Update(AppSetting Objeto)
        {
            myContext.Update(Objeto);
        }
    }
}