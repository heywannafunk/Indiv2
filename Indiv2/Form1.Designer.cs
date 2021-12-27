namespace Indiv2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cubeSpecCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downWallSpecCheckBox = new System.Windows.Forms.CheckBox();
            this.sphereSpecCheckBox = new System.Windows.Forms.CheckBox();
            this.upWallSpecCheckBox = new System.Windows.Forms.CheckBox();
            this.rightWallSpecCheckBox = new System.Windows.Forms.CheckBox();
            this.frontWallSpecCheckBox = new System.Windows.Forms.CheckBox();
            this.leftWallSpecCheckBox = new System.Windows.Forms.CheckBox();
            this.backWallSpecCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sphereRefCheckBox = new System.Windows.Forms.CheckBox();
            this.cubeRefCheckBox = new System.Windows.Forms.CheckBox();
            this.twoLightsCB = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(145, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 640);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(791, 615);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Redraw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cubeSpecCheckBox
            // 
            this.cubeSpecCheckBox.AutoSize = true;
            this.cubeSpecCheckBox.Location = new System.Drawing.Point(8, 23);
            this.cubeSpecCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.cubeSpecCheckBox.Name = "cubeSpecCheckBox";
            this.cubeSpecCheckBox.Size = new System.Drawing.Size(63, 21);
            this.cubeSpecCheckBox.TabIndex = 2;
            this.cubeSpecCheckBox.Text = "Cube";
            this.cubeSpecCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.downWallSpecCheckBox);
            this.groupBox1.Controls.Add(this.sphereSpecCheckBox);
            this.groupBox1.Controls.Add(this.upWallSpecCheckBox);
            this.groupBox1.Controls.Add(this.cubeSpecCheckBox);
            this.groupBox1.Controls.Add(this.rightWallSpecCheckBox);
            this.groupBox1.Controls.Add(this.frontWallSpecCheckBox);
            this.groupBox1.Controls.Add(this.leftWallSpecCheckBox);
            this.groupBox1.Controls.Add(this.backWallSpecCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(125, 249);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Specularity";
            // 
            // downWallSpecCheckBox
            // 
            this.downWallSpecCheckBox.AutoSize = true;
            this.downWallSpecCheckBox.Location = new System.Drawing.Point(8, 222);
            this.downWallSpecCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.downWallSpecCheckBox.Name = "downWallSpecCheckBox";
            this.downWallSpecCheckBox.Size = new System.Drawing.Size(62, 21);
            this.downWallSpecCheckBox.TabIndex = 0;
            this.downWallSpecCheckBox.Text = "Floor";
            this.downWallSpecCheckBox.UseVisualStyleBackColor = true;
            // 
            // sphereSpecCheckBox
            // 
            this.sphereSpecCheckBox.AutoSize = true;
            this.sphereSpecCheckBox.Location = new System.Drawing.Point(8, 52);
            this.sphereSpecCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.sphereSpecCheckBox.Name = "sphereSpecCheckBox";
            this.sphereSpecCheckBox.Size = new System.Drawing.Size(76, 21);
            this.sphereSpecCheckBox.TabIndex = 2;
            this.sphereSpecCheckBox.Text = "Sphere";
            this.sphereSpecCheckBox.UseVisualStyleBackColor = true;
            // 
            // upWallSpecCheckBox
            // 
            this.upWallSpecCheckBox.AutoSize = true;
            this.upWallSpecCheckBox.Location = new System.Drawing.Point(8, 194);
            this.upWallSpecCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.upWallSpecCheckBox.Name = "upWallSpecCheckBox";
            this.upWallSpecCheckBox.Size = new System.Drawing.Size(72, 21);
            this.upWallSpecCheckBox.TabIndex = 0;
            this.upWallSpecCheckBox.Text = "Ceiling";
            this.upWallSpecCheckBox.UseVisualStyleBackColor = true;
            // 
            // rightWallSpecCheckBox
            // 
            this.rightWallSpecCheckBox.AutoSize = true;
            this.rightWallSpecCheckBox.Location = new System.Drawing.Point(8, 166);
            this.rightWallSpecCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.rightWallSpecCheckBox.Name = "rightWallSpecCheckBox";
            this.rightWallSpecCheckBox.Size = new System.Drawing.Size(90, 21);
            this.rightWallSpecCheckBox.TabIndex = 0;
            this.rightWallSpecCheckBox.Text = "Right wall";
            this.rightWallSpecCheckBox.UseVisualStyleBackColor = true;
            // 
            // frontWallSpecCheckBox
            // 
            this.frontWallSpecCheckBox.AutoSize = true;
            this.frontWallSpecCheckBox.Location = new System.Drawing.Point(8, 81);
            this.frontWallSpecCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.frontWallSpecCheckBox.Name = "frontWallSpecCheckBox";
            this.frontWallSpecCheckBox.Size = new System.Drawing.Size(90, 21);
            this.frontWallSpecCheckBox.TabIndex = 0;
            this.frontWallSpecCheckBox.Text = "Front wall";
            this.frontWallSpecCheckBox.UseVisualStyleBackColor = true;
            // 
            // leftWallSpecCheckBox
            // 
            this.leftWallSpecCheckBox.AutoSize = true;
            this.leftWallSpecCheckBox.Location = new System.Drawing.Point(8, 138);
            this.leftWallSpecCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.leftWallSpecCheckBox.Name = "leftWallSpecCheckBox";
            this.leftWallSpecCheckBox.Size = new System.Drawing.Size(81, 21);
            this.leftWallSpecCheckBox.TabIndex = 0;
            this.leftWallSpecCheckBox.Text = "Left wall";
            this.leftWallSpecCheckBox.UseVisualStyleBackColor = true;
            // 
            // backWallSpecCheckBox
            // 
            this.backWallSpecCheckBox.AutoSize = true;
            this.backWallSpecCheckBox.Location = new System.Drawing.Point(8, 109);
            this.backWallSpecCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.backWallSpecCheckBox.Name = "backWallSpecCheckBox";
            this.backWallSpecCheckBox.Size = new System.Drawing.Size(88, 21);
            this.backWallSpecCheckBox.TabIndex = 0;
            this.backWallSpecCheckBox.Text = "Back wall";
            this.backWallSpecCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sphereRefCheckBox);
            this.groupBox2.Controls.Add(this.cubeRefCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(792, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(125, 97);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transparancy";
            // 
            // sphereRefCheckBox
            // 
            this.sphereRefCheckBox.AutoSize = true;
            this.sphereRefCheckBox.Location = new System.Drawing.Point(8, 52);
            this.sphereRefCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.sphereRefCheckBox.Name = "sphereRefCheckBox";
            this.sphereRefCheckBox.Size = new System.Drawing.Size(76, 21);
            this.sphereRefCheckBox.TabIndex = 2;
            this.sphereRefCheckBox.Text = "Sphere";
            this.sphereRefCheckBox.UseVisualStyleBackColor = true;
            // 
            // cubeRefCheckBox
            // 
            this.cubeRefCheckBox.AutoSize = true;
            this.cubeRefCheckBox.Location = new System.Drawing.Point(8, 23);
            this.cubeRefCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.cubeRefCheckBox.Name = "cubeRefCheckBox";
            this.cubeRefCheckBox.Size = new System.Drawing.Size(63, 21);
            this.cubeRefCheckBox.TabIndex = 2;
            this.cubeRefCheckBox.Text = "Cube";
            this.cubeRefCheckBox.UseVisualStyleBackColor = true;
            // 
            // twoLightsCB
            // 
            this.twoLightsCB.AutoSize = true;
            this.twoLightsCB.Location = new System.Drawing.Point(7, 28);
            this.twoLightsCB.Margin = new System.Windows.Forms.Padding(4);
            this.twoLightsCB.Name = "twoLightsCB";
            this.twoLightsCB.Size = new System.Drawing.Size(93, 21);
            this.twoLightsCB.TabIndex = 4;
            this.twoLightsCB.Text = "Second pl";
            this.twoLightsCB.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.twoLightsCB);
            this.groupBox3.Location = new System.Drawing.Point(792, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 61);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lighting";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(791, 582);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(923, 655);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Indiv2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cubeSpecCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox sphereSpecCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox sphereRefCheckBox;
        private System.Windows.Forms.CheckBox cubeRefCheckBox;
        private System.Windows.Forms.CheckBox twoLightsCB;
        private System.Windows.Forms.CheckBox frontWallSpecCheckBox;
        private System.Windows.Forms.CheckBox rightWallSpecCheckBox;
        private System.Windows.Forms.CheckBox leftWallSpecCheckBox;
        private System.Windows.Forms.CheckBox backWallSpecCheckBox;
        private System.Windows.Forms.CheckBox downWallSpecCheckBox;
        private System.Windows.Forms.CheckBox upWallSpecCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
    }
}

