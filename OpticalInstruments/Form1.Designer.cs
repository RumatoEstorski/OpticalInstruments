namespace OpticalInstruments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pbLense = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Focus = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Focus)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выпуклая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(662, 334);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(73, 74);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 3;
            this.pb1.TabStop = false;
            this.pb1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            this.pb1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseEvent);
            // 
            // pb2
            // 
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(178, 78);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(82, 74);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 4;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            this.pb2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            // 
            // pbLense
            // 
            this.pbLense.Image = ((System.Drawing.Image)(resources.GetObject("pbLense.Image")));
            this.pbLense.Location = new System.Drawing.Point(420, 144);
            this.pbLense.Name = "pbLense";
            this.pbLense.Size = new System.Drawing.Size(56, 191);
            this.pbLense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLense.TabIndex = 5;
            this.pbLense.TabStop = false;
            this.pbLense.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            this.pbLense.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseEvent);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(725, 89);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Вогнутая";
            this.button6.UseVisualStyleBackColor = true;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите фокус:";
            // 
            // Focus
            // 
            this.Focus.Location = new System.Drawing.Point(725, 9);
            this.Focus.Maximum = 5;
            this.Focus.Minimum = 1;
            this.Focus.Name = "Focus";
            this.Focus.Size = new System.Drawing.Size(115, 45);
            this.Focus.TabIndex = 10;
            this.Focus.Value = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 494);
            this.Controls.Add(this.Focus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pbLense);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Focus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pbLense;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar Focus;
    }
}

