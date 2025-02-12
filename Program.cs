using Demo;

namespace session2Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var proudct = ListGenerator.ProductList;
            var customer = ListGenerator.CustomerList;
            string[] _words = File.ReadAllLines("dictionary_english.txt");
            //foreach (string word in _words)
            //{

            //    Console.WriteLine(word);
            //}
            #region queston1
            #region 1
            //var result = proudct.Where(proudct => proudct.UnitsInStock != 0).First();
            //Console.WriteLine(result);

            #endregion
            #region 2
            //var result = proudct.Where(proudct => proudct.UnitPrice > 1000).FirstOrDefault();
            //Console.WriteLine(result);
            #endregion
            #region 3
            //int [] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(i => i > 5).First()-1;
            //Console.WriteLine(result);
            #endregion
            #endregion
            #region quesyion2
            #region 1
            //#region MyRegion
            //int [] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result =Arr.Where(i=>i%2!=0).Count();
            //Console.WriteLine(result);
            #endregion
            #region 2
            //var result = customer.Select(i => new
            //{
            //    name = i.CustomerName,
            //    order = i.Orders.Count()

            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3
            //var result = proudct.GroupBy(p=>p.Category).Select(proudct=> new
            //{
            //    Category=proudct.Key,
            //    produect= proudct.Count()

            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);
            #endregion
            #region 5
            //var result = _words.Select(p=>p.Length);

            //foreach (var word in _words)
            //{
            //    Console.WriteLine(word.Length);
            //}
            #endregion
            #region 6
            //var result = _words.Min(p=>p.Length);

            //Console.WriteLine( result);

            #endregion
            #region 7
            //var result = _words.Max(p => p.Length);

            //Console.WriteLine(result);
            #endregion
            #region 8
            //var result = _words.Average(p => p.Length);

            //Console.WriteLine(result);
            #endregion
            #endregion
            #region question3
            #region 1
            //var result = proudct.Select(p=>p.Category ).Distinct();
            //foreach (var item in result) 
            //{ 
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2
            //var result = customer.Select(c => c.CustomerName[0])
            //    .Union(proudct.Select(p => p.ProductName[0])).Distinct();


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #region 3
            //var result = customer.Select(c => c.CustomerName[0])
            //    .Intersect(proudct.Select(p => p.ProductName[0])).Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4
            //var result = customer.Select(c => c.CustomerName[0])
            //    .Except(proudct.Select(p => p.ProductName[0])).Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 5
          //  var result = customer.Select(c => c.CustomerName.Substring(c.CustomerName.Length-3))
          //.Concat(proudct.Select(p => p.ProductName.Substring(p.ProductName.Length-3)));
       

          //  foreach (var item in result)
          //  {
          //      Console.WriteLine(item);
          //  }
            #endregion
            #endregion



        }
    }
}
