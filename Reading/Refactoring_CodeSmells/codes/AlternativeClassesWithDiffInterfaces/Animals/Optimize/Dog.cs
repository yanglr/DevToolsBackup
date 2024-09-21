namespace AlternativeClassesWithDiffInterfaces.Animals.Optimize
{
    public class Dog : IAnimal
    {
        public GenderType Gender { get; set; }
        public string MakeSound()
        {
            return "Woof!";
        }
    }
}
