﻿namespace BlackJack
{
    partial class PlayBlackjack
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rtbHand1 = new System.Windows.Forms.RichTextBox();
            this.txtHandValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 15);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(43, 60);
            this.txtCard.Margin = new System.Windows.Forms.Padding(4);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(287, 22);
            this.txtCard.TabIndex = 1;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(43, 92);
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(287, 213);
            this.rtbOutput.TabIndex = 2;
            this.rtbOutput.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DealCard);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 18);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rtbHand1
            // 
            this.rtbHand1.Location = new System.Drawing.Point(401, 92);
            this.rtbHand1.Margin = new System.Windows.Forms.Padding(4);
            this.rtbHand1.Name = "rtbHand1";
            this.rtbHand1.Size = new System.Drawing.Size(287, 213);
            this.rtbHand1.TabIndex = 6;
            this.rtbHand1.Text = "";
            // 
            // txtHandValue
            // 
            this.txtHandValue.Location = new System.Drawing.Point(477, 426);
            this.txtHandValue.Name = "txtHandValue";
            this.txtHandValue.Size = new System.Drawing.Size(187, 22);
            this.txtHandValue.TabIndex = 7;
            this.txtHandValue.TextChanged += new System.EventHandler(this.txtHandValue_TextChanged);
            // 
            // PlayBlackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 597);
            this.Controls.Add(this.txtHandValue);
            this.Controls.Add(this.rtbHand1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlayBlackjack";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.PlayBlackjack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox rtbHand1;
        private System.Windows.Forms.TextBox txtHandValue;
    }
}

