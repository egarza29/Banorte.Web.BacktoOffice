using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities
{
    public enum CAMLOrderByDirection
    {
        Ascending,
        Descending
    }
    public class OrderByCAML
    {
        public string FieldName { set; get; }
        public CAMLOrderByDirection OrderByDirection { set; get; }
        public string OrderByDirectionStr
        {
            get
            {
                return "Ascending = \"" + (OrderByDirection == CAMLOrderByDirection.Ascending ? "TRUE" : "FALSE") + "\"";
            }

        }
    }
}