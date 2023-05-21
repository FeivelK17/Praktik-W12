using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktik_W12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuStrip Menu = new MenuStrip();
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDPLAYER addPlayer = new ADDPLAYER();
            addPlayer.Show();
        }
    }
}
