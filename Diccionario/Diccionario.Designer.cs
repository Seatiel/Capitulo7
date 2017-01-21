namespace Diccionario
{
    partial class Diccionario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Añadirbutton = new System.Windows.Forms.Button();
            this.DefiniciontextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.hashBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Definicion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre:";
            // 
            // Añadirbutton
            // 
            this.Añadirbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Añadirbutton.Location = new System.Drawing.Point(400, 140);
            this.Añadirbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Añadirbutton.Name = "Añadirbutton";
            this.Añadirbutton.Size = new System.Drawing.Size(100, 28);
            this.Añadirbutton.TabIndex = 15;
            this.Añadirbutton.Text = "Añadir";
            this.Añadirbutton.UseVisualStyleBackColor = true;
            this.Añadirbutton.Click += new System.EventHandler(this.Añadirbutton_Click);
            // 
            // DefiniciontextBox
            // 
            this.DefiniciontextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefiniciontextBox.Location = new System.Drawing.Point(150, 69);
            this.DefiniciontextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DefiniciontextBox.Name = "DefiniciontextBox";
            this.DefiniciontextBox.Size = new System.Drawing.Size(132, 27);
            this.DefiniciontextBox.TabIndex = 14;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombretextBox.Location = new System.Drawing.Point(150, 29);
            this.NombretextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(132, 27);
            this.NombretextBox.TabIndex = 13;
            // 
            // hashBox
            // 
            this.hashBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashBox.FormattingEnabled = true;
            this.hashBox.ItemHeight = 20;
            this.hashBox.Items.AddRange(new object[] {
            "Palabra                              Descripcion"});
            this.hashBox.Location = new System.Drawing.Point(34, 140);
            this.hashBox.Margin = new System.Windows.Forms.Padding(4);
            this.hashBox.Name = "hashBox";
            this.hashBox.Size = new System.Drawing.Size(345, 204);
            this.hashBox.TabIndex = 12;
            // 
            // Diccionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Añadirbutton);
            this.Controls.Add(this.DefiniciontextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.hashBox);
            this.Name = "Diccionario";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Añadirbutton;
        private System.Windows.Forms.TextBox DefiniciontextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.ListBox hashBox;
    }
}

