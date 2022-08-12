using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarV2
{
    public partial class EventAdder : Form
    {
        public BtnMonth refBtn;
        public EventAdder(object btn)
        {
            refBtn = btn as BtnMonth;
            InitializeComponent();
            lblDate.Text += refBtn.date.ToLongDateString();
            if (refBtn.isHoliday)
            {
                tbTitle.Text = refBtn.holiday.title;
                tbDetails.Text = refBtn.holiday.details;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text.Equals(""))
            {
                MessageBox.Show("Title cannot be empty!","Error");
            }
            else
            {
                refBtn.holiday = new Holiday(tbTitle.Text, tbDetails.Text);
                this.Close();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Holiday newHoliday = new Holiday(tbTitle.Text, tbDetails.Text);
            if (refBtn.holiday.isEqual(newHoliday))
            {
                refBtn.holiday = null;
            }

            this.Close();
        }


    }
}
