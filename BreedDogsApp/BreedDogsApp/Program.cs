using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreedDogsApp
{

    class Program
    {
        static void Main(string[] args)
        {
            BreedEpagneulPicard EpagneulPicard;
            EpagneulPicard.Breed = "Picardy Spaniel  (Epagneul Picard)";
            EpagneulPicard.Section = "Continental Pointing Dogs";
            EpagneulPicard.Weight = 23;
            EpagneulPicard.Height = 57.5;
            EpagneulPicard.BigSize = true;
            EpagneulPicard.GroupDog = BreedEpagneulPicard.Group.Pointing_Dogs;

            Console.WriteLine(EpagneulPicard);
        }
    }
}

struct BreedEpagneulPicard
{
    public string Breed;
    public string Section;
    public int Weight;
    public double Height;
    public bool BigSize;
    public enum Group {Sheepdogs_and_Cattledogs = 1, Pinscher_and_Schnauzer = 2, Terriers = 3, Dachshunds = 4, Spitz_and_primitive_types = 5, Scent_hounds_and_related_breeds = 6, Pointing_Dogs = 7, Retrievers_Flushing_Dogs_Water_Dogs = 8, Companion_and_ToyDogs = 9, Sighthounds = 10};
    public Group GroupDog;
       
    public override string ToString()
    {
        return String.Format("{0}, {1}, {2}, {3}, {4}, {5}", Breed, Section, Weight, Height, BigSize, (int)GroupDog);
    }
} 
