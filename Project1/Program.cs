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
                Console.WriteLine(newArray[j]);
                j++;
            }
    return newArray;
}
string[] myArray={"hello","2","world",":-)"}; 
string[] string3Char=StringLess3Char(myArray);   
