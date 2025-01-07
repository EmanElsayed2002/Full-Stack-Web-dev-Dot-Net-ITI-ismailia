using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationProject
{
    public class QuestionsList : List<Question>
    {
        public void Add(Question q)
        {
            base.Add(q);
        }
    }
}
