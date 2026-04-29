namespace Task2
{
    public class BlackWhiteFilterDecorator : FilterDecorator
    {
        public BlackWhiteFilterDecorator(IImage image) : base(image) { }

        public override string GetDescription() => base.GetDescription() + " + черно-белый фильтр";
        public override string Process() => base.Process() + " -> [Применение B&W]";
    }

    public class BlurFilterDecorator : FilterDecorator
    {
        public BlurFilterDecorator(IImage image) : base(image) { }

        public override string GetDescription() => base.GetDescription() + " + размытие";
        public override string Process() => base.Process() + " -> [Применение Blur]";
    }

    public class SharpenFilterDecorator : FilterDecorator
    {
        public SharpenFilterDecorator(IImage image) : base(image) { }

        public override string GetDescription() => base.GetDescription() + " + резкость";
        public override string Process() => base.Process() + " -> [Применение Sharpen]";
    }
}