using System.Text.Json;
using System.Xml.Serialization;

namespace _01_Serialization
{
    public class Book
    {
        //create the class Book ( Id , Title , Author , Subject , Price , Tax ( Price * 0.15 ) , Tostring() 
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Subject { get; set; }

        public double Price { get; set; }

        public double Tax
        {
            get { return (Price * 0.15); }
        }

        public override string ToString()
        {
            return $"Book => Id : {Id}, Title : {Title},Author : {Author}, Subject : {Subject}, Price : {Price}";
        }
    }

    class Novel
    {
        //Name,Id,Category,Price Author
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name}, Category : {Category} , Author : {Author}, Price: {Price}";
        }
    }
    internal class Program
    {
        public static List<Book> list = new List<Book>()
            {
                new Book() { Id=1, Title="Atlas Shrugged", Author="Ayn Rand", Subject="Fiction", Price=657.55},
                new Book() { Id=2, Title="1984", Author="George Orwell", Subject="Dystopian Fiction", Price=399.99 },
                new Book() { Id=3, Title="To Kill a Mockingbird", Author="Harper Lee", Subject="Fiction", Price=349.50 },
                new Book() { Id=4, Title="The Great Gatsby", Author="F. Scott Fitzgerald", Subject="Classic Fiction", Price=299.00 },
                new Book() { Id=5, Title="Brave New World", Author="Aldous Huxley", Subject="Science Fiction", Price=375.75 },
                new Book() { Id=6, Title="The Catcher in the Rye", Author="J.D. Salinger", Subject="Fiction", Price=325.40 },
                new Book() { Id=7, Title="The Hobbit", Author="J.R.R. Tolkien", Subject="Fantasy", Price=450.00 },
                new Book() { Id=8, Title="Fahrenheit 451", Author="Ray Bradbury", Subject="Dystopian Fiction", Price=289.99 },
                new Book() { Id=9, Title="Pride and Prejudice", Author="Jane Austen", Subject="Classic Romance", Price=310.25 },
                new Book() { Id=10, Title="The Alchemist", Author="Paulo Coelho", Subject="Philosophical Fiction", Price=360.00 },
            };
        static void Main1(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));

            FileStream fs = new FileStream(@"E:\.net Prac\Day06\Day02_Soln\fileStream.xml",FileMode.Create,FileAccess.ReadWrite);

            serializer.Serialize(fs,list);
            Console.WriteLine("File Saved");

            fs.Seek(0, SeekOrigin.Begin);

            List<Book> books =(List<Book>)serializer.Deserialize(fs);

            fs.Close();

            foreach(var file in books)
                Console.WriteLine(file);
        }

        static void Main(string[] args)
        {
            using
                (FileStream fs = new FileStream(@"E:\.net Prac\Day06\Day02_Soln\fileStream1.json", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {

                JsonSerializer.Serialize(fs, list);
                Console.WriteLine("File Saved");

                fs.Seek(0, SeekOrigin.Begin);

                List<Book> books = (List<Book>)JsonSerializer.Deserialize(fs, typeof(List<Book>));

                fs.Close();
                foreach(var book in books)
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}