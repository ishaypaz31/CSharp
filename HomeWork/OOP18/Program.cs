using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP18
{
    class Program
    {
        static void Main(string[] args)
        {
            MyButton button1 = new MyButton("Go", new Point(3, 4), new Point(2, 6));
            Point button2 = new Point((11), 15);
            MyCanvas.CreateNewButton(1, 2, 3, 4);
            MyCanvas.CreateNewButton(1, 5, 3, 9);
            MyCanvas.CreateNewButton(1, 5, 3, 9);
            MyCanvas.ClearAllButtons();
            MyCanvas.CreateNewButton(1, 5, 3, 9);
            MyCanvas.CreateNewButton(1, 5, 3, 9);
            Console.WriteLine($"Current number of buttons: {MyCanvas.GetCurrentNumberOfButtons()}");
            MyCanvas.ClearAllButtons();
            Console.WriteLine($"Current number of buttons: {MyCanvas.GetCurrentNumberOfButtons()}");
            MyCanvas.CreateNewButton(1, 5, 3, 9);
            MyCanvas.CreateNewButton(1, 5, 3, 9);
            MyCanvas.CreateNewButton(1, 5, 3, 9);
            Console.WriteLine($"Current number of buttons: {MyCanvas.GetCurrentNumberOfButtons()}");
            MyCanvas.DeleteLastButton();
            Console.WriteLine($"Current number of buttons: {MyCanvas.GetCurrentNumberOfButtons()}");
        }
    }
}
