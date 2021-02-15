using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150221_LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            #region QuerySyntax

            //var querySyntax =       ////kan ook IEnumerable<int> zijn         ////IQueryable<int> is nodig voor Databases
            //    from n in list
            //    where n > 4
            //    select n;
            //foreach (var item in querySyntax)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region MethodSyntax
            //var MethodSyntax =
            //    // IEnumerable<int> MethodSyntax =
            //    list
            //    .Where(n => n > 4);
            //   // .Select(n => n);                      Select hier overobdig
            //foreach (var item in MethodSyntax)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Mixed Syntax
            //var mixedSyntax = (from n in list
            //                   select n).Max();

            //Console.WriteLine(mixedSyntax);
            #endregion


            list.Max(); //werkt ook (is deel van Linq)

            #region Zonder Linq

            int begin = 0;
            foreach (var item in list)
            {
                if (item > begin)
                {
                    begin = item;
                }
            }
            Console.WriteLine("biggest value" + begin);
            #endregion
        }
    }
}
