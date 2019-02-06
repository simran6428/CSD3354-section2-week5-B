using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simran
{
    class program
    {
        static void Main(string[] args)
        {
            LinkedList a = new LinkedList();
            a.run();
            a.WalkoverTheList();
            a.WalkoverTheList();
        }
    }

    class Dog
    {
        public static int NumberOfDogs = 0;
        private Dog()
        {

            Dog.NumberOfDogs++;
        }
        public String DogName;
        public String DogBreed;
        public Dog nextDog;
        public Dog prvDog;
    }
    class LinkedList
    {
        public Dog current;
        public Dog Head;
        public Dog Peanut = new Dog();
        public Dog Fifi = new Dog();
        public Dog Jordan = new Dog();
        public Dog Fido = new Dog();
        public Dog Roy = new Dog();
        public Dog Coco = new Dog();
        public void run()
        {
            Head = Peanut;
            Peanut.DogName = "Peanut";
            Peanut.DogBreed = "Bichon";
            Peanut.nextDog = Fifi;
            Peanut.prvDog = null;

            Fifi.DogName = "Fifi";
            Fifi.DogBreed = "Poodle";
            Fifi.nextDog = Jordan;

            Jordan.DogName = "Jordan";
            Jordan.DogBreed = "Germansheppard";
            Jordan.nextDog = Fido;

            Fido.DogName = "Fido";
            Fido.DogBreed = "Beagle";
            Fido.nextDog = null;

            Roy.DogName = "Roy";
            Roy.DogBreed = "Spaniel";
            Roy.nextDog = Jordan;
            Roy.prvDog = Fifi;

            Coco.DogName = "Coco";
            Coco.DogBreed = "Border Collie";
            Coco.nextDog = Roy;
            Coco.prvDog = Roy;


        }
        public void WalkoverTheList()
        {
            current = Head;
            while (current != null) ;

            {
                Console.WriteLine(current.DogName);
                current = current.nextDog;
            }


        }


        public void WalkoverTheList_REVERSE()
        {
            current = Tail;
            while (current != null) ;

            {
                Console.WriteLine(current.DogName);
                current = current.prvDog;
            }



        }
    }
}