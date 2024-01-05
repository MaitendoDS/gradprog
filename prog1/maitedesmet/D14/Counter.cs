using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14
{
    internal class Counter
    {
        private int _value;
        public int GetValue()
        {
            return _value;
        }
        public void SetValue(int value)
        {
            _value = value;
        }

        private int _step =1;
        public int GetStep()
        {
            
            return _step;
        }
        public void SetStep(int step)
        {
            _step = step;
        }

        public int Advance()
        {
            _value = _value + _step;
            return _value;
        }
      


    }



    

}
