using System;

namespace WebApi
{
    public class Contact
    {
        public Contact(ContactModel contactModel) {
            id = contactModel.id;
            
            firstName = contactModel.name.first;
            middleName = contactModel.name.middle;
            lastName = contactModel.name.last;

            city = contactModel.address.city;
            state = contactModel.address.state;
            street = contactModel.address.street;
            zip = contactModel.address.zip;

            workPhone = contactModel.phone
                .Find(phone => phone.type == "work").number;
            
            cellNumber = contactModel.phone
                .Find(phone => phone.type == "cell").number;

            email = contactModel.email;

            //TODO: implement audit data
            updatedOn = DateTime.Now;
            updatedBy = "gegillam";
        }
        public Contact() { }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }

        public string workPhone { get; set; }
        public string cellNumber { get; set; }
        public string email { get; set; }
        public string zip { get; set; }
        public string street { get; set; }
        public string state { get; set; }
        public string city { get; set; }

        public int id { get; set; }

        public DateTime updatedOn { get; set; }
        public string updatedBy { get; set; }


    }
}