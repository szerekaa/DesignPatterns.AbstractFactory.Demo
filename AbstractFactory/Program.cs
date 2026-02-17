using AbstractFactory.Creators;

DocumentCreator fancyCreator = new FancyDocumentCreator();
DocumentCreator modernCreator = new ModernDocumentCreator();

AbstractLetter fancyLetter = fancyCreator.CreateLetter();
AbstractLetter modernLetter = modernCreator.CreateLetter();
AbstractResume fancyResume = fancyCreator.CreateResume();
AbstractResume modernResume = modernCreator.CreateResume();

Console.WriteLine(fancyLetter.ToString());
Console.WriteLine(modernLetter.ToString());
Console.WriteLine(fancyResume.ToString());
Console.WriteLine(modernResume.ToString());

fancyResume.Interact(fancyLetter);
modernResume.Interact(modernLetter);
fancyResume.Interact(modernLetter);
modernResume.Interact(fancyLetter);