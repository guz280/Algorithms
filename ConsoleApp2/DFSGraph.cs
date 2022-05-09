using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	// https://www.geeksforgeeks.org/depth-first-search-or-dfs-for-a-graph/

	// This class represents a directed graph
	// using adjacency list representation
	public class DFSGraph
	{
		// number of vertices
		private int numberOfVertices;

		// Array of lists for
		// Adjacency List Representation
		private List<int>[] adjacent;

		public DFSGraph(int v)
		{
			numberOfVertices = v;
			adjacent = new List<int>[v];
			for (int i = 0; i < v; i++)
			{
				adjacent[i] = new List<int>();
			}
		}

		public void AddEdge(int v, int w)
		{
			adjacent[v].Add(w); // Add w to v's List
		}


		// Function used by DFS
		public void DFSUtil(int v, bool[] visited)
		{
			// Mark the current node as visited
			// and print it
			visited[v] = true;
			Console.Write(v + " ");

			// Recur for all the vertices
			// adjacent to this vertex
			List<int> vList = adjacent[v];
			foreach(var n in vList)
			{
				if (!visited[n])
				{
					DFSUtil(n, visited);
				}
			}
		}

		// Function to do DFS traversal
		// It uses recursive DFSUtil()
		public void DFS(int v)
		{
			// Mark all the vertices as not visited
			// (set as false by default in c#)
			bool[] visited = new bool[numberOfVertices];

			// Call the recursive helper function
			// to print DFS traversal
			DFSUtil(v, visited);
		}

	}
}
