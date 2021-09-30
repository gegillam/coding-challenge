using System;
using System.Collections.Generic;

namespace WebApi
{
    public class ContactModel
    {
        public ContactModel(Contact contact)
        {
            id = contact.id;
            name.first = contact.firstName;
            name.middle = contact.middleName;
            name.last = contact.lastName;

            address.city = contact.city;
            address.state = contact.state;
            address.street = contact.street;
            address.zip = contact.zip;
            
            phone.Add(new Phone()
            {
                type = "work",
                number = contact.workPhone
            });

            phone.Add(
            new Phone()
            {
                type = "cell",
                number = contact.cellNumber
            });

            email = contact.email;
        }
        public ContactModel() { }
        /// <summary>
        /// test23
        /// </summary>
        public int id { get; set; }
        public Name name { get; set; }
        public Address address { get; set; }
        public List<Phone> phone { get; set; }
        public string email { get; set; }
        // private DateTime updatedOn { get; set; }
  
    }
}

public class Name
{
    Name() { }
    Name(Name name) {
        first = name.first;
        middle = name.middle;
        last = name.last;
    }

    public string first { get; set; }
    public string middle { get; set; }
    public string last { get; set; }

}
public class Address {
    Address() { }
    Address(Address address) {
        street = address.street;
        city = address.city;
        state = address.state;
        zip = address.zip;
    }
    public string street { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string zip { get; set; }

}
public class Phone {
    public Phone() { }
    Phone(Phone phone) {
        number = phone.number;
        type = phone.type;
    }
    public string number { get; set; }
    public string type { get; set; }

}

