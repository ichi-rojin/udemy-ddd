using DDD.WinForm.Common;
using System;
using System.Windows.Forms;

namespace DDD.WinForm
{
    public partial class WeatherLatestView : Form
    {

        public string CommonCOnst { get; private set; }

        public WeatherLatestView()
        {
            InitializeComponent();
        }

        private void WeatherLatestView_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LatestButton_Click(object sender, EventArgs e)
        {
            var dt = Data.WeatherSQLite.GetLatest(Convert.ToInt32(AreaIdTextBox.Text));
            if (dt.Rows.Count > 0)
            {
                DataDateLabel.Text = dt.Rows[0]["DataDate"].ToString();
                ConditionLabel.Text = dt.Rows[0]["Condition"].ToString();
                TemperatureLabel.Text =
                   CommonFunc.RoundString(
                       Convert.ToSingle(dt.Rows[0]["Temperature"]),
                       CommonConst.TemperatureDecimalPoint)
                       + CommonConst.TemperatureUnitName;
            }
        }

    }
}
