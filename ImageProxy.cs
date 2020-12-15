using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ImageProxy
    {
        private bool done;
        private Timer timer;
        public ImageProxy()
        {
            //se crea un hilo temporizador y se comienza, se le asigna un tiempo de 5 segundos
            timer = new Timer(
             new TimerCallback(timerCall), this, 5000, 0);
        }
        
        //Este método se ejecuta cuando se  completa el temporizador
        private void timerCall(object obj)
        {
            done = true;
            timer.Dispose();
        }

        /*Dependiendo del estado del método anterior, se retorna una clase
         *u otra, es decir, al dar click sobre el botón, se comienza el temporizador
         * retorna una imagen inicialmente, pasados los 5 segundos si se vuelve hacer click 
         * la imagen cambia
         */
        public Image getImage()
        {
            Imager img;
            if (done)
                img = new FinalImage();
            else
                img = new QuickImage();
            return img.getImage();
        }
    }
}
