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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        CSharpBootCampTravelDbEntities db = new CSharpBootCampTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var locations = db.Locations.Select(l => new
            {
                l.LocationId,
                l.City,
                l.Country,
                l.Capacity,
                l.Price,
                l.DayNight,
                Guides = l.Guides.GuideName + " " + l.Guides.GuideSurname
            }).ToList();
            dgvLocations.DataSource = locations;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var guides = db.Guides.Select(g => new
            {
                FullName = g.GuideName + " " + g.GuideSurname,
                g.GuideId
            }).ToList();

            cbxGuides.DisplayMember = "FullName";
            cbxGuides.ValueMember = "GuideId";
            cbxGuides.DataSource = guides;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Locations location = new Locations();
            location.Capacity = byte.Parse(nudCapacity.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cbxGuides.SelectedValue.ToString());
            db.Locations.Add(location);
            db.SaveChanges();
            MessageBox.Show("Location Added Successfully");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeLocation = db.Locations.Find(id);
            db.Locations.Remove(removeLocation);
            db.SaveChanges();
            MessageBox.Show("Location Deleted Successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateLocation = db.Locations.Find(id);
            updateLocation.DayNight = txtDayNight.Text;
            updateLocation.Price = decimal.Parse(txtPrice.Text);
            updateLocation.Capacity = byte.Parse(nudCapacity.Value.ToString());
            updateLocation.City = txtCity.Text;
            updateLocation.Country = txtCountry.Text;
            updateLocation.GuideId = int.Parse(cbxGuides.SelectedValue.ToString());
            db.SaveChangesAsync();
            MessageBox.Show("Location Updated Successfully");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var getLocation = db.Locations.Where(x => x.LocationId == id).ToList();
            dgvLocations.DataSource = getLocation;
        }
    }
}
