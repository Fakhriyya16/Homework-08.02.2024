//Hometask 08.02.2024

//1) n - ededinin faktorialini hesablayin.

//int n = 5;
//int factorial = 1;

//for (int i = 1; i <= n; i++)
//{
//    factorial *= i;
//}
//Console.WriteLine(factorial);

//2) Verilmis arrayin icerisinde cut ededlerin ceminin kvadratini hesablayin.

//int[] nums = { 1, 4, 5, 7, 2, 12 };
//int sum = 0;
//int square;

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] % 2 == 0)
//    {
//        sum += nums[i];
//    }
//}
//square = sum * sum;
//Console.WriteLine(square);

//3) n ededi gelir. n - ededinin 2-ni hansisa quvvete yukseltdikde alinan edede beraber
//olub-olmadigini tapin. Meselen : n ededi 4,8,16 ve s. gelirse yazilsin ki, 2-nin quvettidir.
//Eks halda quvveti deil yazilsin.

//int n = 32;
//bool quvvettidir = false;

//for (int i = 2; i <= n; i=i*2)
//{
//    if(n % i == 0)
//    {
//        quvvettidir = true;
//    }
//    else
//    {
//        quvvettidir = false;
//    }
//}
//if (quvvettidir)
//{
//    Console.WriteLine("quvvettidir");
//}
//else
//{
//    Console.WriteLine("quvveti deil");
//}

//4)Sinifde yazdiqlarimin praktikasi.

//int[] arr = { 1, 2, 4, 6, 3, 8, 9 };

//for(int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 3)
//    {
//        Console.WriteLine("Found -" + arr[i]);
//        break;
//    }
//}

//int[] arr = { 1, 2, 4, 6, 2, 8, 9 };

//int count = 0;


//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 2)
//    {
//        count++;
//        if(count == 2)
//        {
//            Console.WriteLine("Found min 2 times - " + arr[i]);
//            break;
//        }
//    }
//}

//int n = 19;

//int count = 0;

//if (n < 2)
//{
//    Console.WriteLine("ne sade, ne murekkeb");
//}
//else
//{
//    for(int i = 1; i <=n; i++)
//    {
//        if(n%i == 0)
//        {
//            count++;
//            if(count == 3)
//            {
//                break;
//            }
//        }
//    }

//    if (count == 2)
//    {
//        Console.WriteLine("sade");
//    }
//    else
//    {
//        Console.WriteLine("murekkeb");
//    }
//}


//int a = 10;

//int b = a;

//b = 100;

//Console.WriteLine(a);
//Console.WriteLine(b);


//int[] arr1 = { 1, 2, 3, 4 };

//int[] arr2 = arr1;

//arr2[0] = 200;

//Console.WriteLine(arr2[0]);
//Console.WriteLine(arr1[0]);


//int[] arr1 = { 1, 2, 3, 4 };

//arr1[0] = 100;

//int[] arr2 = arr1;

//arr2[0] = 200;

//arr2[0] = arr1[0] + arr2[0];

//arr2[0] = 3;

//Console.WriteLine(arr2[0]);
//Console.WriteLine(arr1[0]);

//string name1 = "test";

//string name2 = name1;

//name2 = "salam";

//Console.WriteLine(name1);
//Console.WriteLine(name2);

//int[] arr = { 1, 2, 3, 4, 5, 6 };

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 2)
//    {
//        continue;
//    }
//    if (arr[i] == 4)
//    {
//        break; 
//    }

//    Console.WriteLine(arr[i]);
//}

//int a = 5;
//int b = a + 10;

//Console.WriteLine(a);
//Console.WriteLine(b);


//int a = 15;
//int b = --a;
//int c = ++b;

//Console.WriteLine(a);
//Console.WriteLine(b);   
//Console.WriteLine(c);