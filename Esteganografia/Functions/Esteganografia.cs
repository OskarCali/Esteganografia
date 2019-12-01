using System.Drawing;
using Esteganografia.Estensions;

namespace Esteganografia.Functions
{
    internal class Esteganografia
    {
        public Bitmap ocultar(string text, Bitmap image)
        {
            var state = State.Hiding;

            var chartIndex = 0;
            var charValue = 0;
            long pixelElementIndex = 0;
            var zeros = 0;
            int R = 0, G = 0, B = 0;

            for (var i = 0; i < image.Height; i++)
            for (var j = 0; j < image.Width; j++)
            {
                var pixel = image.GetPixel(j, i);

                var t1 = pixel.R % 2;
                R = pixel.R - pixel.R % 2;
                G = pixel.G - pixel.G % 2;
                B = pixel.B - pixel.B % 2;

                for (var k = 0; k < 3; k++)
                {
                    if (pixelElementIndex % 8 == 0)
                    {
                        if (state == State.Filling_Zeros && zeros == 8)
                        {
                            if ((pixelElementIndex - 1) % 3 < 2) image.SetPixel(j, i, Color.FromArgb(R, G, B));

                            return image;
                        }

                        if (chartIndex >= text.Length)
                            state = State.Filling_Zeros;
                        else
                            charValue = text[chartIndex++];
                    }

                    switch (pixelElementIndex % 3)
                    {
                        case 0:
                            if (state == State.Hiding)
                            {
                                R += charValue % 2;
                                charValue /= 2;
                            }

                            break;
                        case 1:
                            if (state == State.Hiding)
                            {
                                G += charValue % 2;
                                charValue /= 2;
                            }

                            break;
                        case 2:
                            if (state == State.Hiding)
                            {
                                B += charValue % 2;
                                charValue /= 2;
                            }

                            image.SetPixel(j, i, Color.FromArgb(R, G, B));
                            break;
                    }

                    pixelElementIndex++;

                    if (state == State.Filling_Zeros) zeros++;
                }
            }

            return image;
        }

        public string mostrar(Bitmap image)
        {
            var colorUnitIndex = 0;
            var charValue = 0;

            var msg = "";

            for (var i = 0; i < image.Height; i++)
            for (var j = 0; j < image.Width; j++)
            {
                var pixel = image.GetPixel(j, i);

                for (var k = 0; k < 3; k++)
                {
                    switch (colorUnitIndex % 3)
                    {
                        case 0:
                            charValue = charValue * 2 + pixel.R % 2;
                            break;
                        case 1:
                            charValue = charValue * 2 + pixel.G % 2;
                            break;
                        case 2:
                            charValue = charValue * 2 + pixel.B % 2;
                            break;
                    }

                    colorUnitIndex++;

                    if (colorUnitIndex % 8 == 0)
                    {
                        charValue = charValue.ReverseBits();

                        if (charValue == 0) return msg;

                        var c = (char) charValue;
                        msg += c.ToString();

                        charValue = 0;
                    }
                }
            }

            return msg;
        }

        private enum State
        {
            Hiding,
            Filling_Zeros
        }
    }
}