using Practica_1.Properties;
namespace Practica_1
{
    partial class Practica_1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Practica_1));
            lblReloj = new Label();
            tmrReloj = new System.Windows.Forms.Timer(components);
            btnIniciar = new Button();
            btnDetener = new Button();
            btnReiniciar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblReloj
            // 
            lblReloj.AutoSize = true;
            lblReloj.Font = new Font("Arial Black", 48F, FontStyle.Bold);
            lblReloj.Location = new Point(139, 102);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(505, 136);
            lblReloj.TabIndex = 0;
            lblReloj.Text = "00:00:00";
            // 
            // tmrReloj
            // 
            tmrReloj.Interval = 1000;
            tmrReloj.Tick += tmrReloj_Tick;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Image = (Image)resources.GetObject("btnIniciar.Image");
            btnIniciar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIniciar.Location = new Point(70, 264);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(171, 102);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.TextAlign = ContentAlignment.MiddleRight;
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Font = new Font("Arial", 15F, FontStyle.Bold);
            btnDetener.Image = Resources.Imagen_2;
            btnDetener.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetener.Location = new Point(294, 264);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(197, 102);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "Detener";
            btnDetener.TextAlign = ContentAlignment.MiddleRight;
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Font = new Font("Arial", 15F, FontStyle.Bold);
            btnReiniciar.Image = Resources.Imagen_3;
            btnReiniciar.ImageAlign = ContentAlignment.MiddleLeft;
            btnReiniciar.Location = new Point(543, 264);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(211, 102);
            btnReiniciar.TabIndex = 3;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.TextAlign = ContentAlignment.MiddleRight;
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(203, 70);
            label1.Name = "label1";
            label1.Size = new Size(51, 54);
            label1.TabIndex = 4;
            label1.Text = "H";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(358, 70);
            label2.Name = "label2";
            label2.Size = new Size(59, 54);
            label2.TabIndex = 5;
            label2.Text = "M";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(529, 70);
            label3.Name = "label3";
            label3.Size = new Size(44, 54);
            label3.TabIndex = 6;
            label3.Text = "S";
            // 
            // Practica_1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnReiniciar);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(lblReloj);
            Name = "Practica_1";
            Text = "Practica 1, Cronómetro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReloj;
        private System.Windows.Forms.Timer tmrReloj;
        private Button btnIniciar;
        private Button btnDetener;
        private Button btnReiniciar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
