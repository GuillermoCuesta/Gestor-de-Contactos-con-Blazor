using Gestor_de_Contactos.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace GestordeContactos.Server.Validations
{
    public class ContactValidation
    {
        public void hola(Contact contact)
        {
            //if (contact == null)
            //{
            //    ModelState.AddModelError("Contact", "Contact can't be empity");
            //}

            //if (string.IsNullOrEmpty(contact.FirstName))
            //{
            //    ModelState.AddModelError("FirstName", "First Name can't be empity");
            //}

            //if (string.IsNullOrEmpty(contact.LastName))
            //{
            //    ModelState.AddModelError("LastName", "Last Name can't be empity");
            //}

            //if (contact.PhoneNumber.Equals(null))
            //{
            //    ModelState.AddModelError("PhoneNumber", "Phone Number can't be empity");
            //}

            //if (string.IsNullOrEmpty(contact.Address))
            //{
            //    ModelState.AddModelError("Address", "Address can't be empity");
            //}
        }
    }
}
