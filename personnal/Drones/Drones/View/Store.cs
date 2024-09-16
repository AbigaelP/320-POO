using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Store
    {

        public new void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse (droneBrush, new Rectangle(X, Y, Largeur, Profondeur));
        }
    }
}
