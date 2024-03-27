using Assignment.Interfaces;

namespace Assignment.Decorators
{
    public class UnderlineDecorator : TextDecorator
    {
        public UnderlineDecorator(ITextFormatter textFormatter) : base(textFormatter)
        {
        }
        public override void Format()
        {
            Console.WriteLine("This text is underlined.");
            base.Format();
        }
    }
}
