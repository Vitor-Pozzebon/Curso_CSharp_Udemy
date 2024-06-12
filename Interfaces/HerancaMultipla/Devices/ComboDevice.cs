namespace HerancaMultipla.Devices
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice Print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice Processing " + document);
        }

        public string Scan()
        {
            return "ComboDevice Scan Result";
        }
    }
}
