using System;

namespace Polymorphism.Flyables
{
    public interface IFlyable
    {
        void Fly();
    }

    public class Bird : IFlyable
    {
        public void Tweet() =>
            Console.WriteLine("Tweet, tweet!");

        public void Fly() =>
            Console.WriteLine("Flying using its wings.");
    }

    public class Kite : IFlyable
    {
        public void Fly() =>
            Console.WriteLine("Flying carried by the wind.");
    }

    public interface IFeulable
    {
        void Fuel();
    }

    public class Plane : IFlyable, IFeulable
    {
        public void Fly() =>
            Console.WriteLine("Flying using jet propulsion.");

        public void Fuel() =>
            Console.WriteLine("Filling tanks with jet fuel.");
    }
}