using L2O___D09;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp10
{
    class Program
    {
        public static void Main()
        {

            #region Restriction Operators
            //Console.WriteLine("1. all products that are out of stock.");

            //var list = ListGenerators.ProductList.Where(p => p.UnitsInStock == 0);

            //foreach (var product in list1)
            //{
            //    Console.WriteLine(product);
            //}

            // Console.WriteLine("2. all products that are in stock and cost more than 3.00 per unit.");

            //var list2 = ListGenerators.ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            // foreach (var product in list2)
            // {
            //     Console.WriteLine(product);
            // }


            // Console.WriteLine("3. Returns digits whose name is shorter than their value.");
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var lst = Arr.Where((value, index) => value.Length < index); 
            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Element Operators
            //Console.WriteLine("1. first Product out of Stock ");
            //var firstItem1 = ListGenerators.ProductList.FirstOrDefault(p => p.UnitsInStock == 0); 
            //Console.WriteLine(firstItem1);

            //Console.WriteLine("2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.");
            //var firstItem2 = ListGenerators.ProductList.FirstOrDefault(p => p.UnitPrice>1000);
            //if (firstItem != null)
            //{
            //    Console.WriteLine(firstItem2);
            //}
            //else Console.WriteLine("null");

            //    Console.WriteLine("3. Retrieve the second number greater than 5 ");
            //    int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var secArr = Arr.Where(num=>num>5).ElementAt(1);
            //    Console.WriteLine(secArr); 

            #endregion

            #region Set Operators


            //Console.WriteLine("1. Find the unique Category names from Product List");
            //var lst = ListGenerators.ProductList.Select(p => p.Category).Distinct(); 
            //foreach(var item in lst)
            //{
            // Console.WriteLine(item);
            //}

            //Console.WriteLine("2. Produce a Sequence containing the unique first letter from both product and customer names.");
            //var seq = ListGenerators.ProductList.Select(p => p.ProductName).Select(pname => pname.ElementAt(0)).Distinct().Concat(ListGenerators.CustomerList.Select(c => c.CustomerID).Select(cname => cname.ElementAt(0)).Distinct());
            //foreach (var item in seq)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("3. Create one sequence that contains the common first letter from both product and customer names.");
            //var seq2 = ListGenerators.ProductList.Select(p => p.ProductName).Select(pname => pname.ElementAt(0)).Intersect(ListGenerators.CustomerList.Select(c => c.CustomerID).Select(cname => cname.ElementAt(0)));
            //foreach (var item in seq2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.");
            //var seq3 = ListGenerators.ProductList.Select(p => p.ProductName).Select(pname => pname.ElementAt(0)).Except(ListGenerators.CustomerList.Select(c => c.CustomerID).Select(cname => cname.ElementAt(0)));
            //foreach (var item in seq3)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("5. Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates");
            //var n1 = ListGenerators.ProductList.Select(p => p.ProductName).Select(name => name.Substring(name.Length - 3));
            //var n2 = ListGenerators.CustomerList.Select(c => c.CustomerID).Select(name => name.Substring(name.Length - 3));
            //var seq4 = n1.Concat(n2);

            //foreach (var item in seq4)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Aggregate Operators

            //Console.WriteLine("1. Uses Count to get the number of odd numbers in the array");
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var oddCount = Arr.Where(num => num % 2 == 1).Count();

            //    Console.WriteLine(oddCount);


            //Console.WriteLine("2. Return a list of customers and how many orders each has.");
            //var lst = ListGenerators.CustomerList.Select(c => new { Customer_Name = c.CustomerID, No_Of_Orders = c.Orders.Length }); 
            //foreach(var item in lst)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("3. Return a list of categories and how many products each has");
            //var lst2  = from p in ListGenerators.ProductList
            //         group p by p.Category
            //            into prdGroups
            //            select new { Category = prdGroups.Key, No_Of_Products = prdGroups.Count() };

            //foreach (var item in lst2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("4. Get the total of the numbers in an array.");
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var total = Arr.Sum();
            //Console.WriteLine(total);


            //Console.WriteLine("5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).");

            //List<String> Words = new List<String>();
            //int total = 0;

            //using (StreamReader file = new StreamReader("dictionary_english.txt"))
            //{
            //    string ln;
            //    int num = 0;


            //    while ((ln = file.ReadLine()) != null)
            //    {
            //        Words.Add(ln);
            //        num = ln.Length;
            //       total += num;

            //    }
            //    file.Close();
            //}

            //Console.WriteLine(total);


            //Console.WriteLine("6. Get the total units in stock for each product category.");
            //var lst6 = ListGenerators.ProductList.GroupBy(p=>p.Category).Select(p=> new {Category = p.Key , TotalUnitsInStock = p.Sum(p=>p.UnitsInStock)});
            //foreach(var item in lst6)
            //{
            //    Console.WriteLine(item); 
            //}

            //Console.WriteLine("7. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).");

            //List<String> Words = new List<String>();

            //using (StreamReader file = new StreamReader("dictionary_english.txt"))
            //{

            //    string ln;

            //    while ((ln = file.ReadLine()) != null)
            //    {
            //        Words.Add(ln);

            //    }
            //    file.Close();
            //}

            //var Shortest_Length = Words.Min(word => word.Length);

            //Console.WriteLine(Shortest_Length);

            //Console.WriteLine("8. Get the cheapest price among each category's products");
            //var cheapest = ListGenerators.ProductList.GroupBy(p => p.Category).Select(p => new { Category = p.Key, minPrice = p.Min(p => p.UnitPrice) });
            //foreach (var prod in cheapest)
            //{
            //    Console.WriteLine(prod);
            //}

            //Console.WriteLine("9. Get the products with the cheapest price in each category (Use Let)");

            //var cheapest2 = from prod in ListGenerators.ProductList
            //                group prod by prod.Category
            //              into prodGroup
            //                let MinPriceInCategory = prodGroup.Min(prod => prod.UnitPrice)
            //                orderby MinPriceInCategory
            //                select new { Category = prodGroup.Key, MinPrice = MinPriceInCategory }; 
            //foreach (var prod in cheapest2)
            //{
            //    Console.WriteLine(prod);
            //}

            //Console.WriteLine("10. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).");

            //List<String> Words = new List<String>();

            //using (StreamReader file = new StreamReader("dictionary_english.txt"))
            //{

            //    string ln;

            //    while ((ln = file.ReadLine()) != null)
            //    {
            //        Words.Add(ln);

            //    }
            //    file.Close();
            //}

            //var Longest_Length = Words.Max(word => word.Length);

            //Console.WriteLine(Longest_Length);

            //Console.WriteLine("11. Get the most expensive price among each category's products.");
            //var expLst = ListGenerators.ProductList.GroupBy(p => p.Category).Select(p => new { Category = p.Key, MostExpensiveProd = p.Max(p => p.UnitPrice) });

            //foreach (var prod in expLst)
            //{
            //    Console.WriteLine(prod);
            //}

            //Console.WriteLine("12. Get the products with the most expensive price in each category.");

            //var expLst1 = 
            //              from prod in ListGenerators.ProductList
            //              group prod by prod.Category into g
            //              let mostExpensive = g.Aggregate((prod1, prod2) => (prod1.UnitPrice > prod2.UnitPrice) ? prod1 : prod2)
            //              select new { Category = g.Key, Product_Name = mostExpensive.ProductName, MostExpensivePrice = mostExpensive.UnitPrice };

            //foreach (var prod in expLst1)
            //{
            //    Console.WriteLine(prod);
            //}

            //Console.WriteLine("13. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).");

            //List<String> Words = new List<String>();

            //using (StreamReader file = new StreamReader("dictionary_english.txt"))
            //{

            //    string ln;

            //    while ((ln = file.ReadLine()) != null)
            //    {
            //        Words.Add(ln);

            //    }
            //    file.Close();
            //}

            //var avg_Length = Words.Average(word => word.Length);

            //Console.WriteLine(avg_Length);


            //Console.WriteLine("14. Get the average price of each category's products.");
            //var avgPrice = ListGenerators.ProductList.GroupBy(p => p.Category).Select(p => new { Category = p.Key, AvgPrice = p.Average(p => p.UnitPrice) }); 
            //foreach(var item in avgPrice)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region Ordering Operators


            //Console.WriteLine("1. Sort a list of products by name");

            //var list7 = ListGenerators.ProductList.Select(prod => prod.ProductName).OrderBy(name => name);

            //foreach (var prod in list7)
            //{
            //    Console.WriteLine(prod);
            //}




            // Console.WriteLine("2. Uses a custom comparer to do a case-insensitive sort of the words in an array.");
            // string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            // var list8 = Arr.OrderBy(x => x);

            // foreach (var item in list8)
            // {
            //     Console.WriteLine(item);
            // }




            //Console.WriteLine("3. Sort a list of products by units in stock from highest to lowest.");
            // var list9 = ListGenerators.ProductList.Select( prod => new { Product = prod.ProductName, UnitsInStock = prod.UnitsInStock}).OrderByDescending(prod => prod.UnitsInStock);

            // foreach (var item in list9)
            // {
            //     Console.WriteLine(item);
            // }



            //Console.WriteLine("4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.");


            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var list10 = Arr.Select(x => x).OrderBy(x => x.Length).ThenBy(x => x);
            //foreach (var ele in list10)
            //{
            //    Console.WriteLine(ele);
            //}




            //Console.WriteLine("5. Sort first by word length and then by a case-insensitive sort of the words in an array.");

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var list11 = words.OrderBy(words => words.Length);

            //foreach (var item in list11)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("6. Sort a list of products, first by category, and then by unit price, from highest to lowest.");
            //var list12 = ListGenerators.ProductList.OrderBy(p =>p.Category).ThenByDescending(p=>p.UnitPrice);

            //foreach (var ele in list12)
            //{
            //    Console.WriteLine(ele);
            //}

            //Console.WriteLine("7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.");
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var list13 = Arr.OrderBy(words => words.Length).ThenByDescending(x => x);

            //foreach (var item in list13)
            //{
            //    Console.WriteLine(item);
            //}



            //Console.WriteLine("8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.");

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var list14 = Arr.Select( (ele, index ) => new { word = ele, x = index}).Where(ele => ele.word[1] == 'i').Select(ele => ele.x);

            //foreach (var ele in list14)
            //{
            //    Console.WriteLine(ele);
            //}


            #endregion

            #region Partitioning Operators

            //Console.WriteLine("1.Get the first 3 orders from customers in Washington");

            //var list15 = ListGenerators.CustomerList.Where(c => c.Address.Contains("Washington")).Take(3);

            //foreach (var item in list15)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("2.Get all but the first 2 orders from customers in Washington.");

            //var list16 = ListGenerators.CustomerList.Where(ele => ele.Address.Contains("Washington")).Select(ele => ele.Orders).Concat(ListGenerators.CustomerList.Select(ele => ele.Orders));

            //foreach (var item in list16)
            //{
            //    foreach (var order in item)
            //        Console.WriteLine(order);
            //}



            //Console.WriteLine("3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.");

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var list17 = numbers.Select((ele, index) => new { val = ele, index = index }).TakeWhile(ele => ele.val > ele.index);

            //foreach (var item in list17)
            //{
            //    Console.WriteLine(item);
            //}




            //Console.WriteLine("4.Get the elements of the array starting from the first element divisible by 3");
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var list18 = numbers.SkipWhile(ele => ele % 3 != 0);

            //foreach (int ele in list18)
            //{
            //    Console.WriteLine(ele);
            //}




            //Console.WriteLine("5.Get the elements of the array starting from the first element less than its position.");

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var list19 = numbers.Select((ele, index) => new { val = ele, index = index }).SkipWhile(ele => ele.val >= ele.index).Select(ele => ele.val);

            //foreach (int ele in list19)
            //{
            //    Console.WriteLine(ele);
            //}

            #endregion

            #region Projection Operators


            //Console.WriteLine("1.Return a sequence of just the names of a list of products.");

            //var list20 = ListGenerators.ProductList.Select(prod => prod.ProductName);

            //foreach (var prod in list20)
            //{
            //    Console.WriteLine(prod);
            //}




            //Console.WriteLine("2.Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).");
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var list21 = words.Select(word => word.ToUpper()).Concat(words.Select(word => word.ToLower()));

            //foreach (var prod in list21)
            //{
            //    Console.WriteLine(prod);
            //}




            //Console.WriteLine("3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.");

            //var list22 = ListGenerators.ProductList.Select(prod => new { ProductNme = prod.ProductName, UnitsInStock = prod.UnitsInStock, Price = prod.UnitPrice });

            //foreach (var prod in list22)
            //{
            //    Console.WriteLine(prod);
            //}




            //Console.WriteLine("4.Determine if the value of ints in an array match their position in the array.");
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var list23 = Arr.Select((ele, index) => ele + ": " + !!(ele == index));

            //foreach (var prod in list23)
            //{
            //    Console.WriteLine(prod);
            //}




            //Console.WriteLine("5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.");

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var list24 = numbersA.SelectMany(a => numbersB, (a, b) => new { a, b }).Where(arg => arg.a < arg.b).Select(arg => arg.a + " is less than " + arg.b);

            //foreach (var prod in list24)
            //{
            //    Console.WriteLine(prod);
            //}



            //Console.WriteLine("6.Select all orders where the order total is less than 500.00.");

            //var list24 = ListGenerators.CustomerList.Select(ele => ele.Orders.Where(order => order.Total < 500));

            //foreach (var item in list24)
            //{
            //    foreach (var order in item)
            //    {
            //        Console.WriteLine(order);
            //    }

            //}




            //Console.WriteLine("7.Select all orders where the order was made in 1998 or later.");
            //var list25 = ListGenerators.CustomerList.Select(ele => ele.Orders.Where(order => order.OrderDate.Year >= 1998));

            //foreach (var item in list25)
            //{
            //    foreach (var order in item)
            //    {
            //        Console.WriteLine(order);
            //    }
            //}
            #endregion

            #region Quantifiers

            //Console.WriteLine("1.Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.");

            //List<String> Words = new List<string>();

            //using (StreamReader file = new StreamReader("dictionary_english.txt"))
            //{

            //    string line;

            //    while ((line = file.ReadLine()) != null)
            //    {
            //        Words.Add(line);

            //    }
            //    file.Close();
            //}

            //var Contained = Words.Any(word => word.Contains("ei"));

            //Console.WriteLine(Contained);




            //Console.WriteLine("2.Return a grouped a list of products only for categories that have at least one product that is out of stock.");


            //var list26 = from prod in ListGenerators.ProductList
            //              group prod by prod.Category
            //              into cat
            //              where cat.Any(ele => ele.UnitsInStock == 0)
            //              select cat;

            //foreach (var item in list26)
            //{
            //    foreach (var unit in item)
            //        Console.WriteLine(unit);
            //}




            //Console.WriteLine("3.Return a grouped a list of products only for categories that have all of their products in stock..");


            //var list27 = from prod in ListGenerators.ProductList
            //              group prod by prod.Category
            //              into cat
            //              where cat.All(ele => ele.UnitsInStock != 0)
            //              select cat;

            //foreach (var item in list27)
            //{
            //    foreach (var unit in item)
            //        Console.WriteLine(unit);
            //}

            #endregion


            #region Grouping Operators

            //Console.WriteLine("1.Use group by to partition a list of numbers by their remainder when divided by 5");
            //int[] Numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            //var list28 = from num in Numbers
            //              group num by (num % 5)
            //              into grp
            //              select grp;

            //int i = 0;
            //foreach (var grp in list28)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {i++} when divided by 5 ");

            //    foreach (var num in grp)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}




            //Console.WriteLine("2.Uses group by to partition a list of words by their first letter.");
            //List<string> Words = new List<string>();
            //string word;

            //using (StreamReader file = new StreamReader("dictionary_english.txt"))
            //{
            //    while ((word = file.ReadLine()) != null)
            //    {
            //        Words.Add(word);
            //    }
            //    file.Close();
            //}

            //var list28 = from wrd in Words
            //              group wrd by wrd.ElementAt(0)
            //              into grp
            //              select grp;

            //char ch = 'A';
            //foreach (var grp in list28)
            //{
            //    Console.WriteLine($"Words with a letter of {ch++}: ");

            //    foreach (var w in grp)
            //    {
            //        Console.WriteLine(w);
            //    }
            //}




            //Console.WriteLine("3.Consider this Array as an Input ");
            //string[] Arr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };
            //var list30 = Arr.GroupBy(word => new string(word.Trim().OrderBy(c => c).ToArray()));

            //foreach (var grp in list30)
            //{
            //    foreach (var wrd in grp)
            //    {
            //        Console.WriteLine(wrd);
            //        Console.WriteLine(".........");
            //    }
            //}

            #endregion

        }
    }
}
