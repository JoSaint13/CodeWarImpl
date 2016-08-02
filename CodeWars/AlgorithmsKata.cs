using System.Linq;
using System.Text;

namespace CodeWars
{
    public class AlgorithmsKata
    {
        public static string PigIt(string str)
        {
            var arr = str.Split(' ');
            var sb = new StringBuilder();

            foreach (var item in arr)
            {
                var first = item[0];
                sb.Append(item.Remove(0, 1));
                sb.Append(first + "ay");
                sb.Append(" ");
            }

            return sb.ToString().TrimEnd();
        }

        public static string PigIt2(string str)
        {
            var sb = new StringBuilder();
            str.Split(' ').ToList().ForEach(x => sb.Append(string.Concat(new string(x.Skip(1).ToArray()), x[0] + "ay ")));
            return sb.ToString().TrimEnd();
        }
    }
}
