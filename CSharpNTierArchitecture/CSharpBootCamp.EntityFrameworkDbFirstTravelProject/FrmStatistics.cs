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
    public partial class FrmStatistics : Form
    {
        CSharpBootCampTravelDbEntities db = new CSharpBootCampTravelDbEntities();
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Locations.Count().ToString();
            lblSumCapacity.Text = db.Locations.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guides.Count().ToString();
            lblAvgCapacity.Text = ((double)db.Locations.Average(x => x.Capacity)).ToString("F2");
            lblAvgLocationPrice.Text = db.Locations.Average(x => x.Price).ToString() + " ₺";

            int lastCountryId = db.Locations.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Locations.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();

            lblCappadociaLocationCapacity.Text = db.Locations.Where(x => x.City == "Cappadocia").Select(y => y.Capacity).FirstOrDefault().ToString();

            lblTurkeyCapacityAvg.Text = db.Locations.Where(x => x.Country == "Turkey").Average(y => y.Capacity).ToString();

            var romeGuideId = db.Locations.Where(x => x.City == "Rome").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guides.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            var maxCapacity = db.Locations.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.Locations.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();

            var maxPrice = db.Locations.Max(x => x.Price);
            lblMaxPriceLocation.Text = db.Locations.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();

            var guideIdByNameOzgeSengezer = db.Guides.Where(x => x.GuideName == "Özge" && x.GuideSurname == "Şengezer").Select(y => y.GuideId).FirstOrDefault();
            lblOzgeSengezerLocation.Text = db.Locations.Where(x => x.GuideId == guideIdByNameOzgeSengezer).Count().ToString();
        }
    }
}
