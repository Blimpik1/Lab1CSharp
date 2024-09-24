using System;

class Program

{
    static void Main(string[] args)
    {
        //Task 1
        Console.OutputEncoding = System.Text.Encoding.UTF8;

       
        double pounds;  
        double kilograms;  
        const double conversionFactor = 0.453592;  //коефіцієнт

       
        Console.Write("Вага в фунтах: ");
        pounds = Convert.ToDouble(Console.ReadLine());

       
        kilograms = pounds * conversionFactor;

    
        Console.WriteLine($"{pounds} фунтів = {kilograms} кілограмів");
        

        //Task 2
        double a = 2, h = 3;
        double S = (1.0 / 2) * a * h; 
        Console.WriteLine(S);
        
        //Task 3
        double x1 = 5.35;
        double x2 = 10.75;

        Console.WriteLine($"Змінна x1 дорівнює: {x1}");
        Console.WriteLine($"Змінна x2 дорівнює: {x2}");
        
        //Task 4
        double b, v, alpha, area;
        Console.WriteLine("Обчислення площі паралелограма");
        Console.WriteLine("Введіть вихідні дані: ");
        Console.Write("Сторона (см) -> ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Висота (см) -> ");
        v = Convert.ToDouble(Console.ReadLine());

        Console.Write("Градусна міра кута (градуси) -> ");
        alpha = Convert.ToDouble(Console.ReadLine());

        double alphaRadians = alpha * (Math.PI / 180);  
        area = b * v * Math.Sin(alphaRadians);

       Console.WriteLine($"Площа паралелограма: {area} кв.см.");
    }
}
