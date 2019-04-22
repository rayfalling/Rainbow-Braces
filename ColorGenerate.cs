using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Rainbow_braces {
    static class ColorGenerate {
        public static Color CurrentColor;

        public static Color GenerateFirst(Color c = default) {
            if (c == default) {
                var r = new Random();
                CurrentColor = Color.FromRgb((byte) r.NextDouble(), (byte) r.NextDouble(), (byte) r.NextDouble());
                return CurrentColor;
            }

            CurrentColor = c;
            return CurrentColor;
        }

        public static Color GenerateNext() {
            var r = new Random();
            CurrentColor = Color.FromRgb((byte) (CurrentColor.R + ), (byte)r.NextDouble(), (byte)r.NextDouble());
        }
    }
}