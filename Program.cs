﻿// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        IAnimal animal1 = new Dog();
        IAnimal animal2 = new Cat();

        animal1.MakeSound(); // Output: Woof!
        animal2.MakeSound(); // Output: Meow!
    }
}

