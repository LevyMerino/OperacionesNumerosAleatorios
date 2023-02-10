using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OperacionesNumerosAleatorios
{
    internal class ListNumbers
    {
        private List<int> _numbers;
        private int _n;
        public string minor;
        public string higher;
        internal ListNumbers(int n)
        {
            _numbers = new List<int>();
            _n = n;
            minor = string.Empty;
            higher = string.Empty;
        }

        internal void RandomNumbers()
        {
            Random random = new();

            for (int c = 0; c < _n; c++)
            {
                int randomNumber = random.Next(1, 101);
                _numbers.Add(randomNumber);
            }
        }

        internal string getInput()
        {
            return String.Join(", ", _numbers);
        }


        internal string getAverage()
        {

            float average = _numbers.Sum() / _n;
            return average.ToString();
        }

        internal string getAddition()
        {
            return _numbers.Sum().ToString();
        }

        internal string getDescending()
        {

            var descendingList = _numbers.OrderByDescending(x => x).ToList();
            higher = descendingList.First().ToString();
            return String.Join(", ", descendingList);
        }


        internal string getAscending()
        {

            var ascendingList = _numbers.OrderBy(x => x).ToList();
            minor = ascendingList.First().ToString();
            return String.Join(", ", ascendingList);
        }

    }
}
