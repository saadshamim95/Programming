using System;

namespace Data_Structure
{
    class PrimeAnagramUsingQueue
    {
        public void printAnagram() {
            int[] primes = new int[169];
            int j = 0;
            for (int i = 0; i < 1000; i++)
            {
                bool prime = Utility.IsPrime(i);
                if (prime)
                    primes[j++] = i;
            }

            int[] anagramArray = new int[108];
            j = 0;
            for (int i = 0; i < primes.Length; i++)
            {
                for (int k = i + 1; k < primes.Length - 1; k++)
                {
                    string str1 = Convert.ToString(primes[i]);
                    string str2 = Convert.ToString(primes[k]);
                    bool anagram = Utility.IsAnagrams(str1, str2);
                    bool flag1;
                    bool flag2;
                    if (anagram)
                    {
                        int l = j;
                        flag1 = false;
                        flag2 = false;
                        while (l > 0)
                        {
                            if (anagramArray[l] == primes[i])
                                flag1 = true;
                            if (anagramArray[l] == primes[k])
                                flag2 = true;
                            if (flag1 && flag2)
                                break;
                            l--;
                        }
                        if (!flag1 && !flag2)
                        {
                            anagramArray[j++] = primes[i];
                            anagramArray[j++] = primes[k];
                        }
                        else if (flag1 && !flag2)
                            anagramArray[j++] = primes[k];
                        else if (!flag1 && flag2)
                            anagramArray[j++] = primes[i];
                    }
                }
            }
            Array.Sort(anagramArray);

            QueueLinkedList<int> queueLinkedList = new QueueLinkedList<int>();
            for (int i = 0; i < anagramArray.Length; i++)
                queueLinkedList.enqueue(anagramArray[i]);

            int item;
            Console.WriteLine("Printing Queue:");
            for (int i = 0; i < anagramArray.Length; i++) {
                item = queueLinkedList.dequeue();
                if (item != 0)
                    Console.Write(item + " ");
            }         
        }
    }
}
