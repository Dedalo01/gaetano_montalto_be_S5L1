namespace eserS5L1.Models
{
    public class StaticDB
    {
        private static int _id = 0;

        private static readonly List<Worker> _workers = [
        new Worker() { Id = _id++, Name = "Gianfranco", LastName = "Pieraccino", Address = "Via Milano 12", FiscalCode = "BLASDSA2", IsMarried = true, HowManyChildren = 0, Position = "Software Developer" },
            new Worker() { Id = _id++, Name = "Giammaria", LastName = "Pierantono", Address = "Via Ezechiele 33", FiscalCode = "OSDINVE12", IsMarried = false, HowManyChildren = 3, Position = "Singer" },

        ];

        public static List<Worker> Workers { get { return _workers; } }

        public static Worker GetWorkerById(int id) { return _workers[id]; }

        public static Worker Add(string name, string lastName, string address, string fiscalCode, bool isMarried, int howManyChildren, string position)
        {
            _id++;
            Worker worker = new Worker() { Id = _id, Name = name, LastName = lastName, Address = address, IsMarried = isMarried, FiscalCode = fiscalCode, Position = position, HowManyChildren = howManyChildren };
            _workers.Add(worker);

            return worker;
        }
    }
}
