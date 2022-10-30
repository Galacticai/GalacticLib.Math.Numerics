using System;
// —————————————————————————————————————————————
//? 
//!? 📜 Range.cs
//!? 🖋️ Galacticai 📅 2022
//!  ⚖️ GPL-3.0-or-later
//?  🔗 Dependencies: No special dependencies
//? 
// —————————————————————————————————————————————

using sMath = System.Math;

namespace GalacticLib.Math.Numerics {
    /// <summary> Numerical boundary (<see cref="double"/> type) </summary>
    public class Range {

        #region Shortcuts
        /// <summary> A <see cref="Range"/> from 0 to 1 </summary>
        public static readonly Range ZERO_ONE = new(0, 1);
        /// <summary> A <see cref="Range"/> from 0 to 10 </summary>
        public static readonly Range ZERO_TEN = new(0, 10);
        /// <summary> A <see cref="Range"/> from 0 to 100 </summary>
        public static readonly Range ZERO_HUNDRED = new(0, 100);

        /// <summary> Minimum boundary of this <see cref="Range"/> </summary>
        public double Min => sMath.Min(_Start, _End);
        /// <summary> Maximum boundary of this <see cref="Range"/> </summary>
        public double Max => sMath.Max(_Start, _End);

        #endregion
        #region Methods

        /// <summary> Gets the <paramref name="input"/> but forced within this <see cref="Range"/> </summary>
        /// <param name="input"> Input </param>
        /// <returns> <paramref name="input"/> forced within the <see cref="Min"/> and <see cref="Max"/> of this <see cref="Range"/> </returns>
        public double AtOrBetween(double input)
            => input.AtOrBetween(Min, Max);

        /// <summary> Get the ratio of <paramref name="input"/> relative to this <see cref="Range"/> </summary>
        /// <param name="input"> Input </param>
        /// <returns> Ratio of <paramref name="input"/> relative to this <see cref="Range"/></returns>
        public double GetRatio(double input) {
            //? Try catch because double==double is never precise
            //? (can't detect division by zero beforehand)
            try {
                return (input - Min) / (Max - Min);
            } catch { //(System.DivideByZeroException divideByZeroExceptiion) {
                return input > End ? 1 : 0;
            }
        }

        /// <summary> Get the percentage of <paramref name="input"/> relative to this <see cref="Range"/> </summary>
        /// <param name="input"> Input </param>
        /// <returns> <see cref="GetRatio(double)"/> * 100</returns>
        public double GetPercent(double input)
            => GetRatio(input) * 100;

        /// <summary> Union of this <see cref="Range"/> with another <paramref name="range"/> </summary>
        /// <returns> new <see cref="Range"/> spanning both ranges </returns>
        public Range Union(Range range)
            => new(sMath.Min(Min, range.Min), sMath.Max(Max, range.Max));

        #endregion

        private double _Start;
        private double _End;
        /// <summary> Srarting boundary </summary>
        public double Start {
            get => FromEnd ? _End : _Start;
            set => _Start = value;
        }
        /// <summary> Ending boundary </summary>
        public double End {
            get => FromEnd ? _Start : _End;
            set => _End = value;
        }
        /// <summary> Reverses the <see cref="Start"/> and <see cref="End"/> </summary>
        public bool FromEnd { get; set; }
        /// <summary> Numerical boundary (<see cref="double"/> type) </summary>
        /// <param name="start"> Starting boundary </param>
        /// <param name="end"> Ending boundary </param>
        /// <param name="fromEnd"> Reverses the <see cref="Start"/> and <see cref="End"/> </param>
        public Range(double start, double end, bool fromEnd) {
            Start = start;
            End = end;
            FromEnd = fromEnd;
        }
        /// <summary> Numerical boundary (<see cref="double"/> type) </summary>
        /// <param name="start"> Starting boundary </param>
        /// <param name="end"> Ending boundary </param>
        public Range(double start, double end)
                    : this(start, end, false) { }

        /// <summary> Converts this <see cref="Range"/> to a <see cref="string"/> </summary>
        /// <returns> "<see cref="Min"/>~<see cref="Max"/>" </returns>
        public override string ToString()
            => $"{Min}~{Max}";
        /// <summary> Get the hash code for this <see cref="Range"/>  </summary>
        /// <returns> Combined hash code of <see cref="Min"/> and <see cref="Max"/> </returns>
        public override int GetHashCode()
            => HashCode.Combine(Min, Max);
        /// <summary> Determines whether this <see cref="Range"/> is equal to an <see cref="object"/> </summary>
        /// <param name="obj"> Target <see cref="object"/> </param>
        /// <returns> true if:
        /// <list type="number">
        ///     <item> <paramref name="obj"/> is an <see cref="Range"/> </item>
        ///     <item> <see cref="Min"/> and <see cref="Max"/> values of both <see cref="Range"/>s are equal </item>
        /// </list></returns>
        public override bool Equals(object? obj) {
            if (obj is not Range other) return false;
            return Min == other.Min && Max == other.Max;
        }
        /// <summary> Determines if 2 <see cref="Range"/>s are equal </summary>
        /// <returns> true if <paramref name="range1"/> and <paramref name="range2"/> are equal </returns>
        public static bool operator ==(Range range1, Range range2)
            => range1.Equals(range2);
        /// <summary> Determines if 2 <see cref="Range"/>s are different </summary>
        /// <returns> true if <paramref name="range1"/> and <paramref name="range2"/> are different </returns>
        public static bool operator !=(Range range1, Range range2)
            => !range1.Equals(range2);
        /// <summary> Determines if an <see cref="Range"/> is greater than another </summary>
        /// <returns> true if the <see cref="Max"/> value of <paramref name="range1"/> is greater than that of <paramref name="range2"/> </returns>
        public static bool operator >(Range range1, Range range2)
            => range1.Max > range2.Max;
        /// <summary> Determines if an <see cref="Range"/> is smaller than another </summary>
        /// <returns> true if the <see cref="Min"/> value of <paramref name="range1"/> is smaller than that of <paramref name="range2"/> </returns>
        public static bool operator <(Range range1, Range range2)
            => range1.Min < range2.Min;
    }
}