string[] StringLess3Char(string[]array)

{
    int amountStringLess3char=0;
    for(int i=0; i<array.Length;i++)
        if((array[i]).Length<=3)
            amountStringLess3char++;
    string[] newArray=new string[amountStringLess3char];
    int j=0;
    for(int i=0; i<array.Length;i++)
        if((array[i]).Length<=3)
            {
                newArray[j]=array[i];
                j++;
            }
    return newArray;
}

void ShowArray(string[]array)
{
        if(array.Length!=0)
        {
            Console.Write("Array is:[");

            for(int i=0; i<(array.Length-1); i++)
            {
                Console.Write(array[i] + " ");
                Console.Write(",");
            }
            Console.WriteLine(array[array.Length-1]+ "]");
        }

        else
            Console.WriteLine("Array is:[]");
}

string[] myArray={"hello","2","world",":-)"}; 
//string[] myArray={"Russia","Denmark","Kazan"}; 
//string[] myArray={"1234","1567","-2","computer science"};
string[] string3Char=StringLess3Char(myArray);   
ShowArray(string3Char);
