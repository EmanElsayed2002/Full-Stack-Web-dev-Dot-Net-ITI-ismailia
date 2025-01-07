using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationProject
{
    public class AnswersList : List<Answer>
    {
        public void Add(Answer v)
        {

            base.Add(v);
        }
    }
}
