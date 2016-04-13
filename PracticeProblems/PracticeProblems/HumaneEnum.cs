using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class HumaneEnum
    {

        enum animals { dog, cat, rabbit, bird };
        enum animalNames { Buster, Sparky, Jinx, Sam, Roger, Shadow, Champ, Dexter, Asia, Oliver, Buggs, Whistle, Felix, Sally, Isis, Scruff };
        enum dogBreed { Labrador, Collie, Terrier, Poodle };
        enum catBreed { Siamese, Persian, AmericanShorthair, RussianBlue };
        enum rabbitBreed { Flemish, FrenchLop, Angora, Netherland };
        enum birdBreed { Parakeet, Cockatoo, Sparrow, Canary };

        public void TrackAnimals()
        {
            Console.WriteLine(animalNames.Asia + " is a 1 year old " + catBreed.Persian + " " + animals.cat);
            Console.WriteLine(animalNames.Felix + " is a 2 year old " + catBreed.AmericanShorthair + " " + animals.cat);
            Console.WriteLine(animalNames.Jinx + " is a 3 year old " + catBreed.Siamese + " " + animals.cat);
            Console.WriteLine(animalNames.Shadow + " is a 2 year old " + catBreed.RussianBlue + " " + animals.cat);
            Console.WriteLine(animalNames.Buggs + " is a 1 year old " + rabbitBreed.Flemish + " " + animals.rabbit);
            Console.WriteLine(animalNames.Buster + " is a 4 year old " + rabbitBreed.Angora + " " + animals.rabbit);
            Console.WriteLine(animalNames.Oliver + " is a 2 year old " + rabbitBreed.Netherland + " " + animals.rabbit);
            Console.WriteLine(animalNames.Roger + " is a 2 year old " + rabbitBreed.FrenchLop + " " + animals.rabbit);
            Console.WriteLine(animalNames.Dexter + " is a 1 year old " + birdBreed.Canary + " " + animals.bird);
            Console.WriteLine(animalNames.Isis + " is a 1 year old " + birdBreed.Sparrow + " " + animals.bird);
            Console.WriteLine(animalNames.Whistle + " is a 2 year old " + birdBreed.Parakeet + " " + animals.bird);
            Console.WriteLine(animalNames.Sally + " is a 2 year old " + birdBreed.Cockatoo + " " + animals.bird);
            Console.WriteLine(animalNames.Champ + " is a 4 year old " + dogBreed.Labrador + " " + animals.dog);
            Console.WriteLine(animalNames.Sam + " is a 3 year old " + dogBreed.Poodle + " " + animals.dog);
            Console.WriteLine(animalNames.Scruff + " is a 1 year old " + dogBreed.Terrier + " " + animals.dog);
            Console.WriteLine(animalNames.Sparky + " is a 2 year old " + dogBreed.Collie + " " + animals.dog);
            Console.ReadLine();
        }
    }
}
