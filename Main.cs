using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u14
{
    public partial class Main : System.Windows.Forms.Form
    {
        static Main main;
        static Client C1, C2, C3;

        public Main()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Initialise();
        }

        private void Initialise()
        {
            main = this;

            C1 = new Client("Клиент 1");
            C2 = new Client("Клиент 2");
            C3 = new Client("Клиент 3");

            C1.Initialise(ref C2, ref C3);
            C2.Initialise(ref C1, ref C3);
            C3.Initialise(ref C1, ref C2);

            C1.Show();
            C2.Show();
            C3.Show();
        }

        public static void Exit()
        {
            main.Close();
        }
    }
}
