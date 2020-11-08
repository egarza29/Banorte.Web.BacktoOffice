using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Interfaces;
using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.App.Applications
{
    public class AppKeyQuestionAnswer:IAppKeyQuestionAnswer
    {
        DDD.Domain.Interfaces.IKeyQuestionAnswer myContext;

        public AppKeyQuestionAnswer(DDD.Domain.Interfaces.IKeyQuestionAnswer _mycontext)
        {
            myContext = _mycontext;
        }
        public void Add(KeyQuestionAnswer Objeto)
        {
            myContext.Add(Objeto);
        }

        public void Delete(KeyQuestionAnswer Objeto)
        {
            myContext.Delete(Objeto);
        }

        public KeyQuestionAnswer GetById(int Id)
        {
            return myContext.GetById(Id);
        }

        public IList<KeyQuestionAnswer> List()
        {
            return myContext.List();
        }

        public void Update(KeyQuestionAnswer Objeto)
        {
            myContext.Update(Objeto) ;
        }
    }
}