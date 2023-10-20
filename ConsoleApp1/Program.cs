#region task1
//int[] numbers = { 4, 15, 16, 23, 22 };

//for (int i = numbers.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(numbers[i]);
//}
#endregion
#region task2
//string name = Console.ReadLine();
//string[] names = { "Nadir", "Saiq", "Islam", "Nesib" };
//foreach (var item in names)
//{
//	if (name == item)
//	{
//        Console.WriteLine("ad tapildi");
//        break;
//    }
//	else
//	{
//        Console.WriteLine("tapilmadi");
//        break;
//    }
//}
#endregion
#region task3
//string name = Console.ReadLine();
//char herf = 'a';
//char herf2 = 'i';
//int count1 = 0;
//int count2 = 0;
//for (int i = 0; i < name.Length; i++)
//{
//    if (name[i] == herf)
//    {
//        count1++;
//    }
//    else if (name[i] == herf2)
//    {
//        count2++;
//    }
//}
//Console.Write("a herflerinin sayi:");
//Console.WriteLine(count1);
//Console.Write("i herflerinin sayi:");
//Console.WriteLine(count2);
#endregion

#region task4
//string[] name1 = { "Nadir" };
//string[] name2 = { "Nadir" };
//if (name1[0] == name2[0])
//{
//    Console.WriteLine("Beraberdir");
//}
//else
//{
//    Console.WriteLine("beraber deyil");
//}
#endregion
#region task5

int start1= 0;
int start2 = 1;
Console.WriteLine(start1);
while (start2>0)
{
    int count = start1 + start2;
    
    Console.WriteLine(count);
    int temp = start2;
    start2 = count;
    start1= temp;

    }


#endregion