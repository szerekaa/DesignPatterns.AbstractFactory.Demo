namespace AbstractFactory.Creators
{
    public abstract class DocumentCreator
    {
        public abstract AbstractLetter CreateLetter();
        public abstract AbstractResume CreateResume();
    }
}
