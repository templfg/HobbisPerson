using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HobbyLibrary;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сущик А.В.
            List<Hobby> hobbies = new List<Hobby>();
            hobbies.Add(new Hobby("Баскетбол", "Кидать мячик в корзину"));
            hobbies.Add(new Hobby("Вязание", "Крестиком и шпицами"));
            hobbies.Add(new Hobby("Футбол", "Пинать мячик ногой, иногда головой"));

            Person person = new Person("Сущик Артём", "Юбилейная 20А", hobbies);

            person.ShowAll();
            Console.ReadLine();
        }
    }
}
