using System.Windows.Forms;
using EmployeeInformationSystem.BLL;
using EmployeeInformationSystem.DAL.DAO;

namespace EmployeeInformationSystem.UI
{
    public partial class DesignationUI : Form
    {
        public DesignationUI()
        {
            InitializeComponent();
        }

        private void saveDesignationButton_Click(object sender, System.EventArgs e)
        {
            DesignationManager aDesignationManager = new DesignationManager();
            Designation aDesignation = new Designation();
            aDesignation.Code = codeTextBox.Text;
            aDesignation.Title = titleTextBox.Text;
            string msg = aDesignationManager.Save(aDesignation);
            MessageBox.Show(msg);
        }
    }
}
