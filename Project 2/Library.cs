using System.Collections;

namespace Project2{

    class Library{
        public static void Run(){
            Hashtable Books = new Hashtable{
                { "Sefiller", "Victor Hugo" },
                { "Suç ve Ceza", "Fyodor Dostoyevski" },
                { "Beyaz Geceler", "Fyodor Dostoyevski" },
                { "Notre Dame'ın Kamburu", "Victor Hugo" }
            };

            AddBook(Books, "C# learing", "Hikmet");
            UpdateAuthor(Books,"C# learing","Ali");
            BooksOfAuthor(Books,"Victor Hugo");

        }
        static void AddBook(Hashtable books, string bookName, string author ){
            if(!books.ContainsKey(bookName)){
                books.Add(bookName,author);
                Console.WriteLine($"{bookName}-{author} eklendi.");
            }
        }

        static void UpdateAuthor(Hashtable books,string bookName, string newAuthor){
            if(books.ContainsKey(bookName)){
                books[bookName] = newAuthor;
                Console.WriteLine($"{bookName} changed to {newAuthor}");
            }else{
                Console.WriteLine("Kitap bulunmadi.");
            }
        }
        static void BooksOfAuthor(Hashtable books, string author){
            Console.WriteLine($"List of books for {author}");
            foreach(DictionaryEntry book in books){
                if ((string?)book.Value == author){
                    Console.WriteLine($"\t- {book.Key}");
                }
            }
        }

    }

}