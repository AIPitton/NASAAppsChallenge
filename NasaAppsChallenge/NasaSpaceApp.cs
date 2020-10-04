using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NasaAppsChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnEarthProCent_Click(object sender, EventArgs e)
        {
            int travelTimeEarthProCent = (497*286770)/86400;
            displayEarthProCent.Text = travelTimeEarthProCent.ToString("n0")+" days";
        }

        private void bttnEarthGalacticCenter_Click(object sender, EventArgs e)
        {
            int travelTimeEarthGalCent = (497 * 1680000) / 86400;
            displayEarthGalacticCenter.Text = travelTimeEarthGalCent.ToString("n0") + " days";            
        }

        private void bttnEarthBarnardsStar_Click(object sender, EventArgs e)
        {
            int travelTimeEarthBarnardsStar = (497 * 383586) / 86400;
            displayEarthBarnardsStar.Text = travelTimeEarthBarnardsStar.ToString("n0") + " days";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
