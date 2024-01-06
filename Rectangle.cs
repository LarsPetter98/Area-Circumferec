namespace AreaAndCircumference
{
    class Rectangle : BaseClass
    {
        public Rectangle()
        {
            SetValues("width", "height");
            Area = Value1 * Value2;
            Circumference = (Value1 * 2) + (Value2 * 2);

            Console.Clear();
            Console.WriteLine($"Area is: {Area}");
            Console.WriteLine($"Circumference is: {Circumference}");
        }
    }
}