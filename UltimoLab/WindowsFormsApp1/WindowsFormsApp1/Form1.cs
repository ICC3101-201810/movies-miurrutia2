using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<Persona> Personas = new List<Persona>();
        public List<Pelicula> Peliculas = new List<Pelicula>();
        public List<Estudio> Estudios = new List<Estudio>();
        public List<PeliculaActor> peliculaactor = new List<PeliculaActor>();
        public List<PeliculaProductor> peliculaproductor = new List<PeliculaProductor>();
        public BasedeDatos basedato;
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 frm7 = new Form7();
            frm7.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            
            BinaryFormatter bin = new BinaryFormatter();
            Stream stream = new FileStream("../../Serializado.txt", FileMode.Create, FileAccess.Write);
            bin.Serialize(stream, basedato);
            stream.Close();
            base.OnFormClosing(e);

        }

        


    }
}
