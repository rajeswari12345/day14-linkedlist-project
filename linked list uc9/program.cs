// See https://aka.ms/new-console-template for more information
using System;
class linkedlist
{

    // Head of list
    Node head;

    // Linked list Node
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    // Given a key, deletes the first
    // occurrence of key in linked list
    void deleteNode(int key)
    {
        // Store head node
        Node temp = head, prev = null;

        // If head node itself holds
        // the key to be deleted
        if (temp != null &&
            temp.data == key)
        {
            // Changed head
            head = temp.next;
            return;
        }

        // Search for the key to be
        // deleted, keep track of the
        // previous node as we need
        // to change temp.next
        while (temp != null &&
               temp.data != key)
        {
            prev = temp;
            temp = temp.next;
        }

        // If key was not present
        // in linked list
        if (temp == null)
            return;

        // Unlink the node from linked list
        prev.next = temp.next;
    }

    // Inserts a new Node at
    // front of the list.
    public void Push(int new_data)
    {
        Node new_node = new Node(new_data);
        new_node.next = head;
        head = new_node;
    }

    // This function prints contents
    // of linked list starting from
    // the given node
    public void printList()
    {
        Node tnode = head;
        while (tnode != null)
        {
            Console.Write(tnode.data + " ");
            tnode = tnode.next;
        }
    }

    // Driver code
    public static void Main(String[] args)
    {
        LinkedList llist = new LinkedList();

        llist.Push(56);
        llist.Push(30);
        llist.Push(40);
        llist.Push(70);

        Console.WriteLine("\nCreated Linked list is:");
        llist.printList();

        // Delete node with data 1
        llist.deleteNode(1);

        Console.WriteLine("\nLinked List after Deletion of 40:");
        llist.printList();
    }
}