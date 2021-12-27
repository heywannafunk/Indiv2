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
            this.cubeSpecularCB = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downWallSpecularCB = new System.Windows.Forms.CheckBox();
            this.sphereSpecularCB = new System.Windows.Forms.CheckBox();
            this.upWallSpecularCB = new System.Windows.Forms.CheckBox();
            this.rightWallSpecularCB = new System.Windows.Forms.CheckBox();
            this.frontWallSpecularCB = new System.Windows.Forms.CheckBox();
            this.leftWallSpecularCB = new System.Windows.Forms.CheckBox();
            this.backWallSpecularCB = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refractSphereCB = new System.Windows.Forms.CheckBox();
            this.refractCubeCB = new System.Windows.Forms.CheckBox();
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
            // cubeSpecularCB
            // 
            this.cubeSpecularCB.AutoSize = true;
            this.cubeSpecularCB.Location = new System.Drawing.Point(8, 23);
            this.cubeSpecularCB.Margin = new System.Windows.Forms.Padding(4);
            this.cubeSpecularCB.Name = "cubeSpecularCB";
            this.cubeSpecularCB.Size = new System.Drawing.Size(63, 21);
            this.cubeSpecularCB.TabIndex = 2;
            this.cubeSpecularCB.Text = "Cube";
            this.cubeSpecularCB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.downWallSpecularCB);
            this.groupBox1.Controls.Add(this.sphereSpecularCB);
            this.groupBox1.Controls.Add(this.upWallSpecularCB);
            this.groupBox1.Controls.Add(this.cubeSpecularCB);
            this.groupBox1.Controls.Add(this.rightWallSpecularCB);
            this.groupBox1.Controls.Add(this.frontWallSpecularCB);
            this.groupBox1.Controls.Add(this.leftWallSpecularCB);
            this.groupBox1.Controls.Add(this.backWallSpecularCB);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(125, 249);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Specularity";
            // 
            // downWallSpecularCB
            // 
            this.downWallSpecularCB.AutoSize = true;
            this.downWallSpecularCB.Location = new System.Drawing.Point(8, 222);
            this.downWallSpecularCB.Margin = new System.Windows.Forms.Padding(4);
            this.downWallSpecularCB.Name = "downWallSpecularCB";
            this.downWallSpecularCB.Size = new System.Drawing.Size(62, 21);
            this.downWallSpecularCB.TabIndex = 0;
            this.downWallSpecularCB.Text = "Floor";
            this.downWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // sphereSpecularCB
            // 
            this.sphereSpecularCB.AutoSize = true;
            this.sphereSpecularCB.Location = new System.Drawing.Point(8, 52);
            this.sphereSpecularCB.Margin = new System.Windows.Forms.Padding(4);
            this.sphereSpecularCB.Name = "sphereSpecularCB";
            this.sphereSpecularCB.Size = new System.Drawing.Size(76, 21);
            this.sphereSpecularCB.TabIndex = 2;
            this.sphereSpecularCB.Text = "Sphere";
            this.sphereSpecularCB.UseVisualStyleBackColor = true;
            // 
            // upWallSpecularCB
            // 
            this.upWallSpecularCB.AutoSize = true;
            this.upWallSpecularCB.Location = new System.Drawing.Point(8, 194);
            this.upWallSpecularCB.Margin = new System.Windows.Forms.Padding(4);
            this.upWallSpecularCB.Name = "upWallSpecularCB";
            this.upWallSpecularCB.Size = new System.Drawing.Size(72, 21);
            this.upWallSpecularCB.TabIndex = 0;
            this.upWallSpecularCB.Text = "Ceiling";
            this.upWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // rightWallSpecularCB
            // 
            this.rightWallSpecularCB.AutoSize = true;
            this.rightWallSpecularCB.Location = new System.Drawing.Point(8, 166);
            this.rightWallSpecularCB.Margin = new System.Windows.Forms.Padding(4);
            this.rightWallSpecularCB.Name = "rightWallSpecularCB";
            this.rightWallSpecularCB.Size = new System.Drawing.Size(90, 21);
            this.rightWallSpecularCB.TabIndex = 0;
            this.rightWallSpecularCB.Text = "Right wall";
            this.rightWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // frontWallSpecularCB
            // 
            this.frontWallSpecularCB.AutoSize = true;
            this.frontWallSpecularCB.Location = new System.Drawing.Point(8, 81);
            this.frontWallSpecularCB.Margin = new System.Windows.Forms.Padding(4);
            this.frontWallSpecularCB.Name = "frontWallSpecularCB";
            this.frontWallSpecularCB.Size = new System.Drawing.Size(90, 21);
            this.frontWallSpecularCB.TabIndex = 0;
            this.frontWallSpecularCB.Text = "Front wall";
            this.frontWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // leftWallSpecularCB
            // 
            this.leftWallSpecularCB.AutoSize = true;
            this.leftWallSpecularCB.Location = new System.Drawing.Point(8, 138);
            this.leftWallSpecularCB.Margin = new System.Windows.Forms.Padding(4);
            this.leftWallSpecularCB.Name = "leftWallSpecularCB";
            this.leftWallSpecularCB.Size = new System.Drawing.Size(81, 21);
            this.leftWallSpecularCB.TabIndex = 0;
            this.leftWallSpecularCB.Text = "Left wall";
            this.leftWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // backWallSpecularCB
            // 
            this.backWallSpecularCB.AutoSize = true;
            this.backWallSpecularCB.Location = new System.Drawing.Point(8, 109);
            this.backWallSpecularCB.Margin = new System.Windows.Forms.Padding(4);
            this.backWallSpecularCB.Name = "backWallSpecularCB";
            this.backWallSpecularCB.Size = new System.Drawing.Size(88, 21);
            this.backWallSpecularCB.TabIndex = 0;
            this.backWallSpecularCB.Text = "Back wall";
            this.backWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.refractSphereCB);
            this.groupBox2.Controls.Add(this.refractCubeCB);
            this.groupBox2.Location = new System.Drawing.Point(792, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(125, 97);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transparancy";
            // 
            // refractSphereCB
            // 
            this.refractSphereCB.AutoSize = true;
            this.refractSphereCB.Location = new System.Drawing.Point(8, 52);
            this.refractSphereCB.Margin = new System.Windows.Forms.Padding(4);
            this.refractSphereCB.Name = "refractSphereCB";
            this.refractSphereCB.Size = new System.Drawing.Size(76, 21);
            this.refractSphereCB.TabIndex = 2;
            this.refractSphereCB.Text = "Sphere";
            this.refractSphereCB.UseVisualStyleBackColor = true;
            // 
            // refractCubeCB
            // 
            this.refractCubeCB.AutoSize = true;
            this.refractCubeCB.Location = new System.Drawing.Point(8, 23);
            this.refractCubeCB.Margin = new System.Windows.Forms.Padding(4);
            this.refractCubeCB.Name = "refractCubeCB";
            this.refractCubeCB.Size = new System.Drawing.Size(63, 21);
            this.refractCubeCB.TabIndex = 2;
            this.refractCubeCB.Text = "Cube";
            this.refractCubeCB.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.CheckBox cubeSpecularCB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox sphereSpecularCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox refractSphereCB;
        private System.Windows.Forms.CheckBox refractCubeCB;
        private System.Windows.Forms.CheckBox twoLightsCB;
        private System.Windows.Forms.CheckBox frontWallSpecularCB;
        private System.Windows.Forms.CheckBox rightWallSpecularCB;
        private System.Windows.Forms.CheckBox leftWallSpecularCB;
        private System.Windows.Forms.CheckBox backWallSpecularCB;
        private System.Windows.Forms.CheckBox downWallSpecularCB;
        private System.Windows.Forms.CheckBox upWallSpecularCB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
    }
}

