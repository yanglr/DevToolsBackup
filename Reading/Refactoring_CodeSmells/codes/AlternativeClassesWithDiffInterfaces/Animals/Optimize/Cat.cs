namespace AlternativeClassesWithDiffInterfaces.Animals.Optimize
{
    public class Cat : IAnimal
    {
        public GenderType Gender { get; set; }

        public string MakeSound()
        {
            return "Meow!";
        }
    }
}
