int first = Convert.ToInt16(Console.ReadLine());
if (first < 10)
{
    Console.WriteLine(first);
}

else if (first >= 10 && first <= 99)
{
int second = first / 10;
int third = first % 10;
Console.WriteLine($" {second} {third} {second + third}");
}
else if (first >= 100 && first <= 999)
{
int second = first / 100;
int third = first / 10;
int fourth = third % 10;
int fifth = first % 10;  
Console.WriteLine($" {second} {fourth} {fifth} {second + fourth + fifth}");
}
else if (first >= 1000 && first <=9999) 
{
int second = first / 1000;
int third = first / 100;
int fourth = first % 100;
int afterfourth = fourth / 10;
int fifth = first / 100;
int afterfifth = fifth % 10;
int sixth = first % 10; 
Console.WriteLine($" {second} {afterfifth} {afterfourth} {sixth} {second + afterfifth + afterfourth + sixth}");
} 
