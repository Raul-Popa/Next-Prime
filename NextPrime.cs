using System;

namespace nextprime
{
    class Program
    {
        static bool IsPrime(long n){
            if(n == 2)
                return true;

            if(n % 2 == 0)
                return false;

            for(int i =3;i<=Math.Sqrt(n);i+=2){
                if(n % i == 0)
                    return false;
            }
            return true;
        }

        static long NextPrime(long currentPrime){
            long n = currentPrime+1;
            while(true){
                if(!IsPrime(n))
                    n++;
                else
                    break;
            }
            return n;
        }

        static void Main(string[] args)
        {
             
            //This is a simple program that will keep displaying prime numbers until the user tells it to stop
            

            long n=2;

            while(true){
                Console.WriteLine("For a prime type \'Y\', to quit type \'N\'");
                string input = Console.ReadLine();
                if(input.ToLower()=="y"){
                    Console.WriteLine(n);
                    n=NextPrime(n);
                }
                else
                    break;
                
            }
        }
    }
}
