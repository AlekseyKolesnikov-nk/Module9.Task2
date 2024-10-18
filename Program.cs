namespace Module9.Task2
{
    public static class Programm
    {
        public static void Main(string[] args)
        {
            NumberSelect numberSelect = new NumberSelect();
            numberSelect.NumberSelectEvent += Names.NameSort;

            var arrayExceptions = new List<Exception>() { new FormatException(), new ArgumentOutOfRangeException() }; 
            //foreach (var item in arrayExceptions)
            {
                bool bad = true;
                while(bad)
                {
                    try
                    {
                        numberSelect.Select();
                        bad=false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Выбрано значение, отличное от 1 или 2");
                    };
                }
            }
        }
    }
}