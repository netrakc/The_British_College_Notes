using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapesInheritanceExample
{
    abstract class Shape
    {

        protected Color colour; //shape's colour
        protected int x, y; //not I could use c# properties for this
        public Shape(Color colour, int x, int y)
        {

            this.colour = colour; //shape's colour
            this.x = x; //its x pos
            this.y = y; //its y pos
            //can't provide anything else as "shape" is too general
        }

        public abstract void draw(Graphics g); //any derrived class must implement this method

        public override string ToString()
        {
            return base.ToString()+"    "+this.x+","+this.y+" : ";
        }

    }
}


