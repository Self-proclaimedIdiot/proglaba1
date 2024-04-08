﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proglaba1
{
    internal class Rational
    {
        private int numerator;
        private int denominator;
        public int Numerator { get { return numerator; } }
        public int Denominator { get { return denominator; } }
        public static int NOD(int a, int b)
        {

            if (a < 0) a = -a;
            if (b < 0) b = -b;
            int i = 0;
            if (a < b) i = a;
            else i = b;
            while (a % i != 0 || b % i != 0) i--;
            return i;
        }
        public static int NOK(int a, int b)
        {

            if (a < 0) a = -a;
            if (b < 0) b = -b;
            int i = 0;
            if (a > b) i = a;
            else i = b;
            while (i % a != 0 || i % b != 0) i++;
            return i;
        }
        public static Rational operator +(Rational a, Rational b)
        {
            int nok = NOK(a.denominator, b.denominator);
            int amul = nok / a.denominator;
            int bmul = nok / b.denominator;
            int newnum = a.numerator * amul + b.numerator * bmul;
            if (newnum == 0) return new Rational(0, 1);
            int nod = NOD(newnum, nok);
            return new Rational(newnum / nod, nok / nod);
        }
        public static Rational operator -(Rational a, Rational b)
        {
            return a + (-b);
        }
        public static Rational operator *(Rational a, Rational b)
        {
            int nod = NOD(a.numerator * b.numerator, a.denominator * b.denominator);
            return new Rational(a.numerator * b.numerator / nod, a.denominator * b.denominator / nod);
        }
        public static Rational operator /(Rational a, Rational b)
        {
            Rational c = new Rational(b.denominator, b.numerator);
            int nod = NOD(a.numerator * c.numerator, a.denominator * c.denominator);
            return new Rational(a.numerator * c.numerator / nod, a.denominator * c.denominator / nod);
        }
        public static Rational operator -(Rational a)
        {
            return new Rational(-a.numerator, a.denominator);
        }
        public static bool operator ==(Rational a, Rational b)
        {
            int noda = NOD(a.numerator, a.denominator);
            int nodb = NOD(b.numerator, b.denominator);
            return a.numerator / noda == b.numerator / nodb && a.denominator / noda == b.denominator / nodb;
        }
        public static bool operator !=(Rational a, Rational b)
        {
            int noda = NOD(a.numerator, a.denominator);
            int nodb = NOD(b.numerator, b.denominator);
            return a.numerator / noda != b.numerator / nodb && a.denominator / noda != b.denominator / nodb;
        }
        public static bool operator >(Rational a, Rational b)
        {
            int nok = NOK(a.denominator, b.denominator);
            int amul = nok / a.denominator;
            int bmul = nok / b.denominator;
            return a.numerator * amul > b.numerator * bmul;
        }
        public static bool operator <(Rational a, Rational b)
        {
            int nok = NOK(a.denominator, b.denominator);
            int amul = nok / a.denominator;
            int bmul = nok / b.denominator;
            return a.numerator * amul < b.numerator * bmul;
        }
        public static bool operator >=(Rational a, Rational b)
        {
            int nok = NOK(a.denominator, b.denominator);
            int amul = nok / a.denominator;
            int bmul = nok / b.denominator;
            return a.numerator * amul >= b.numerator * bmul;
        }
        public static bool operator <=(Rational a, Rational b)
        {
            int nok = NOK(a.denominator, b.denominator);
            int amul = nok / a.denominator;
            int bmul = nok / b.denominator;
            return a.numerator * amul <= b.numerator * bmul;
        }
        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public override string ToString()
        {
            if (numerator == 0) return "0";
            else
            if (denominator == 1) return numerator.ToString();
            return numerator.ToString() + "/" + denominator.ToString();
        }
    }
}
