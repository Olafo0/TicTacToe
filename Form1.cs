using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac
{
    public partial class Form1 : Form
    {
        public Game game { get; set; }
        public Form1()
        {
            InitializeComponent();
            game = new Game();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            var button = ((Button)sender);

            game.GameTurn(button);
            game.HasWon(button);
        }
    }
}
