using Assignment.Interfaces;

namespace Assignment.Decorators
{
    public class BoldDecorator : TextDecorator
    {
        public BoldDecorator(ITextFormatter textFormatter) : base(textFormatter)
        {
        }

        public override void Format()
        {
            Console.WriteLine("This text is bold.");
            base.Format();
        }
    }
}
