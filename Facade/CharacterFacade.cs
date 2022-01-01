using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    internal class CharacterFacade
    {
        public List<List<Char>> Lists { get; set; }
        public List<Char> Characters { get; set;}
        public List<Char> Word { get; set; } 

        public CharacterFacade()
        {
            Lists = new List<List<Char>>();
            Word = new List<Char>();
        }

        public string GetInput()
        {
            Console.WriteLine("Write a 5 character word:");
            string input = Console.ReadLine();
            if (input.Length != 5)
            {
                Console.WriteLine("Exiting program - Error - The string needs to be EXACTLY 5 characters long");
                Console.ReadLine();
            }
            return input;
        }

        public void SaveWord(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                List<Char> character = new List<Char>();
                Lists.Add(character);
                character.Add(input[i]);
            }
        }

        public void LoadWord()
        {
            Console.WriteLine("The saved word is:");
              
            foreach (var List in Lists)
            {
                Console.Write(List.Last());
            }
            
            Console.ReadLine();

        }
    }
}
