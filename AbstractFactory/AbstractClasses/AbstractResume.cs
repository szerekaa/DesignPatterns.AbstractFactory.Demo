public abstract class AbstractResume
{
    public abstract string Style { get; set; }
    public abstract string Author { get; set; }
    public abstract string Company { get; set; }

    public DateOnly Date => DateOnly.FromDateTime(DateTime.Now);
    public abstract void Interact(AbstractLetter abstractLetter);
}