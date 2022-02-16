using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLab2
{
    class GenericList<T>
    {
        Node<T> head;
        
        public bool Insert(T value)
        {
            if(head != null)
            {
                
            }
            return true;
        }
    }
    class Node<T>
    {
        T value;
        Node<T> Next = null;
        Node<T> Before = null;
    }
}
