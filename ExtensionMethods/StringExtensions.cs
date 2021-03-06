﻿using System;
using System.Linq;

namespace System
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("number of words should be greater or equal to zero");

            if(numberOfWords == 0)
                return "";
            var words = str.Split(' ');

            if (str.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords));
        }
    }
}
