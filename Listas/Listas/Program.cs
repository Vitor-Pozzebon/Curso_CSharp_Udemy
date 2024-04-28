using System;
using System.Globalization;
using System.Collections.Generic;       //biblioteca para usar strings

namespace Listas {
    class Program {
        static void Main(string[] args) {
            
            //padrão de instanciação de uma lista

            //List<string> list = new List<string>();
            //List<string> list2 = new List<string> { "Maria", "Alex" };

            List<string> list = new List<string>();

            //add - adiciona o elemento ao final da lista
            //insert - adiciona o elemento em uma posição específica da lista
            //count - mostra o tamanho da lista
            //Find e FindLast - achar o primeiro ou último elemento da lista que satisfaça um predicado
            //FindIndex e FindLastIndex - achar a primeira ou última posição da lista que satisfaça um predicado
            //FindAll - filtra a lista toda com base em um predicado

            //Remover elementos da lista:
            //Remove - remove um elemento específico - deve passar o próprio elemento como parâmetro
            //RemoveAll - remove um grupo de elementos de acordo com um predicado
            //RemoveAt - remove um elemento específico baseado no índice da lista
            //RemoveRange - remove uma faixa de elementos - precisa passar o índice inicial da remoção e a contagem de elementos que quer remover

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Tamanho da lista: " + list.Count);
            Console.WriteLine("---------------------------------------------------");

            string s1 = list.Find(x => x[0] == 'A');        // x tal que x[0] == 'A'
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] ==  'A'); ;
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First index 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last index 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------------------------------------");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2);
            Console.WriteLine("---------------------------------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------------------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}