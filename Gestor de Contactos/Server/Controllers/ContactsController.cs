using Gestor_de_Contactos.Repositories.Interfaces;
using Gestor_de_Contactos.Shared;
using Microsoft.AspNetCore.Mvc;

namespace GestordeContactos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;

        public ContactsController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<IActionResult> Post([FromBody] Contact contact)
        {
            if (contact == null)
            {
                ModelState.AddModelError("Contact", "Contact can't be empity");
            }

            if (string.IsNullOrEmpty(contact.FirstName))
            {
                ModelState.AddModelError("FirstName", "First Name can't be empity");
            }

            if (string.IsNullOrEmpty(contact.LastName))
            {
                ModelState.AddModelError("LastName", "Last Name can't be empity");
            }

            if (contact.PhoneNumber.Equals(null))
            {
                ModelState.AddModelError("PhoneNumber", "Phone Number can't be empity");
            }

            if (string.IsNullOrEmpty(contact.Address))
            {
                ModelState.AddModelError("Address", "Address can't be empity");
            }

            await _contactRepository.InsetContact(contact);

            return NoContent();
        }

        [HttpDelete("{phoneNumber}")]
        public async Task Delete(int phoneNumber)
        {
            await _contactRepository.DeleteContact(phoneNumber);
        }

        [HttpGet("{phoneNumber}")]
        public async Task<Contact> Get(int phoneNumber)
        {
            return await _contactRepository.GetDetails(phoneNumber);
        }

        [HttpGet]
        public async Task<IEnumerable<Contact>> GetAll()
        {
            return await _contactRepository.GetAll();
        }

        [HttpPut("{phoneNumber}")]
        public async Task<IActionResult> UpdateContact(int phoneNumber, [FromBody] Contact contact)
        {
            await _contactRepository.UpdateContact(contact);

            return NoContent();
        }
    }
}
