public abstract class AbstractLetter
{
    public abstract string Title { get; set; }
    public abstract string Style { get; set; }
    public abstract string Author { get; set; }

    public DateOnly Date => DateOnly.FromDateTime(DateTime.Now);

    public abstract void Interact(AbstractResume abstractResume);
}