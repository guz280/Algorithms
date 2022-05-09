using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	// https://www.geeksforgeeks.org/breadth-first-search-or-bfs-for-a-graph/

	// This class represents a directed
	// graph using adjacency list
	// representation
	public class BFSGraph
	{
		// number of vertices
		private int numberOfVertices;

		// Adjacency Lists
		LinkedList<int>[] adjacentLists;

		public BFSGraph(int v)
		{
			adjacentLists = new LinkedList<int>[v];
			for(int i = 0; i < adjacentLists.Length; i++)
			{
				adjacentLists[i] = new LinkedList<int>();
			}
			numberOfVertices = v;
		}


		// Function to add an edge into the graph
		public void AddEdge(int v, int w)
		{
			adjacentLists[v].AddLast(w);
		}



		// print BFS traversal from a given source
		public void BFS(int source)
		{
			// Mark all the vertices as not visited (by default set as false)
			bool[] visited = new bool[numberOfVertices];
			for(int i = 0; i < numberOfVertices; i++)
			{
				visited[i] = false;
			}

			// create a queue for BFS
			LinkedList<int> queue = new LinkedList<int>();

			// mark the current node as visited and enqueue it
			visited[source] = true;
			queue.AddLast(source);


			string result = "";

			while (queue.Any()) // Determines whether a sequence contains any elements 
			{
				// Dequeue a vertex from queue and save it
				source = queue.First(); // Gets the first node of the System.Collections.Generic.LinkedList`1
				result = result + source + " - ";

				queue.RemoveFirst(); // Removes the node at the start of the System.Collections.Generic.LinkedList`1.


				// Get all adjacent vertices of the dequeued vertex source.
				// if an adjacent has not been visited, then mark it visited and enqueue it
				LinkedList<int> list = adjacentLists[source];

				foreach (var val in list)
				{
					if (!visited[val])
					{
						visited[val] = true;
						queue.AddLast(val); // Adds a new node containing the specified value at the end of the System.Collections.Generic.LinkedList`1.
					}
				}
			}

			Console.WriteLine(result);

		}
	}
}
