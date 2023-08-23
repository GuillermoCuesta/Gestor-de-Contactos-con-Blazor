using Gestor_de_Contactos.Client.Interfaces;
using Gestor_de_Contactos.Shared;
using System.Net.Http.Json;

namespace Gestor_de_Contactos.Client.Services
{
    public class ContactService : IContactService

    {
        private readonly HttpClient _httpClient;

        public ContactService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task DeleteContact(int phoneNumber)
        {
            await _httpClient.DeleteAsync($"api/contacts/{phoneNumber}");
        }

        public async Task<IEnumerable<Contact>> GetAllContacts()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Contact>>($"api/contacts");
        }

        public async Task<Contact> GetContactById(int phoneNumber)
        {
            return await _httpClient.GetFromJsonAsync<Contact>($"api/contacts/{phoneNumber}");
        }

        public async Task SaveContact(Contact contact)
        {
            await _httpClient.PostAsJsonAsync<Contact>($"api/contacts", contact);
        }

        public async Task UpdateContact(int phoneNumber, Contact contact)
        {
            await _httpClient.PutAsJsonAsync<Contact>($"api/contacts/{contact.PhoneNumber}", contact);
        }
    }
}
