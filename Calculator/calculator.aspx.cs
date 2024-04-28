using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculatorService.WebService1SoapClient obj = new CalculatorService.WebService1SoapClient();
            int sum = obj.Add(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text));
            int mul = obj.mul(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text));
            lblMul.Text=mul.ToString();
            lblSum.Text=sum.ToString();

            
            gvCalculation.DataSource = obj.GetCalculation();
            gvCalculation.DataBind();
            gvCalculation.HeaderRow.Cells[0].Text = "Recents Calculations";
            resMul.Visible = true;
            resSum.Visible = true;  

        }
    }
}