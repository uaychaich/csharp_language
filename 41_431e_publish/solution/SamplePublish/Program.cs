/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-27
*/

using System.Threading.Tasks;

int[] data = new int[]{10,20,30,40,50,60};
ParallelLoopResult result = Parallel.ForEach(data,(item)=>{Console.WriteLine(item);});