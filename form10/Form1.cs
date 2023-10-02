using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int kenar1, kenar2, Alan, Cevre;

            kenar1 = Convert.ToInt32(txtKenar1.Text);
            kenar2 = Convert.ToInt32(txtKenar2.Text);

            Alan = kenar1 * kenar2;
            Cevre = kenar1 * 2 + kenar2 * 2;

            lblAlan.Text ="dikdörtgen alanı :" +  Alan.ToString();
            lblCevre.Text ="dikdörten çevresi :" + Cevre.ToString();
        }
    }
}
