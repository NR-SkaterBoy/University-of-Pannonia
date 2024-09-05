using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    internal class Box
    {
        private string _name;
        private int _width;
        private int _height;
        private int _length;

        public Box(string name, int width, int height, int length)
        {
            this._name = name;
            this._width = width;
            this._height = height;
            this._length = length;
        }

        public string Name { get { return _name; } }
        public int Width { get { return _width; } }
        public int Height { get { return _height;} }
        public int Length { get { return _length;} }

        public string FormazottSzoveg()
        {
            return $"{Name}, w: {Width}, h: {Height}, l: {Length}";
        }

        public int Felszin()
        {
            return this.Length * this.Width * this.Height;
        }

        public int Terfogat()
        {
            return 2 * (this.Width * this.Height + this.Width * this.Length + this.Length * this.Height);
        }

        public bool Belefer(Box masikDoboz)
        {
            return this.Width >= masikDoboz.Width && this.Height >= masikDoboz.Height && this.Length >= masikDoboz.Length;
        }

        public bool Belefer(int szelesseg, int magassag, int hossz)
        {
            return this.Width <= szelesseg && this.Height <= magassag && this.Length <= hossz;
        }
    }
}
