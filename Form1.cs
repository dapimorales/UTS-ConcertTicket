using UTS_ConcertTicket.UI;

namespace UTS_ConcertTicket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var main = new Frm_MainDashboard(null);
            main.ShowDialog();
        }
    }
}
