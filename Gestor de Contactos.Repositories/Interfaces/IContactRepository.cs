using Gestor_de_Contactos.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Contactos.Repositories.Interfaces
{
    public interface IContactRepository
    {
        Task<bool> InsetContact(Contact contact);
        Task<bool> UpdateContact(Contact contact);
        Task<bool> DeleteContact(int numPhoneContact);
        Task<IEnumerable<Contact>> GetAll();
        Task<Contact> GetDetails(int numPhoneContact);  

    }
}
