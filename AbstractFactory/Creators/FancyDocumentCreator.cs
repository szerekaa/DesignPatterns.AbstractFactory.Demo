using AbstractFactory.Documents;

namespace AbstractFactory.Creators
{
    public class FancyDocumentCreator : DocumentCreator
    {
        public override AbstractLetter CreateLetter()
        {
            return new FancyLetter("Title", "Fancy Letter", "Author_Fancy_Letter");
        }

        public override AbstractResume CreateResume()
        {
            return new FancyResume("Fancy Resume", "Author_Fancy_Resume", "Company XYZ");
        }
    }
}
