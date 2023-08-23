using Gestor_de_Contactos.Shared;

namespace Gestor_de_Contactos.Client.Interfaces
{
    public interface IContactService
    {
        Task SaveContact(Contact contact);
        Task DeleteContact(int phoneNumber);
        Task <IEnumerable<Contact>> GetAllContacts();
        Task<Contact> GetContactById(int id);
        Task UpdateContact(int phoneNumber, Contact contact);
    }
}
