using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Entities
{
    public class Student
    {
        public string Name { get; private set; }
        public string SurName { get; private set; }
        public List<Rating> Ratings { get; private set; }

        public Student(string name, string surName, params Rating[] ratings)
        {
            Name = name;
            SurName = surName;
            Ratings = new List<Rating>();
            if (ratings != null)
            {
                foreach (var i in ratings)
                {
                    Ratings.Add(i);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{Name} {SurName} \n");
            foreach(var r in Ratings)
            {
                result.Append($"{r.Subj} : ");
                foreach(var m in r.Marks)
                {
                    result.Append($"{m} ");
                }
                result.Append("\n");
            }
            return result.ToString();
        }
    }

}
