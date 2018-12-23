namespace lab1
{
    partial class FormGruzConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSamosval = new System.Windows.Forms.Label();
            this.labelGruz = new System.Windows.Forms.Label();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.KlazBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSamosval);
            this.groupBox1.Controls.Add(this.labelGruz);
            this.groupBox1.Location = new System.Drawing.Point(48, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип кузова";
            // 
            // labelSamosval
            // 
            this.labelSamosval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSamosval.Location = new System.Drawing.Point(26, 102);
            this.labelSamosval.Name = "labelSamosval";
            this.labelSamosval.Padding = new System.Windows.Forms.Padding(30, 5, 3, 0);
            this.labelSamosval.Size = new System.Drawing.Size(131, 33);
            this.labelSamosval.TabIndex = 2;
            this.labelSamosval.Text = "Самосвал";
            this.labelSamosval.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSamosval_MouseDown);
            // 
            // labelGruz
            // 
            this.labelGruz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGruz.Location = new System.Drawing.Point(26, 35);
            this.labelGruz.Name = "labelGruz";
            this.labelGruz.Padding = new System.Windows.Forms.Padding(30, 5, 3, 0);
            this.labelGruz.Size = new System.Drawing.Size(131, 33);
            this.labelGruz.TabIndex = 1;
            this.labelGruz.Text = "Грузовик";
            this.labelGruz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Location = new System.Drawing.Point(44, 17);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(175, 149);
            this.pictureBoxCar.TabIndex = 1;
            this.pictureBoxCar.TabStop = false;
            this.pictureBoxCar.Click += new System.EventHandler(this.pictureBoxCar_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxCar);
            this.panel1.Location = new System.Drawing.Point(295, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 276);
            this.panel1.TabIndex = 2;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(44, 233);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(46, 5, 3, 0);
            this.label2.Size = new System.Drawing.Size(175, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Доп. Цвет";
            this.label2.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.label2.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(44, 184);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(35, 5, 3, 0);
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Основной цвет";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel9);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(605, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 276);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel6.Location = new System.Drawing.Point(82, 210);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(38, 37);
            this.panel6.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(82, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(38, 37);
            this.panel4.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Yellow;
            this.panel7.Location = new System.Drawing.Point(82, 158);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(38, 37);
            this.panel7.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(82, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(38, 37);
            this.panel3.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Silver;
            this.panel8.Location = new System.Drawing.Point(19, 210);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(38, 37);
            this.panel8.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Chartreuse;
            this.panel5.Location = new System.Drawing.Point(19, 98);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(38, 37);
            this.panel5.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Red;
            this.panel9.Location = new System.Drawing.Point(19, 158);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(38, 37);
            this.panel9.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(19, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 37);
            this.panel2.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(48, 249);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(179, 39);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(48, 292);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(179, 39);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // KlazBtn
            // 
            this.KlazBtn.Location = new System.Drawing.Point(650, 19);
            this.KlazBtn.Name = "KlazBtn";
            this.KlazBtn.Size = new System.Drawing.Size(75, 30);
            this.KlazBtn.TabIndex = 6;
            this.KlazBtn.Text = "Клац!";
            this.KlazBtn.UseVisualStyleBackColor = true;
            this.KlazBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGruzConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 343);
            this.Controls.Add(this.KlazBtn);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGruzConfig";
            this.Text = "FormGruzConfig";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSamosval;
        private System.Windows.Forms.Label labelGruz;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button KlazBtn;
    }
}