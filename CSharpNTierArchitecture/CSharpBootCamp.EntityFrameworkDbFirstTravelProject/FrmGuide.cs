using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBootCamp.EntityFrameworkDbFirstTravelProject
{
    public partial class FrmGuide : Form
    {
        public FrmGuide()
        {
            InitializeComponent();
        }
        CSharpBootCampTravelDbEntities db = new CSharpBootCampTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Guides.ToList();
            dgvGuides.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guides guide = new Guides();
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;
            db.Guides.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Guide Added Successfully");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeGuide = db.Guides.Find(id);
            db.Guides.Remove(removeGuide);
            db.SaveChanges();
            MessageBox.Show("Guide Deleted Successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateGuide = db.Guides.Find(id);
            updateGuide.GuideName = txtName.Text;
            updateGuide.GuideSurname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Guide Updated Successfully");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var getGuide = db.Guides.Where(x => x.GuideId == id).ToList();
            dgvGuides.DataSource = getGuide;
        }
    }
}
