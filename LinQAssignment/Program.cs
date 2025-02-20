using static LinQAssignment.ListGenerator;
namespace LinQAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region 1. Find all products that are out of stock.
            //var Products = ProductList.Where(P => P.UnitsInStock == 0);
            //foreach (var Product in Products)
            //    Console.WriteLine(Product);
            #endregion
            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var Products = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice>3);
            //foreach (var Product in Products)
            //    Console.WriteLine(Product);
            #endregion
            #region 3. Returns digits whose name is shorter than their value.
            //String[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //int[] Indices = Enumerable.Range(0, Arr?.Length??0).ToArray();
            //var Result = Arr?.Zip(Indices, (d, i) => new
            //{
            //    digit = d,
            //    index = i
            //}).Where(x => x.digit.Length < x.index)
            //.Select(x => x.index);

            //if (Result is not null)
            //{
            //    foreach (var num in Result)
            //        Console.Write($"{num} ");
            //}
            #endregion
            #endregion

            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock 
            //var Result =ProductList.FirstOrDefault(P=>P.UnitsInStock==0);
            //Console.WriteLine(Result);
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var Result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            //Console.WriteLine(Result);
            #endregion
            #region 3. Retrieve the second number greater than 5 Int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int? number = Arr.OrderBy(x => x)
            //                  .Where(x => x > 11) 
            //                  .Skip(1)
            //                  .FirstOrDefault();
            //Console.WriteLine(number);
            #endregion


            #endregion

            #region LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var oddNums=Arr.Where(x=>x%2!=0).Count();
            //Console.WriteLine(oddNums);

            #endregion
            #region 2. Return a list of customers and how many orders each has
            //var customerList = CustomerList.Select(c => new
            //{
            //    customerName = c.CustomerName,
            //    orderNum = c.Orders.Count()

            //}).ToList();
            //foreach (var c in customerList) { Console.WriteLine($"{c.customerName} has number of orders: {c.orderNum}"); }

            #endregion
            #region 3. Return a list of categories and how many products each has
            //var categoryList = from P in ProductList
            //                   group P by P.Category
            //                   into cat
            //                   select new
            //                   {
            //                       CatName = cat.Key,
            //                       productCount = cat.Count(),
            //                   };

            //foreach (var category in categoryList)
            //{
            //    Console.WriteLine($"{category}");
            //}
            #endregion
            #region 4.  Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            //int Total = Arr.Sum();
            //Console.WriteLine(Total);

            #endregion
            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");
            //int chars = dictionaryWords.Sum(w => w.Length);
            //Console.WriteLine($"{chars}");



            #endregion
            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");
            //int shortLen= dictionaryWords.Min(x => x.Length);
            //Console.WriteLine($"{shortLen}");
            #endregion
            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");
            //int LongLen = dictionaryWords.Max(x => x.Length);
            //Console.WriteLine($"{LongLen}");
            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");
            //int avgLen = (int)dictionaryWords.Average(x => x.Length);
            //Console.WriteLine($"{avgLen}");
            #endregion
            #endregion

            #region LINQ - Ordering Operators
            #region 1. Sort a list of products by name
            //var productSorted = ProductList.OrderBy(x => x.ProductName);
            //foreach (var product in productSorted)
            //{
            //    Console.WriteLine($"{product}");
            //}
            #endregion
            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortList = Arr.OrderBy(w => w.ToLower());
            //foreach (var word in sortList) 
            //    Console.WriteLine($"{word}");

            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var productList = ProductList.OrderByDescending(p=>p.UnitsInStock);
            ////foreach (var product in productList) Console.WriteLine($"{product}");
            //foreach (var product in productList) Console.WriteLine($" product: {product.ProductName},the UnitsInStock: {product.UnitsInStock}");
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var sorting= Arr.OrderBy(x => x.Length).ThenBy(x => x);
            //foreach(string str in sorting) 
            //    Console.WriteLine($"{str}");
            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sorting= Arr.OrderBy(x => x.Length).ThenBy(x => x.ToLower());
            //foreach (string str in sorting)
            //    Console.WriteLine($"{str}");
            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var sortProducts = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var product in sortProducts)
            //    Console.WriteLine($"category: {product.Category}, product: {product.ProductName},the price: {product.UnitPrice}");
            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sorting = Arr.OrderBy(x => x.Length).ThenByDescending(x => x.ToLower());
            //foreach (string str in sorting)
            //    Console.WriteLine($"{str}");
            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var filters= Arr.Where(w => w[1]=='i')
            //    .Reverse();
            //foreach(var filter in filters) 
            //    Console.WriteLine($"{filter}");
            #endregion
            #endregion

            #region LINQ – Transformation Operators
            #region 1. Return a sequence of just the names of a list of products.
            //var ProductName=ProductList.Select(x=>x.ProductName).ToList();
            //foreach (var Product in ProductName) Console.WriteLine($"product name :{Product}");
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var wordsList = words.Select(word=>new
            //{
            //    upperWord=word.ToUpper(),
            //    lowerWord=word.ToLower(),


            //});
            //foreach (var word in wordsList)
            //    Console.WriteLine($"upper version : {word.upperWord}, lower version: {word.lowerWord}");


            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var productProperties = ProductList.Select(p => new
            //{
            //    p.ProductID,
            //    p.ProductName,
            //    Price =p.UnitPrice

            //});
            //foreach (var product in productProperties) Console.WriteLine($"ptoduct name{product.ProductName} , product Price : {product.Price} , product Id : {product.ProductID}");


            #endregion

            #region 4. Determine if the value of int in an array matches their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var filterNums = Arr
            //.Select(
            //    (v, i) => new
            //    {
            //        Value = v,
            //        InPlace = v == i
            //    });
            //Console.WriteLine("Number: In-place?");
            //foreach (var n in filterNums)
            //{
            //    Console.WriteLine($"{n.Value} : {n.InPlace} ");
            //}
            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var finalOutput = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { a, b };
            //Console.WriteLine("pairs where a < b:");
            //foreach (var pair in finalOutput) Console.WriteLine($"{pair.a} is less than {pair.b}");

            #endregion

            #region 6. Select all orders where the order total is less than 500.00.
            //var filteredOrders = CustomerList
            // .SelectMany(c => c.Orders) 
            // .Where(O => O.Total < 500.00m);
            //foreach (var order in filteredOrders) Console.WriteLine(order);


            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.
            //var filteredOrders = CustomerList
            // .SelectMany(c => c.Orders)
            // .Where(O => O.OrderDate.Year >= 1998);
            //foreach (var order in filteredOrders) Console.WriteLine(order);
            #endregion

            #region 

            #endregion
            #endregion

            #region LINQ - Aggregate Operators
            #region 1. Get the total units in stock for each product category.
            //var total = ProductList.GroupBy(p => p.Category)
            //    .Select(c => new
            //    {
            //        category = c.Key,
            //        totalStock = c.Sum(p => p.UnitsInStock)
            //    });
            //foreach (var cat in total) 
            //    Console.WriteLine($"category : {cat.category} , the total units : {cat.totalStock}");

            #endregion

            #region 2. Get the cheapest price among each category's products
            //var cheapest = ProductList.GroupBy(p => p.Category)
            //    .Select(c => new
            //    {
            //        category = c.Key,
            //        cheapestPrice = c.Min(p => p.UnitPrice)
            //    });
            //foreach (var price in cheapest)
            //    Console.WriteLine($"category : {price.category} ,has cheapest product price  : {price.cheapestPrice}");

            #endregion

            #region 3. Get the products with the cheapest price in each category (Use Let)

            //var cheapestProduct = from p in ProductList
            //                      group p by p.Category into c
            //                      let min = c.Min(p => p.UnitPrice)
            //                      from product in c
            //                      where product.UnitPrice == min
            //                      select product;

            //foreach (var product in cheapestProduct)
            //    Console.WriteLine($"category: {product.Category},has product: {product.ProductName},its price: {product.UnitPrice}");
            #endregion

            #region 4. Get the most expensive price among each category's products.
            //var expensive = ProductList.GroupBy(p => p.Category)
            //    .Select(c => new
            //    {
            //        category = c.Key,
            //        highestPrice = c.Max(p => p.UnitPrice)
            //    });
            //foreach (var price in expensive)
            //    Console.WriteLine($"category : {price.category} ,has most expensive product price  : {price.highestPrice}");

            #endregion

            #region 5. Get the products with the most expensive price in each category.

            //var expensiveProduct = from p in ProductList
            //                      group p by p.Category into c
            //                      let max = c.Max(p => p.UnitPrice)
            //                      from product in c
            //                      where product.UnitPrice == max
            //                      select product;

            //foreach (var product in expensiveProduct)
            //    Console.WriteLine($"category: {product.Category},has most expensive product: {product.ProductName},its price: {product.UnitPrice}");
            #endregion

            #region 6. Get the average price of each category's products.
            //var average = ProductList.GroupBy(p => p.Category)
            //    .Select(c => new
            //    {
            //        category = c.Key,
            //        averagePrice = c.Average(p => p.UnitPrice)
            //    });
            //foreach (var price in average)
            //    Console.WriteLine($"category : {price.category} ,has average price  : {price.averagePrice}");
            #endregion

            #endregion

            #region LINQ - Set Operators
            #region 1. Find the unique Category names from Product List
            //var unique = ProductList
            //            .Select(p => p.Category)
            //            .Union(new List<string>());

            //foreach (var category in unique)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names
            //var uniqueLetters = ProductList
            //                        .Select(p => p.ProductName[0])
            //                        .Union(CustomerList
            //                        .Select(c => c.CustomerName[0]));

            //foreach (var letter in uniqueLetters)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var commonLetters = ProductList
            //                        .Select(p => p.ProductName[0])
            //                        .Intersect(CustomerList
            //                        .Select(c => c.CustomerName[0]));

            //foreach (var letter in commonLetters)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var exceptLetters = ProductList
            //                        .Select(p => p.ProductName[0])
            //                        .Except(CustomerList
            //                        .Select(c => c.CustomerName[0]));

            //foreach (var letter in exceptLetters)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            // var ThreeChars =ProductList
            //.Select(p => p.ProductName.Length >= 3 ? p.ProductName.Substring(p.ProductName.Length - 3) : p.ProductName)
            //.Concat(CustomerList
            //.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName.Substring(c.CustomerName.Length - 3) : c.CustomerName));
            // foreach (var chars in ThreeChars)
            // {
            //     Console.WriteLine(chars);
            // }
            #endregion


            #endregion

            #region LINQ - Partitioning Operators
            #region 1. Get the first 3 orders from customers in Washington
            // var first3Orders = CustomerList
            //.Where( c => c.Address.Contains("wa"))
            //.SelectMany(c => c.Orders)
            //.Take(3);
            // foreach (var order in first3Orders)
            // {
            //     Console.WriteLine($"order: {order}");
            // }
            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.

            //var Orders = CustomerList
            //    .Where(c => c.Address.Contains("wa"))
            //    .SelectMany(c => c.Orders)
            //    .Skip(2);
            //foreach (var order in Orders)
            //{
            //    Console.WriteLine($"order : {order}");
            //}
            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Nums = numbers.TakeWhile(
            //                   (num, index) => num >= index);

            //Console.WriteLine("numbers:");
            //foreach (var num in Nums)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion

            #region  4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(N => N% 3 != 0);
            //Console.WriteLine("numbers:");
            //foreach (var num in result)
            //    Console.WriteLine(num);


            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.SkipWhile((num, index) => num >= index);
            //Console.WriteLine("numbers:");
            //foreach (var num in Result)
            //    Console.WriteLine(num);


            #endregion


            #endregion

            #region LINQ - Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");
            //Console.WriteLine(dictionaryWords.Any(w => w.Contains("ei")));

            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var products = from p in ProductList
            //               group p by p.Category into c
            //               where c.Any(p => p.UnitsInStock == 0)
            //               select c;
            //foreach (var category in products)
            //{
            //    Console.WriteLine($"category: {category.Key}");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($" product name :{product.ProductName} (Stock: {product.UnitsInStock})");
            //    }
            //}



            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var products = from p in ProductList
            //               group p by p.Category into c
            //               where c.All(p => p.UnitsInStock > 0)
            //               select c;
            //foreach (var category in products)
            //{
            //    Console.WriteLine($"category: {category.Key}");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($" product name :{product.ProductName} (Stock: {product.UnitsInStock})");
            //    }
            //}
            #endregion




            #endregion

            #region LINQ – Grouping Operators
            #region 1.	Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var filteredNums = numbers.GroupBy(n => n % 5);

            //foreach (var group in filteredNums)
            //{
            //    Console.WriteLine($"numbers with a remainder of {group.Key} when divided by 5:");
            //    foreach (var number in group) Console.WriteLine(number);

            //}
            #endregion

            #region 2.Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input
            // string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");
            // var partition = dictionaryWords
            //.GroupBy(word => char.ToUpper(word[0]))
            //.OrderBy(group => group.Key);
            // foreach (var part in partition)
            // {
            //     Console.WriteLine($"Group: {part.Key}");

            //     foreach (var word in part)
            //         Console.WriteLine(word);
            //     Console.WriteLine("-----------------------------");
            // }
            #endregion

            #region 3.Consider this Array as an InputString[] Arr = { "from", "salt", "earn", " last", "near", "form" };Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            // String[] Arr = { "from", "salt", "earn", "last", "near", "form" };
            // var similarWords = Arr
            //.GroupBy(word => new string(word.OrderBy(c => c).ToArray()))
            //.OrderBy(w => Arr.ToList().IndexOf(w.First()));
            // foreach (var group in similarWords)
            // {
            //     foreach (var word in group) { Console.WriteLine(word); }
            //     Console.WriteLine("....");
            // }

            #endregion
            #endregion

        }
    }
}
