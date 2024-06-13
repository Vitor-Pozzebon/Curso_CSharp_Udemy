﻿using System;

namespace RestricoesGenerics.Services
{
    internal class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable     //para permitir fazer a comparação
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
