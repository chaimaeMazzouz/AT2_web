using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AT2_web
{
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            calDate.Visible = false;
        }

        protected void listMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            calDate.Visible = true;
            switch (listMatch.SelectedIndex)
            {
                case 1:
                    calDate.SelectedDate = new DateTime(2016, 02, 16);
                    calDate.VisibleDate = calDate.SelectedDate;
                    lblMatchs.Text = "Match : " + listMatch.Text + "<br>Le : " + calDate.SelectedDate.ToShortDateString();
                    break;
                case 2:
                    calDate.SelectedDate = new DateTime(2016, 02, 16);
                    calDate.VisibleDate = calDate.SelectedDate;
                    lblMatchs.Text = "Match : " + listMatch.Text + "<br>Le : " + calDate.SelectedDate.ToShortDateString();
                    break;
                case 3:
                    calDate.SelectedDate = new DateTime(2016, 02, 17);
                    calDate.VisibleDate = calDate.SelectedDate;
                    lblMatchs.Text = "Match : " + listMatch.Text + "<br>Le : " + calDate.SelectedDate.ToShortDateString();
                    break;
                default:
                    calDate.Visible = false;
                    lblMatchs.Text = "";
                    break;
            }
        }
    }  }