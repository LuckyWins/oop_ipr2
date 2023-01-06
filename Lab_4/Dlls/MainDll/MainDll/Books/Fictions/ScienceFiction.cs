namespace Lab_4.Books.Fictions
{
    public class ScienceFiction : FantasticTales
    {
        public bool IsEarth { get; set; }

        public ScienceFiction() { }

        public ScienceFiction(FantasticTales f) : base(f) { }

        public ScienceFiction(ScienceFiction s) : base(s)
        {
            this.IsEarth = s.IsEarth;
        }
    }
}
