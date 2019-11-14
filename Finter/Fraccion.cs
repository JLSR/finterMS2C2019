using System;
using System.Globalization;

namespace Finter
{
    public class Fraccion
    {
        long _mINumerator;
        long _mIDenominator;

        public Fraccion()
        {
            Initialize(0, 1);
        }

        public Fraccion(long iWholeNumber)
        {
            Initialize(iWholeNumber, 1);
        }

        public Fraccion(double dDecimalValue)
        {
            Fraccion temp = ToFraction(dDecimalValue);
            Initialize(temp.Numerator, temp.Denominator);
        }

        public Fraccion(string strValue)
        {
            Fraccion temp = ToFraction(strValue);
            Initialize(temp.Numerator, temp.Denominator);
        }

        public Fraccion(long iNumerator, long iDenominator)
        {
            Initialize(iNumerator, iDenominator);
        }

        /// <summary>
        /// Internal function for constructors
        /// </summary>
        private void Initialize(long iNumerator, long iDenominator)
        {
            Numerator = iNumerator;
            Denominator = iDenominator;
            ReduceFraction(this);
        }

        /// <summary>
        /// Properites
        /// </summary>
        public long Denominator
        {
            get { return _mIDenominator; }
            set
            {
                if (value != 0)
                    _mIDenominator = value;
                else
                    throw new FractionException("Denominator cannot be assigned a ZERO Value");
            }
        }

        public long Numerator
        {
            get { return _mINumerator; }
            set { _mINumerator = value; }
        }

        public long Value
        {
            set
            {
                _mINumerator = value;
                _mIDenominator = 1;
            }
        }

        /// <summary>
        /// The function returns the current Fraccion object as double
        /// </summary>
        public double ToDouble()
        {
            return ((double) this.Numerator / this.Denominator);
        }

        /// <summary>
        /// The function returns the current Fraccion object as a string
        /// </summary>
        public override string ToString()
        {
            string str;
            if (this.Denominator == 1)
                str = this.Numerator.ToString();
            else
                str = this.Numerator + "/" + this.Denominator;
            return str;
        }

        /// <summary>
        /// The function takes an string as an argument and returns its corresponding reduced fraction
        /// the string can be an in the form of and integer, double or fraction.
        /// e.g it can be like "123" or "123.321" or "123/456"
        /// </summary>
        public static Fraccion ToFraction(string strValue)
        {
            int i;
            for (i = 0; i < strValue.Length; i++)
                if (strValue[i] == '/')
                    break;

            if (i == strValue.Length) // if string is not in the form of a fraction
                // then it is double or integer
                return (Convert.ToDouble(strValue));
            //return ( ToFraction( Convert.ToDouble(strValue) ) );

            // else string is in the form of Numerator/Denominator
            long iNumerator = Convert.ToInt64(strValue.Substring(0, i));
            long iDenominator = Convert.ToInt64(strValue.Substring(i + 1));
            return new Fraccion(iNumerator, iDenominator);
        }


