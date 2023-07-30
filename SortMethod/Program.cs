

void OrderedArray(int []array)
{
    for(int i=0; i< array.Length-1; i++)
    {
        int minPosition=i;
        for(int j=i+1; j<array.Length; j++)
        {
            if(array[j]<array[minPosition])
            {
                minPosition=j;
            }
        }
        int temporary = array[i];
        array[i]= array[minPosition];
        array[minPosition]=temporary;
    }
    
}
void PrintArray(int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}

int [] testArray = {4,67,3,9,0,4,55,34,71,32,58};
PrintArray(testArray);
OrderedArray(testArray);
PrintArray(testArray);