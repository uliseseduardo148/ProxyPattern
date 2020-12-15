using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
   public class QuickImage:Imager
    {
        public QuickImage() { }
        public Image getImage()
        {
        return new Bitmap("C:\\Users\\cliente-preferido\\source\\repos\\ProxyPattern\\java.png");
        }
    }
}
