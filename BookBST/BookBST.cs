using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace BookBST
{
    public class BookBST
    {
        private BookBSTNode root;

        public Book Find(int isbn)
        {
            if (root == null) throw new Exception("BST is empty!");
            return Find(root, isbn);
        }

        private Book Find(BookBSTNode node, int isbn)
        {
            if (node == null) throw new Exception("ISBN #" + isbn + " was not found");
            if (node.isbn == isbn)
            {
                //  Exit condition
                return node.book;
            }
            //  There's a value != to isbn
            if (isbn < node.isbn)
            {
                return Find(node.left, isbn);
            }
            // Go right
            return Find(node.right, isbn);
        }

        public void Add(Book book)
        {
            if (root == null)
            {
                root = new BookBSTNode(book.Isbn, book);
            }
            else
            {
                Add(root, book.Isbn, book);
            }
        }

        private void Add(BookBSTNode node, int isbn, Book book)
        {
            if (node.isbn < isbn)
            {
                //  go right
                if (node.right == null)
                {
                    node.right = new BookBSTNode(isbn, book);
                }
                else
                {
                    Add(node.right, isbn, book);
                }
            }
            else if (node.isbn > isbn)
            {
                // go left
                if (node.left == null)
                {
                    node.left = new BookBSTNode(isbn, book);
                }
                else
                {
                    Add(node.left, isbn, book);
                }
            }
            else
            {
                //  Same ISBN, not allowed
                throw new Exception("Duplicate ISBNs are not allowed.");
            }
        }

        public Book Remove(int isbn)
        {
            Book book;
            root = Remove(root, isbn, out book);
            if (book != null) return book;
            throw new Exception("The ISBN was not found in the BST");
        }


        private BookBSTNode Remove(BookBSTNode root, int isbn, out Book returnBook)
        {
            //  Used to pass the book to an output parameter
            returnBook = null;

            if (root == null) return null;

            if (isbn < root.isbn)
            {
                root.left = Remove(root.left, isbn, out returnBook);
            }
            else if (isbn > root.isbn)
            {
                root.right = Remove(root.right, isbn, out returnBook);
            }
            else
            {
                //  found it, populate the output variable
                returnBook = root.book;

                //  Case 1: No Child
                if (root.IsLeaf())
                {
                    root = null;
                }
                //  Case 2: One child
                else if (root.left == null)
                {
                    root = root.right;
                }
                else if (root.right == null)
                {
                    root = root.left;
                }
                //  Case 3: Two children
                else
                {
                    Book removed;  //  unused output parameter
                    BookBSTNode maxBookBstNode = FindMax(root.left);
                    root.book = maxBookBstNode.book;
                    root.isbn = maxBookBstNode.isbn;
                    root.left = Remove(root.left, maxBookBstNode.isbn, out removed);
                }
            }
            return root;
        }

        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>();
            GetBookList(root, books);
            return books;
        }

        private void GetBookList(BookBSTNode current, List<Book> books)
        {
            if (current == null) return;
            GetBookList(current.left, books);
            books.Add(current.book);
            GetBookList(current.right, books);
        }

        private BookBSTNode FindMax(BookBSTNode node)
        {
            while (node.right != null) node = node.right;
            return node;
        }

        public void Print()
        {
            if (root == null) { return; }
            Print(root);
        }
        private void Print(BookBSTNode node)
        {
            if (node == null) return;
            Print(node.left);
            Console.WriteLine(node.book.Isbn);
            Print(node.right);
        }


        public void PrintSideways()
        {
            PrintSideways(root, 0);
        }

        private void PrintSideways(BookBSTNode root, int level)
        {
            if (root != null)
            {
                PrintSideways(root.right, level + 1);
                for (int i = 0; i < level; i++)
                {
                    Console.Write("    ");
                }
                Console.WriteLine(root.isbn);
                PrintSideways(root.left, level+1);
            }
        }

        private class BookBSTNode
        {
            public int isbn;
            public Book book;
            public BookBSTNode left;
            public BookBSTNode right;

            public BookBSTNode(int isbn, Book book)
            {
                this.isbn = isbn;
                this.book = book;
            }

            public bool IsLeaf()
            {
                return (left == null && right == null);
            }
        }
    }
}
