using Assignment.Interfaces;

namespace Assignment.Decorators
{
    public abstract class TextDecorator : ITextFormatter
    {
        protected ITextFormatter _textFormatter;
        public TextDecorator(ITextFormatter textFormatter)
        {
            _textFormatter = textFormatter;
        }
        public virtual void Format()
        {
            _textFormatter.Format();
        }
    }
}
