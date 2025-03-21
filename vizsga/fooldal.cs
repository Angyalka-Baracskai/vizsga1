using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizsga
{
    public partial class fooldal : Form
    {
        public fooldal()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tanar_Click(object sender, EventArgs e)
        {
            tanar form2 = new tanar(); // példányosítottuk a Form2 osztályt
            this.Hide(); // elrejtettük a fooldal ablakot
            form2.FormClosed += (sendObject, args) =>
            {
                // eltávolítjuk a lehetséges hivatkozásokat a Form2 objektumra
                form2.Dispose(); // lefoglalt erőforrások felszabadítása
                form2 = null; // semmivé tesszük a Form2 objektumot
                GC.Collect(); // szemétgyűjtő futtatása
                this.Show(); // Ha a hívott ablak megszűnt, térjen vissza ide
            };
            form2.Show(); // megjelenítettük a Form1 ablakot
        }

        private void diak_Click(object sender, EventArgs e)
        {
            diak form3 = new diak(); // példányosítottuk a Form3 osztályt
            this.Hide(); // elrejtettük a fooldal ablakot
            form3.Show(); // megjelenítettük a Form3 ablakot
            form3.FormClosed += (sendObject, args) =>
            {
                // eltávolítjuk a lehetséges hivatkozásokat a Form3 objektumra
                form3.Dispose(); // lefoglalt erőforrások felszabadítása
                form3 = null; // semmivé tesszük a Form1 objektumot
                GC.Collect(); // szemétgyűjtő futtatása
                this.Show(); // Ha a hívott ablak megszűnt, térjen vissza ide
            };
            form3.Show(); // megjelenítettük a Form1 ablakot
        }

        private void tantargy_Click(object sender, EventArgs e)
        {
            
            tantargy form4 = new tantargy(); // példányosítottuk a Form4 osztályt
            this.Hide(); // elrejtettük a fooldal ablakot
            form4.Show(); // megjelenítettük a Form4 ablakot
            form4.FormClosed += (sendObject, args) =>
            {
                // eltávolítjuk a lehetséges hivatkozásokat a Form4 objektumra
                form4.Dispose(); // lefoglalt erőforrások felszabadítása
                form4 = null; // semmivé tesszük a Form4 objektumot
                GC.Collect(); // szemétgyűjtő futtatása
                this.Show(); // Ha a hívott ablak megszűnt, térjen vissza ide
            };
            form4.Show(); // megjelenítettük a Form1 ablakot
        }

        private void fooldal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult valasztasEredmenye = MessageBox.Show("Valóban szeretne kilépni?","Exit alert", MessageBoxButtons.YesNo);
            if (valasztasEredmenye == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // én github oldalam linkje, ha rámegy megnyitjta az oldalam
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Angyalka-Baracskai",
                UseShellExecute = true
            });
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Peti github oldal linkje, ha rámegy megnyitjta az oldala

            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/P3T8",
                UseShellExecute = true
            });
        }

        public bool sun = true;
        //string[] labels = new Label[] { label1, label2, label3};

    private void pictureBox3_Click(object sender, EventArgs e)
        {
           if(sun == true)
           {
                this.BackColor = Color.White;
           }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            /*if (sun != true)
            {
                this.BackColor = Color.Black;
                labels.ForeColor = Color.Black;
            }*/
        }
    }
}
