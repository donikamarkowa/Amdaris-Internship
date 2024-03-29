using Assignment.Interfaces;

namespace Assignment.Decorators
{
    public class ItalicDecorator : TextDecorator
    {
        public ItalicDecorator(ITextFormatter textFormatter) : base(textFormatter)
        {
        }
        public override void Format()
        {
            Console.WriteLine("This text is italic.");
            base.Format();
        }
    }
}
