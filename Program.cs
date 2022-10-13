int[] bubbles = {3,1,5,2,4};
int temp = 0; 
for (int x = 0; x<bubbles.Length; x++)
{
    for (int i = 0; i<bubbles.Length-1;i++)
    {
        if (bubbles[i]<bubbles[i+1])
        {
            temp = bubbles[i];
            bubbles[i] = bubbles[i+1];
            bubbles[i+1] = temp;
        }
        
    }

}

for (int i=0; i<5; i++)
{
        Console.WriteLine( bubbles[i]);
}



Console.ReadKey();
