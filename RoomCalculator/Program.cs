//GC Bootcamp Room Calculator

Console.WriteLine("Welcome to my room dimensions calculator!");

//gets dimensions from user

Console.WriteLine("Please enter the length of the room: ");
decimal length = Decimal.Parse(Console.ReadLine());

Console.WriteLine("Please enter the width of the room: ");
decimal width = Decimal.Parse(Console.ReadLine());

Console.WriteLine("Please enter the height of the room: ");
decimal height = Decimal.Parse(Console.ReadLine());

decimal area = length * width;

//prints calculations

Console.WriteLine("The area of the room is {0} sq units", area);

Console.WriteLine("The perimeter of the room is {0} units", (length * 2) + (width * 2));

Console.WriteLine("The volume of the room is {0} cubic units", length * width * height);

decimal surfaceArea = (length * width * 2) + (length * height * 2) +
    (height * width * 2);

Console.WriteLine("The surface area of the room is {0}", (length * width * 2) + 
    (length * height * 2) + (height * width * 2));

//determines whether a room is small, medium, or large

if(area >= 650)
{
    Console.WriteLine("This is a large room!");
}
else if (area > 250)
{
    Console.WriteLine("This is a medium room!");
}
else
{
    Console.WriteLine("This is a small room!");
}