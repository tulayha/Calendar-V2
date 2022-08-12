using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CalendarV2
{
    
    public partial class Calendar : Form
    {
        private string path = "Holidays.txt";
        private int index = 0;
        private Dictionary<string, Holiday> lsHolidays = new Dictionary<string, Holiday>();

        #region Initialize form and set up grid
        public Calendar()
        {
            checkFile();
            InitializeComponent();
            SetCalendar();
            setDates();
            this.FormClosing += Calendar_FormClosing;
        }

        private void SetCalendar()
        {
            BtnMonth btnDay = new BtnMonth();
            flPnlGrid.Size = new System.Drawing.Size((btnDay.Size.Width + btnDay.Margin.All * 2) * 7, (btnDay.Size.Height + btnDay.Margin.All * 2) * 6);
            fpPanelDaylbl.Size = new System.Drawing.Size((btnDay.Size.Width + btnDay.Margin.All * 2) * 7, (btnDay.Size.Height + btnDay.Margin.All * 2));
            foreach (Label lbl in fpPanelDaylbl.Controls)
            {
                lbl.Size = btnDay.Size;
            }
            for (int i = 0; i < 6 * 7; i++)
            {
                btnDay = new BtnMonth();
                flPnlGrid.Controls.Add(btnDay);
                btnDay.Click += btnDay_Click;
            }

        }

        #endregion

        #region Update calendar values
        private void setDates(int indexMonth = 0)
        {
            DateTime refDate = DateTime.Now.AddMonths(indexMonth);
            refDate = new DateTime(refDate.Year, refDate.Month, 1);
            int firstDayMonth = (int) refDate.DayOfWeek;
            int startDate = firstDayMonth == 7 ? 0 : -firstDayMonth;
            ttPopup.RemoveAll();
            lblDispMY.Text = refDate.ToString("MMMM yyyy");
            foreach (BtnMonth e in flPnlGrid.Controls)
            {
                e.date = refDate.AddDays(startDate++);
                if (lsHolidays.ContainsKey(e.date.ToShortDateString()))
                {
                    e.holiday = lsHolidays[e.date.ToShortDateString()];
                    string txt = "Holiday!" + Environment.NewLine + "Title: " + e.holiday.title + (e.holiday.details != "" ?  Environment.NewLine + "Details: " + e.holiday.details : "");
                    ttPopup.SetToolTip(e, txt);
                }
                e.isCurrentMonth(refDate);
            }
        }

        #endregion

        #region Button Click Handlers
        private void btnDay_Click(object sender, EventArgs e)
        {
            BtnMonth btn = sender as BtnMonth;
            EventAdder AdderForm = new EventAdder(btn);
            AdderForm.ShowDialog();
            if (btn.holidayChanged)
            {
                if (btn.holiday == null || btn.holiday.isEmpty)
                {
                    if (lsHolidays.ContainsKey(btn.date.ToShortDateString()))
                    {
                        lsHolidays.Remove(btn.date.ToShortDateString());
                    }
                    ttPopup.SetToolTip(btn, null);
                }
                else
                {
                    if (lsHolidays.ContainsKey(btn.date.ToShortDateString()))
                    {
                        lsHolidays[btn.date.ToShortDateString()] = btn.holiday;
                    }
                    else { lsHolidays.Add(btn.date.ToShortDateString(), btn.holiday); }
                    string txt = "Holiday!" + Environment.NewLine + "Title: " + btn.holiday.title + (btn.holiday.details != "" ? Environment.NewLine + "Details: " + btn.holiday.details : "");
                    ttPopup.SetToolTip(btn, txt);
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            setDates(--index);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            setDates(++index);
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            index = 0;
            setDates();
        }

        #endregion

        #region Timer Handler
        private void timerOneSec_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }
        #endregion

        #region File Loader/Saver operations
        private void checkFile()
        {
            if (File.Exists(path))
            {
                string[] tempDataF = File.ReadAllLines(path);
                if (tempDataF != null)
                {

                    foreach (string evnt in tempDataF)
                    {
                        string[] data = evnt.Split('#');
                        string[] details = data[1].Split('%');
                        lsHolidays.Add(data[0], new Holiday(details[0], details[1]));
                    }
                }
            }
        }

        private void Calendar_FormClosing(object sender, FormClosingEventArgs e)
        {
               File.Delete(path);
               foreach (var item in lsHolidays)
               {
                   File.AppendAllText(path, item.Key + "#" + item.Value.title + "%" + item.Value.details + Environment.NewLine);
               }
        }

        #endregion
    }
}
