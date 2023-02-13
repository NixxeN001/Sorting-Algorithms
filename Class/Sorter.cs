using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_AlgorithmsNew.Class
{
    public static class Sorter
    {
        public static void SortbyFloat<T>(ref List<T> data, string fieldToSortName) where T : class
        {
            T temp;
            for (int i = 0; i < data.Count - 1; i++)
            {
                for (int j = 0; j < data.Count - 1; j++)
                {
                    if (getFloatVal<T>(data[j], fieldToSortName) > getFloatVal<T>(data[j + 1], fieldToSortName))
                    {
                        temp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j + 1] = temp;
                    }
                }
            }
        }
        public static void SortbyInt<T>(ref List<T> data, string fieldToSortName) where T : class
        {
            T temp;
            for (int i = 0; i < data.Count - 1; i++)
            {
                for (int j = 0; j < data.Count - 1; j++)
                {
                    if (getIntVal<T>(data[j], fieldToSortName) > getIntVal<T>(data[j + 1], fieldToSortName))
                    {
                        temp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j + 1] = temp;
                    }
                }
            }
        }

        public static void SortbyString<T>(ref List<T> data, string fieldtoSortName) where T: class
        {
            T temp;
            for (int i = 0; i < data.Count-1; i++)
            {
                for (int j = 0; j < data.Count-1; j++)
                {
                    if (getStrVal(data[j], fieldtoSortName).CompareTo(getStrVal(data[j+1],fieldtoSortName))>0)
                    {
                        temp = data[j];
                        data[j ] = data[j+1];
                        data[j+1] = temp;
                    }
                }
            }
        }



        private static float getFloatVal<T>(T obj, string fieldName) where T : class
        {
            return (float)typeof(T).GetField(fieldName).GetValue(obj);
        }
        private static int getIntVal<T>(T obj, string fieldName) where T : class
        {
            return (int)typeof(T).GetField(fieldName).GetValue(obj);
        }
        private static string getStrVal<T>(T obj, string fieldName) where T : class
        {
            return (string)typeof(T).GetField(fieldName).GetValue(obj);
        }
    }
}
