using System;


namespace Bookcomposite
{
    public interface IBook
    {
        public void ShowInfo();
    }
    public class BookLeaf : IBook
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int YearPublished { get; set; }
        public BookLeaf(string title, string category, int yearPublished)
        {
            Title = title;
            Category = category;
            YearPublished = yearPublished;
        }

        public void ShowInfo(){
            Console.WriteLine($"Title: {Title} - Category: {Category} - Year: {YearPublished}");
        }
    }


    public class CollectionComposite : IBook
    {
        public List<IBook> books;
        public string Author {get; set;}
        public string Description {get; set;}

        public string CollectionTitle{get; set;}

        public CollectionComposite (string author, string description, string collectionTitle = ""){
            books = new List<IBook> ();
            Author = author;
            Description = description;
            CollectionTitle = collectionTitle;
        }

        public void ShowInfo()
        {
            Console.WriteLine(@$"
            Author: {Author} 
            {Description}");
            ShowCollectionInfo();
        }

        public void ShowCollectionInfo()
        {
            foreach(IBook book in books)
            {
                book.ShowInfo();
            }
        }

        public void AddBook(IBook book){
            books.Add(book);
        }

        
    }



}