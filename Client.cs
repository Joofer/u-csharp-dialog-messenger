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
    public partial class Client : System.Windows.Forms.Form
    {
        private Client C1, C2;
        private string name;

        public Client(string n)
        {
            InitializeComponent();
            name = n;
        }

        public void Initialise(ref Client c1, ref Client c2)
        {
            Text = name;

            C1 = c1;
            C2 = c2;

            labelSendMessage.Text = "Отправить сообщение";
            labelStatus.Text = "";
            buttonSend1.Text = "Отправить " + C1.GetName();
            buttonSend2.Text = "Отправить " + C2.GetName();
        }

        public void Send(string message, string sender, string receiver)
        {
            listBoxMessages.Items.Add(sender + " - " + receiver + ": " + message);
        }

        public string GetName()
        {
            return name;
        }

        private void buttonSend1_Click(object sender, EventArgs e)
        {
            Send(textBoxMessage.Text, name, C1.GetName());
            C1.Send(textBoxMessage.Text, name, C1.GetName());
            C2.Send(textBoxMessage.Text, name, C1.GetName());
            textBoxMessage.Text = "";
        }

        private void buttonSend2_Click(object sender, EventArgs e)
        {
            Send(textBoxMessage.Text, name, C2.GetName());
            C1.Send(textBoxMessage.Text, name, C2.GetName());
            C2.Send(textBoxMessage.Text, name, C2.GetName());
            textBoxMessage.Text = "";
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Main.Exit();
        }
    }
}
