using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11CS
{
    public class TFQ:Question
    {
        public TFQ(string _body, string _heaader, int _mark, List<Answer> _choises) : base("True/False", _body, _heaader, _mark, _choises)
        {
        }
    }
}
