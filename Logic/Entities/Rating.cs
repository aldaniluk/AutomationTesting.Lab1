using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class Rating
    {
        public Subject Subj { get; private set; }
        public List<int> Marks { get; private set; }

        public Rating(Subject subject, params int[] marks)
        {
            Subj = subject;
            Marks = new List<int>();
            if (marks != null)
            {
                foreach (var i in marks)
                {
                    Marks.Add(i);
                }
            }
        }
    }
}
