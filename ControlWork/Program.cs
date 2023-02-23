string[] GetList()
{
Console.Write("Введите количесвто элементок массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] arr = new string[m];
for (int i = 0; i < arr.Length; i++)
    arr[i] = Convert.ToString(Console.ReadLine());  
return arr;    
}

void MoreThreeSymb(string[] lst)
{
Console.Write("[");    
for (int i = 0; i < lst.Length; i++)
    {
    if (lst[i].Length <= 3) 
        {
        if (i < lst.Length - 1)
        Console.Write($"\"{lst[i]}\", "); 
        else
        Console.Write($"\"{lst[i]}\"] ");
        }
    } 
}

MoreThreeSymb(GetList());