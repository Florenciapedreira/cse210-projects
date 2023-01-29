using AppLista.controllers;
using AppLista.models;
namespace AppLista;
public class Program
    {
        public static void Main(string[] args)
        {
            PersonController obj = new();
            int option = 0;
            do{
                Console.WriteLine("Welcome to this Journal");
                Console.WriteLine("Please select one of the following choises: ");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Quit");
                Console.WriteLine("What would you like to do? ");
                var data = Console.ReadLine();
                if(data != null)
                {
                    option = int.Parse(data);
                }

                switch(option)
                {
                    case 1:
                        Console.Write("What was your favourite part of the day?: ");
                        var inputId = Console.ReadLine();
                        Console.Write("How did I see the hand of the Lord in my life today?: ");
                        var inputName = Console.ReadLine();

                        if(inputId != null && inputName != null)
                        {
                            obj.addPerson( new Person(
                                inputId.ToString(),
                                inputName.ToString()
                            ));
                        }
                        break;

                    case 2:
                        string date = DateTime.UtcNow.ToString("dd/MM/yyyy" );
                        Console.WriteLine("Date: {0}", date);
                        Console.WriteLine(obj.showlist());
                        break;

                    case 3:
                        Console.Write("What is the filename? ");
                        string seventh = Console.ReadLine();
                        break; 

                    case 4:
                        Console.WriteLine("Leaving the application.");
                        option = 4;
                        break;
                    default:
                        Console.WriteLine("Type a valid option");
                        break;


                }

            
            } while (option != 4);
        
        }
        
    }