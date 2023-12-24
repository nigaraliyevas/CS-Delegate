using Delegates;
/*Console.WriteLine(Sum(IsEven,5,6,8,11,13));
bool IsEven(int num, int m)
{
    return num % 2 == 0;
}
bool IsOdd(int num)
{
    return num % 2 == 1;
}
int Sum(Check method,params int[] nums)
{
    int sum = 0;
    foreach (var item in nums)
    {
        if (method(item))
        {
            sum += item;
        }
    }
    return sum;
}*/
Print print = Info;
print += StrLength;
print("lorem");
//void Info(string str1,string str2)
//{
//    Console.WriteLine($"{str1} {str2}");
//}
void Info(string str1)
{
    Console.WriteLine(str1);
}
void StrLength(string str1)
{
    Console.WriteLine(str1.Length);
}