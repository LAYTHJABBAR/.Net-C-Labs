using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// app to calculate the Power consumption bill
// Author: Layth Al-shareefi
// date: April- 2020

namespace customerbill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // set the Residential radio button to true when the Application start
            radResidential.Checked = true;
            if (radResidential.Checked == true)
            {
                lblInformation.Text = "Information about Residential Plan";
                txtInformation.Text = "$6.00 plus $0.052 for each kWh used ($6.00 is charged even when kWh usage is zero)";
            }
        }

        // assign the application constants

        const double RES_FLAT_RATE = 6.00;
        const double COMM_FLAT_RATE = 60.00;
        const double IND_FLAT_OFF_RATE = 40.00;
        const double IND_FLAT_RATE = 76.00;
        const double RES_CHA_RATE = 0.052;
        const double COMM_CHA_RATE = 0.045;
        const double IND_CHA_OFF_RATE = 0.028;
        const double IND_CHA_RATE = 0.065;

        // methode to show the residential plan information
        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            pnlOffPeak.Visible = false;
            lblInformation.Text = "Information about Residential Plan";
            txtInformation.Text = "$6.00 plus $0.052 for each kWh used ($6.00 is charged even when kWh usage is zero)";
            lblw1.Text = "KWH Used";
            lbl1.Text = "Please Enter How Many KWH was Used";

        }

        // methode to show the commercial plan information
        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            pnlOffPeak.Visible = false;
            pnlCalculated.Visible = false;
            txtKWH.Text = "";
            lblInformation.Text = "Information about Commercial Plan";
            txtInformation.Text = "Flat rate of $60.00 for the first 1000 kWh used (or part of, even when zero), and $0.045 for each additional kWh";
            lblw1.Text = "KWH Used";
            lbl1.Text = "Please Enter How Many KWH was Used";
        }

        // methode to show the industerial  plan information
        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            pnlOffPeak.Visible = true;
            txtKWH.Text = "";
            lblInformation.Text = "Information about Industrial Plan";
            txtInformation.Text = "Rate depends on whether usage occurred during peak hours or off-peak hours \n " +
                " 1- Peak hours: Flat rate of $76.00 for the first 1000 kWh used(or part of, even when zero), and $0.065 for each additional kWh \n" +
                "2- Off - peak hours: Flat rate of $40.00 for the first 1000 kWh used(or part of, even when zero), and $0.028 for each additional kWh";
            lblw1.Text = "KWH Used in Peak Hours";
            lbl1.Text = "Type here Only KWH Used in peak hours";

        }

        // Calculate button methode
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (Validator.IsPresent(txtKWH, lblw1.Text) && Validator.IsNonNegativeInteger(txtKWH, lblw1.Text))
            {
                double KWH = Convert.ToDouble(txtKWH.Text);
                if (radResidential.Checked == true)
                {
                    residental(KWH, out double rate);
                    outPut(rate);
                }

                else if (radCommercial.Checked == true)
                {
                    Commercial(KWH, out double rate);
                    outPut(rate);
                }


                if (radIndustrial.Checked == true)
                {
                    if (Validator.IsPresent(txtKWH2, lblw2.Text) && 
                        Validator.IsNonNegativeInteger(txtKWH2, lblw2.Text))
                    {

                        double KWHOffPeak = Convert.ToDouble(txtKWH2.Text);
                        IndusterialPeak(KWH, out double rate);
                        IndusterialOffPeak(KWHOffPeak, out double rateOff);
                        double totalRate = rate + rateOff;
                        txtCalculated.Text = totalRate.ToString("c");
                        pnlCalculated.Visible = true;
                    }
                }

                void outPut(double rate)
                {
                    txtCalculated.Text = rate.ToString("c");
                    pnlCalculated.Visible = true;
                }
            }
            
        }

        // methode to calculate the Residental  bill
        private void residental(double KWH, out double rate)
            {
            rate = KWH * RES_CHA_RATE + RES_FLAT_RATE;
            }

        // methode to caculate the Commercial bill
        private void Commercial(double KWH, out double rate)
        {
            if (KWH < 1000)
            {
                rate = COMM_FLAT_RATE;
            }
            else
            {
                rate = COMM_FLAT_RATE + ((KWH - 1000) * COMM_CHA_RATE);
            }
        }
        //methode to Calculate the Industerial Peak-hours bill
        private void IndusterialPeak(double KWH, out double rate)
        {
            if (KWH < 1000)
            {
                rate = IND_FLAT_RATE;
            }
            else
            {
                rate = IND_FLAT_RATE + ((KWH - 1000) * IND_CHA_RATE);
            }
        }

        // methode to Calcute the Indestrial Off-peak hours
        private void IndusterialOffPeak(double KWHOffPeak, out double rateOff)
        {
            if (KWHOffPeak < 1000)
            {
                rateOff = IND_FLAT_OFF_RATE;
            }
            else
            {
                rateOff = IND_FLAT_OFF_RATE + ((KWHOffPeak - 1000) * IND_CHA_OFF_RATE);
            }
        }

        // Reset key Methode
        private void btnReset_Click(object sender, EventArgs e)
        {
            pnlCalculated.Visible = false;
            txtCalculated.Text = "";
            radResidential.Checked = true;
            txtKWH.Text = "";
        }

        // Exit Button Methode

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
