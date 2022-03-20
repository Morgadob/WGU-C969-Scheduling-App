
namespace Brandon_Morgado_C969_Scheduling
{
    partial class AddAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AppCusText = new System.Windows.Forms.ComboBox();
            this.AppTypeText = new System.Windows.Forms.ComboBox();
            this.AppStartPicker = new System.Windows.Forms.DateTimePicker();
            this.AppEndPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AppContact = new System.Windows.Forms.TextBox();
            this.AppLocat = new System.Windows.Forms.TextBox();
            this.AppDescBox = new System.Windows.Forms.TextBox();
            this.AppCusTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AppUrlBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 651);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 651);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 74);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AppCusText
            // 
            this.AppCusText.FormattingEnabled = true;
            this.AppCusText.Location = new System.Drawing.Point(198, 64);
            this.AppCusText.Name = "AppCusText";
            this.AppCusText.Size = new System.Drawing.Size(331, 28);
            this.AppCusText.TabIndex = 2;
            this.AppCusText.DropDownClosed += new System.EventHandler(this.AppCusText_DropDownClosed);
            this.AppCusText.SelectedValueChanged += new System.EventHandler(this.AppCusText_SelectedValueChanged);
            this.AppCusText.Click += new System.EventHandler(this.AppCusText_Click);
            // 
            // AppTypeText
            // 
            this.AppTypeText.FormattingEnabled = true;
            this.AppTypeText.Location = new System.Drawing.Point(200, 411);
            this.AppTypeText.Name = "AppTypeText";
            this.AppTypeText.Size = new System.Drawing.Size(331, 28);
            this.AppTypeText.TabIndex = 3;
            this.AppTypeText.DropDownClosed += new System.EventHandler(this.AppTypeText_DropDownClosed);
            this.AppTypeText.Click += new System.EventHandler(this.AppTypeText_Click);
            // 
            // AppStartPicker
            // 
            this.AppStartPicker.CustomFormat = "\"MM\'/\'dd\'/\'yyyy hh\':\'mm tt\"";
            this.AppStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AppStartPicker.Location = new System.Drawing.Point(198, 510);
            this.AppStartPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AppStartPicker.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.AppStartPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.AppStartPicker.Name = "AppStartPicker";
            this.AppStartPicker.Size = new System.Drawing.Size(331, 26);
            this.AppStartPicker.TabIndex = 48;
            this.AppStartPicker.Value = new System.DateTime(2019, 4, 30, 0, 0, 0, 0);
            // 
            // AppEndPicker
            // 
            this.AppEndPicker.CustomFormat = "\"MM\'/\'dd\'/\'yyyy hh\':\'mm tt\"";
            this.AppEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AppEndPicker.Location = new System.Drawing.Point(198, 584);
            this.AppEndPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AppEndPicker.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.AppEndPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.AppEndPicker.Name = "AppEndPicker";
            this.AppEndPicker.Size = new System.Drawing.Size(331, 26);
            this.AppEndPicker.TabIndex = 49;
            this.AppEndPicker.Value = new System.DateTime(2019, 4, 30, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(37, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(35, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(35, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 53;
            this.label4.Text = "End Time";
            // 
            // AppContact
            // 
            this.AppContact.Location = new System.Drawing.Point(198, 358);
            this.AppContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppContact.Name = "AppContact";
            this.AppContact.Size = new System.Drawing.Size(331, 26);
            this.AppContact.TabIndex = 63;
            // 
            // AppLocat
            // 
            this.AppLocat.Location = new System.Drawing.Point(198, 306);
            this.AppLocat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppLocat.Name = "AppLocat";
            this.AppLocat.Size = new System.Drawing.Size(333, 26);
            this.AppLocat.TabIndex = 62;
            // 
            // AppDescBox
            // 
            this.AppDescBox.Location = new System.Drawing.Point(198, 201);
            this.AppDescBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppDescBox.Multiline = true;
            this.AppDescBox.Name = "AppDescBox";
            this.AppDescBox.Size = new System.Drawing.Size(333, 78);
            this.AppDescBox.TabIndex = 61;
            // 
            // AppCusTitle
            // 
            this.AppCusTitle.Location = new System.Drawing.Point(198, 141);
            this.AppCusTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppCusTitle.MaxLength = 255;
            this.AppCusTitle.Name = "AppCusTitle";
            this.AppCusTitle.Size = new System.Drawing.Size(333, 26);
            this.AppCusTitle.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(35, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 64;
            this.label5.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(35, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 65;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(37, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 66;
            this.label7.Text = "Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(35, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 67;
            this.label8.Text = "Contact";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(35, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 38);
            this.label9.TabIndex = 69;
            this.label9.Text = "URL";
            // 
            // AppUrlBox
            // 
            this.AppUrlBox.Location = new System.Drawing.Point(198, 460);
            this.AppUrlBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppUrlBox.Name = "AppUrlBox";
            this.AppUrlBox.Size = new System.Drawing.Size(331, 26);
            this.AppUrlBox.TabIndex = 68;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 760);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AppUrlBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AppContact);
            this.Controls.Add(this.AppLocat);
            this.Controls.Add(this.AppDescBox);
            this.Controls.Add(this.AppCusTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppEndPicker);
            this.Controls.Add(this.AppStartPicker);
            this.Controls.Add(this.AppTypeText);
            this.Controls.Add(this.AppCusText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AddAppointment";
            this.Text = "AddAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox AppCusText;
        private System.Windows.Forms.ComboBox AppTypeText;
        private System.Windows.Forms.DateTimePicker AppStartPicker;
        private System.Windows.Forms.DateTimePicker AppEndPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AppContact;
        private System.Windows.Forms.TextBox AppLocat;
        private System.Windows.Forms.TextBox AppDescBox;
        private System.Windows.Forms.TextBox AppCusTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AppUrlBox;
    }
}