// See https://aka.ms/new-console-template for more information
using System;
using RPG.src.Entities;

namespace RPG.Entities {
    
    class Program{
    
        static void Main(string[] args){

            Hero Arus = new Hero("Arus", 24 , "knight");
            Wizard Jenica = new Wizard("Jenica", 25, "red mage");

            Console.WriteLine(Arus.Attack());
            Console.WriteLine(Jenica);
        }
    }
} 

