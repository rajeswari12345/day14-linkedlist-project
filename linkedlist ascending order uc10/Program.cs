// See https://aka.ms/new-console-template for more information
using System;
internal class Node
{
	internal int data;
	internal Node next;

	internal Node(int data, Node next)
	{
		this.data = data;
		this.next = next;
	}

	internal Node()
	{
	}
}

internal class Main
{
	// Helper function to print a given linked list
	public static void printList(Node head)
	{
		Node ptr = head;
		while (ptr != null)
		{
			Console.Write(ptr.data + " —> ");
			ptr = ptr.next;
		}

		Console.WriteLine("null");
	}

	// Insert a given node at its correct sorted position into a given
	// list sorted in increasing order
	public static Node sortedInsert(Node head, Node newNode)
	{
		Node dummy = new Node();
		Node current = dummy;
		dummy.next = head;

		while (current.next != null && current.next.data < newNode.data)
		{
			current = current.next;
		}

		newNode.next = current.next;
		current.next = newNode;
		return dummy.next;
	}

	// Given a list, change it to be in sorted order (using `sortedInsert()`)
	public static Node insertSort(Node head)
	{
		Node result = null; // build the answer here
		Node current = head; // iterate over the original list
		Node next;

		while (current != null)
		{
			// tricky: note the next reference before we change it
			next = current.next;

			result = sortedInsert(result, current);
			current = next;
		}

		return result;
	}

	public static void Main(string[] args)
	{
		// input keys
		int[] keys = new int[] { 56,30,40,70};

		// points to the head node of the linked list
		Node head = null;

		// construct a linked list
		for (int i = keys.Length - 1; i >= 0; i--)
		{
			head = new Node(keys[i], head);
		}

		head = insertSort(head);

		// print linked list
		printList(head);
	}
}
