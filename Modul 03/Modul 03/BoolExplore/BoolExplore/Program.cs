using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolExplore
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _b = true;
            bool _test = 5 > 10;
            int[] _i = new int[] { 4, 3, 2 };
            int _ui = Convert.ToInt32(Console.ReadLine());
           
            bool _check01 = _ui <= _i.Length;
            bool _check02 = _ui > 0;
            bool _exp01 = _check01 && _check02;//Logic "AND"
            bool _exp02 = _check01 || _check02;//Logic "OR"
            bool _exp03 = !_check01;

            Console.WriteLine("Logic AND:"+_exp01.ToString());
            Console.WriteLine("LOgic OR:"+ _exp02.ToString());
            Console.WriteLine("NOT OF "+_check01.ToString()+": "+_exp03);
        }
    }
}
