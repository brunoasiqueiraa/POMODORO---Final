﻿namespace WindowsFormsApplication1
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.label23 = new System.Windows.Forms.Label();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.btniniciar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltempo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label23.Location = new System.Drawing.Point(29, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(236, 31);
            this.label23.TabIndex = 47;
            this.label23.Text = "Realizando Tarefa";
            // 
            // tempo
            // 
            this.tempo.Interval = 10;
            this.tempo.Tick += new System.EventHandler(this.temp);
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(64, 109);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(267, 23);
            this.btniniciar.TabIndex = 62;
            this.btniniciar.Text = "Iniciar Pomodoris";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.iniciar);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(1089, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 39);
            this.label2.TabIndex = 63;
            this.label2.Text = "0";
            // 
            // lbltempo
            // 
            this.lbltempo.AutoSize = true;
            this.lbltempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbltempo.Location = new System.Drawing.Point(286, 241);
            this.lbltempo.Name = "lbltempo";
            this.lbltempo.Size = new System.Drawing.Size(0, 39);
            this.lbltempo.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Tempo Pomodori";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(624, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Quando o tempo do pomodori acabar faça uma pausa de 5 minutos caso seja seu 4° po" +
    "modori faça uma pausa de 15 a 30 minutos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(691, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 71;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(698, 431);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbltempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.label23);
            this.Name = "Form4";
            this.Text = "Realizando Tarefa";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Timer tempo;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}