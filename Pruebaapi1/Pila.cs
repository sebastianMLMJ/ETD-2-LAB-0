using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Pruebaapi1
{
    public class Pila <T> 
    {
        public class Nodo
        {
            public T dato;
            public Nodo siguiente;

            public Nodo(T valor)
            {
                dato = valor;
                siguiente = null;
            }


        }
        public Nodo primero = null;
        



        public void Insertar(T valor)
        {
            
            int contador = 1;
            Nodo scanner = primero;
            Nodo scanneraux = primero;
            Nodo nuevo = new Nodo(valor);
            
            if (primero == null)
            {
                primero = nuevo;
            }
            if (primero != null)
            {
                
                nuevo.siguiente = primero;
                primero = nuevo;

                while (scanner!= null)
                {
                    
                    contador++;
                    if (contador == 10)
                    {
                        scanner.siguiente = null;
                    }
                    scanner = scanner.siguiente;
                }
                
            }
            
        }

       



        public IEnumerator<T> GetEnumerator()
        {
            Nodo current = primero;
            int contador=0;

            while (current != null && contador !=2)
            {
                yield return current.dato;
                current = current.siguiente;
                contador++;
            }
        }


    }
}
