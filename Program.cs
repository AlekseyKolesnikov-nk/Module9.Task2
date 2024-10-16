namespace Module9.Task2
{
    public static class Programm
    {
        public static void Main(string[] args)
        {
            NumberSelect numberSelect = new NumberSelect();
            numberSelect.NumberSelectEvent += Names.NameSort;

            var arrayExceptions = new List<Exception>() { new FormatException(), new ArgumentOutOfRangeException() }; 
            foreach (var item in arrayExceptions)
            {
                while(true)
                {
                    try
                    {
                        numberSelect.Select();
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    };
                }
            }
        }
    }
}