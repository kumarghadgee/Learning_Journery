package com.sunbeam;

public class assi1_2 {

    // Node definition
    static class Node {
        int data;
        Node next;

        Node(int data) {
            this.data = data;
            this.next = null;
        }
    }

    Node head;

    // ---------------- DISPLAY ----------------
    void display() {
        Node temp = head;
        while (temp != null) {
            System.out.print(temp.data + " -> ");
            temp = temp.next;
        }
        System.out.println("NULL");
    }

    // ---------------- INSERT AFTER ----------------
    void insertAfter(int target, int newData) {
        Node temp = head;

        while (temp != null) {
            if (temp.data == target) {
                Node newNode = new Node(newData);

                newNode.next = temp.next;
                temp.next = newNode;

                return;
            }
            temp = temp.next;
        }

        System.out.println("Target not found");
    }

    // ---------------- INSERT BEFORE ----------------
    void insertBefore(int target, int newData) {

        // Case 1: Empty list
        if (head == null) {
            System.out.println("List is empty");
            return;
        }

        // Case 2: Insert before head
        if (head.data == target) {
            Node newNode = new Node(newData);
            newNode.next = head;
            head = newNode;
            return;
        }

        Node prev = null;
        Node curr = head;

        while (curr != null && curr.data != target) {
            prev = curr;
            curr = curr.next;
        }

        if (curr == null) {
            System.out.println("Target not found");
            return;
        }

        Node newNode = new Node(newData);
        prev.next = newNode;
        newNode.next = curr;
    }

    // ---------------- MAIN ----------------
    public static void main(String[] args) {
        assi1_2 list = new assi1_2();

        // Creating list: 10 -> 20 -> 30
        list.head = new Node(10);
        list.head.next = new Node(20);
        list.head.next.next = new Node(30);

        System.out.print("Original List: ");
        list.display();

        // Insert after 20
        list.insertAfter(20, 25);
        System.out.print("After inserting 25 after 20: ");
        list.display();

        // Insert before 20
        list.insertBefore(20, 15);
        System.out.print("After inserting 15 before 20: ");
        list.display();
    }
}

