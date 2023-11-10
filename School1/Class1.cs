using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School1
{

    internal class Class1
    {
        private static Page1 _reg;
        public static Page1 reg
        {
            get
            { 
                if(_reg == null)
                {
                    _reg = new Page1();
                }
                return _reg;
            }
        }
        public static Page3 _autho;
        public static Page3 autho
        {
            get
            {
              _autho = new Page3();
                return _autho;
            }
        }



        private static Page2 _mainWindow;
        public static Page2 mainWindow
        {
            get
            {
                _mainWindow= new Page2();
                return _mainWindow;
            }
        }
    

    }
}
