int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
     return result;
}
int a1 = 105;
int b1 = 201;
int c1 = 309;
int a2 = 102;
int b2 = 203;
int c2 = 303;
int a3 = 103;
int b3 = 109; 
int c3 = 400;

//int max1 = Max(a1, b1, c1);
//int max2 =  Max(a1, b1, c1);
//int max3 = Max(a3, b3, c3);

int max = Max ( 
    Max(a1, b1, c1), 
    Max(a1, b1, c1), 
    Max(a3, b3, c3));

Console.WriteLine(max);