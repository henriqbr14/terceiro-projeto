namespace terceiroprojeto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TbValor1 = new TextBox();
            TbValor2 = new TextBox();
            lblvalor2 = new Label();
            lblvalor1 = new Label();
            LblTotal = new Label();
            LblResultado = new Label();
            btnsoma = new Button();
            SuspendLayout();
            // 
            // TbValor1
            // 
            TbValor1.Location = new Point(142, 60);
            TbValor1.Name = "TbValor1";
            TbValor1.Size = new Size(100, 23);
            TbValor1.TabIndex = 0;
            // 
            // TbValor2
            // 
            TbValor2.Location = new Point(142, 118);
            TbValor2.Name = "TbValor2";
            TbValor2.Size = new Size(100, 23);
            TbValor2.TabIndex = 1;
            // 
            // lblvalor2
            // 
            lblvalor2.AutoSize = true;
            lblvalor2.Location = new Point(94, 121);
            lblvalor2.Name = "lblvalor2";
            lblvalor2.Size = new Size(42, 15);
            lblvalor2.TabIndex = 2;
            lblvalor2.Text = "Valor 2";
            lblvalor2.Click += label1_Click;
            // 
            // lblvalor1
            // 
            lblvalor1.AutoSize = true;
            lblvalor1.Location = new Point(94, 60);
            lblvalor1.Name = "lblvalor1";
            lblvalor1.Size = new Size(42, 15);
            lblvalor1.TabIndex = 3;
            lblvalor1.Text = "Valor 1";
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Location = new Point(94, 180);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(32, 15);
            LblTotal.TabIndex = 4;
            LblTotal.Text = "Total";
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.Location = new Point(142, 180);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(16, 15);
            LblResultado.TabIndex = 5;
            LblResultado.Text = "...";
            // 
            // btnsoma
            // 
            btnsoma.Font = new Font("Segoe UI", 9F);
            btnsoma.Location = new Point(115, 240);
            btnsoma.Name = "btnsoma";
            btnsoma.Size = new Size(75, 23);
            btnsoma.TabIndex = 6;
            btnsoma.Text = "Soma";
            btnsoma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 450);
            Controls.Add(btnsoma);
            Controls.Add(LblResultado);
            Controls.Add(LblTotal);
            Controls.Add(lblvalor1);
            Controls.Add(lblvalor2);
            Controls.Add(TbValor2);
            Controls.Add(TbValor1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbValor1;
        private TextBox TbValor2;
        private Label lblvalor2;
        private Label lblvalor1;
        private Label LblTotal;
        private Label LblResultado;
        private Button btnsoma;
    }
}
