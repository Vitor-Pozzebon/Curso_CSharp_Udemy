using System;
using System.Globalization;

namespace TiposDeDados {
    struct Point {
        public double X;
        public double Y;

        public override string ToString() {
            return "(" + X + ", " + Y + ")";
        }
    }
}
