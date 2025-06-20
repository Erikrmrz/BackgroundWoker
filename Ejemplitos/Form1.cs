using System.Media;
using System.Numerics;
namespace Ejemplitos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SOUND PLAYER
        private void ReportStatus(string statusMessage)
        {
            // If the caller passed in a message...
            if (!string.IsNullOrEmpty(statusMessage))
            {
                // ...post the caller's message to the status bar.
                //this.statusBar.Panels[0].Text = statusMessage;
            }
        }
        SoundPlayer player = new SoundPlayer();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Assign the selected file's path to 
                // the SoundPlayer object.  
                player.SoundLocation = this.textBox1.Text;

                // Load the .wav file.
                player.LoadAsync();
            }
            catch (Exception ex)
            {
                ReportStatus(ex.Message);
            }
        }
        //PICTURE BOX

        private void button2_Click(object sender, EventArgs e)
        {
            // Ensure WaitOnLoad is false.
            pictureBox1.WaitOnLoad = false;
            string ruta = textBox2.Text;

            // Load the image asynchronously.
            pictureBox1.LoadAsync(ruta);
        }
        

    }
}
