using System;
using System.Collections.Generic;
using System.Collections;

namespace Traveller.Helper
{
    public static class HelperFunctions
    {
        public static int RollDice(int dice)
        {
            var rand = new Random();
            int result = 0;
            for (int i = 0; i < dice; ++i)
            {
                result += rand.Next(1, 7);
            }

            return result;
        }

        public static string GenerateRandomAlphanum(int length)
        {
            var rand = new Random();
            string alphanum_options = "0123456789ABVDEFGHIJKLMNOPQRSTUVWXYZ";
            string generated_alphanum = "";
            for (int i = 0; i < length; ++i)
            {
                generated_alphanum = generated_alphanum + alphanum_options[rand.Next(0, alphanum_options.Length)];
            }
            return generated_alphanum;
        }

        public static string GetDescription(this int index, List<string> list)
        {
            string description;

            if (index < list.Count && index > -1)
            {
                description = list[index];
            }
            else
            {
                description = "?";
            }
            return description;
        }


        public static Double GetDescription(this int index, List<Double> list)
        {
            Double description;

            if (index < list.Count && index > -1)
            {
                description = list[index];
            }
            else
            {
                description = -1;
            }
            return description;
        }

        public static bool TryGetElement<T>(this List<T> list, int index)
        {
            if (index < list.Count && index > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int Clamp(int n, int lower, int upper) {
            return Math.Max(lower, Math.Min(n, upper));
        }
    }
}