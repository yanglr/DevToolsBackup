namespace AlternativeClassesWithDiffInterfaces.Animals.Optimize
{
    public interface IAnimal
    {
        GenderType Gender { get; set; }
        string MakeSound();
    }
}
