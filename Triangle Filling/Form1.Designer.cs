namespace Triangle_Filling
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ObjectTextureButton = new System.Windows.Forms.Button();
            this.ObjectTextureImage = new System.Windows.Forms.PictureBox();
            this.ObjectColorRadioButtonTexture = new System.Windows.Forms.RadioButton();
            this.ObjectColorButton = new System.Windows.Forms.Button();
            this.ObjectColorImage = new System.Windows.Forms.PictureBox();
            this.ObjectColorRadioButtonConstant = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LightRadiusTextBox = new System.Windows.Forms.TextBox();
            this.LightVectorRadioButtonRadius = new System.Windows.Forms.RadioButton();
            this.LightVectorRadioButtonConstant = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NormalMapButton = new System.Windows.Forms.Button();
            this.NormalMapImage = new System.Windows.Forms.PictureBox();
            this.NormalMapRadioButtonNormalMap = new System.Windows.Forms.RadioButton();
            this.NormalVectorRadioButtonConstant = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ChangeHeightMapButton = new System.Windows.Forms.Button();
            this.HeightMapImage = new System.Windows.Forms.PictureBox();
            this.DisturbanceRadioButtonMap = new System.Windows.Forms.RadioButton();
            this.DisturbanceRadioButtonNone = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LightColorButton = new System.Windows.Forms.Button();
            this.LightColorImage = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectTextureImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectColorImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NormalMapImage)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightMapImage)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LightColorImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Image);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 753);
            this.splitContainer1.SplitterDistance = 393;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 753);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ObjectTextureButton);
            this.groupBox1.Controls.Add(this.ObjectTextureImage);
            this.groupBox1.Controls.Add(this.ObjectColorRadioButtonTexture);
            this.groupBox1.Controls.Add(this.ObjectColorButton);
            this.groupBox1.Controls.Add(this.ObjectColorImage);
            this.groupBox1.Controls.Add(this.ObjectColorRadioButtonConstant);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object color";
            // 
            // ObjectTextureButton
            // 
            this.ObjectTextureButton.Location = new System.Drawing.Point(226, 74);
            this.ObjectTextureButton.Name = "ObjectTextureButton";
            this.ObjectTextureButton.Size = new System.Drawing.Size(75, 30);
            this.ObjectTextureButton.TabIndex = 5;
            this.ObjectTextureButton.Text = "Change";
            this.ObjectTextureButton.UseVisualStyleBackColor = true;
            this.ObjectTextureButton.Click += new System.EventHandler(this.ObjectTextureButton_Click);
            // 
            // ObjectTextureImage
            // 
            this.ObjectTextureImage.Location = new System.Drawing.Point(112, 74);
            this.ObjectTextureImage.Name = "ObjectTextureImage";
            this.ObjectTextureImage.Size = new System.Drawing.Size(100, 64);
            this.ObjectTextureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ObjectTextureImage.TabIndex = 4;
            this.ObjectTextureImage.TabStop = false;
            this.ObjectTextureImage.BackgroundImageChanged += new System.EventHandler(this.ObjectTextureImage_BackgroundImageChanged);
            // 
            // ObjectColorRadioButtonTexture
            // 
            this.ObjectColorRadioButtonTexture.AutoSize = true;
            this.ObjectColorRadioButtonTexture.Location = new System.Drawing.Point(9, 79);
            this.ObjectColorRadioButtonTexture.Name = "ObjectColorRadioButtonTexture";
            this.ObjectColorRadioButtonTexture.Size = new System.Drawing.Size(77, 21);
            this.ObjectColorRadioButtonTexture.TabIndex = 3;
            this.ObjectColorRadioButtonTexture.Text = "Texture";
            this.ObjectColorRadioButtonTexture.UseVisualStyleBackColor = true;
            this.ObjectColorRadioButtonTexture.CheckedChanged += new System.EventHandler(this.ObjectColorRadioButtonTexture_CheckedChanged);
            // 
            // ObjectColorButton
            // 
            this.ObjectColorButton.Location = new System.Drawing.Point(226, 37);
            this.ObjectColorButton.Name = "ObjectColorButton";
            this.ObjectColorButton.Size = new System.Drawing.Size(75, 30);
            this.ObjectColorButton.TabIndex = 2;
            this.ObjectColorButton.Text = "Change";
            this.ObjectColorButton.UseVisualStyleBackColor = true;
            this.ObjectColorButton.Click += new System.EventHandler(this.ObjectColorButton_Click);
            // 
            // ObjectColorImage
            // 
            this.ObjectColorImage.Location = new System.Drawing.Point(112, 37);
            this.ObjectColorImage.Name = "ObjectColorImage";
            this.ObjectColorImage.Size = new System.Drawing.Size(100, 30);
            this.ObjectColorImage.TabIndex = 1;
            this.ObjectColorImage.TabStop = false;
            this.ObjectColorImage.BackColorChanged += new System.EventHandler(this.ObjectColorImage_BackColorChanged);
            // 
            // ObjectColorRadioButtonConstant
            // 
            this.ObjectColorRadioButtonConstant.AutoSize = true;
            this.ObjectColorRadioButtonConstant.Checked = true;
            this.ObjectColorRadioButtonConstant.Location = new System.Drawing.Point(9, 42);
            this.ObjectColorRadioButtonConstant.Name = "ObjectColorRadioButtonConstant";
            this.ObjectColorRadioButtonConstant.Size = new System.Drawing.Size(85, 21);
            this.ObjectColorRadioButtonConstant.TabIndex = 0;
            this.ObjectColorRadioButtonConstant.TabStop = true;
            this.ObjectColorRadioButtonConstant.Text = "Constant";
            this.ObjectColorRadioButtonConstant.UseVisualStyleBackColor = true;
            this.ObjectColorRadioButtonConstant.CheckedChanged += new System.EventHandler(this.ObjectColorRadioButtonConstant_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LightRadiusTextBox);
            this.groupBox2.Controls.Add(this.LightVectorRadioButtonRadius);
            this.groupBox2.Controls.Add(this.LightVectorRadioButtonConstant);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Light-direction vector";
            // 
            // LightRadiusTextBox
            // 
            this.LightRadiusTextBox.Location = new System.Drawing.Point(214, 64);
            this.LightRadiusTextBox.Name = "LightRadiusTextBox";
            this.LightRadiusTextBox.Size = new System.Drawing.Size(100, 22);
            this.LightRadiusTextBox.TabIndex = 4;
            // 
            // LightVectorRadioButtonRadius
            // 
            this.LightVectorRadioButtonRadius.AutoSize = true;
            this.LightVectorRadioButtonRadius.Location = new System.Drawing.Point(9, 64);
            this.LightVectorRadioButtonRadius.Name = "LightVectorRadioButtonRadius";
            this.LightVectorRadioButtonRadius.Size = new System.Drawing.Size(198, 21);
            this.LightVectorRadioButtonRadius.TabIndex = 3;
            this.LightVectorRadioButtonRadius.Text = "Animated on a sphere, R =";
            this.LightVectorRadioButtonRadius.UseVisualStyleBackColor = true;
            this.LightVectorRadioButtonRadius.CheckedChanged += new System.EventHandler(this.LightVectorRadioButtonRadius_CheckedChanged);
            // 
            // LightVectorRadioButtonConstant
            // 
            this.LightVectorRadioButtonConstant.AutoSize = true;
            this.LightVectorRadioButtonConstant.Checked = true;
            this.LightVectorRadioButtonConstant.Location = new System.Drawing.Point(9, 37);
            this.LightVectorRadioButtonConstant.Name = "LightVectorRadioButtonConstant";
            this.LightVectorRadioButtonConstant.Size = new System.Drawing.Size(146, 21);
            this.LightVectorRadioButtonConstant.TabIndex = 2;
            this.LightVectorRadioButtonConstant.TabStop = true;
            this.LightVectorRadioButtonConstant.Text = "Constant - [0, 0, 1]";
            this.LightVectorRadioButtonConstant.UseVisualStyleBackColor = true;
            this.LightVectorRadioButtonConstant.CheckedChanged += new System.EventHandler(this.LightVectorRadioButtonConstant_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NormalMapButton);
            this.groupBox3.Controls.Add(this.NormalMapImage);
            this.groupBox3.Controls.Add(this.NormalMapRadioButtonNormalMap);
            this.groupBox3.Controls.Add(this.NormalVectorRadioButtonConstant);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 453);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 144);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Normal vector N";
            // 
            // NormalMapButton
            // 
            this.NormalMapButton.Location = new System.Drawing.Point(226, 62);
            this.NormalMapButton.Name = "NormalMapButton";
            this.NormalMapButton.Size = new System.Drawing.Size(75, 29);
            this.NormalMapButton.TabIndex = 4;
            this.NormalMapButton.Text = "Change";
            this.NormalMapButton.UseVisualStyleBackColor = true;
            this.NormalMapButton.Click += new System.EventHandler(this.NormalMapButton_Click);
            // 
            // NormalMapImage
            // 
            this.NormalMapImage.Location = new System.Drawing.Point(120, 62);
            this.NormalMapImage.Name = "NormalMapImage";
            this.NormalMapImage.Size = new System.Drawing.Size(100, 76);
            this.NormalMapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NormalMapImage.TabIndex = 3;
            this.NormalMapImage.TabStop = false;
            this.NormalMapImage.BackgroundImageChanged += new System.EventHandler(this.NormalMapImage_BackgroundImageChanged);
            // 
            // NormalMapRadioButtonNormalMap
            // 
            this.NormalMapRadioButtonNormalMap.AutoSize = true;
            this.NormalMapRadioButtonNormalMap.Location = new System.Drawing.Point(9, 62);
            this.NormalMapRadioButtonNormalMap.Name = "NormalMapRadioButtonNormalMap";
            this.NormalMapRadioButtonNormalMap.Size = new System.Drawing.Size(105, 21);
            this.NormalMapRadioButtonNormalMap.TabIndex = 2;
            this.NormalMapRadioButtonNormalMap.Text = "Normal map";
            this.NormalMapRadioButtonNormalMap.UseVisualStyleBackColor = true;
            this.NormalMapRadioButtonNormalMap.CheckedChanged += new System.EventHandler(this.NormalMapRadioButtonNormalMap_CheckedChanged);
            // 
            // NormalVectorRadioButtonConstant
            // 
            this.NormalVectorRadioButtonConstant.AutoSize = true;
            this.NormalVectorRadioButtonConstant.Checked = true;
            this.NormalVectorRadioButtonConstant.Location = new System.Drawing.Point(9, 35);
            this.NormalVectorRadioButtonConstant.Name = "NormalVectorRadioButtonConstant";
            this.NormalVectorRadioButtonConstant.Size = new System.Drawing.Size(146, 21);
            this.NormalVectorRadioButtonConstant.TabIndex = 1;
            this.NormalVectorRadioButtonConstant.TabStop = true;
            this.NormalVectorRadioButtonConstant.Text = "Constant - [0, 0, 1]";
            this.NormalVectorRadioButtonConstant.UseVisualStyleBackColor = true;
            this.NormalVectorRadioButtonConstant.CheckedChanged += new System.EventHandler(this.NormalVectorRadioButtonConstant_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ChangeHeightMapButton);
            this.groupBox4.Controls.Add(this.HeightMapImage);
            this.groupBox4.Controls.Add(this.DisturbanceRadioButtonMap);
            this.groupBox4.Controls.Add(this.DisturbanceRadioButtonNone);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 603);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 147);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Disturbance vector D";
            // 
            // ChangeHeightMapButton
            // 
            this.ChangeHeightMapButton.Location = new System.Drawing.Point(218, 65);
            this.ChangeHeightMapButton.Name = "ChangeHeightMapButton";
            this.ChangeHeightMapButton.Size = new System.Drawing.Size(75, 29);
            this.ChangeHeightMapButton.TabIndex = 3;
            this.ChangeHeightMapButton.Text = "Change";
            this.ChangeHeightMapButton.UseVisualStyleBackColor = true;
            this.ChangeHeightMapButton.Click += new System.EventHandler(this.ChangeHeightMapButton_Click);
            // 
            // HeightMapImage
            // 
            this.HeightMapImage.Location = new System.Drawing.Point(112, 65);
            this.HeightMapImage.Name = "HeightMapImage";
            this.HeightMapImage.Size = new System.Drawing.Size(100, 76);
            this.HeightMapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeightMapImage.TabIndex = 2;
            this.HeightMapImage.TabStop = false;
            this.HeightMapImage.BackgroundImageChanged += new System.EventHandler(this.HeightMapImage_BackgroundImageChanged);
            // 
            // DisturbanceRadioButtonMap
            // 
            this.DisturbanceRadioButtonMap.AutoSize = true;
            this.DisturbanceRadioButtonMap.Location = new System.Drawing.Point(9, 65);
            this.DisturbanceRadioButtonMap.Name = "DisturbanceRadioButtonMap";
            this.DisturbanceRadioButtonMap.Size = new System.Drawing.Size(97, 21);
            this.DisturbanceRadioButtonMap.TabIndex = 1;
            this.DisturbanceRadioButtonMap.Text = "HeightMap";
            this.DisturbanceRadioButtonMap.UseVisualStyleBackColor = true;
            this.DisturbanceRadioButtonMap.CheckedChanged += new System.EventHandler(this.DisturbanceRadioButtonMap_CheckedChanged);
            // 
            // DisturbanceRadioButtonNone
            // 
            this.DisturbanceRadioButtonNone.AutoSize = true;
            this.DisturbanceRadioButtonNone.Checked = true;
            this.DisturbanceRadioButtonNone.Location = new System.Drawing.Point(9, 38);
            this.DisturbanceRadioButtonNone.Name = "DisturbanceRadioButtonNone";
            this.DisturbanceRadioButtonNone.Size = new System.Drawing.Size(124, 21);
            this.DisturbanceRadioButtonNone.TabIndex = 0;
            this.DisturbanceRadioButtonNone.TabStop = true;
            this.DisturbanceRadioButtonNone.Text = "None - [0, 0, 0]";
            this.DisturbanceRadioButtonNone.UseVisualStyleBackColor = true;
            this.DisturbanceRadioButtonNone.CheckedChanged += new System.EventHandler(this.DisturbanceRadioButtonNone_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LightColorButton);
            this.groupBox5.Controls.Add(this.LightColorImage);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(387, 144);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Light color";
            // 
            // LightColorButton
            // 
            this.LightColorButton.Location = new System.Drawing.Point(226, 35);
            this.LightColorButton.Name = "LightColorButton";
            this.LightColorButton.Size = new System.Drawing.Size(75, 30);
            this.LightColorButton.TabIndex = 5;
            this.LightColorButton.Text = "Change";
            this.LightColorButton.UseVisualStyleBackColor = true;
            this.LightColorButton.Click += new System.EventHandler(this.LightColorButton_Click);
            // 
            // LightColorImage
            // 
            this.LightColorImage.Location = new System.Drawing.Point(112, 35);
            this.LightColorImage.Name = "LightColorImage";
            this.LightColorImage.Size = new System.Drawing.Size(100, 30);
            this.LightColorImage.TabIndex = 4;
            this.LightColorImage.TabStop = false;
            this.LightColorImage.BackColorChanged += new System.EventHandler(this.LightColorImage_BackColorChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Constant";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Image
            // 
            this.Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Image.Location = new System.Drawing.Point(0, 0);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(785, 753);
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Lambertian reflectance model";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectTextureImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectColorImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NormalMapImage)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightMapImage)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LightColorImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button ChangeHeightMapButton;
        private System.Windows.Forms.PictureBox HeightMapImage;
        private System.Windows.Forms.RadioButton DisturbanceRadioButtonMap;
        private System.Windows.Forms.RadioButton DisturbanceRadioButtonNone;
        private System.Windows.Forms.RadioButton NormalMapRadioButtonNormalMap;
        private System.Windows.Forms.RadioButton NormalVectorRadioButtonConstant;
        private System.Windows.Forms.Button NormalMapButton;
        private System.Windows.Forms.PictureBox NormalMapImage;
        private System.Windows.Forms.RadioButton LightVectorRadioButtonConstant;
        private System.Windows.Forms.TextBox LightRadiusTextBox;
        private System.Windows.Forms.RadioButton LightVectorRadioButtonRadius;
        private System.Windows.Forms.Button ObjectTextureButton;
        private System.Windows.Forms.PictureBox ObjectTextureImage;
        private System.Windows.Forms.RadioButton ObjectColorRadioButtonTexture;
        private System.Windows.Forms.Button ObjectColorButton;
        private System.Windows.Forms.PictureBox ObjectColorImage;
        private System.Windows.Forms.RadioButton ObjectColorRadioButtonConstant;
        private System.Windows.Forms.Button LightColorButton;
        private System.Windows.Forms.PictureBox LightColorImage;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

