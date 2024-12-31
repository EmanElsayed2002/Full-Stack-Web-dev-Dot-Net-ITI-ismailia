using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11CS
{
   abstract public class Question
    {
        public string Type { get; set; }
        public string Body { get; set; }
        public string Header { get; set; }
        public int Mark { get; set; }

       public List<Answer> Choises { get; set; }

        protected Question(string _type, string _body, string _heaader, int _mark,List<Answer> _choises)
        {
            Type = _type;
            Body= _body;
            Header = _heaader;
            Mark = _mark;
            Choises = _choises;
        }
        protected Question()
        {
            Type = "MCQ";
            Body = "Empty Question";
            Header = "";
            Mark = 0;
        }
    }
}
