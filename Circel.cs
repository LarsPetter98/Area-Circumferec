namespace AreaAndCircumference
{
    class Circel : BaseClass
    {
        public Circel()
        {
            SetValues("radius", "diameter");
            Area = 3.14 * Value1;
            Circumference = 3.14 * Value2;

            Console.Clear();
            Console.WriteLine($"Area is: {Area}");
            Console.WriteLine($"Circumference is: {Circumference}");
        }
    }
}