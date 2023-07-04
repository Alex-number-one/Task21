int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());
int third = first;
if (second == 1)
{
    first *= second;
    Console.WriteLine(first);
}
for (int i = 1; i < second; i++)
{


    first *= third;
    Console.WriteLine(first);
}