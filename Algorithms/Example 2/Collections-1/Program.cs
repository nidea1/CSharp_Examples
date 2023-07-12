using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Throw the 20 positive numbers entered from the keyboard into 2 separate lists as prime and non-prime. (Write using the ArrayList class.)

        // Block negative and non-numeric entries.
        // Print the elements of each array in ascending order.
        // Print the number of elements and the average of both arrays.
        
        ArrayList numbers = new ArrayList();
        ArrayList primes = new ArrayList();
        ArrayList nonPrimes = new ArrayList();
        

        Console.WriteLine("Enter 20 possitive numbers");

        while (numbers.Count < 20){
            for (int i = 0; i < 20; i++){
                try{
                    Console.Write("{0}- ", i+1);
                    int n = int.Parse(Console.ReadLine());
                    if (n < 1){
                        throw new Exception();
                    }

                    numbers.Add(n);
                }catch{
                    Console.WriteLine("You must enter a numeric number.");
                    i--;
                }

            }
        }

        bool isPrime;
        foreach (int number in numbers){
            isPrime = true;

            if (number == 1){
                isPrime = false;
            }

            for (int i = 2; i < number; i++){
                if(number > 2 && number % i == 0){
                    isPrime = false;
                    break;
                }
            }
            

            if (isPrime){
                primes.Add(number);
            }else{
                nonPrimes.Add(number);
            }
        }

        primes.Sort();
        nonPrimes.Sort();
        
        int sumPrimes = 0;
        int sumNonPrimes = 0;

        Console.Write("Prime numbers: ");
        foreach (int number in primes){
            Console.Write("{0}, ",number);
            sumPrimes += number;
        }

        Console.Write("\nNon-Prime numbers: ");
        foreach (int number in nonPrimes){
            Console.Write("{0}, ",number);
            sumNonPrimes += number;
        }

        Console.WriteLine("\nPrime numbers count: {0}", primes.Count);
        Console.WriteLine("Prime numbers avg: {0}", (float)sumPrimes/primes.Count);

        Console.WriteLine("Non-Primes numbers count: {0}", nonPrimes.Count);
        Console.WriteLine("Non-Primes numbers avg: {0}", (float)sumNonPrimes/nonPrimes.Count);
    }
}
