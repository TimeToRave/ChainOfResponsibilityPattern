namespace ChainOfResponsibilityPattern.Interfaces
{
    public interface IHandler
    {
        public IHandler NextHandler { get; set; }

        public object Handle(object request);
    }
}