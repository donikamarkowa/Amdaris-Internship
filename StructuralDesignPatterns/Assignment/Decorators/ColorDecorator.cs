using Assignment.Interfaces;

namespace Assignment.Decorators
{
    public class ColorDecorator : TextDecorator
    {
        private string _color;
        public ColorDecorator(ITextFormatter textFormatter, string color) : base(textFormatter)
        {
            _color = color;
        }
        public override void Format()
        {
            Console.WriteLine($"This text is a {_color} text.");
            base.Format();
        }
    }
}
