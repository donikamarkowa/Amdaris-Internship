using Assignment.Interfaces;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITextFormatter textComponent = new TextComponent();

            ITextFormatter formattedText1 = new BoldDecorator(textComponent);
            Console.WriteLine("Information about style of the first text: ");
            formattedText1.Format();

            Console.WriteLine();

            ITextFormatter formattedText2 = new UnderlineDecorator(new ColorDecorator(textComponent, "green"));
            Console.WriteLine("Information about style of the second text: ");
            formattedText2.Format();

            Console.WriteLine();

            ITextFormatter formattedText3 = new ItalicDecorator(new BoldDecorator(new UnderlineDecorator(new ColorDecorator(textComponent, "purple"))));
            Console.WriteLine("Information about style of the second text: ");
            formattedText3.Format();

        }
    }
}
