namespace A22
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label_title = new Label();
            label_Fname = new Label();
            label_Lname = new Label();
            label_address = new Label();
            label_mobile = new Label();
            label_plan = new Label();
            label_duration = new Label();
            label_paymentFrequency = new Label();
            checkBox_247access = new CheckBox();
            checkBox_personalTrainer = new CheckBox();
            checkBox_dietCons = new CheckBox();
            checkBox_accessOnline = new CheckBox();
            textBox_Fname = new TextBox();
            textBox_Lname = new TextBox();
            textBox_address = new TextBox();
            textBox_mobile = new TextBox();
            radioButton_basic = new RadioButton();
            radioButton_regular = new RadioButton();
            radioButton_premium = new RadioButton();
            radioButton_3mths = new RadioButton();
            radioButton_12mths = new RadioButton();
            radioButton_24mths = new RadioButton();
            radioButton_payWeekly = new RadioButton();
            radioButton_payMonthly = new RadioButton();
            label_directDebit = new Label();
            button_calculate = new Button();
            groupBox_membershipType = new GroupBox();
            groupBox_duration = new GroupBox();
            radioButton_debitYes = new RadioButton();
            radioButton_debitNo = new RadioButton();
            groupBox_directDebit = new GroupBox();
            groupBox_paymentFrequency = new GroupBox();
            label_discounts = new Label();
            textBox_email = new TextBox();
            label_email = new Label();
            groupBox_custDetails = new GroupBox();
            groupBox_memDetails = new GroupBox();
            groupBox_payment = new GroupBox();
            groupBox_extras = new GroupBox();
            label1 = new Label();
            groupBox_membershipType.SuspendLayout();
            groupBox_duration.SuspendLayout();
            groupBox_directDebit.SuspendLayout();
            groupBox_paymentFrequency.SuspendLayout();
            groupBox_custDetails.SuspendLayout();
            groupBox_memDetails.SuspendLayout();
            groupBox_payment.SuspendLayout();
            groupBox_extras.SuspendLayout();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label_title.Location = new Point(201, 55);
            label_title.Name = "label_title";
            label_title.Size = new Size(145, 21);
            label_title.TabIndex = 0;
            label_title.Text = "Membership Form";
            // 
            // label_Fname
            // 
            label_Fname.AutoSize = true;
            label_Fname.Location = new Point(26, 39);
            label_Fname.Name = "label_Fname";
            label_Fname.Size = new Size(67, 15);
            label_Fname.TabIndex = 1;
            label_Fname.Text = "First Name:";
            // 
            // label_Lname
            // 
            label_Lname.AutoSize = true;
            label_Lname.Location = new Point(260, 39);
            label_Lname.Name = "label_Lname";
            label_Lname.Size = new Size(66, 15);
            label_Lname.TabIndex = 2;
            label_Lname.Text = "Last Name:";
            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Location = new Point(26, 79);
            label_address.Name = "label_address";
            label_address.Size = new Size(52, 15);
            label_address.TabIndex = 3;
            label_address.Text = "Address:";
            // 
            // label_mobile
            // 
            label_mobile.AutoSize = true;
            label_mobile.Location = new Point(26, 119);
            label_mobile.Name = "label_mobile";
            label_mobile.Size = new Size(47, 15);
            label_mobile.TabIndex = 4;
            label_mobile.Text = "Mobile:";
            // 
            // label_plan
            // 
            label_plan.AutoSize = true;
            label_plan.Location = new Point(13, 48);
            label_plan.Name = "label_plan";
            label_plan.Size = new Size(33, 15);
            label_plan.TabIndex = 5;
            label_plan.Text = "Plan:";
            // 
            // label_duration
            // 
            label_duration.AutoSize = true;
            label_duration.Location = new Point(13, 101);
            label_duration.Name = "label_duration";
            label_duration.Size = new Size(57, 15);
            label_duration.TabIndex = 6;
            label_duration.Text = "Duration:";
            // 
            // label_paymentFrequency
            // 
            label_paymentFrequency.AutoSize = true;
            label_paymentFrequency.Location = new Point(243, 35);
            label_paymentFrequency.Name = "label_paymentFrequency";
            label_paymentFrequency.Size = new Size(65, 15);
            label_paymentFrequency.TabIndex = 7;
            label_paymentFrequency.Text = "Frequency:";
            // 
            // checkBox_247access
            // 
            checkBox_247access.AutoSize = true;
            checkBox_247access.Location = new Point(32, 28);
            checkBox_247access.Name = "checkBox_247access";
            checkBox_247access.Size = new Size(137, 19);
            checkBox_247access.TabIndex = 8;
            checkBox_247access.Text = "24/7 Access ($1 p/w)";
            checkBox_247access.UseVisualStyleBackColor = true;
            // 
            // checkBox_personalTrainer
            // 
            checkBox_personalTrainer.AutoSize = true;
            checkBox_personalTrainer.Location = new Point(32, 65);
            checkBox_personalTrainer.Name = "checkBox_personalTrainer";
            checkBox_personalTrainer.Size = new Size(166, 19);
            checkBox_personalTrainer.TabIndex = 9;
            checkBox_personalTrainer.Text = "Personal Trainer ($20 p/w)";
            checkBox_personalTrainer.UseVisualStyleBackColor = true;
            // 
            // checkBox_dietCons
            // 
            checkBox_dietCons.AutoSize = true;
            checkBox_dietCons.Location = new Point(248, 28);
            checkBox_dietCons.Name = "checkBox_dietCons";
            checkBox_dietCons.Size = new Size(174, 19);
            checkBox_dietCons.TabIndex = 10;
            checkBox_dietCons.Text = "Diet Consultation ($20 p/w)";
            checkBox_dietCons.UseVisualStyleBackColor = true;
            // 
            // checkBox_accessOnline
            // 
            checkBox_accessOnline.AutoSize = true;
            checkBox_accessOnline.Location = new Point(248, 65);
            checkBox_accessOnline.Name = "checkBox_accessOnline";
            checkBox_accessOnline.Size = new Size(227, 19);
            checkBox_accessOnline.TabIndex = 11;
            checkBox_accessOnline.Text = "Access Online Fitness Videos ($2 p/w)";
            checkBox_accessOnline.UseVisualStyleBackColor = true;
            // 
            // textBox_Fname
            // 
            textBox_Fname.Location = new Point(99, 31);
            textBox_Fname.Name = "textBox_Fname";
            textBox_Fname.Size = new Size(144, 23);
            textBox_Fname.TabIndex = 12;
            // 
            // textBox_Lname
            // 
            textBox_Lname.Location = new Point(332, 31);
            textBox_Lname.Name = "textBox_Lname";
            textBox_Lname.Size = new Size(124, 23);
            textBox_Lname.TabIndex = 13;
            // 
            // textBox_address
            // 
            textBox_address.Location = new Point(99, 71);
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(357, 23);
            textBox_address.TabIndex = 14;
            // 
            // textBox_mobile
            // 
            textBox_mobile.Location = new Point(99, 111);
            textBox_mobile.Name = "textBox_mobile";
            textBox_mobile.Size = new Size(142, 23);
            textBox_mobile.TabIndex = 15;
            // 
            // radioButton_basic
            // 
            radioButton_basic.AutoSize = true;
            radioButton_basic.Location = new Point(9, 14);
            radioButton_basic.Name = "radioButton_basic";
            radioButton_basic.Size = new Size(106, 19);
            radioButton_basic.TabIndex = 16;
            radioButton_basic.TabStop = true;
            radioButton_basic.Text = "Basic ($10 p/w)";
            radioButton_basic.UseVisualStyleBackColor = true;
            // 
            // radioButton_regular
            // 
            radioButton_regular.AutoSize = true;
            radioButton_regular.Location = new Point(120, 14);
            radioButton_regular.Name = "radioButton_regular";
            radioButton_regular.Size = new Size(119, 19);
            radioButton_regular.TabIndex = 17;
            radioButton_regular.TabStop = true;
            radioButton_regular.Text = "Regular ($15 p/w)";
            radioButton_regular.UseVisualStyleBackColor = true;
            // 
            // radioButton_premium
            // 
            radioButton_premium.AutoSize = true;
            radioButton_premium.Location = new Point(245, 14);
            radioButton_premium.Name = "radioButton_premium";
            radioButton_premium.Size = new Size(130, 19);
            radioButton_premium.TabIndex = 18;
            radioButton_premium.TabStop = true;
            radioButton_premium.Text = "Premium ($20 p/w)";
            radioButton_premium.UseVisualStyleBackColor = true;
            // 
            // radioButton_3mths
            // 
            radioButton_3mths.AutoSize = true;
            radioButton_3mths.Location = new Point(6, 18);
            radioButton_3mths.Name = "radioButton_3mths";
            radioButton_3mths.Size = new Size(76, 19);
            radioButton_3mths.TabIndex = 19;
            radioButton_3mths.TabStop = true;
            radioButton_3mths.Text = "3 Months";
            radioButton_3mths.UseVisualStyleBackColor = true;
            // 
            // radioButton_12mths
            // 
            radioButton_12mths.AutoSize = true;
            radioButton_12mths.Location = new Point(103, 18);
            radioButton_12mths.Name = "radioButton_12mths";
            radioButton_12mths.Size = new Size(86, 19);
            radioButton_12mths.TabIndex = 20;
            radioButton_12mths.TabStop = true;
            radioButton_12mths.Text = "12 Months*";
            radioButton_12mths.UseVisualStyleBackColor = true;
            // 
            // radioButton_24mths
            // 
            radioButton_24mths.AutoSize = true;
            radioButton_24mths.Location = new Point(203, 19);
            radioButton_24mths.Name = "radioButton_24mths";
            radioButton_24mths.Size = new Size(93, 19);
            radioButton_24mths.TabIndex = 21;
            radioButton_24mths.TabStop = true;
            radioButton_24mths.Text = "24 Months**";
            radioButton_24mths.UseVisualStyleBackColor = true;
            // 
            // radioButton_payWeekly
            // 
            radioButton_payWeekly.AutoSize = true;
            radioButton_payWeekly.Location = new Point(7, 14);
            radioButton_payWeekly.Name = "radioButton_payWeekly";
            radioButton_payWeekly.Size = new Size(64, 19);
            radioButton_payWeekly.TabIndex = 22;
            radioButton_payWeekly.TabStop = true;
            radioButton_payWeekly.Text = "Weekly";
            radioButton_payWeekly.UseVisualStyleBackColor = true;
            // 
            // radioButton_payMonthly
            // 
            radioButton_payMonthly.AutoSize = true;
            radioButton_payMonthly.Location = new Point(76, 15);
            radioButton_payMonthly.Name = "radioButton_payMonthly";
            radioButton_payMonthly.Size = new Size(70, 19);
            radioButton_payMonthly.TabIndex = 23;
            radioButton_payMonthly.TabStop = true;
            radioButton_payMonthly.Text = "Monthly";
            radioButton_payMonthly.UseVisualStyleBackColor = true;
            // 
            // label_directDebit
            // 
            label_directDebit.AutoSize = true;
            label_directDebit.Location = new Point(15, 35);
            label_directDebit.Name = "label_directDebit";
            label_directDebit.Size = new Size(74, 15);
            label_directDebit.TabIndex = 24;
            label_directDebit.Text = "Direct Debit:";
            // 
            // button_calculate
            // 
            button_calculate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            button_calculate.Location = new Point(206, 788);
            button_calculate.Name = "button_calculate";
            button_calculate.Size = new Size(97, 34);
            button_calculate.TabIndex = 25;
            button_calculate.Text = "Calculate";
            button_calculate.UseVisualStyleBackColor = true;
            button_calculate.Click += button_calculate_Click;
            // 
            // groupBox_membershipType
            // 
            groupBox_membershipType.Controls.Add(radioButton_premium);
            groupBox_membershipType.Controls.Add(radioButton_regular);
            groupBox_membershipType.Controls.Add(radioButton_basic);
            groupBox_membershipType.Location = new Point(52, 34);
            groupBox_membershipType.Name = "groupBox_membershipType";
            groupBox_membershipType.Size = new Size(383, 41);
            groupBox_membershipType.TabIndex = 26;
            groupBox_membershipType.TabStop = false;
            // 
            // groupBox_duration
            // 
            groupBox_duration.Controls.Add(radioButton_24mths);
            groupBox_duration.Controls.Add(radioButton_12mths);
            groupBox_duration.Controls.Add(radioButton_3mths);
            groupBox_duration.Location = new Point(75, 81);
            groupBox_duration.Name = "groupBox_duration";
            groupBox_duration.Size = new Size(308, 44);
            groupBox_duration.TabIndex = 27;
            groupBox_duration.TabStop = false;
            // 
            // radioButton_debitYes
            // 
            radioButton_debitYes.AutoSize = true;
            radioButton_debitYes.Location = new Point(6, 14);
            radioButton_debitYes.Name = "radioButton_debitYes";
            radioButton_debitYes.Size = new Size(57, 19);
            radioButton_debitYes.TabIndex = 28;
            radioButton_debitYes.TabStop = true;
            radioButton_debitYes.Text = "Yes***";
            radioButton_debitYes.UseVisualStyleBackColor = true;
            // 
            // radioButton_debitNo
            // 
            radioButton_debitNo.AutoSize = true;
            radioButton_debitNo.Location = new Point(69, 13);
            radioButton_debitNo.Name = "radioButton_debitNo";
            radioButton_debitNo.Size = new Size(41, 19);
            radioButton_debitNo.TabIndex = 29;
            radioButton_debitNo.TabStop = true;
            radioButton_debitNo.Text = "No";
            radioButton_debitNo.UseVisualStyleBackColor = true;
            // 
            // groupBox_directDebit
            // 
            groupBox_directDebit.Controls.Add(radioButton_debitNo);
            groupBox_directDebit.Controls.Add(radioButton_debitYes);
            groupBox_directDebit.Location = new Point(99, 16);
            groupBox_directDebit.Name = "groupBox_directDebit";
            groupBox_directDebit.Size = new Size(121, 39);
            groupBox_directDebit.TabIndex = 30;
            groupBox_directDebit.TabStop = false;
            // 
            // groupBox_paymentFrequency
            // 
            groupBox_paymentFrequency.Controls.Add(radioButton_payMonthly);
            groupBox_paymentFrequency.Controls.Add(radioButton_payWeekly);
            groupBox_paymentFrequency.Location = new Point(314, 16);
            groupBox_paymentFrequency.Name = "groupBox_paymentFrequency";
            groupBox_paymentFrequency.Size = new Size(157, 39);
            groupBox_paymentFrequency.TabIndex = 31;
            groupBox_paymentFrequency.TabStop = false;
            // 
            // label_discounts
            // 
            label_discounts.AutoSize = true;
            label_discounts.Location = new Point(32, 700);
            label_discounts.Name = "label_discounts";
            label_discounts.Size = new Size(500, 45);
            label_discounts.TabIndex = 36;
            label_discounts.Text = resources.GetString("label_discounts.Text");
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(312, 111);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(144, 23);
            textBox_email.TabIndex = 38;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(260, 119);
            label_email.Name = "label_email";
            label_email.Size = new Size(39, 15);
            label_email.TabIndex = 37;
            label_email.Text = "Email:";
            // 
            // groupBox_custDetails
            // 
            groupBox_custDetails.Controls.Add(textBox_email);
            groupBox_custDetails.Controls.Add(label_email);
            groupBox_custDetails.Controls.Add(textBox_mobile);
            groupBox_custDetails.Controls.Add(textBox_address);
            groupBox_custDetails.Controls.Add(textBox_Lname);
            groupBox_custDetails.Controls.Add(textBox_Fname);
            groupBox_custDetails.Controls.Add(label_mobile);
            groupBox_custDetails.Controls.Add(label_address);
            groupBox_custDetails.Controls.Add(label_Lname);
            groupBox_custDetails.Controls.Add(label_Fname);
            groupBox_custDetails.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox_custDetails.Location = new Point(32, 96);
            groupBox_custDetails.Name = "groupBox_custDetails";
            groupBox_custDetails.Size = new Size(500, 172);
            groupBox_custDetails.TabIndex = 39;
            groupBox_custDetails.TabStop = false;
            groupBox_custDetails.Text = "Customer Details";
            // 
            // groupBox_memDetails
            // 
            groupBox_memDetails.Controls.Add(groupBox_duration);
            groupBox_memDetails.Controls.Add(groupBox_membershipType);
            groupBox_memDetails.Controls.Add(label_duration);
            groupBox_memDetails.Controls.Add(label_plan);
            groupBox_memDetails.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox_memDetails.Location = new Point(34, 287);
            groupBox_memDetails.Name = "groupBox_memDetails";
            groupBox_memDetails.Size = new Size(498, 156);
            groupBox_memDetails.TabIndex = 40;
            groupBox_memDetails.TabStop = false;
            groupBox_memDetails.Text = "Membership Details";
            // 
            // groupBox_payment
            // 
            groupBox_payment.Controls.Add(groupBox_paymentFrequency);
            groupBox_payment.Controls.Add(groupBox_directDebit);
            groupBox_payment.Controls.Add(label_directDebit);
            groupBox_payment.Controls.Add(label_paymentFrequency);
            groupBox_payment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox_payment.Location = new Point(32, 467);
            groupBox_payment.Name = "groupBox_payment";
            groupBox_payment.Size = new Size(500, 76);
            groupBox_payment.TabIndex = 41;
            groupBox_payment.TabStop = false;
            groupBox_payment.Text = "Payment Details";
            // 
            // groupBox_extras
            // 
            groupBox_extras.Controls.Add(checkBox_accessOnline);
            groupBox_extras.Controls.Add(checkBox_dietCons);
            groupBox_extras.Controls.Add(checkBox_personalTrainer);
            groupBox_extras.Controls.Add(checkBox_247access);
            groupBox_extras.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox_extras.Location = new Point(32, 560);
            groupBox_extras.Name = "groupBox_extras";
            groupBox_extras.Size = new Size(500, 108);
            groupBox_extras.TabIndex = 42;
            groupBox_extras.TabStop = false;
            groupBox_extras.Text = "Extras";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 21);
            label1.Name = "label1";
            label1.Size = new Size(110, 34);
            label1.TabIndex = 43;
            label1.Text = "City Gym";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 881);
            Controls.Add(label1);
            Controls.Add(groupBox_extras);
            Controls.Add(groupBox_payment);
            Controls.Add(groupBox_memDetails);
            Controls.Add(groupBox_custDetails);
            Controls.Add(label_discounts);
            Controls.Add(button_calculate);
            Controls.Add(label_title);
            Name = "Form1";
            Text = "Form1";
            groupBox_membershipType.ResumeLayout(false);
            groupBox_membershipType.PerformLayout();
            groupBox_duration.ResumeLayout(false);
            groupBox_duration.PerformLayout();
            groupBox_directDebit.ResumeLayout(false);
            groupBox_directDebit.PerformLayout();
            groupBox_paymentFrequency.ResumeLayout(false);
            groupBox_paymentFrequency.PerformLayout();
            groupBox_custDetails.ResumeLayout(false);
            groupBox_custDetails.PerformLayout();
            groupBox_memDetails.ResumeLayout(false);
            groupBox_memDetails.PerformLayout();
            groupBox_payment.ResumeLayout(false);
            groupBox_payment.PerformLayout();
            groupBox_extras.ResumeLayout(false);
            groupBox_extras.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label label_title;
        public Label label_Fname;
        public Label label_Lname;
        public Label label_address;
        public Label label_mobile;
        public Label label_plan;
        public Label label_duration;
        public TextBox textBox_Fname;
        public TextBox textBox_Lname;
        public TextBox textBox_address;
        public TextBox textBox_mobile;
        public RadioButton radioButton_basic;
        public RadioButton radioButton_regular;
        public RadioButton radioButton_premium;
        public Label label_directDebit;
        public GroupBox groupBox_membershipType;
        public GroupBox groupBox_duration;
        public GroupBox groupBox_directDebit;
        public TextBox textBox_email;
        public Label label_email;
        public Label label_paymentFrequency;
        public CheckBox checkBox_247access;
        public CheckBox checkBox_personalTrainer;
        public CheckBox checkBox_dietCons;
        public CheckBox checkBox_accessOnline;
        public Button button_calculate;
        public GroupBox groupBox_paymentFrequency;
        public Label label_discounts;
        public Label label1;
        public RadioButton radioButton_3mths;
        public RadioButton radioButton_12mths;
        public RadioButton radioButton_24mths;
        public RadioButton radioButton_payWeekly;
        public RadioButton radioButton_payMonthly;
        public RadioButton radioButton_debitYes;
        public RadioButton radioButton_debitNo;
        public GroupBox groupBox_custDetails;
        public GroupBox groupBox_memDetails;
        public GroupBox groupBox_payment;
        public GroupBox groupBox_extras;
    }
}
