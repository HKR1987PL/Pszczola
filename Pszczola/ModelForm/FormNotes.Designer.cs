﻿namespace Pszczola
{
    partial class FormNotes
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
            this.lb_lista = new System.Windows.Forms.ListBox();
            this.b_zamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.lb_lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_lista.FormattingEnabled = true;
            this.lb_lista.HorizontalScrollbar = true;
            this.lb_lista.Location = new System.Drawing.Point(3, 3);
            this.lb_lista.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.lb_lista.Name = "listBox1";
            this.lb_lista.Size = new System.Drawing.Size(318, 304);
            this.lb_lista.TabIndex = 0;
            // 
            // button1
            // 
            this.b_zamknij.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_zamknij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_zamknij.Location = new System.Drawing.Point(6, 315);
            this.b_zamknij.Name = "button1";
            this.b_zamknij.Size = new System.Drawing.Size(312, 23);
            this.b_zamknij.TabIndex = 1;
            this.b_zamknij.Text = "Zamknij";
            this.b_zamknij.UseVisualStyleBackColor = true;
            this.b_zamknij.Click += new System.EventHandler(this.B_zamknij_Click);
            // 
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 347);
            this.Controls.Add(this.b_zamknij);
            this.Controls.Add(this.lb_lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormNotes";
            this.Padding = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Notatki";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_lista;
        private System.Windows.Forms.Button b_zamknij;
    }
}