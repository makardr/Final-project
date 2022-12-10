namespace Final_project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.namesTextBox = new System.Windows.Forms.TextBox();
            this.rolesTextbox = new System.Windows.Forms.TextBox();
            this.panelScreen = new System.Windows.Forms.Panel();
            this.randomizeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guaranteedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // namesTextBox
            // 
            this.namesTextBox.Location = new System.Drawing.Point(40, 76);
            this.namesTextBox.Name = "namesTextBox";
            this.namesTextBox.Size = new System.Drawing.Size(399, 22);
            this.namesTextBox.TabIndex = 0;
            this.namesTextBox.Text = "Name1 Name2 Name3 Name4 Name5 Name6 Name7 Name8";
            // 
            // rolesTextbox
            // 
            this.rolesTextbox.Location = new System.Drawing.Point(40, 157);
            this.rolesTextbox.Name = "rolesTextbox";
            this.rolesTextbox.Size = new System.Drawing.Size(399, 22);
            this.rolesTextbox.TabIndex = 1;
            this.rolesTextbox.Text = "Role0 Role0 Role1 Role1 Role1 Role2 Role2 Role2 Role3 Role4";
            // 
            // panelScreen
            // 
            this.panelScreen.Location = new System.Drawing.Point(13, 239);
            this.panelScreen.Name = "panelScreen";
            this.panelScreen.Size = new System.Drawing.Size(775, 476);
            this.panelScreen.TabIndex = 2;
            // 
            // randomizeBtn
            // 
            this.randomizeBtn.Location = new System.Drawing.Point(40, 196);
            this.randomizeBtn.Name = "randomizeBtn";
            this.randomizeBtn.Size = new System.Drawing.Size(108, 23);
            this.randomizeBtn.TabIndex = 3;
            this.randomizeBtn.Text = "Randomize";
            this.randomizeBtn.UseVisualStyleBackColor = true;
            this.randomizeBtn.Click += new System.EventHandler(this.randomizeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input roles in this format:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Role Role Role1 Role2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input names in this format:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name1 Name2 Name3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Necessary role:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Role that is guaranteed to be assigned";
            // 
            // guaranteedTextBox
            // 
            this.guaranteedTextBox.Location = new System.Drawing.Point(534, 75);
            this.guaranteedTextBox.Name = "guaranteedTextBox";
            this.guaranteedTextBox.Size = new System.Drawing.Size(100, 22);
            this.guaranteedTextBox.TabIndex = 10;
            this.guaranteedTextBox.Text = "Role4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 814);
            this.Controls.Add(this.guaranteedTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomizeBtn);
            this.Controls.Add(this.panelScreen);
            this.Controls.Add(this.rolesTextbox);
            this.Controls.Add(this.namesTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namesTextBox;
        private System.Windows.Forms.TextBox rolesTextbox;
        private System.Windows.Forms.Panel panelScreen;
        private System.Windows.Forms.Button randomizeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox guaranteedTextBox;
    }
}

