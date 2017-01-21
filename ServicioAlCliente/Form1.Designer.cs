namespace ServicioAlCliente
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Atenderbutton = new System.Windows.Forms.Button();
            this.Añadirbutton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.ClientetextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cliente:";
            // 
            // Atenderbutton
            // 
            this.Atenderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atenderbutton.Location = new System.Drawing.Point(426, 116);
            this.Atenderbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Atenderbutton.Name = "Atenderbutton";
            this.Atenderbutton.Size = new System.Drawing.Size(100, 28);
            this.Atenderbutton.TabIndex = 13;
            this.Atenderbutton.Text = "Atender";
            this.Atenderbutton.UseVisualStyleBackColor = true;
            this.Atenderbutton.Click += new System.EventHandler(this.Atenderbutton_Click);
            // 
            // Añadirbutton
            // 
            this.Añadirbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Añadirbutton.Location = new System.Drawing.Point(426, 80);
            this.Añadirbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Añadirbutton.Name = "Añadirbutton";
            this.Añadirbutton.Size = new System.Drawing.Size(100, 28);
            this.Añadirbutton.TabIndex = 12;
            this.Añadirbutton.Text = "Anadir";
            this.Añadirbutton.UseVisualStyleBackColor = true;
            this.Añadirbutton.Click += new System.EventHandler(this.Añadirbutton_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(14, 80);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(376, 184);
            this.listBox.TabIndex = 11;
            // 
            // ClientetextBox
            // 
            this.ClientetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientetextBox.Location = new System.Drawing.Point(112, 36);
            this.ClientetextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientetextBox.Name = "ClientetextBox";
            this.ClientetextBox.Size = new System.Drawing.Size(162, 27);
            this.ClientetextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Atenderbutton);
            this.Controls.Add(this.Añadirbutton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.ClientetextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Atenderbutton;
        private System.Windows.Forms.Button Añadirbutton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox ClientetextBox;
    }
}

