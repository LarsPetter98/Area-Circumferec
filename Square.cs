namespace AreaAndCircumference
{
    class Square : BaseClass
    {
        public Square()
        {
            SetValues("width", "height");
            Area = Value1 * Value2;
            Circumference = Value1 * 4;

            Console.Clear();
            Console.WriteLine($"Area is: {Area}");
            Console.WriteLine($"Circumference is: {Circumference}");
        }
    }
}