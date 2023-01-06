namespace Lab_4.Books.Fictions
{
    public class Travelling : Fiction
    {
        public string Countries { get; set; }

        public Travelling() { }

        public Travelling(Fiction f) : base(f) { }

        public Travelling(Travelling t) : base(t)
        {
            this.Countries = t.Countries;
        }
    }
}
