using Banorte.Web.BacktoOffice.Domain.Interfaces.Generics;
using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security;
using System.Text;

namespace Banorte.Web.BacktoOffice.Domain.Infrastructure.Generic
{
    public class GenericRepository<T> : IGeneric<T>, IDisposable where T : class
    {
        private ClientContext _context = null;
        private Microsoft.SharePoint.Client.Web _web = null;
        public GenericRepository()
        {
            _context = new ClientContext(ConfigurationManager.AppSettings["Sharepoint.Site"]);
            var securePassword = new SecureString();
            var _pwd = ConfigurationManager.AppSettings["Sharepoint.Password"];
            _pwd.ToCharArray().ToList().ForEach(c => securePassword.AppendChar(c));
            _context.Credentials = new SharePointOnlineCredentials(ConfigurationManager.AppSettings["Sharepoint.UserName"], securePassword);


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
            if (_context != null) {
                _context.Dispose();                
            }
            _context = null;
            _web = null;
        }

    }
}
