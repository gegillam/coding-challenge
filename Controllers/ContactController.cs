using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ContactController
        : ApiController
    {
        //DataController(DataContext _dataContext) {
        //        //TODO: Ninject Context    
        //}

        /// <summary>
        /// Returns a list of contacts sorted by last name then first name
        /// </summary>
        /// <returns></returns>
        public List<ContactModel> get() {


            var contactContext = new ContactContext();
            var z = contactContext.Contacts.ToList()
                .OrderBy(x => x.lastName)
                .ThenBy(x => x.firstName)
                .Select(x => new ContactModel(x)).ToList();

            return contactContext.Contacts.ToList().Select(x => new ContactModel(x)).ToList();
        }
        /// <summary>
        /// Returns a contact based off of the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ContactModel get(int id) {
            var dataContext = new ContactContext();
            return new ContactModel(dataContext.Contacts.Find(id));
        }
         
        // POST api/values
        /// <summary>
        /// Adds a contact to the database
        /// </summary>
        /// <param name="contactModel"></param>
        public void Post(ContactModel contactModel)
        {
            var dataContext = new ContactContext();
            dataContext.Contacts.Add(new Contact(contactModel));
            dataContext.SaveChanges();
        }

        // PUT api/values/5
        /// <summary>
        /// Updates a contact by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dataModel"></param>
        public void Put(int id, [FromBody]ContactModel dataModel)
        {
            var dataContext = new ContactContext();
            var existingData = dataContext.Contacts.Find(id);
            existingData.updatedOn = DateTime.Now;
            existingData.updatedBy = "gegillam"; //todo: implement identities
            dataContext.Entry(existingData).CurrentValues.SetValues(dataModel);
            dataContext.SaveChanges();
        }

        // DELETE api/values/5
        /// <summary>
        /// Deletes a contact by id
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var dataContext = new ContactContext();
            var data = dataContext.Contacts.Find(id);
            dataContext.Contacts.Remove(data);
            dataContext.SaveChanges();
        }
    }
}
