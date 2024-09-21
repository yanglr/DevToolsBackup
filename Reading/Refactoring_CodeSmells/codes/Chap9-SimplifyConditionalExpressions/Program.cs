using Autofac;
using SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithStrategy.Interfaces;
using SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithStrategy.Strategies;

namespace SimplifyConditionalExpressions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            // Register bird strategies
            builder.RegisterType<EuropeanBirdSpeedStrategy>().As<IFlySpeedStrategy>().Named<IFlySpeedStrategy>("EuropeanSwallow");
            builder.RegisterType<AfricanBirdSpeedStrategy>().As<IFlySpeedStrategy>().Named<IFlySpeedStrategy>("AfricanBird");
            builder.RegisterType<NorwegianBlueBirdSpeedStrategy>().As<IFlySpeedStrategy>().Named<IFlySpeedStrategy>("Norwegian");

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                EuropeanBirdSpeedStrategy birdSpeedStrategy = scope.Resolve<EuropeanBirdSpeedStrategy>();
                Console.WriteLine(birdSpeedStrategy.GetFlySpeed(new Sol6ReplaceConditionalWithPolymorphism.BirdsWithStrategy.Bird(birdSpeedStrategy), 5));
            }
        }
    }
}