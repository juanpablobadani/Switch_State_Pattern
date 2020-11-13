using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Switch _switch = new Switch();

            _switch.Press();
            _switch.Press();
            _switch.Press();
            _switch.Press();
            _switch.Press();
            _switch.Press();


            Console.ReadKey();
        }
    }
}
