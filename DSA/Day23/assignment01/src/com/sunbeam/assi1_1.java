package com.sunbeam;

import java.util.*;

public class assi1_1 {

    // ---------------- 1. NUMBER ----------------

    // Reverse Method
    static boolean isPalindromeNumberReverse(int n) {
        int original = n, rev = 0;
        while (n > 0) {
            rev = rev * 10 + n % 10;
            n /= 10;
        }
        return original == rev;
    }

    // Without Reverse
    static boolean isPalindromeNumberNoReverse(int n) {
        int div = 1;
        while (n / div >= 10) div *= 10;

        while (n > 0) {
            int left = n / div;
            int right = n % 10;
            if (left != right) return false;

            n = (n % div) / 10;
            div /= 100;
        }
        return true;
    }

    // ---------------- 2. STRING ----------------

    // Two Pointer
    static boolean isPalindromeStringTwoPointer(String s) {
        int i = 0, j = s.length() - 1;
        while (i < j) {
            if (s.charAt(i) != s.charAt(j)) return false;
            i++; j--;
        }
        return true;
    }

    // Reverse String
    static boolean isPalindromeStringReverse(String s) {
        String rev = new StringBuilder(s).reverse().toString();
        return s.equals(rev);
    }

    // ---------------- 3. ARRAY ----------------

    static boolean isPalindromeArray(int[] arr) {
        int i = 0, j = arr.length - 1;
        while (i < j) {
            if (arr[i] != arr[j]) return false;
            i++; j--;
        }
        return true;
    }

    // ---------------- 4. LINKED LIST ----------------

    static class ListNode {
        int val;
        ListNode next;
        ListNode(int x) { val = x; }
    }

    // Reverse Half (Optimal)
    static boolean isPalindromeLinkedList(ListNode head) {
        if (head == null || head.next == null) return true;

        ListNode slow = head, fast = head;

        // Find middle
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        // Reverse second half
        ListNode prev = null;
        while (slow != null) {
            ListNode next = slow.next;
            slow.next = prev;
            prev = slow;
            slow = next;
        }

        // Compare halves
        ListNode first = head, second = prev;
        while (second != null) {
            if (first.val != second.val) return false;
            first = first.next;
            second = second.next;
        }
        return true;
    }

    // Using Stack
    static boolean isPalindromeLinkedListStack(ListNode head) {
        Stack<Integer> stack = new Stack<>();
        ListNode temp = head;

        while (temp != null) {
            stack.push(temp.val);
            temp = temp.next;
        }

        temp = head;
        while (temp != null) {
            if (temp.val != stack.pop()) return false;
            temp = temp.next;
        }
        return true;
    }

    // ---------------- 5. TREE ----------------

    static class TreeNode {
        int val;
        TreeNode left, right;
        TreeNode(int x) { val = x; }
    }

    // Recursive (Mirror)
    static boolean isSymmetric(TreeNode root) {
        return isMirror(root.left, root.right);
    }

    static boolean isMirror(TreeNode t1, TreeNode t2) {
        if (t1 == null && t2 == null) return true;
        if (t1 == null || t2 == null) return false;

        return (t1.val == t2.val)
                && isMirror(t1.left, t2.right)
                && isMirror(t1.right, t2.left);
    }

    // Iterative (Queue)
    static boolean isSymmetricIterative(TreeNode root) {
        Queue<TreeNode> q = new LinkedList<>();
        q.add(root.left);
        q.add(root.right);

        while (!q.isEmpty()) {
            TreeNode t1 = q.poll();
            TreeNode t2 = q.poll();

            if (t1 == null && t2 == null) continue;
            if (t1 == null || t2 == null) return false;
            if (t1.val != t2.val) return false;

            q.add(t1.left);
            q.add(t2.right);
            q.add(t1.right);
            q.add(t2.left);
        }
        return true;
    }

    // ---------------- MAIN METHOD ----------------

    public static void main(String[] args) {

        // Number
        System.out.println("Number: " + isPalindromeNumberReverse(121));
        System.out.println("Number (No Reverse): " + isPalindromeNumberNoReverse(121));

        // String
        System.out.println("String: " + isPalindromeStringTwoPointer("madam"));
        System.out.println("String (Reverse): " + isPalindromeStringReverse("madam"));

        // Array
        int[] arr = {1, 2, 3, 2, 1};
        System.out.println("Array: " + isPalindromeArray(arr));

        // Linked List
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(2);
        head.next.next.next = new ListNode(1);

        System.out.println("LinkedList: " + isPalindromeLinkedList(head));
        System.out.println("LinkedList (Stack): " + isPalindromeLinkedListStack(head));

        // Tree
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(2);
        root.left.left = new TreeNode(3);
        root.left.right = new TreeNode(4);
        root.right.left = new TreeNode(4);
        root.right.right = new TreeNode(3);

        System.out.println("Tree: " + isSymmetric(root));
        System.out.println("Tree (Iterative): " + isSymmetricIterative(root));
    }
}

