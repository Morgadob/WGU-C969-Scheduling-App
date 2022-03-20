
namespace Brandon_Morgado_C969_Scheduling
{
    partial class ModifyAppointment
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EndAppModPick = new System.Windows.Forms.DateTimePicker();
            this.StartAppModPick = new System.Windows.Forms.DateTimePicker();
            this.TypeAppMod = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AppContactMod = new System.Windows.Forms.TextBox();
            this.AppModLocat = new System.Windows.Forms.TextBox();
            this.AppModDescBox = new System.Windows.Forms.TextBox();
            this.AppModCusTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AppModCusText = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AppUrlBoxMod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(25, 638);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 61;
            this.label4.Text = "End Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(25, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 60;
            this.label3.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(25, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Type";
            // 
            // EndAppModPick
            // 
            this.EndAppModPick.CustomFormat = "\"MM\'/\'dd\'/\'yyyy hh\':\'mm tt\"";
            this.EndAppModPick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndAppModPick.Location = new System.Drawing.Point(188, 638);
            this.EndAppModPick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EndAppModPick.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.EndAppModPick.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.EndAppModPick.Name = "EndAppModPick";
            this.EndAppModPick.Size = new System.Drawing.Size(331, 26);
            this.EndAppModPick.TabIndex = 58;
            this.EndAppModPick.Value = new System.DateTime(2019, 4, 30, 0, 0, 0, 0);
            // 
            // StartAppModPick
            // 
            this.StartAppModPick.CustomFormat = "\"MM\'/\'dd\'/\'yyyy hh\':\'mm tt\"";
            this.StartAppModPick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartAppModPick.Location = new System.Drawing.Point(188, 564);
            this.StartAppModPick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartAppModPick.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.StartAppModPick.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.StartAppModPick.Name = "StartAppModPick";
            this.StartAppModPick.Size = new System.Drawing.Size(331, 26);
            this.StartAppModPick.TabIndex = 57;
            this.StartAppModPick.Value = new System.DateTime(2019, 4, 30, 0, 0, 0, 0);
            // 
            // TypeAppMod
            // 
            this.TypeAppMod.FormattingEnabled = true;
            this.TypeAppMod.Location = new System.Drawing.Point(188, 491);
            this.TypeAppMod.Name = "TypeAppMod";
            this.TypeAppMod.Size = new System.Drawing.Size(331, 28);
            this.TypeAppMod.TabIndex = 56;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 700);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 74);
            this.button2.TabIndex = 55;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 700);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 74);
            this.button1.TabIndex = 54;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(25, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 77;
            this.label8.Text = "Contact";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(27, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 76;
            this.label7.Text = "Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(25, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 75;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(25, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 74;
            this.label5.Text = "Title";
            // 
            // AppContactMod
            // 
            this.AppContactMod.Location = new System.Drawing.Point(188, 359);
            this.AppContactMod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppContactMod.Name = "AppContactMod";
            this.AppContactMod.Size = new System.Drawing.Size(331, 26);
            this.AppContactMod.TabIndex = 73;
            // 
            // AppModLocat
            // 
            this.AppModLocat.Location = new System.Drawing.Point(188, 307);
            this.AppModLocat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppModLocat.Name = "AppModLocat";
            this.AppModLocat.Size = new System.Drawing.Size(333, 26);
            this.AppModLocat.TabIndex = 72;
            // 
            // AppModDescBox
            // 
            this.AppModDescBox.Location = new System.Drawing.Point(188, 202);
            this.AppModDescBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppModDescBox.Multiline = true;
            this.AppModDescBox.Name = "AppModDescBox";
            this.AppModDescBox.Size = new System.Drawing.Size(333, 78);
            this.AppModDescBox.TabIndex = 71;
            // 
            // AppModCusTitle
            // 
            this.AppModCusTitle.Location = new System.Drawing.Point(188, 142);
            this.AppModCusTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppModCusTitle.MaxLength = 255;
            this.AppModCusTitle.Name = "AppModCusTitle";
            this.AppModCusTitle.Size = new System.Drawing.Size(333, 26);
            this.AppModCusTitle.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "Customer";
            // 
            // AppModCusText
            // 
            this.AppModCusText.FormattingEnabled = true;
            this.AppModCusText.Location = new System.Drawing.Point(188, 65);
            this.AppModCusText.Name = "AppModCusText";
            this.AppModCusText.Size = new System.Drawing.Size(331, 28);
            this.AppModCusText.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(27, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 25);
            this.label9.TabIndex = 79;
            this.label9.Text = "URL";
            // 
            // AppUrlBoxMod
            // 
            this.AppUrlBoxMod.Location = new System.Drawing.Point(190, 431);
            this.AppUrlBoxMod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppUrlBoxMod.Name = "AppUrlBoxMod";
            this.AppUrlBoxMod.Size = new System.Drawing.Size(331, 26);
            this.AppUrlBoxMod.TabIndex = 78;
            // 
            // ModifyAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 838);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AppUrlBoxMod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AppContactMod);
            this.Controls.Add(this.AppModLocat);
            this.Controls.Add(this.AppModDescBox);
            this.Controls.Add(this.AppModCusTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppModCusText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndAppModPick);
            this.Controls.Add(this.StartAppModPick);
            this.Controls.Add(this.TypeAppMod);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ModifyAppointment";
            this.Text = "ModifyAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker EndAppModPick;
        private System.Windows.Forms.DateTimePicker StartAppModPick;
        private System.Windows.Forms.ComboBox TypeAppMod;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AppContactMod;
        private System.Windows.Forms.TextBox AppModLocat;
        private System.Windows.Forms.TextBox AppModDescBox;
        private System.Windows.Forms.TextBox AppModCusTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AppModCusText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AppUrlBoxMod;
    }
}