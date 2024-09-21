using AlternativeClassesWithDiffInterfaces.Animals;
using AlternativeClassesWithDiffInterfaces.Animals.Optimize;
using Cat = AlternativeClassesWithDiffInterfaces.Animals.Optimize.Cat;
using Dog = AlternativeClassesWithDiffInterfaces.Animals.Optimize.Dog;

namespace AlternativeClassesWithDiffInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal>
                { new Dog { Gender = GenderType.Male }, new Cat { Gender = GenderType.Female } };
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
            }
        }
    }
}
