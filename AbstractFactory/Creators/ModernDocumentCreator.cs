using AbstractFactory.Documents;

namespace AbstractFactory.Creators
{
    public class ModernDocumentCreator : DocumentCreator
    {

        public override AbstractLetter CreateLetter()
        {
            return new ModernLetter("Title", "Modern Letter", "Author_Modern_Letter");
        }

        public override AbstractResume CreateResume()
        {
            return new ModernResume("Modern Resume", "Author_Modern_Resume", "Company XYZ");
        }
    }
}
