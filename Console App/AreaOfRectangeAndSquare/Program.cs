
while (true)
{
    string choice;
    Console.WriteLine("1. Rectangle\n2. Square\n3. Circle");
    Console.Write("Enter Your choice : ");
    choice = Console.ReadLine();
    if (choice == null)
    {
        break;
    }
    else if (choice == "1")
    {
        Console.Write("Enter the Width of rectangle : ");
        int width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Height of retangle : ");
        int height = Convert.ToInt32(Console.ReadLine());

        int area = width * height;
        Console.WriteLine("Area of the rectangle is : "+area);
    }
    else if (choice == "2")
    {
        Console.Write("Enter the length of the square : ");
        int length = Convert.ToInt32(Console.ReadLine());
        int area = length * length;
        Console.WriteLine("Area of square is : " + area);
    }
    else if (choice == "3")
    {
        Console.Write("Enter the radius of circle : ");
        int radius = Convert.ToInt32(Console.ReadLine());
        double area = Math.PI * radius * radius;
        Console.WriteLine("Area of the circle is : " + area);
    }

}
