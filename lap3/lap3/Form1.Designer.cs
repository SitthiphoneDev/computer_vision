namespace lap3
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
            pictureBox1 = new PictureBox();
            pictBoxGray = new PictureBox();
            lblX = new Label();
            lblY = new Label();
            lblValue = new Label();
            btnLoad = new Button();
            btnConverttoGray = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxGray).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(430, 373);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // pictBoxGray
            // 
            pictBoxGray.Location = new Point(484, 12);
            pictBoxGray.Name = "pictBoxGray";
            pictBoxGray.Size = new Size(430, 373);
            pictBoxGray.SizeMode = PictureBoxSizeMode.StretchImage;
            pictBoxGray.TabIndex = 1;
            pictBoxGray.TabStop = false;
            pictBoxGray.Click += pictureBox2_Click;
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(24, 457);
            lblX.Name = "lblX";
            lblX.Size = new Size(21, 20);
            lblX.TabIndex = 2;
            lblX.Text = "X:";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(139, 457);
            lblY.Name = "lblY";
            lblY.Size = new Size(20, 20);
            lblY.TabIndex = 3;
            lblY.Text = "Y:";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(269, 457);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(54, 20);
            lblValue.TabIndex = 4;
            lblValue.Text = "Values:";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(424, 450);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(91, 35);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnConverttoGray
            // 
            btnConverttoGray.Location = new Point(560, 450);
            btnConverttoGray.Name = "btnConverttoGray";
            btnConverttoGray.Size = new Size(172, 35);
            btnConverttoGray.TabIndex = 6;
            btnConverttoGray.Text = "Convert To Grayscale";
            btnConverttoGray.UseVisualStyleBackColor = true;
            btnConverttoGray.Click += btnConverttoGray_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(789, 450);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 35);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 512);
            Controls.Add(btnSave);
            Controls.Add(btnConverttoGray);
            Controls.Add(btnLoad);
            Controls.Add(lblValue);
            Controls.Add(lblY);
            Controls.Add(lblX);
            Controls.Add(pictBoxGray);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxGray).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictBoxGray;
        private Label lblX;
        private Label lblY;
        private Label lblValue;
        private Button btnLoad;
        private Button btnConverttoGray;
        private Button btnSave;
    }
}