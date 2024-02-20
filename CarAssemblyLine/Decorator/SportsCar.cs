namespace CarAssemblyLine.Decorator
{
    internal class SportsCar : CarDecorator
    {
        public SportsCar(ICar car) : base(car)
        {
        }

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine("Adding Sports car features");
        }

        public override string Drive()
        {
            return base.Drive() + " fast";
        }
    }
}
