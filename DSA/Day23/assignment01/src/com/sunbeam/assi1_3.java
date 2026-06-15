package com.sunbeam;

public class assi1_3 {

    static class Node {
        int data;
        Node next;

        Node(int data) {
            this.data = data;
            this.next = null;
        }
    }

    Node head;

    // -------- INSERT IN SORTED ORDER --------
    void insertSorted(int newData) {
        Node newNode = new Node(newData);

        // Case 1: Empty list OR insert at beginning
        if (head == null || newData <= head.data) {
            newNode.next = head;
            head = newNode;
            return;
        }

        Node temp = head;

        // Traverse to find correct position
        while (temp.next != null && temp.next.data < newData) {
            temp = temp.next;
        }

        // Insert in between or end
        newNode.next = temp.next;
        temp.next = newNode;
    }

    // -------- DISPLAY --------
    void display() {
        Node temp = head;
        while (temp != null) {
            System.out.print(temp.data + " -> ");
            temp = temp.next;
        }
        System.out.println("NULL");
    }

    // -------- MAIN --------
    public static void main(String[] args) {
        assi1_3 list = new assi1_3();

        list.insertSorted(30);
        list.insertSorted(10);
        list.insertSorted(20);
        list.insertSorted(25);
        list.insertSorted(5);

        list.display();  // Output: 5 -> 10 -> 20 -> 25 -> 30 -> NULL
    }
}

