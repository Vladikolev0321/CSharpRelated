using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LibraryIterator
{
    public class Library :IEnumerable<Book>
    {
        private List<Book> books;

        public Library()
        {
        }

        public void Add(Book book)
        {
            this.books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new BookIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.books.GetEnumerator();
        }

        private class BookIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int index;

            public BookIterator(List<Book> books)
            {
                this.books = books;
            }
            
            public Book Current
            {
                get
                {
                    return this.books[this.index];
                }
            }

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                return ++this.index < this.books.Count;
            }

            public void Reset()
            {
                this.index = -1;
            }
        }
    }
}
