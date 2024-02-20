namespace CarAssemblyLine
{
    internal class Car : ICar
    {
        public void Assemble()
        {
            Console.WriteLine("Assemble basic car");
        }

        public string Drive()
        {
            return "Driving";
        }
    }
}
