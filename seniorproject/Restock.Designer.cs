﻿namespace seniorproject
{
    partial class Restock
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
            this.amountTracker = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountTracker)).BeginInit();
            this.SuspendLayout();
            // 
            // amountTracker
            // 
            this.amountTracker.Location = new System.Drawing.Point(58, 69);
            this.amountTracker.Maximum = 50000;
            this.amountTracker.Name = "amountTracker";
            this.amountTracker.Size = new System.Drawing.Size(273, 45);
            this.amountTracker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Amount";
            // 
            // amountBox
            // 
            this.amountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountBox.Location = new System.Drawing.Point(65, 120);
            this.amountBox.Multiline = true;
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(266, 25);
            this.amountBox.TabIndex = 3;
            this.amountBox.Text = "Amount...";
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.orderButton.Location = new System.Drawing.Point(368, 116);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(134, 29);
            this.orderButton.TabIndex = 5;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cancelButton.Location = new System.Drawing.Point(368, 151);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(134, 29);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // Restock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 205);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountTracker);
            this.Name = "Restock";
            this.Text = "Restock Item";
            ((System.ComponentModel.ISupportInitialize)(this.amountTracker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar amountTracker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button cancelButton;
    }
}