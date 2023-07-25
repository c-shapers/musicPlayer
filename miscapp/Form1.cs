using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miscapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Create Global variables of string type to save songs and details
        String[] paths, files;


        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
                }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }

        private void bunifuShapes1_ShapeChanged(object sender, Bunifu.UI.WinForms.BunifuShapes.ShapeChangedEventArgs e)
        {

        }

        private void bunifuShapes1_ShapeChanged_1(object sender, Bunifu.UI.WinForms.BunifuShapes.ShapeChangedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlaying_Click(object sender, EventArgs e)
        {
            indicator.Top = btnPlaying.Top+6;
            bunifuPages1.SetPage(0);
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            indicator.Top = btnExplore.Top+7;
            bunifuPages1.SetPage(1);
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuRange1_RangeChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
           
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
                    }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code to play Music
            player.URL = paths[listBoxSongs.SelectedIndex];

            bunifuPages1.SetPage(0);
            indicator.Top = btnPlaying.Top + 6;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            lblHeader.Text = player.status + " Playing...";
            imgVisualize.Visible = player.status.ToLower().Contains("playing");

        }

        private void player_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (player.status.ToLower().Contains("playing"))
            {
                player.Ctlcontrols.pause();
            }
            else
            {
                player.Ctlcontrols.play();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void volume_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (player.status.ToLower().Contains("playing"))
            {
            slider.Maximum = (int)player.Ctlcontrols.currentItem.duration;
            lblTime.Text = player.Ctlcontrols.currentPositionString;
            slider.Value = (int)player.Ctlcontrols.currentPosition;
            }
        }

        private void slider_MouseUp(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = slider.Value;
        }

        private void slider_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
           
        }
    

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            //Code to import songs
            OpenFileDialog ofd = new OpenFileDialog();

            // Code to select multiple songs
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //save names of songs
                paths = ofd.FileNames; //save the path of songs

                //Display songs in listBox
                for (int i=0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); //Display songs in listbox
                }
            }
        }
    }
}
