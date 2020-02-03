﻿namespace FontTool
{
    partial class MainForm
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
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.font = new System.Windows.Forms.TextBox();
            this.pick = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hint = new System.Windows.Forms.ComboBox();
            this.browse = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.size = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.style = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.display = new FontTool.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Text";
            // 
            // text
            // 
            this.text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text.Location = new System.Drawing.Point(16, 30);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(756, 20);
            this.text.TabIndex = 1;
            this.text.TextChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Font";
            // 
            // font
            // 
            this.font.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.font.Location = new System.Drawing.Point(16, 74);
            this.font.Name = "font";
            this.font.ReadOnly = true;
            this.font.Size = new System.Drawing.Size(213, 20);
            this.font.TabIndex = 3;
            // 
            // pick
            // 
            this.pick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pick.Location = new System.Drawing.Point(428, 71);
            this.pick.Name = "pick";
            this.pick.Size = new System.Drawing.Size(75, 23);
            this.pick.TabIndex = 4;
            this.pick.Text = "Pick...";
            this.pick.UseVisualStyleBackColor = true;
            this.pick.Click += new System.EventHandler(this.pick_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rendering Hint";
            // 
            // hint
            // 
            this.hint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hint.FormattingEnabled = true;
            this.hint.Location = new System.Drawing.Point(590, 73);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(164, 21);
            this.hint.TabIndex = 6;
            this.hint.SelectedIndexChanged += new System.EventHandler(this.Hint_SelectedIndexChanged);
            // 
            // browse
            // 
            this.browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browse.Location = new System.Drawing.Point(509, 71);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 5;
            this.browse.Text = "Browse...";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "TrueType Font (*.ttf)|*.ttf";
            // 
            // size
            // 
            this.size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.size.Location = new System.Drawing.Point(235, 74);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(59, 20);
            this.size.TabIndex = 8;
            this.size.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.size.ValueChanged += new System.EventHandler(this.Size_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Size";
            // 
            // style
            // 
            this.style.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.style.FormattingEnabled = true;
            this.style.Location = new System.Drawing.Point(301, 72);
            this.style.Name = "style";
            this.style.Size = new System.Drawing.Size(121, 21);
            this.style.TabIndex = 10;
            this.style.SelectedIndexChanged += new System.EventHandler(this.Style_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Style";
            // 
            // display
            // 
            this.display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.display.Location = new System.Drawing.Point(16, 110);
            this.display.Name = "display";
            this.display.Padding = new System.Windows.Forms.Padding(3);
            this.display.Size = new System.Drawing.Size(756, 322);
            this.display.TabIndex = 7;
            this.display.Text = "text";
            this.display.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.display.Paint += new System.Windows.Forms.PaintEventHandler(this.Display_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.style);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.size);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.display);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pick);
            this.Controls.Add(this.font);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Font Tool";
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox font;
        private System.Windows.Forms.Button pick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hint;
        private CustomLabel display;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.NumericUpDown size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox style;
        private System.Windows.Forms.Label label5;
    }
}

