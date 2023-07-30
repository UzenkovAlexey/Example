int[] array = {157, 220, 31, 494, 543, 698, 751, 841, 926, 170, 101, 152,};

int n = array.Length;
int find = 926;

int index = 0; 

while (index < n) 
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break
    }
      //inndex = index =1;
      index++;
}