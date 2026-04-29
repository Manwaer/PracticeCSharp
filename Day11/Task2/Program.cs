using Task2;

class Program
{
    static void Main()
    {
        IImage image = new BaseImage();
        
        image = new BlackWhiteFilterDecorator(image);
        image = new BlurFilterDecorator(image);
        image = new SharpenFilterDecorator(image);
        
        Console.WriteLine("Описание фото: " + image.GetDescription());
        Console.WriteLine("Этапы обработки: " + image.Process());
    }
}