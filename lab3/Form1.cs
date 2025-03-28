namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Base class: Book
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        // Derived class: Magazine
        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }

        // Derived class: Ebook
        public class Ebook : Book
        {
            public string FileFormat { get; set; }
            public override string GetInfo()
            {
                return $"{Title} (Ebook in {FileFormat} format)";
            }
        }

        // ? Task 3.1: New Class - Textbook
        public class Textbook : Book
        {
            public string Subject { get; set; }
            public override string GetInfo()
            {
                return $"{Title} (Textbook on {Subject}) by {Author}";
            }
        }

        // ? Task 3.2: New Class - AudioBook
        public class AudioBook : Book
        {
            public string Narrator { get; set; }
            public double Duration { get; set; } // Duration in hours
            public override string GetInfo()
            {
                return $"{Title} (Audiobook, Narrated by {Narrator}, {Duration} hours)";
            }
        }

        // ? Polymorphic function to display book information
        public void DisplayBooksInfo(Book[] books)
        {
            listBoxBooks.Items.Clear(); // Clear previous entries
            foreach (var book in books)
            {
                listBoxBooks.Items.Add(book.GetInfo()); // Calls overridden GetInfo()
            }
        }

        // ? Testing the Application with new classes
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book[] books =
            {
                new Book { Title = "C# Fundamentals", Author = "John Doe" },
                new Magazine { Title = "Tech Weekly", Author = "Jane Smith", IssueNumber = 45 },
                new Ebook { Title = "Mastering C#", Author = "Alice Brown", FileFormat = "PDF" },
                new Textbook { Title = "Physics for Beginners", Author = "Dr. Richard", Subject = "Physics" },
                new AudioBook { Title = "Learn C# in 10 Hours", Author = "Mike Ross", Narrator = "James Dean", Duration = 10.5 }
            };

            DisplayBooksInfo(books);
        }
    }
}
