namespace AbstractFactory.Documents
{
    public class ModernLetter : AbstractLetter
    {
        public ModernLetter(string title, string style, string author)
        {
            Title = title;
            Style = style;
            Author = author;
        }

        public override string Title { get; set; }
        public override string Style { get; set; }
        public override string Author { get; set; }

        public override void Interact(AbstractResume abstractResume)
        {
            Console.WriteLine(Style + " interacts with " + abstractResume.Style);
        }

        public override string ToString()
        {
            return "Letter: Style: " + Style + ", Author: " + Author + ", Title: " + Title + ", Date: " + Date;
        }

    }
}
