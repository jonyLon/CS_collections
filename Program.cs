global using global::System.Collections;
namespace CS_collections
{
    internal class Program
    {
        static public void PrintColl(IEnumerable coll, string name)
        {
            Console.WriteLine(name + ": ");
            foreach (Object item in coll)
            {
                Console.Write(item+"  ");
            }
            Console.WriteLine();
        }

        static public List<bool> FilterBool(IEnumerable coll)
        {
            List<bool> boolList = new List<bool>();
            foreach (Object item in coll)
            {
                if (item is bool)
                {
                    boolList.Add((bool)item);
                }
            }
            return boolList;
        }
        static public List<int> FilterInt(IEnumerable coll)
        {
            List<int> intList = new List<int>();
            foreach (Object item in coll)
            {
                if (item is int)
                {
                    intList.Add((int)item);
                }
            }
            return intList;
        }
        static public List<double> FilterDouble(IEnumerable coll)
        {
            List<double> DoubleList = new List<double>();
            foreach (Object item in coll)
            {
                if (item is double)
                {
                    DoubleList.Add((double)item);
                }
            }
            return DoubleList;
        }

        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add(2);
            arrList.Add(3);
            arrList.Add(true);
            arrList.Add(false);
            arrList.Add(true);
            arrList.Add(false);
            arrList.Add(3.14);
            arrList.Add(3.18);
            arrList.Add(9.8);
            arrList.Add(4.8);
            PrintColl(arrList, "ArrayList");
            var boolList = FilterBool(arrList);
            var intList = FilterInt(arrList);
            var doubleList = FilterDouble(arrList);
            PrintColl(boolList, "Bool list");
            PrintColl(intList, "Int list");
            PrintColl(doubleList, "Double List");

            List<string> list = new List<string>();
            list.AddRange(new string[]{ "Contrary", "to", "popular", "belief", "Lorem", "Aontrary" });
            int max = 0;
            foreach (var item in list)
            {
                if (item.Length > max)
                {
                    max = item.Length;
                }
            }
            List<string> maxLen = new List<string>();
            list.ForEach(item =>
            {
                if (item.Length == max)
                {
                    maxLen.Add(item);
                }
            });
            maxLen.Sort();
            Console.WriteLine(maxLen[0]);
        }
    }


}