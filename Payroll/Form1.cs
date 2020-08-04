using Objects2;
using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Text;
using System.Data;

namespace Payroll
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        public bool PayrollFileExists { get; private set; }

        public void Form1_Load(object sender, EventArgs e)
        {

            // Set all of the input boxes to zero
            QtyInput.Text = "0";
            PayRateInput.Text = "0";
            ExtraInput.Text = "0";

            // Find the most recently saved file in the Archive directory.
            string Folder = @"C:\Users\pdevine\OneDrive - Bastian Solutions\Desktop\Payroll\Archive\";
            var files = new DirectoryInfo(Folder).GetFiles("*.*");
            string latestfile = "";

            DateTime todaysDate = DateTime.MinValue;

            try // Try to load data from a previous csv file. If none exist, log the error message and continue loading the rest of the program.
            {
                foreach (FileInfo file in files)
                {

                    if (file.LastWriteTime > todaysDate)
                    {

                        todaysDate = file.LastWriteTime;
                        latestfile = file.Name;

                    }

                }

                // Create a single variable for the file name and path
                string mostRecentFileAndPath = string.Format("{0}{1}", Folder, latestfile);

                // Load the data from the csv file into the dataGridView1, skipping the first row.
                string[] allRows = File.ReadAllLines(mostRecentFileAndPath);
                Boolean headerRowHasBeenSkipped = false;

                foreach (string sRow in allRows)
                {
                    if (headerRowHasBeenSkipped)
                    {
                        if (!string.IsNullOrEmpty(sRow))
                        {

                            // Skip first item in the array
                            string[] arrRow = sRow.Split(new char[] { ',' });
                            dataGridView1.Rows.Add(arrRow);

                        }
                    }
                    else
                    {

                        headerRowHasBeenSkipped = true;

                    }

                }

            }
            catch (Exception A)
            {
             
                Console.WriteLine(A.Message);

            }

        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            
            EmployeePayroll employeePayRoll = new EmployeePayroll();

            employeePayRoll.EmployeeFirstName = FirstNameInput.Text;

            employeePayRoll.EmployeeLastName = LastNameInput.Text;

            employeePayRoll.EmployeeEmail = EmailInput.Text;
            
            double PayRate = 0;
            double.TryParse(PayRateInput.Text, out PayRate);
            employeePayRoll.EmployeePayRate = PayRate;

            double Quantity = 0;
            double.TryParse(QtyInput.Text, out Quantity);
            employeePayRoll.TaskQty = Quantity;

            double ExtraPay = 0;
            double.TryParse(ExtraInput.Text, out ExtraPay);
            employeePayRoll.EmployeeExtraPay = ExtraPay;

            double TotalPay = 0;
            double.TryParse(TotalPayInput.Text, out TotalPay);
            employeePayRoll.EmployeeTotalPay = TotalPay;

            employeePayRoll.EmployeeComments = CommentsInput.Text;

            // Display the new information in the grid from the field.
            dataGridView1.Rows.Add(FirstNameInput.Text, LastNameInput.Text, EmailInput.Text, PayRate, Quantity, ExtraPay, TotalPay, CommentsInput.Text);
            dataGridView1.Columns[0].DisplayIndex = 0;
            
            // Clear out the input fields
            FirstNameInput.Clear();
            LastNameInput.Clear();
            EmailInput.Clear();
            PayRateInput.Clear();
            QtyInput.Clear();
            ExtraInput.Clear();
            TotalPayInput.Clear();
            CommentsInput.Clear();

                      
        }

        private void SendingEmail_TextChanged(object sender, EventArgs e)
        {
            string FromEmail = SendingAddress.Text;
        }

        private void FirstNameInput_TextChanged(object sender, EventArgs e)
        {
                                 
        }

        private void LastNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void PayRateInput_TextChanged(object sender, EventArgs e)
        {

            CalculateTotalOnTextChange();

        }

        private void QtyInput_TextChanged(object sender, EventArgs e)
        {

            CalculateTotalOnTextChange();

        }

        private void ExtraInput_TextChanged(object sender, EventArgs e)
        {
            
            CalculateTotalOnTextChange();

        }

        // Method for calculating total pay
        private void CalculateTotalOnTextChange()
        {

            // Convert strings inputs from textboxes into integers.
            double PayRate = 0;
            double.TryParse(PayRateInput.Text, out PayRate);

            double Quantity = 0;
            double.TryParse(QtyInput.Text, out Quantity);

            double ExtraPay = 0;
            double.TryParse(ExtraInput.Text, out ExtraPay);

            double TotalPay = (Quantity * PayRate) + ExtraPay;
            TotalPayInput.Text = TotalPay.ToString();

        }

        private void TotalPayInput_TextChanged(object sender, EventArgs e)
        {
                                 
        }

        private void CommentsInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void PayPeriodStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PayPeriodEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MainTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Preview_Click(object sender, EventArgs e)
        {
            
        }

        private void SendEmail_Click(object sender, EventArgs e)
        {

          /*  
            try
            {

                string[,] Datavalue = new string[dataGridView1.Rows.Count, dataGridView1.Columns.Count];
                    
                    // loop over each row in the grid
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        // send an email for each row in the grid
                        for (var i = 0; i < dataGridView1.Rows.Count; i++)
                        {

                            // set up the email connection
                            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                            client.EnableSsl = true;
                            client.DeliveryMethod = SmtpDeliveryMethod.Network;
                            client.UseDefaultCredentials = false;
                            client.Credentials = new NetworkCredential("philip@devineandcompany.com", "PHilip12#$"); // (SendingAddress.Text, "PHilip12#$");

                            // create and format the message
                            MailMessage msgobj = new MailMessage();
                            msgobj.To.Add(dataGridView1.Rows[i].Cells[2].Value.ToString()); 
                            msgobj.From = new MailAddress(SendingAddress.Text);
                            msgobj.Subject = "Payroll for " + dataGridView1.Rows[i].Cells[0].Value + " " + dataGridView1.Rows[i].Cells[1].Value + " | " + PayPeriodStartPicker.Text + " " + "-" + " " + PayPeriodEndPicker.Text + ".";
                        msgobj.Body = "Hi " + dataGridView1.Rows[i].Cells[0].Value + ", here is your paystub information.  Please keep this email for your records." + Environment.NewLine + Environment.NewLine +
                                  "Pay Period: " + PayPeriodStartPicker.Text + " " + "-" + " " + PayPeriodEndPicker.Text + "." + Environment.NewLine +
                                  "Pay Rate: " + "$" + dataGridView1.Rows[i].Cells[3].Value + Environment.NewLine +
                                  "Quantity: " + dataGridView1.Rows[i].Cells[4].Value + Environment.NewLine +
                                  "Extra: " + "$" + dataGridView1.Rows[i].Cells[5].Value + Environment.NewLine +
                                  "Total Pay: " + "$" + dataGridView1.Rows[i].Cells[6].Value + Environment.NewLine +
                                  "Comments: " + dataGridView1.Rows[i].Cells[7].Value + Environment.NewLine + Environment.NewLine +
                                  "Thanks for all of your work, please let me know if I can help with anything." + Environment.NewLine + Environment.NewLine +
                                  "Best," + Environment.NewLine + Environment.NewLine +
                                  "Philip Devine";
                            client.Send(msgobj);
                            MessageBox.Show("Message successfully sent.");


                    }

                }
                
            }

            catch (System.Net.Mail.SmtpException)

            {

                MessageBox.Show("Message failed to send.");

            }
             */
            try
            {

                // Export data from dataGridView to .csv file

                // Format the pay period start values
                string ppsDay = PayPeriodStartPicker.Value.Day.ToString();
                string ppsMonth = PayPeriodStartPicker.Value.Month.ToString();
                string ppsYear = PayPeriodStartPicker.Value.Year.ToString();

                // Format the pay period end values
                string ppeDay = PayPeriodEndPicker.Value.Day.ToString();
                string ppeMonth = PayPeriodEndPicker.Value.Month.ToString();
                string ppeYear = PayPeriodEndPicker.Value.Year.ToString();

                // Create a single variable for the payperiod
                string fullPayPeriod = string.Format("{0}.{1}.{2} - {3}.{4}.{5}", ppsMonth, ppsDay, ppsYear, ppeMonth, ppeDay, ppeYear);

                if (dataGridView1.Rows.Count > 0)
                {
                    // Build the CSV file data as a comma separated string.
                    string csv = string.Empty;

                    // Add the Header row for CSV file.
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        csv += column.HeaderText + ',';
                    }

                    // Add new line
                    csv += "\r\n";

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Add the Data rows.
                            csv += cell.Value.ToString().Replace(",", ";") + ',';
                        }

                        // Add new line
                        csv += "\r\n";
                    }

                    // Exporting to CSV.
                    string folderPath = "C:\\Users\\pdevine\\OneDrive - Bastian Solutions\\Desktop\\Payroll\\Archive\\";
                    File.WriteAllText(folderPath + fullPayPeriod + ".csv", csv);
                }
            }
            catch (Exception A)
            {

                Console.WriteLine(A.Message);
                MessageBox.Show("Could not find export the file to the configured directory.");

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // TODO: Add method for calculating pay between cells. 

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

    }

}
