namespace CarAssemblyLine.Decorator
{
    internal class CarDecorator : ICar
    {
        public ICar Car { get; set; }

        public CarDecorator(ICar car)
        {
            Car = car;
        }

        public virtual void Assemble()
        {
            Car.Assemble();
        }

        public virtual string Drive()
        {
            return Car.Drive();
        }
    }
}
