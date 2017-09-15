using System.Collections.Generic;
using System.Text;

namespace Logic.Entities
{
    public class Faculty
    {
        public string Name { get; private set; }
        public List<Group> Groups { get; private set; }

        public Faculty(string name, params Group[] groups)
        {
            Name = name;
            Groups = new List<Group>();
            if (groups != null)
            {
                foreach (var i in groups)
                {
                    Groups.Add(i);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{Name} \n");
            foreach (var f in Groups)
            {
                result.Append($"Group №{f.Number}\n");
                foreach (var s in f.Students)
                {
                    result.Append($"{s.Name}\n");
                }
            }
            return result.ToString();
        }
    }
}
