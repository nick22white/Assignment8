using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineBookstore.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        //Adds item to cart
        public virtual void AddItem(Book book, int qty)
        {
            CartLine line = Lines
                .Where(p => p.Book.BookId == book.BookId)
                .FirstOrDefault();

            if(line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }


        //Removes from cart
        public virtual void RemoveLine(Book book) =>
            Lines.RemoveAll(x => x.Book.BookId == book.BookId);

        //clears from cart
        public virtual void Clear() => Lines.Clear();

        //computes total
        public double ComputeTotalSum() =>
            Lines.Sum(e => e.Book.Price * e.Quantity);


        //container that holds a few pieces of information
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
