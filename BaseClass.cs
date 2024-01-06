namespace AreaAndCircumference
{
    class BaseClass
    {
        public double Area { get; set; }
        public double Circumference { get; set; }
        public double Value1 { get; set; }
        public double Value2 { get; set; }

        public void SetValues(string value1, string value2)
        {
            Console.WriteLine($"Please enter the {value1}");
            Value1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Please enter the {value2}");
            Value2 = Convert.ToDouble(Console.ReadLine());
        }
    }
}