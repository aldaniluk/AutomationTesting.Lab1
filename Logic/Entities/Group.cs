using System.Collections.Generic;
using System.Text;

namespace Logic.Entities
{
    public class Group
    {
        public int Number { get; private set; }
        public List<Student> Students { get; private set; }

        public Group(int number, params Student[] students)
        {
            Number = number;
            Students = new List<Student>();
            if (students != null)
            {
                foreach (var i in students)
                {
                    Students.Add(i);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"Group: {Number} \n");
            foreach (var s in Students)
            {
                result.Append($"{s.Name} {s.SurName}\n");
            }
            return result.ToString();
        }
    }
}
