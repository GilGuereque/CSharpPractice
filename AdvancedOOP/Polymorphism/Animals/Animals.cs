using System;

namespace Polymorphism.Animals
{
    interface IAnimal
    {
        void MakeSound();
    }

    interface IHousePet : IAnimal
    {
        void TakeToVet();
    }

    interface IFeline : IAnimal
    {
        void HideInCardboardBox();
    }

    class DomesticCatImplementingInterfaces : IFeline, IHousePet
    {
        public void HideInCardboardBox() =>
            Console.WriteLine("Hide in any cardboard box!");

        public void MakeSound()
        {
            Console.WriteLine("Purr purr.");
        }

        public void TakeToVet() =>
            Console.WriteLine("Take to Dr. Paws using a transporter.");
    }
}