        /// <summary>
        /// The function takes a floating point number as an argument 
        /// and returns its corresponding reduced fraction
        /// </summary>
        public static Fraccion ToFraction(double dValue)
        {
            try
            {
                checked
                {
                    Fraccion frac;
                    if (dValue % 1 == 0) // if whole number
                    {
                        frac = new Fraccion((long) dValue);
                    }
                    else
                    {
                        double dTemp = dValue;
                        long iMultiple = 1;
                        string strTemp = dValue.ToString();
                        while (strTemp.IndexOf("E") > 0) // if in the form like 12E-9
                        {
                            dTemp *= 10;
                            iMultiple *= 10;
                            strTemp = dTemp.ToString();
                        }

                        int i = 0;
                        while (strTemp[i] != Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                            i++;
                        int iDigitsAfterDecimal = strTemp.Length - i - 1;
                        while (iDigitsAfterDecimal > 0)
                        {
                            dTemp *= 10;
                            iMultiple *= 10;
                            iDigitsAfterDecimal--;
                        }

                        frac = new Fraccion((int) Math.Round(dTemp), iMultiple);
                    }

                    return frac;
                }
            }
            catch (OverflowException)
            {
                throw new FractionException("Conversion not possible due to overflow");
            }
            catch (Exception)
            {
                throw new FractionException("Conversion not possible");
            }
        }

        /// <summary>
        /// The function replicates current Fraccion object
        /// </summary>
        public Fraccion Duplicate()
        {
            Fraccion frac = new Fraccion();
            frac.Numerator = Numerator;
            frac.Denominator = Denominator;
            return frac;
        }

        /// <summary>
        /// The function returns the inverse of a Fraccion object
        /// </summary>
        public static Fraccion Inverse(Fraccion frac1)
        {
            if (frac1.Numerator == 0)
                throw new FractionException("Operation not possible (Denominator cannot be assigned a ZERO Value)");

            long iNumerator = frac1.Denominator;
            long iDenominator = frac1.Numerator;
            return (new Fraccion(iNumerator, iDenominator));
        }


        /// <summary>
        /// Operators for the Fraccion object
        /// includes -(unary), and binary opertors such as +,-,*,/
        /// also includes relational and logical operators such as ==,!=,<,>,<=,>=
        /// </summary>
        public static Fraccion operator -(Fraccion frac1)
        {
            return (Negate(frac1));
        }

        public static Fraccion operator +(Fraccion frac1, Fraccion frac2)
        {
            return (Add(frac1, frac2));
        }

        public static Fraccion operator +(int iNo, Fraccion frac1)
        {
            return (Add(frac1, new Fraccion(iNo)));
        }

        public static Fraccion operator +(Fraccion frac1, int iNo)
        {
            return (Add(frac1, new Fraccion(iNo)));
        }

        public static Fraccion operator +(double dbl, Fraccion frac1)
        {
            return (Add(frac1, ToFraction(dbl)));
        }

        public static Fraccion operator +(Fraccion frac1, double dbl)
        {
            return (Add(frac1, ToFraction(dbl)));
        }

        public static Fraccion operator -(Fraccion frac1, Fraccion frac2)
        {
            return (Add(frac1, -frac2));
        }

        public static Fraccion operator -(int iNo, Fraccion frac1)
        {
            return (Add(-frac1, new Fraccion(iNo)));
        }

        public static Fraccion operator -(Fraccion frac1, int iNo)
        {
            return (Add(frac1, -(new Fraccion(iNo))));
        }

        public static Fraccion operator -(double dbl, Fraccion frac1)
        {
            return (Add(-frac1, ToFraction(dbl)));
        }

        public static Fraccion operator -(Fraccion frac1, double dbl)
        {
            return (Add(frac1, -ToFraction(dbl)));
        }

        public static Fraccion operator *(Fraccion frac1, Fraccion frac2)
        {
            return (Multiply(frac1, frac2));
        }

        public static Fraccion operator *(int iNo, Fraccion frac1)
        {
            return (Multiply(frac1, new Fraccion(iNo)));
        }

        public static Fraccion operator *(Fraccion frac1, int iNo)
        {
            return (Multiply(frac1, new Fraccion(iNo)));
        }

        public static Fraccion operator *(double dbl, Fraccion frac1)
        {
            return (Multiply(frac1, ToFraction(dbl)));
        }

        public static Fraccion operator *(Fraccion frac1, double dbl)
        {
            return (Multiply(frac1, ToFraction(dbl)));
        }

        public static Fraccion operator /(Fraccion frac1, Fraccion frac2)
        {
            return (Multiply(frac1, Inverse(frac2)));
        }

        public static Fraccion operator /(int iNo, Fraccion frac1)
        {
            return (Multiply(Inverse(frac1), new Fraccion(iNo)));
        }

        public static Fraccion operator /(Fraccion frac1, int iNo)
        {
            return (Multiply(frac1, Inverse(new Fraccion(iNo))));
        }

        public static Fraccion operator /(double dbl, Fraccion frac1)
        {
            return (Multiply(Inverse(frac1), ToFraction(dbl)));
        }

        public static Fraccion operator /(Fraccion frac1, double dbl)
        {
            return (Multiply(frac1, Inverse(ToFraction(dbl))));
        }

        public static bool operator ==(Fraccion frac1, Fraccion frac2)
        {
            return frac1.Equals(frac2);
        }

        public static bool operator !=(Fraccion frac1, Fraccion frac2)
        {
            return (!frac1.Equals(frac2));
        }

        public static bool operator ==(Fraccion frac1, int iNo)
        {
            return frac1.Equals(new Fraccion(iNo));
        }

        public static bool operator !=(Fraccion frac1, int iNo)
        {
            return (!frac1.Equals(new Fraccion(iNo)));
        }

        public static bool operator ==(Fraccion frac1, double dbl)
        {
            return frac1.Equals(new Fraccion(dbl));
        }

        public static bool operator !=(Fraccion frac1, double dbl)
        {
            return (!frac1.Equals(new Fraccion(dbl)));
        }

        public static bool operator <(Fraccion frac1, Fraccion frac2)
        {
            return frac1.Numerator * frac2.Denominator < frac2.Numerator * frac1.Denominator;
        }

        public static bool operator >(Fraccion frac1, Fraccion frac2)
        {
            return frac1.Numerator * frac2.Denominator > frac2.Numerator * frac1.Denominator;
        }

        public static bool operator <=(Fraccion frac1, Fraccion frac2)
        {
            return frac1.Numerator * frac2.Denominator <= frac2.Numerator * frac1.Denominator;
        }

        public static bool operator >=(Fraccion frac1, Fraccion frac2)
        {
            return frac1.Numerator * frac2.Denominator >= frac2.Numerator * frac1.Denominator;
        }


        /// <summary>
        /// overloaed user defined conversions: from numeric data types to Fractions
        /// </summary>
        public static implicit operator Fraccion(long lNo)
        {
            return new Fraccion(lNo);
        }

        public static implicit operator Fraccion(double dNo)
        {
            return new Fraccion(dNo);
        }

        public static implicit operator Fraccion(string strNo)
        {
            return new Fraccion(strNo);
        }

        /// <summary>
        /// overloaed user defined conversions: from fractions to double and string
        /// </summary>
        public static explicit operator double(Fraccion frac)
        {
            return frac.ToDouble();
        }

        public static implicit operator string(Fraccion frac)
        {
            return frac.ToString();
        }

        /// <summary>
        /// checks whether two fractions are equal
        /// </summary>
        public override bool Equals(object obj)
        {
            Fraccion frac = (Fraccion) obj;
            return (Numerator == frac.Numerator && Denominator == frac.Denominator);
        }

        /// <summary>
        /// returns a hash code for this fraction
        /// </summary>
        public override int GetHashCode()
        {
            return (Convert.ToInt32((Numerator ^ Denominator) & 0xFFFFFFFF));
        }

        /// <summary>
        /// internal function for negation
        /// </summary>
        private static Fraccion Negate(Fraccion frac1)
        {
            long iNumerator = -frac1.Numerator;
            long iDenominator = frac1.Denominator;
            return (new Fraccion(iNumerator, iDenominator));
        }

        /// <summary>
        /// internal functions for binary operations
        /// </summary>
        private static Fraccion Add(Fraccion frac1, Fraccion frac2)
        {
            try
            {
                checked
                {
                    long iNumerator = frac1.Numerator * frac2.Denominator + frac2.Numerator * frac1.Denominator;
                    long iDenominator = frac1.Denominator * frac2.Denominator;
                    return (new Fraccion(iNumerator, iDenominator));
                }
            }
            catch (OverflowException)
            {
                throw new FractionException("Overflow occurred while performing arithemetic operation");
            }
            catch (Exception)
            {
                throw new FractionException("An error occurred while performing arithemetic operation");
            }
        }

        private static Fraccion Multiply(Fraccion frac1, Fraccion frac2)
        {
            try
            {
                checked
                {
                    long iNumerator = frac1.Numerator * frac2.Numerator;
                    long iDenominator = frac1.Denominator * frac2.Denominator;
                    return (new Fraccion(iNumerator, iDenominator));
                }
            }
            catch (OverflowException)
            {
                throw new FractionException("Overflow occurred while performing arithemetic operation");
            }
            catch (Exception)
            {
                throw new FractionException("An error occurred while performing arithemetic operation");
            }
        }

        /// <summary>
        /// The function returns GCD of two numbers (used for reducing a Fraccion)
        /// </summary>
        private static long GCD(long iNo1, long iNo2)
        {
            // take absolute values
            if (iNo1 < 0) iNo1 = -iNo1;
            if (iNo2 < 0) iNo2 = -iNo2;

            do
            {
                if (iNo1 < iNo2)
                {
                    long tmp = iNo1; // swap the two operands
                    iNo1 = iNo2;
                    iNo2 = tmp;
                }

                iNo1 = iNo1 % iNo2;
            } while (iNo1 != 0);

            return iNo2;
        }

        /// <summary>
        /// The function reduces(simplifies) a Fraccion object by dividing both its numerator 
        /// and denominator by their GCD
        /// </summary>
        public static void ReduceFraction(Fraccion frac)
        {
            try
            {
                if (frac.Numerator == 0)
                {
                    frac.Denominator = 1;
                    return;
                }

                long iGCD = GCD(frac.Numerator, frac.Denominator);
                frac.Numerator /= iGCD;
                frac.Denominator /= iGCD;

                if (frac.Denominator < 0) // if -ve sign in denominator
                {
                    //pass -ve sign to numerator
                    frac.Numerator *= -1;
                    frac.Denominator *= -1;
                }
            } // end try
            catch (Exception exp)
            {
                throw new FractionException("Cannot reduce Fraccion: " + exp.Message);
            }
        }
    } //end class Fraccion

    public class FractionException : Exception
    {
        public FractionException() : base()
        {
        }

        public FractionException(string Message) : base(Message)
        {
            Console.WriteLine(Message);
        }

        public FractionException(string Message, Exception InnerException) : base(Message, InnerException)
        {
            Console.WriteLine(Message);
        }
    } //end class FractionException
}