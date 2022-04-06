// See https://aka.ms/new-console-template for more information

int StampaArray(int[] array)
{
    int elem=0;
    foreach (int item in array) 
    {
        elem = item;
    }
    Console.WriteLine(elem);
    return elem;
}
int Quadrato(int numero)
{
    return numero * numero;
}
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arr = (int[])array.Clone();
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = Quadrato(array[i]);
    }
    return arr;
}
int sommaElementiArray(int[] array)
{
    int[] NuovoArr =(int[])array.Clone();
    int somma = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        somma+= NuovoArr[i];
    }
    return somma;
}

int[] my_array = new int[] { 2, 6, 7, 5, 3, 9 };

StampaArray(my_array);
StampaArray(ElevaArrayAlQuadrato(my_array));
StampaArray(my_array);
Console.WriteLine(sommaElementiArray(my_array));
Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(my_array)));