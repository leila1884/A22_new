using System;
using System.Windows.Forms;
using Logic_ClassLibrary;

namespace A22
{
    public partial class Form1 : Form
    {
        public CustomerDetails customerDetails;
        public Form1()
        {
            InitializeComponent();

            customerDetails = new CustomerDetails();
        }

        public void button_calculate_Click(object sender, EventArgs e)
        {
            customerDetails.FirstName = textBox_Fname.Text;
            customerDetails.LastName = textBox_Lname.Text;
            customerDetails.Address = textBox_address.Text;
            customerDetails.Email = textBox_email.Text;
            customerDetails.Mobile = textBox_mobile.Text;

            // Get membership type from radio buttons
            if (radioButton_basic.Checked)
            {
                customerDetails.MembershipType = new MembershipType("Basic", 10);
            }
            else if (radioButton_regular.Checked)
            {
                customerDetails.MembershipType = new MembershipType("Regular", 15);
            }
            else if (radioButton_premium.Checked)
            {
                customerDetails.MembershipType = new MembershipType("Premium", 20);
            }

            // Get membership duration from radio buttons
            if (radioButton_3mths.Checked)
            {
                customerDetails.MembershipDuration = new MembershipDuration(3);
            }
            else if (radioButton_12mths.Checked)
            {
                customerDetails.MembershipDuration = new MembershipDuration(12);
            }
            else if (radioButton_24mths.Checked)
            {
                customerDetails.MembershipDuration = new MembershipDuration(24);
            }

            // Get payment option from radio buttons
            bool isDirectDebit = radioButton_debitYes.Checked;
            customerDetails.PaymentOption = new PaymentOption(isDirectDebit);


            // Get extras from form inputs (example: assume these are CheckBox selections)
            bool access247 = checkBox_247access.Checked;
            bool personalTrainer = checkBox_personalTrainer.Checked;
            bool dietConsultation = checkBox_dietCons.Checked;
            bool onlineFitnessVideos = checkBox_accessOnline.Checked;
            customerDetails.Extras = new Extras(access247, personalTrainer, dietConsultation, onlineFitnessVideos);

            // Display customer details
            customerDetails.DisplayCustomerDetails();

            // Calculate and display costs
            MembershipCost cost = new MembershipCost(customerDetails);
            cost.DisplayCostDetails();

            double totalCost = cost.CalculateTotalCost();
            double regularPayment = cost.CalculateRegularPaymentAmount();

           

            // Print Invoice
            InvoicePrinter printer = new InvoicePrinter(customerDetails, cost);
            printer.PrintInvoice("invoice.txt");
        }

        
    }
}
