// —————————————————————————————————————————————
//? 
//!? 📜 Amount.cs
//!? 🖋️ Galacticai 📅 2022
//!  ⚖️ GPL-3.0-or-later
//?  🔗 Dependencies:
//      + (Galacticai) Math.Range.cs
//      + (Galacticai) Math.Range_Extension.cs
//? 
// —————————————————————————————————————————————

namespace GalacticLib.Math.Numerics {
    /// <summary> <see cref="double"/> value that exists in a <see cref="Numerics.Range"/> </summary>
    public class Amount {
        /// <summary> The ratio of <see cref="Value"/>,  relative to the <see cref="Range"/>'s min and max </summary>
        public double Ratio_InRange
            => Range.GetRatio(Value);

        private double _Value;
        /// <summary> Value of this <see cref="Amount"/> </summary>
        public double Value {
            get => _Value;
            set => _Value = value.AtOrBetween(Range);
        }
        /// <summary> Boundary (<see cref="Numerics.Range"/>) of this <see cref="Amount"/> </summary>
        public Range Range { get; set; }

        /// <summary> <see cref="double"/> value that is bounded by the <see cref="Range"/> 
        /// <br/> Bounded from 0 to <paramref name="value"/> </summary>
        public Amount(double value) {
            Value = value;
            Range = new(0, value);
        }
        /// <summary> <see cref="double"/> value that is bounded by the <see cref="Range"/> 
        /// <br/> Bounded by <paramref name="range"/> </summary>
        public Amount(double value, Range range) {
            Value = value;
            Range = range;
        }

        /// <summary> (implicit) <see cref="Value"/> of <paramref name="amount"/> </summary>
        /// <param name="amount"> Target <see cref="Amount"/> </param>
        public static implicit operator double(Amount amount)
            => amount.Value;
        //!? Replacing the instance causes the Range to be reset which means old range data gets lost unexpectedly!
        //!?    => Better create a new instance manually while knowing that a new range is made
        //public static implicit operator Amount(double value) => new(value); 

        /// <summary> Convert this <see cref="Amount"/> to <see cref="string"/> </summary>
        /// <returns> "<see cref="Value"/>" </returns>
        public override string ToString()
            => Value.ToString();
        /// <summary> Get the hash code for this <see cref="Amount"/>  </summary>
        /// <returns> Combined hash code of <see cref="Value"/> and <see cref="Range"/> </returns>
        public override int GetHashCode()
            => HashCode.Combine(Value, Range);
        /// <summary> Determines whether this <see cref="Amount"/> is equal to an <see cref="object"/> </summary>
        /// <param name="obj"> Target <see cref="object"/> </param>
        /// <returns> true if:
        /// <list type="number">
        ///     <item> <paramref name="obj"/> is an <see cref="Amount"/> </item>
        ///     <item> <see cref="Value"/>s and <see cref="Range"/>s are equal </item>
        /// </list></returns>
        public override bool Equals(object? obj) {
            if (obj is not Amount other) return false;
            return Value == other.Value && Range.Equals(other.Range);
        }
        /// <summary> Determines if 2 <see cref="Amount"/>s are equal </summary>
        /// <returns> true if <paramref name="amount1"/> and <paramref name="amount2"/> are equal </returns>
        public static bool operator ==(Amount amount1, Amount amount2)
            => amount1.Equals(amount2);
        /// <summary> Determines if 2 <see cref="Amount"/>s are different </summary>
        /// <returns> true if <paramref name="amount1"/> and <paramref name="amount2"/> are different </returns>
        public static bool operator !=(Amount amount1, Amount amount2)
            => !amount1.Equals(amount2);
        /// <summary> Determines if an <see cref="Amount"/> is greater than another </summary>
        /// <returns> true if the <see cref="Value"/> of <paramref name="amount1"/> is greater than the that of <paramref name="amount2"/> </returns>
        public static bool operator >(Amount amount1, Amount amount2)
            => amount1.Value > amount2.Value;
        /// <summary> Determines if an <see cref="Amount"/> is smaller than another </summary>
        /// <returns> true if the <see cref="Value"/> of <paramref name="amount1"/> is smaller than the that of <paramref name="amount2"/> </returns>
        public static bool operator <(Amount amount1, Amount amount2)
            => amount1.Value < amount2.Value;
    }
}