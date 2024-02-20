namespace CarAssemblyLine.Decorator
{
    internal class LuxuryCar : CarDecorator
    {
        public LuxuryCar(ICar car) : base(car)
        {
        }

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine("Adding luxury features");
        }

        public override string Drive()
        {
            return base.Drive() + " with comfort";
        }
    }
}
