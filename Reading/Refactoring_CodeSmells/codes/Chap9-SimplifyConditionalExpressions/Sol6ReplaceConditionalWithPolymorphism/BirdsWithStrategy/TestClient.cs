using Autofac;
using SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithStrategy.Interfaces;
using SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithStrategy.Strategies;

namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithStrategy
{
    internal class TestClient
    {
        public static void Test()
        {
            var builder = new ContainerBuilder();

            // Register bird strategies
            builder.RegisterType<EuropeanBirdSpeedStrategy>().As<IFlySpeedStrategy>().Keyed<IFlySpeedStrategy>("EuropeanSwallow");
            builder.RegisterType<AfricanBirdSpeedStrategy>().As<IFlySpeedStrategy>().Keyed<IFlySpeedStrategy>("AfricanBird");
            builder.RegisterType<NorwegianBlueBirdSpeedStrategy>().As<IFlySpeedStrategy>().Keyed<IFlySpeedStrategy>("Norwegian");

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var birdSpeedStrategy = scope.ResolveKeyed<IFlySpeedStrategy>("AfricanBird");
                var bird = new Bird(birdSpeedStrategy);
                Console.WriteLine(birdSpeedStrategy.GetFlySpeed(bird, 5));
            }
        }
    }
}
