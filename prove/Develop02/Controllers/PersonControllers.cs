using AppLista.models;

namespace AppLista.controllers
{

    internal class PersonController
    {
        List<Person> listPerson = new();

        public void addPerson(Person person)
        {
            if(person != null)
            {
                listPerson.Add (person);
            }
        }


        public string showlist()
        {
            string text = "Resume \n";
            foreach(Person person in listPerson)
            {
               text += "What was your favourite part of the day?: "+person.Id+"\n";
               text += "How did I see the hand of the Lord in my life today?: "+person.Name+"\n"; 
            }

            return text;
        }
    }
}