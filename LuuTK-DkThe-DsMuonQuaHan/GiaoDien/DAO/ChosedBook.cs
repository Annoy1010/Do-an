using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    class ChosedBook
    {
        private static ChosedBook instance;
        string bookId;
        string bookTitle;
        string bookType;
        string publisher;
        string author;
        string edition;
        string quantity;
        public static ChosedBook Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChosedBook();
                return ChosedBook.instance;
            }
            set
            {
                ChosedBook.Instance = value;
            }
        }
        public ChosedBook()
        {
            this.bookId = "";
            this.bookTitle = "";
            this.bookType = "";
            this.publisher = "";
            this.author = "";
            this.edition = "";
            this.quantity = "";
        }
        public string GetBookID()
        {
            return this.bookId;
        }

        public string GetBookTitle()
        {
            return this.bookTitle;
        }
        public string GetBookType()
        {
            return this.bookType;
        }
        public string GetPublisher()
        {
            return this.publisher;
        }
        public string GetAuthor()
        {
            return this.author;
        }
        public string GetEdition()
        {
            return this.edition;
        }
        public string GetQuantity()
        {
            return this.quantity;
        }
        public void SetData(string bookId, string bookTitle, string bookType, string publisher, string author, string edition, string quantity)
        {
            this.bookId = bookId;
            this.bookTitle = bookTitle;
            this.bookType = bookType;
            this.publisher = publisher;
            this.author = author;
            this.edition = edition;
            this.quantity = quantity;
        }
    }
}
