using System.Collections.Generic;
using System.Text;

namespace Logic.Entities
{
    public class University
    {
        public string Name { get; private set; }
        public List<Faculty> Faculties { get; private set; }

        public University(string name, params Faculty[] faculties)
        {
            Name = name;
            Faculties = new List<Faculty>();
            if (faculties != null)
            {
                foreach (var i in faculties)
                {
                    Faculties.Add(i);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{Name} \n");
            foreach (var f in Faculties)
            {
                result.Append($"{f.Name}\n");
            }
            return result.ToString();
        }
    }
}
