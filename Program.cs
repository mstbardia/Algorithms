// See https://aka.ms/new-console-template for more information

using Algorithms;
using Algorithms.Examples;

var input = new int[] { 11, 520, 90, 91, 23, 21, 19, 20, 65, 32, 32, 0, 444, 62, 71, 101, 6, 8, 2, 4, 10, 3, 1 };


Console.WriteLine(input.ToJson());


//var result = Sort.OrderByAscending_BubbleSort(input);
//var result = Sort.OrderByAscending_SelectionSort(input);
var result = Sort.OrderByAscending_Insertion(input);


Console.WriteLine(result.ToJson());