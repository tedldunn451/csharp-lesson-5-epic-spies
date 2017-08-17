using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lesson_5_epic_spies
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Sets default dates
                endPreviousCalendar.SelectedDate = DateTime.Now.Date;
                startNewCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                endNewCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            }

        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            double COST_PER_DAY = 500.00;
            double BONUS = 1000.00;
            double totalCost = 0.00;

            /* Returns an error message to user if there are not at least 14 days between the end of 
             a previous assignment and the start of a new assignment. Otherwise, returns the total 
             cost of the budgeted assignment possibly including a 1000 dollar bonus if the assigment is 
             more than 3 weeks in length. */
            if (startNewCalendar.SelectedDate.Subtract(endPreviousCalendar.SelectedDate).Days < 14)
            {
                resultLabel.Text = "Error: Must allow at least two weeks between previous assignment and new assignment.";
                startNewCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
            } 
            else
            { 
                int assignmentLength = endNewCalendar.SelectedDate.Subtract(startNewCalendar.SelectedDate).Days;

                if (assignmentLength > 21)
                {
                    totalCost = (assignmentLength * COST_PER_DAY) + BONUS;
                }
                else
                {
                    totalCost = assignmentLength * COST_PER_DAY;
                }

                resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}",
                                                    codeNameTextBox.Text, assignmentNameTextBox.Text, totalCost);
            }
        }
    }
}