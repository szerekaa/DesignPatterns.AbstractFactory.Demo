namespace AbstractFactory.Documents
{
    public class FancyResume : AbstractResume
    {
        public FancyResume(string style, string author, string company)
        {
            Style = style;
            Author = author;
            Company = company;
        }

        public override string Style { get; set; }
        public override string Author { get; set; }
        public override string Company { get; set; }

        public override string ToString()
        {
            return "Resume: Style: " + Style + ", Author: " + Author + ", Company: " + Company + ", Date: " + Date;
        }

        public override void Interact(AbstractLetter abstractLetter)
        {
            Console.WriteLine(Style + " interacts with " + abstractLetter.Style);
        }
    }
}
