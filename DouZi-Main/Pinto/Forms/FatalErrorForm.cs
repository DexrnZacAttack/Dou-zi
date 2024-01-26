using System.Media;
using System.Windows.Forms;

namespace PintoNS.Forms
{
    public partial class FatalErrorForm : Form
    {
        private void FatalErrorForm_Load(object sender, System.EventArgs e)
        {
            SystemSounds.Hand.Play();
        }
        /*        public FatalErrorForm()
       {
           InitializeComponent();
           Icon = Program.GetFormIcon();
       }*/
    }
}
