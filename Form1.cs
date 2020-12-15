using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyPattern
{
    public partial class Form1 : Form
    {
        /*Se crea una instancia de la clase ImageProxy, y se accede al método
         * getImage() que permite cargar la imagen
         */
        private ImageProxy imgProxy;
        
        private void init()
        {
            imgProxy = new ImageProxy();
        }
        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            picImage.Image = imgProxy.getImage();
        }
    }
}
