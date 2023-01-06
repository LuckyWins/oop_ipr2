namespace Lab_4.Books
{
    public class Historical : Book
    {
        public string Period { get; set; }

        public Historical() { }

        public Historical(Book b) : base(b) { }

        public Historical(Historical h) : base(h)
        {
            this.Period = h.Period;
        }
    }
}
