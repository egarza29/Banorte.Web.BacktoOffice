using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities;
using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Interfaces;
using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Infraestructure.Generic;
using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Infraestructure.Repositories
{
    public class ExternalUserRepository : GenericRepository<Domain.Entities.ExternalUser>, IExternalUser
    {
        public ExternalUserRepository() :base()
        {
            myListName = "BAR_ExternalUsr";
        }
        public ExternalUser FindByUser(string user)
        {
            ExternalUser usr = null;
            InitCtx();
            try {
                List myList = _web.Lists.GetByTitle(myListName);
                _context.Load(myList);

                List<ElementoCAML> itm = new List<ElementoCAML>();
                List<OrderByCAML> orderby = new List<OrderByCAML>();

                itm.Add(new ElementoCAML()
                {
                    ComparisonOperators = CAMLComparisonOperators.Eq,
                    FieldName = "Email",
                    FieldType = CAMLFieldType.Text,
                    FieldValue = user,
                    LogicalJoin = CAMLLogicalJoin.And
                });

                CamlQuery query = BuildCamlQuery(itm, orderby);

                ListItemCollection elementos = myList.GetItems(query);
                _context.Load(elementos);

                _context.ExecuteQuery();

                if (elementos != null && elementos.Count > 0) {
                    usr = Mapear(elementos[0]);
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                EndCtx();
            }
            return usr;
        }


        private ExternalUser Mapear(ListItem itm) 
        {
            if (itm == null) 
            {
                return null;
            }
            ExternalUser result = new ExternalUser();
            result.Approver = GetUSerInfo(itm, "Approver");
            result.Author = GetUSerInfo(itm, "Author");
            result.Clave = GetString(itm, "Clave");
            result.Company = GetString(itm, "Company");
            result.Created = GetObjDateTime(itm, "Created");
            result.Department = GetString(itm, "Department");
            result.Editor = GetUSerInfo(itm, "Editor");
            result.Email = GetString(itm, "Email");
            result.Id = itm.Id;
            result.Modified = GetObjDateTime(itm, "Modified");
            result.Photo = GetString(itm, "Photo");
            result.Position = GetString(itm, "Position");
            result.Title = GetString(itm, "Title");

            return result;
        }
    }
}