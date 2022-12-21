
namespace MyProgram
{
    class Myclass
    {

        static void Main()
        {
            
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            
            for(int i =n1; i<=n2; i++)
            {
                int e = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        e++;
                        break;
                    }
                    
                  
                                    
                    
                }
                if(e == 0 && i !=1)
                {
                    Console.Write(i + " ");
                }


            }
           


                

        }
    }
}




    






