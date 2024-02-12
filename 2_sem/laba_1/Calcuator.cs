using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_1
{
    interface Calculate
    {
        float Plus(float x, float y);
        float Minus(float x, float y);
        float Multiplication(float x, float y);
        float Devision(float x, float y);
        float Percent(float x, float y);
        int WithoutOstatok(float x, float y);
        void AddInHistory(float x, Calcuator calcuator);
        string OutInHistory(Calcuator calcuator);


    }
    public class Calcuator:Calculate
    {
        public int count = 2;
        public  float state { get; set; }
        public   float undoValue { get; set; }
        public float dopValue { get; set; }
        public float[] historyValue = new float[3];

        public float Plus(float x, float y)
        {
            return x + y;
        }

        public float Minus(float x, float y)
        {
            return x - y;
        }

        public float Multiplication(float x, float y)
        {
            return x * y;
        }

        public float Devision(float x, float y)
        {
            return x / y;
        }

        public float Percent(float x, float y)
        {
            return x % y;
        }

        public int WithoutOstatok(float x, float y)
        {
            return (int)(x / y);
        }

        public void AddInHistory(float x, Calcuator calcuator)
        {
            if (calcuator.count < 0)
            {
                calcuator.count = 2;
            }
            calcuator.historyValue[calcuator.count] = x;
            calcuator.count--;
           
        }

        public string OutInHistory(Calcuator calcuator)
        {
            string str = "";
            foreach (var item in calcuator.historyValue)
            {
                str += item.ToString();
                str += "\t";
            }
            return str;
        }

        
    }
}
