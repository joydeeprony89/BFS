using System;
using System.Collections.Generic;
using System.Linq;

namespace BFS
{
    class Graph 
    {
        int V;
        Graph(int v)
        {
            V = v;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<int>> keyValuePairs = new Dictionary<int, List<int>>();
            keyValuePairs.Add(1, new List<int>() { 4, 2 });
            keyValuePairs.Add(4, new List<int>() { 3, 1 });
            keyValuePairs.Add(2, new List<int>() { 3, 1, 5, 7,8 });
            keyValuePairs.Add(3, new List<int>() { 2, 4, 9, 10 });
            keyValuePairs.Add(5, new List<int>() { 2, 6, 8 , 7 });
            keyValuePairs.Add(8, new List<int>() { 2, 5, 7 });
            keyValuePairs.Add(7, new List<int>() { 2, 5, 8 });
            keyValuePairs.Add(6, new List<int>() { 5 });
            keyValuePairs.Add(9, new List<int>() { 3 });
            keyValuePairs.Add(10, new List<int>() { 3 });
            Program program = new Program();
            program.BFS(keyValuePairs);
            Console.WriteLine("Hello World!");
        }

        public void BFS(Dictionary<int, List<int>> keyValuePairs)
        {
            Queue<int> q = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();
            int node = keyValuePairs.ElementAt(0).Key;
            q.Enqueue(node);
            visited.Add(node);
            while (q.Count > 0)
            {
                int element = q.Dequeue();
                Console.WriteLine(element);
                List<int> children;
                keyValuePairs.TryGetValue(element, out children);
                foreach (int child in children)
                {
                    if (!visited.Contains(child))
                    {
                        q.Enqueue(child);
                        visited.Add(child);
                    }
                }
            }

        }
    }
}
