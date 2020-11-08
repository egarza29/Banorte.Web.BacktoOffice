using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Entities;
using Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Domain.Interfaces.Generics;
using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security;
using System.Web;

namespace Banorte.Web.BacktoOffice.AccesoEdificios.DDD.Infraestructure.Generic
{
    public class GenericRepository<T> : IGeneric<T>, IDisposable where T : class
    {
        protected ClientContext _context = null;
        protected Microsoft.SharePoint.Client.Web _web = null;

        protected string myListName;
        public string ListName { get => myListName; }

        public GenericRepository()
        {
        }

        protected void InitCtx()
        {
            _context = new ClientContext(ConfigurationManager.AppSettings["Sharepoint.Site"]);
            var securePassword = new SecureString();
            var _pwd = ConfigurationManager.AppSettings["Sharepoint.Password"];
            _pwd.ToCharArray().ToList().ForEach(c => securePassword.AppendChar(c));
            _context.Credentials = new SharePointOnlineCredentials(ConfigurationManager.AppSettings["Sharepoint.UserName"], securePassword);
            _web = _context.Web;
            _context.Load(_web);

            _context.ExecuteQuery();

        }

        protected void EndCtx() {
            this.Dispose();
        }
        public void Add(T Objeto)
        {
            throw new NotImplementedException();
        }

        public void Delete(T Objeto)
        {
            throw new NotImplementedException();
        }


        public T GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IList<T> List()
        {
            throw new NotImplementedException();
        }

        public void Update(T Objeto)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            _context = null;
            _web = null;
        }

        protected CamlQuery BuildCamlQuery(List<DDD.Domain.Entities.ElementoCAML> items, List<OrderByCAML> orderby) 
        {
            string queryJoin = string.Empty;
            string query = "<{0}><FieldRef Name=\"{1}\" {5} /><Value {2} Type=\"{3}\">{4}</Value></{0}>";


            if (items.Count > 0)
            {
                int itemCount = 0;
                foreach (ElementoCAML itm in items)
                {
                    var element = itm;
                    itemCount++;
                    var date = string.Empty;
                    var lookup = string.Empty;
                    // Display only Date
                    if (element.FieldType == CAMLFieldType.DateTime)
                        date = "IncludeTimeValue='false'";
                    if (element.FieldType == CAMLFieldType.Lookup)
                    {
                        lookup = "LookupId='True'";
                    }
                    queryJoin += String.Format(query, element.ComparisonOperatorsStr,
                                    element.FieldName, date, element.FieldTypeStr, element.FieldValue, lookup);

                    if (itemCount >= 2)
                    {
                        queryJoin = String.Format("<{0}>", element.LogicalJoinStr) + queryJoin;
                        queryJoin += String.Format("</{0}>", element.LogicalJoinStr);
                    }
                }
                queryJoin += "<OrderBy>";
                if (orderby != null && orderby.Count > 0)
                {
                    foreach (var itm in orderby)
                    {
                        queryJoin += string.Format("<FieldRef {0} Name=\"{1}\" />", itm.OrderByDirectionStr, itm.FieldName);
                    }
                }
                else
                {
                    queryJoin += "<FieldRef Ascending=\"TRUE\" Name=\"ID\" />";
                }
                queryJoin += "</OrderBy>";
                queryJoin = "<Where>" + queryJoin;
                queryJoin += "</Where>";
            }

            queryJoin = "<Query>" + queryJoin;
            queryJoin += "</Query>";

            queryJoin = "<View>" + queryJoin;
            queryJoin += "</View>";


            CamlQuery result = new CamlQuery();
            result.ViewXml = queryJoin;

            return result;
        }

        public static bool GetBool(ListItem itm, string field)
        {
            bool result = false;
            if (itm != null)
            {
                bool.TryParse(itm[field].ToString(), out result);
            }
            return result;
        }

        public static DateTime GetDateTime(ListItem itm, string field)
        {
            DateTime result = new DateTime();
            if (itm != null)
            {
                try
                {
                    result = (DateTime)itm[field];
                }
                catch { }
            }
            return result;
        }
        public static DateTime? GetObjDateTime(ListItem itm, string field)
        {
            DateTime? result = new DateTime?();
            if (itm != null)
            {
                try
                {
                    result = (DateTime?)itm[field];
                }
                catch { }
            }
            return result;
        }

        public static int GetInt(ListItem itm, string field)
        {
            int result = 0;
            if (itm != null && itm[field] != null)
            {
                result = int.Parse(itm[field].ToString());
            }
            return result;
        }

        public static string GetString(ListItem itm, string field)
        {
            string result = string.Empty;
            try
            {
                if (itm != null && itm[field] != null)
                {
                    result = itm[field].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }

        public static decimal GetNumeric(ListItem itm, string field)
        {
            decimal result = 0;
            if (itm != null && itm[field] != null)
            {
                decimal.TryParse(itm[field].ToString(), out result);
            }
            return result;
        }

        public static SharepointUser GetUSerInfo(ListItem itm, string field)
        {
            SharepointUser result = new SharepointUser();
            try
            {
                if (itm != null && itm[field] is FieldUserValue)
                {

                    FieldUserValue info = (FieldUserValue)itm[field];
                    result.Id = info.LookupId;
                    result.Title = info.LookupValue;
                    result.Email = info.Email;
                }
            }
            catch { }

            return result;

        }
        /*Exception thrown: 'Microsoft.SharePoint.Client.PropertyOrFieldNotInitializedException' in Microsoft.SharePoint.Client.dll
Microsoft.SharePoint.Client.FieldUserValue*/

        public static SharepointBase GetLookupInfo(ListItem itm, string field)
        {
            //Microsoft.SharePoint.Client.FieldLookupValue
            SharepointBase result = new SharepointBase();
            try
            {
                if (itm != null && itm[field] is FieldLookupValue)
                {

                    FieldLookupValue info = (FieldLookupValue)itm[field];
                    result.Id = info.LookupId;
                    result.Title = info.LookupValue;
                }
            }
            catch { }

            return result;
        }
    }
}
