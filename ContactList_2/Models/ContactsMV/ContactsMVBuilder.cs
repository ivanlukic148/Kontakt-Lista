namespace ContactList_2.Models.ContactsMV
{
    public class ContactsMVBuilder
    {
        public ContactsMV[] GetContactsMV()
        {
            var contacts = new[]
            {
                new ContactsMV {Id = "1", Name = "Ivica", Surname = "Ivic", Adress = "Templarska 10", City = "Zagreb", Email = new string[] {"ivica@gmail.com", "ivica@live.com"}, PhoneNumbers = new string [] {"021/324-324", "021/234-234"}, Tags = new string [] {"Dinamo", "Lisinski"}},
                new ContactsMV {Id = "2", Name = "Marica", Surname = "Maric", Adress = "Celestina Medovica 17", City = "Zadar", Email = new string[] {"marica@gmail.com", "ivica@live.com"}, PhoneNumbers = new string [] {"021/324-814"}, Tags = new string [] {"Orgulje"}},
                new ContactsMV {Id = "3", Name = "Perica", Surname = "Peric", Adress = "Gospe od Karmela 2", City = "Split", Email = new string[] {"perica@live.com"}, PhoneNumbers = new string [] {"01/987-324", "01/234-234", "01/321-654"}, Tags = new string [] {"Hajduk", "SV. Duje", "Palača"}},
            };

            return contacts;
        }
    }
}