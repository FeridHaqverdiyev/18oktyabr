using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace _18oktyabr.Models
{
    internal class ListInt
    {
       
        private int[] array;
        private int sum;

        public ListInt(int[] array)
        {
            this.array = array;
        }
        
        public ListInt()
        {
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = value;
                }
                
               
            }
        }
        public void Add(int num)
        {
            Array.Resize(ref array,array.Length+1);
            array[array.Length-1] = num;
        }
        public void AddRange(params int[] nums)
        {
            int oldLength=array.Length;
            Array.Resize(ref array,array.Length+nums.Length);         
        }
        public bool Contains(int num)
        { 
            foreach(var item in array)
            {
                if (item == num)
                {
                    Console.WriteLine("true");
                    return true;
                }
            }
            Console.WriteLine("false");
            return false;   

           
        }

        public int Sum(int[]array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

       

        public void Remove(int num)
        {
           
            Int[] newArr = new Int[0];

            for (int i = 0; i < array.Length-1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array,array.Length-1);
            
        }
        public void RemoveRange(params int[] nums)
        {
            foreach(int num in nums)
            {
                Remove(num);
            }
           
            
        }
        public override string ToString()
        {
            return string.Join(",", array);
        }

        internal void AddRanger(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        internal int Sum()
        {
            throw new NotImplementedException();
        }
    }
    
}
