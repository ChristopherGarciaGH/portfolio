using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEnCSharp
{
    public class ResultadoSuma()
    {
        public int IndiceOperando1 { get; set; } = 0;
        public int IndiceOperando2 { get; set; } = 0;
        public bool Sucess { get; set; } = false; 
    }

    internal class TwoSum
    {
        private int[] _nums;
        private int _target = 0;

        public int[] Sum { get;}


        public int Target
        {
            get { return _target; }
            set { _target = value; }
        }

        public TwoSum(int[] sum, int target)
        {
            this._nums = sum;
            this._target = target;
        }


        public ResultadoSuma sumaObjetivo()
        {
            ResultadoSuma resultadoSuma = new ResultadoSuma();
            for (int i = 0; i < _nums.Length; i++)
            {
                int sum1 = _nums[i];

                for (int j = i + 1; j < _nums.Length; j++)
                {
                    int sum2 = _nums[j];


                    if (sum1 + sum2 == _target)
                    {
                        //Console.WriteLine(sum1);
                        //Console.WriteLine(sum2);
                        resultadoSuma.IndiceOperando1 = i;
                        resultadoSuma.IndiceOperando2 = j;
                        resultadoSuma.Sucess = true;
                    }



                }


            }
            return resultadoSuma;
        }
    }
}
