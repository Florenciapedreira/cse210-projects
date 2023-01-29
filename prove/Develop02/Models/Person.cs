namespace AppLista.models
{
    internal class Person
    {
        public Person(string id, string name)
        {
            this.Id = id;
            this.Name = name;
            
        }
        public string Id {get; set; }
        public string Name {get; set; }
    }    
}