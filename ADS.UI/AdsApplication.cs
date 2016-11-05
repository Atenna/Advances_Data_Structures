using System.Windows.Forms;
using ADS.Core.Domain.Controller;

namespace Advanced_Data_Structures
{
    public partial class AdsApplication : Form
    {
        private LibraryController _ctrl;
        public AdsApplication()
        {
            InitializeComponent();
            _ctrl = new LibraryController();
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            richTextBox1.Text = _ctrl.SearchBookByName("hau");
        }
    }
}
