namespace Task2
{
    public abstract class FilterDecorator : IImage
    {
        protected IImage _image;

        protected FilterDecorator(IImage image)
        {
            _image = image;
        }

        public virtual string GetDescription() => _image.GetDescription();
        public virtual string Process() => _image.Process();
    }
}