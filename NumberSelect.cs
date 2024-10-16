using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Task2
{
    /// <summary>
    /// 
    /// </summary>
    public class NumberSelect
    {
        public delegate void NumberSelectDelegate(int number);
        public event NumberSelectDelegate NumberSelectEvent;

        public void Select()
        {
            Console.WriteLine("\nДля прямой сортировки выберите 1, для обратной сортировки выберите 2");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number! == 1 && number! == 2)
            {
                throw new FormatException();    
            }
            
            if (number! < 1 | number! > 2) throw new ArgumentOutOfRangeException(); 

            NumSelect(number);
        }

        protected virtual void NumSelect(int number)
        {
            NumberSelectEvent?.Invoke(number);
        }
    }
}
