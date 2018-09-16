using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class MonteCarlo : MetroFramework.Forms.MetroForm
    {
        public MonteCarlo()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue600, Primary.LightBlue600, Primary.Lime500, Accent.LightBlue200, TextShade.WHITE);
        }

              private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {
            error.Visible = false;
        }


              private void materialRaisedButton1_Click(object sender, EventArgs e)
              {
                  if (CostPrice.TextLength == 0 || MaxCustomers.TextLength == 0 || Stocktf.TextLength == 0 || SellingPricetf.TextLength == 0 || Weeks.TextLength == 0 || Dec.TextLength == 0 || Change.TextLength == 0)
                  {
                      System.Media.SystemSounds.Exclamation.Play();
                      error.Text="One or more Fields are Empty!";
                      error.Visible = true;
                  }
                  else
                  {

                      MonteCarlo2 mc = new MonteCarlo2();

                      double costprice = Convert.ToDouble(CostPrice.Text);
                      int MaxCustomer = Convert.ToInt32(MaxCustomers.Text);
                      int stock = Convert.ToInt32(Stocktf.Text);
                      double MaxSellingPrice = Convert.ToDouble(SellingPricetf.Text);
                      int week = Convert.ToInt32(Weeks.Text);
                      int Decrease = Convert.ToInt32(Dec.Text);
                      double change = Convert.ToDouble(Change.Text);

                      bestSell.Text = Convert.ToString(mc.PriceEstimation(costprice, MaxCustomer, week, stock, Decrease, change, MaxSellingPrice)) + " Rs";
                      stockLeft.Text = Convert.ToString(mc.stockleft2);
                      customerPerDay.Text = Convert.ToString(mc.CustomerPday2);
                      profit.Text = Convert.ToString(mc.temp2) + " Rs";
                  }
              }
        private void CostPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)||e.KeyChar==8) 
            {
                if (CostPrice.Text.Equals("") && e.KeyChar == 8)
                {
                    SystemSounds.Exclamation.Play();
                }
                else
                {
                    e.Handled = false;
                }
            }
            
            else
            {
                SystemSounds.Exclamation.Play();
                e.Handled = true;
            }

        }

        private void MaxCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                if (MaxCustomers.Text.Equals("") && e.KeyChar == 8)
                {
                    SystemSounds.Exclamation.Play();
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
                e.Handled = true;
            }

        }

        private void Stocktf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                if (Stocktf.Text.Equals("") && e.KeyChar == 8)
                {
                    SystemSounds.Exclamation.Play();
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
                e.Handled = true;
            }
        }

        private void SellingPricetf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                if (SellingPricetf.Text.Equals("") && e.KeyChar == 8)
                {
                    SystemSounds.Exclamation.Play();
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
                e.Handled = true;
            }
        }

        private void Change_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                if (Change.Text.Equals("") && e.KeyChar == 8)
                {
                    SystemSounds.Exclamation.Play();
                }
                else
                {
                    e.Handled = false;
                }
                e.Handled = false;
            }
            else
            {
                SystemSounds.Exclamation.Play();
                e.Handled = true;
            }
        }

        private void Dec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                if (Dec.Text.Equals("") && e.KeyChar == 8)
                {
                    SystemSounds.Exclamation.Play();
                }
                else
                {
                    e.Handled = false;
                }
                e.Handled = false;
            }
            else
            {
                SystemSounds.Exclamation.Play();
                e.Handled = true;
            }
        }

        private void Weeks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                if (Weeks.Text.Equals("") && e.KeyChar == 8)
                {
                    SystemSounds.Exclamation.Play();
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
                e.Handled = true;
            }
        }

        private void CostPrice_Click(object sender, EventArgs e)
        {
            error.Visible = false;
        }

        private void Stocktf_Click(object sender, EventArgs e)
        {
            error.Visible = false;
        }

        private void SellingPricetf_Click(object sender, EventArgs e)
        {
            error.Visible = false;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            error.Visible = false;
        }

        private void Dec_Click(object sender, EventArgs e)
        {
            error.Visible = false;
        }

        private void Weeks_Click(object sender, EventArgs e)
        {
            error.Visible = false;
        }
    }
}
