namespace Kursach.MainOffice
{
    partial class FormChooseOffice
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
            this.buttonMainOffice = new System.Windows.Forms.Button();
            this.buttonFillialOne = new System.Windows.Forms.Button();
            this.buttonFillialTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMainOffice
            // 
            this.buttonMainOffice.Location = new System.Drawing.Point(248, 181);
            this.buttonMainOffice.Name = "buttonMainOffice";
            this.buttonMainOffice.Size = new System.Drawing.Size(348, 55);
            this.buttonMainOffice.TabIndex = 0;
            this.buttonMainOffice.Text = "Главный офис";
            this.buttonMainOffice.UseVisualStyleBackColor = true;
            this.buttonMainOffice.Click += new System.EventHandler(this.buttonMainOffice_Click);
            // 
            // buttonFillialOne
            // 
            this.buttonFillialOne.Location = new System.Drawing.Point(104, 282);
            this.buttonFillialOne.Name = "buttonFillialOne";
            this.buttonFillialOne.Size = new System.Drawing.Size(267, 55);
            this.buttonFillialOne.TabIndex = 1;
            this.buttonFillialOne.Text = "Первый филиал";
            this.buttonFillialOne.UseVisualStyleBackColor = true;
            this.buttonFillialOne.Click += new System.EventHandler(this.buttonFillialOne_Click);
            // 
            // buttonFillialTwo
            // 
            this.buttonFillialTwo.Location = new System.Drawing.Point(457, 282);
            this.buttonFillialTwo.Name = "buttonFillialTwo";
            this.buttonFillialTwo.Size = new System.Drawing.Size(248, 55);
            this.buttonFillialTwo.TabIndex = 2;
            this.buttonFillialTwo.Text = "Второй филиал";
            this.buttonFillialTwo.UseVisualStyleBackColor = true;
            this.buttonFillialTwo.Click += new System.EventHandler(this.buttonFillialTwo_Click);
            // 
            // FormChooseOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 473);
            this.Controls.Add(this.buttonFillialTwo);
            this.Controls.Add(this.buttonFillialOne);
            this.Controls.Add(this.buttonMainOffice);
            this.Name = "FormChooseOffice";
            this.Text = "FormChooseOffice";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonMainOffice;
        private Button buttonFillialOne;
        private Button buttonFillialTwo;
    }
}