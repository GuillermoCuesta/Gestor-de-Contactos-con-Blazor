using Gestor_de_Contactos.Repositories.Interfaces;
using Gestor_de_Contactos.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Contactos.Repositories.Services
{
    public class ContactRepository : IContactRepository
    {
        private readonly IDbConnection _dbconnection;

        public ContactRepository(IDbConnection dbConnection)
        {
            _dbconnection = dbConnection;
        }

        public Task<bool> DeleteContact(int numPhoneContact)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contact>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetDetails(int numPhoneContact)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsetContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateContact(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
