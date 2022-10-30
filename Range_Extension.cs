namespace GalacticLib.Math.Numerics {
    /// <summary> Extension methods for <see cref="Range"/> or things related to it </summary>
    public static class Range_Extension {
        /// <summary> Gets the <paramref name="input"/> but forced within a <see cref="Range"/> </summary>
        /// <param name="input"> Input </param>
        /// <param name="range"> Target boundary (<see cref="Range"/>) </param>
        /// <returns> <paramref name="input"/> forced within the <paramref name="range"/> </returns>
        public static double AtOrBetween(this double input, Range range)
            => input.AtOrBetween(range.Min, range.Max);
        /// <summary> Gets the <paramref name="input"/> but forced within a range </summary>
        /// <param name="input"> Input </param>
        /// <param name="min"> Minimum boundary </param>
        /// <param name="max"> Maximum boundary </param>
        /// <returns> <paramref name="input"/> forced within <paramref name="min"/> and <paramref name="max"/> </returns>
        public static double AtOrBetween(this double input, double min, double max) {
            if (input > max) return max;
            if (input < min) return min;
            return input;
        }
        /// <summary> Gets the <paramref name="input"/> but forced at or above a minimum value </summary>
        /// <param name="input"> Input </param>
        /// <param name="min"> Minimum boundary </param>
        /// <returns> <paramref name="input"/> forced equal or above <paramref name="min"/> </returns>
        public static double AtOrAbove(this double input, double min)
            => input < min ? min : input;
        /// <summary> Gets the <paramref name="input"/> but forced at or below a maximum value </summary>
        /// <param name="input"> Input </param>
        /// <param name="max"> Maximum boundary </param>
        /// <returns> <paramref name="input"/> forced equal or below <paramref name="max"/> </returns>
        public static double AtOrBelow(this double input, double max)
            => input > max ? max : input;
        /// <summary> Gets the <paramref name="input"/> but forced at or above 0 </summary>
        /// <param name="input"> Input </param>
        /// <returns> <paramref name="input"/> if it's greater than 0; Otherwise, 0.  </returns>
        public static double Positive(this double input)
            => AtOrAbove(input, 0);
        /// <summary> Gets the <paramref name="input"/> but forced at or below 0 </summary>
        /// <param name="input"> Input </param>
        /// <returns> <paramref name="input"/> if it's greater than 0; Otherwise, 0.  </returns>
        public static double Negative(this double input)
            => AtOrBelow(input, 0);
        /// <summary> Determines whether <paramref name="input"/> is within a range </summary>
        /// <param name="input"> Input </param>
        /// <param name="min"> Minimum boundary </param>
        /// <param name="max"> Maximum boundary </param>
        /// <returns> true if <paramref name="input"/> is within <paramref name="min"/> and <paramref name="max"/> </returns>
        public static bool IsBetween(this double input, double min, double max)
            => input >= min && input <= max;
        /// <summary> Determines whether <paramref name="input"/> is within a range </summary>
        /// <param name="input"> Input </param>
        /// <param name="range"> Target boundary (<see cref="Range"/>) </param>
        /// <returns> true if <paramref name="input"/> is within the <paramref name="range"/> </returns>
        public static bool IsBetween(this double input, Range range)
            => input.IsBetween(range.Min, range.Max);


        /// <summary> Gets the <paramref name="input"/> but forced within a <see cref="Range"/> </summary>
        /// <param name="input"> Input </param>
        /// <param name="range"> Target boundary (<see cref="Range"/>) </param>
        /// <returns> <paramref name="input"/> forced within the <paramref name="range"/> </returns>
        public static float AtOrBetween(this float input, Range range)
            => input.AtOrBetween(Convert.ToSingle(range.Min), Convert.ToSingle(range.Max));
        /// <summary> Gets the <paramref name="input"/> but forced within a range </summary>
        /// <param name="input"> Input </param>
        /// <param name="min"> Minimum boundary </param>
        /// <param name="max"> Maximum boundary </param>
        /// <returns> <paramref name="input"/> forced within <paramref name="min"/> and <paramref name="max"/> </returns>
        public static float AtOrBetween(this float input, float min, float max) {
            if (input > max) return max;
            if (input < min) return min;
            return input;
        }
        /// <summary> Gets the <paramref name="input"/> but forced at or above a minimum value </summary>
        /// <param name="input"> Input </param>
        /// <param name="min"> Minimum boundary </param>
        /// <returns> <paramref name="input"/> forced equal or above <paramref name="min"/> </returns>
        public static float AtOrAbove(this float input, float min)
            => input < min ? min : input;
        /// <summary> Gets the <paramref name="input"/> but forced at or below a maximum value </summary>
        /// <param name="input"> Input </param>
        /// <param name="max"> Maximum boundary </param>
        /// <returns> <paramref name="input"/> forced equal or below <paramref name="max"/> </returns>
        public static float AtOrBelow(this float input, float max)
            => input > max ? max : input;
        /// <summary> Gets the <paramref name="input"/> but forced at or above 0 </summary>
        /// <param name="input"> Input </param>
        /// <returns> <paramref name="input"/> if it's greater than 0; Otherwise, 0.  </returns>
        public static float Positive(this float input)
            => AtOrAbove(input, 0);
        /// <summary> Gets the <paramref name="input"/> but forced at or below 0 </summary>
        /// <param name="input"> Input </param>
        /// <returns> <paramref name="input"/> if it's greater than 0; Otherwise, 0.  </returns>
        public static float Negative(this float input)
            => AtOrBelow(input, 0);
        /// <summary> Determines whether <paramref name="input"/> is within a range </summary>
        /// <param name="input"> Input </param>
        /// <param name="min"> Minimum boundary </param>
        /// <param name="max"> Maximum boundary </param>
        /// <returns> true if <paramref name="input"/> is within <paramref name="min"/> and <paramref name="max"/> </returns>
        public static bool IsBetween(this float input, float min, float max)
            => input >= min && input <= max;
        /// <summary> Determines whether <paramref name="input"/> is within a range </summary>
        /// <param name="input"> Input </param>
        /// <param name="range"> Target boundary (<see cref="Range"/>) </param>
        /// <returns> true if <paramref name="input"/> is within the <paramref name="range"/> </returns>
        public static bool IsBetween(this float input, Range range)
            => input.IsBetween(Convert.ToSingle(range.Min), Convert.ToSingle(range.Max));
        /// <summary> Gets the <paramref name="input"/> but forced within a <see cref="Range"/> </summary>
        /// <param name="input"> Input </param>
        /// <param name="range"> Target boundary (<see cref="Range"/>) </param>
        /// <returns> <paramref name="input"/> forced within the <paramref name="range"/> </returns>
        public static int AtOrBetween(this int input, Range range)
            => input.AtOrBetween(Convert.ToInt32(range.Min), Convert.ToInt32(range.Max));
        /// <summary> Gets the <paramref name="input"/> but forced within a range </summary>
        /// <param name="input"> Input </param>
        /// <param name="min"> Minimum boundary </param>
        /// <param name="max"> Maximum boundary </param>
        /// <returns> <paramref name="input"/> forced within <paramref name="min"/> and <paramref name="max"/> </returns>
        public static int AtOrBetween(this int input, int min, int max) {
            if (input > max) return max;
            if (input < min) return min;
            return input;
        }
        /// <summary> Gets the <paramref name="input"/> but forced at or above a minimum value </summary>
        /// <param name="input"> Input </param>
        /// <param name="min"> Minimum boundary </param>
        /// <returns> <paramref name="input"/> forced equal or above <paramref name="min"/> </returns>
        public static int AtOrAbove(this int input, int min)
            => input < min ? min : input;
        /// <summary> Gets the <paramref name="input"/> but forced at or below a maximum value </summary>
        /// <param name="input"> Input </param>
        /// <param name="max"> Maximum boundary </param>
        /// <returns> <paramref name="input"/> forced equal or below <paramref name="max"/> </returns>
        public static int AtOrBelow(this int input, int max)
            => input > max ? max : input;

        /// <summary> Gets the <paramref name="input"/> but forced at or above 0 </summary>
        /// <param name="input"> Input </param>
        /// <returns> <paramref name="input"/> if it's greater than 0; Otherwise, 0.  </returns>
        public static int Positive(this int input)
            => AtOrAbove(input, 0);

        /// <summary> Gets the <paramref name="input"/> but forced at or below 0 </summary>
        /// <param name="input"> Input </param>
        /// <returns> <paramref name="input"/> if it's greater than 0; Otherwise, 0.  </returns>
        public static int Negative(this int input)
            => AtOrBelow(input, 0);
        /// <summary> Determines whether <paramref name="input"/> is within a range </summary>
        /// <param name="input"> Input </param>
        /// <param name="min"> Minimum boundary </param>
        /// <param name="max"> Maximum boundary </param>
        /// <returns> true if <paramref name="input"/> is within <paramref name="min"/> and <paramref name="max"/> </returns>
        public static bool IsBetween(this int input, int min, int max)
            => input >= min && input <= max;
        /// <summary> Determines whether <paramref name="input"/> is within a range </summary>
        /// <param name="input"> Input </param>
        /// <param name="range"> Target boundary (<see cref="Range"/>) </param>
        /// <returns> true if <paramref name="input"/> is within the <paramref name="range"/> </returns>
        public static bool IsBetween(this int input, Range range)
            => input.IsBetween(Convert.ToInt32(range.Min), Convert.ToInt32(range.Max));
    }
}
