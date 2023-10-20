namespace Practica_19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cal1 = new TextBox();
            cal2 = new TextBox();
            cal3 = new TextBox();
            cal4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            promedio = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(585, 104);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 141);
            label2.Name = "label2";
            label2.Size = new Size(139, 26);
            label2.TabIndex = 1;
            label2.Text = "Calificación 1";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 185);
            label3.Name = "label3";
            label3.Size = new Size(139, 26);
            label3.TabIndex = 2;
            label3.Text = "Calificación 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(310, 141);
            label4.Name = "label4";
            label4.Size = new Size(139, 26);
            label4.TabIndex = 3;
            label4.Text = "Calificación 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(310, 185);
            label5.Name = "label5";
            label5.Size = new Size(139, 26);
            label5.TabIndex = 4;
            label5.Text = "Calificación 4";
            // 
            // cal1
            // 
            cal1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cal1.Location = new Point(176, 138);
            cal1.Name = "cal1";
            cal1.Size = new Size(118, 33);
            cal1.TabIndex = 5;
            // 
            // cal2
            // 
            cal2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cal2.Location = new Point(176, 182);
            cal2.Name = "cal2";
            cal2.Size = new Size(118, 33);
            cal2.TabIndex = 6;
            // 
            // cal3
            // 
            cal3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cal3.Location = new Point(455, 138);
            cal3.Name = "cal3";
            cal3.Size = new Size(118, 33);
            cal3.TabIndex = 7;
            // 
            // cal4
            // 
            cal4.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cal4.Location = new Point(455, 182);
            cal4.Name = "cal4";
            cal4.Size = new Size(118, 33);
            cal4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(121, 234);
            button1.Name = "button1";
            button1.Size = new Size(110, 36);
            button1.TabIndex = 9;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(260, 234);
            button2.Name = "button2";
            button2.Size = new Size(110, 36);
            button2.TabIndex = 10;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(399, 234);
            button3.Name = "button3";
            button3.Size = new Size(110, 36);
            button3.TabIndex = 11;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(187, 313);
            label6.Name = "label6";
            label6.Size = new Size(107, 26);
            label6.TabIndex = 12;
            label6.Text = "Promedio:";
            // 
            // promedio
            // 
            promedio.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            promedio.Location = new Point(310, 310);
            promedio.Name = "promedio";
            promedio.Size = new Size(116, 33);
            promedio.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 362);
            Controls.Add(promedio);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cal4);
            Controls.Add(cal3);
            Controls.Add(cal2);
            Controls.Add(cal1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Practica 19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox cal1;
        private TextBox cal2;
        private TextBox cal3;
        private TextBox cal4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label6;
        private TextBox promedio;
    }
}