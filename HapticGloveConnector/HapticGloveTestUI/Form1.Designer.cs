namespace HapticGloveTestUI
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
            this.thumbLeft = new System.Windows.Forms.Button();
            this.indexLeft = new System.Windows.Forms.Button();
            this.lefthandPanel = new System.Windows.Forms.Panel();
            this.trackBarLeftThumb = new System.Windows.Forms.TrackBar();
            this.trackBarLeftIndex = new System.Windows.Forms.TrackBar();
            this.trackBarLeftMiddle = new System.Windows.Forms.TrackBar();
            this.trackBarLeftRing = new System.Windows.Forms.TrackBar();
            this.trackBarLeftPinky = new System.Windows.Forms.TrackBar();
            this.leftHandLabel = new System.Windows.Forms.Label();
            this.pinkyLeft = new System.Windows.Forms.Button();
            this.ringLeft = new System.Windows.Forms.Button();
            this.middleLeft = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.TextBox();
            this.rightHandPanel = new System.Windows.Forms.Panel();
            this.trackBarRightThumb = new System.Windows.Forms.TrackBar();
            this.trackBarRightIndex = new System.Windows.Forms.TrackBar();
            this.trackBarRightMiddle = new System.Windows.Forms.TrackBar();
            this.trackBarRightRing = new System.Windows.Forms.TrackBar();
            this.trackBarRightPinky = new System.Windows.Forms.TrackBar();
            this.rightHandLabel = new System.Windows.Forms.Label();
            this.pinkyRight = new System.Windows.Forms.Button();
            this.ringRight = new System.Windows.Forms.Button();
            this.middleRight = new System.Windows.Forms.Button();
            this.thumbRight = new System.Windows.Forms.Button();
            this.indexRight = new System.Windows.Forms.Button();
            this.lefthandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftThumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftRing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftPinky)).BeginInit();
            this.rightHandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRightThumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRightIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRightMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRightRing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRightPinky)).BeginInit();
            this.SuspendLayout();
            // 
            // thumbLeft
            // 
            this.thumbLeft.Location = new System.Drawing.Point(30, 68);
            this.thumbLeft.Name = "thumbLeft";
            this.thumbLeft.Size = new System.Drawing.Size(112, 44);
            this.thumbLeft.TabIndex = 0;
            this.thumbLeft.Text = "thumb";
            this.thumbLeft.UseVisualStyleBackColor = true;
            this.thumbLeft.Click += new System.EventHandler(this.button1_Click);
            // 
            // indexLeft
            // 
            this.indexLeft.Location = new System.Drawing.Point(30, 135);
            this.indexLeft.Name = "indexLeft";
            this.indexLeft.Size = new System.Drawing.Size(112, 47);
            this.indexLeft.TabIndex = 1;
            this.indexLeft.Text = "index finger";
            this.indexLeft.UseVisualStyleBackColor = true;
            this.indexLeft.Click += new System.EventHandler(this.button2_Click);
            // 
            // lefthandPanel
            // 
            this.lefthandPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lefthandPanel.Controls.Add(this.trackBarLeftThumb);
            this.lefthandPanel.Controls.Add(this.trackBarLeftIndex);
            this.lefthandPanel.Controls.Add(this.trackBarLeftMiddle);
            this.lefthandPanel.Controls.Add(this.trackBarLeftRing);
            this.lefthandPanel.Controls.Add(this.trackBarLeftPinky);
            this.lefthandPanel.Controls.Add(this.leftHandLabel);
            this.lefthandPanel.Controls.Add(this.pinkyLeft);
            this.lefthandPanel.Controls.Add(this.ringLeft);
            this.lefthandPanel.Controls.Add(this.middleLeft);
            this.lefthandPanel.Controls.Add(this.thumbLeft);
            this.lefthandPanel.Controls.Add(this.indexLeft);
            this.lefthandPanel.Location = new System.Drawing.Point(36, 57);
            this.lefthandPanel.Name = "lefthandPanel";
            this.lefthandPanel.Size = new System.Drawing.Size(264, 427);
            this.lefthandPanel.TabIndex = 2;
            // 
            // trackBarLeftThumb
            // 
            this.trackBarLeftThumb.Location = new System.Drawing.Point(158, 67);
            this.trackBarLeftThumb.Maximum = 31;
            this.trackBarLeftThumb.Name = "trackBarLeftThumb";
            this.trackBarLeftThumb.Size = new System.Drawing.Size(93, 45);
            this.trackBarLeftThumb.TabIndex = 10;
            this.trackBarLeftThumb.TickFrequency = 0;
            // 
            // trackBarLeftIndex
            // 
            this.trackBarLeftIndex.Location = new System.Drawing.Point(158, 137);
            this.trackBarLeftIndex.Maximum = 31;
            this.trackBarLeftIndex.Name = "trackBarLeftIndex";
            this.trackBarLeftIndex.Size = new System.Drawing.Size(93, 45);
            this.trackBarLeftIndex.TabIndex = 9;
            this.trackBarLeftIndex.TickFrequency = 0;
            // 
            // trackBarLeftMiddle
            // 
            this.trackBarLeftMiddle.Location = new System.Drawing.Point(158, 215);
            this.trackBarLeftMiddle.Maximum = 31;
            this.trackBarLeftMiddle.Name = "trackBarLeftMiddle";
            this.trackBarLeftMiddle.Size = new System.Drawing.Size(93, 45);
            this.trackBarLeftMiddle.TabIndex = 8;
            this.trackBarLeftMiddle.TickFrequency = 0;
            // 
            // trackBarLeftRing
            // 
            this.trackBarLeftRing.Location = new System.Drawing.Point(158, 283);
            this.trackBarLeftRing.Maximum = 31;
            this.trackBarLeftRing.Name = "trackBarLeftRing";
            this.trackBarLeftRing.Size = new System.Drawing.Size(93, 45);
            this.trackBarLeftRing.TabIndex = 7;
            this.trackBarLeftRing.TickFrequency = 0;
            // 
            // trackBarLeftPinky
            // 
            this.trackBarLeftPinky.Location = new System.Drawing.Point(158, 346);
            this.trackBarLeftPinky.Maximum = 31;
            this.trackBarLeftPinky.Name = "trackBarLeftPinky";
            this.trackBarLeftPinky.Size = new System.Drawing.Size(93, 45);
            this.trackBarLeftPinky.TabIndex = 6;
            this.trackBarLeftPinky.TickFrequency = 0;
            // 
            // leftHandLabel
            // 
            this.leftHandLabel.AutoSize = true;
            this.leftHandLabel.Location = new System.Drawing.Point(112, 18);
            this.leftHandLabel.Name = "leftHandLabel";
            this.leftHandLabel.Size = new System.Drawing.Size(48, 13);
            this.leftHandLabel.TabIndex = 5;
            this.leftHandLabel.Text = "left hand";
            this.leftHandLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pinkyLeft
            // 
            this.pinkyLeft.Location = new System.Drawing.Point(30, 346);
            this.pinkyLeft.Name = "pinkyLeft";
            this.pinkyLeft.Size = new System.Drawing.Size(112, 45);
            this.pinkyLeft.TabIndex = 4;
            this.pinkyLeft.Text = "pinky";
            this.pinkyLeft.UseVisualStyleBackColor = true;
            this.pinkyLeft.Click += new System.EventHandler(this.button5_Click);
            // 
            // ringLeft
            // 
            this.ringLeft.Location = new System.Drawing.Point(30, 283);
            this.ringLeft.Name = "ringLeft";
            this.ringLeft.Size = new System.Drawing.Size(112, 43);
            this.ringLeft.TabIndex = 3;
            this.ringLeft.Text = "ring finger";
            this.ringLeft.UseVisualStyleBackColor = true;
            this.ringLeft.Click += new System.EventHandler(this.button4_Click);
            // 
            // middleLeft
            // 
            this.middleLeft.Location = new System.Drawing.Point(30, 213);
            this.middleLeft.Name = "middleLeft";
            this.middleLeft.Size = new System.Drawing.Size(112, 47);
            this.middleLeft.TabIndex = 2;
            this.middleLeft.Text = "middle finger";
            this.middleLeft.UseVisualStyleBackColor = true;
            this.middleLeft.Click += new System.EventHandler(this.button3_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(269, 508);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(112, 47);
            this.connect.TabIndex = 6;
            this.connect.Text = "connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.button11_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(36, 572);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(590, 164);
            this.log.TabIndex = 7;
            this.log.TextChanged += new System.EventHandler(this.log_TextChanged);
            // 
            // rightHandPanel
            // 
            this.rightHandPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightHandPanel.Controls.Add(this.trackBarRightThumb);
            this.rightHandPanel.Controls.Add(this.trackBarRightIndex);
            this.rightHandPanel.Controls.Add(this.trackBarRightMiddle);
            this.rightHandPanel.Controls.Add(this.trackBarRightRing);
            this.rightHandPanel.Controls.Add(this.trackBarRightPinky);
            this.rightHandPanel.Controls.Add(this.rightHandLabel);
            this.rightHandPanel.Controls.Add(this.pinkyRight);
            this.rightHandPanel.Controls.Add(this.ringRight);
            this.rightHandPanel.Controls.Add(this.middleRight);
            this.rightHandPanel.Controls.Add(this.thumbRight);
            this.rightHandPanel.Controls.Add(this.indexRight);
            this.rightHandPanel.Location = new System.Drawing.Point(362, 57);
            this.rightHandPanel.Name = "rightHandPanel";
            this.rightHandPanel.Size = new System.Drawing.Size(264, 427);
            this.rightHandPanel.TabIndex = 8;
            // 
            // trackBarRightThumb
            // 
            this.trackBarRightThumb.Location = new System.Drawing.Point(158, 67);
            this.trackBarRightThumb.Maximum = 31;
            this.trackBarRightThumb.Name = "trackBarRightThumb";
            this.trackBarRightThumb.Size = new System.Drawing.Size(93, 45);
            this.trackBarRightThumb.TabIndex = 10;
            this.trackBarRightThumb.TickFrequency = 0;
            // 
            // trackBarRightIndex
            // 
            this.trackBarRightIndex.Location = new System.Drawing.Point(158, 137);
            this.trackBarRightIndex.Maximum = 31;
            this.trackBarRightIndex.Name = "trackBarRightIndex";
            this.trackBarRightIndex.Size = new System.Drawing.Size(93, 45);
            this.trackBarRightIndex.TabIndex = 9;
            this.trackBarRightIndex.TickFrequency = 0;
            // 
            // trackBarRightMiddle
            // 
            this.trackBarRightMiddle.Location = new System.Drawing.Point(158, 213);
            this.trackBarRightMiddle.Maximum = 31;
            this.trackBarRightMiddle.Name = "trackBarRightMiddle";
            this.trackBarRightMiddle.Size = new System.Drawing.Size(93, 45);
            this.trackBarRightMiddle.TabIndex = 8;
            this.trackBarRightMiddle.TickFrequency = 0;
            // 
            // trackBarRightRing
            // 
            this.trackBarRightRing.Location = new System.Drawing.Point(158, 283);
            this.trackBarRightRing.Maximum = 31;
            this.trackBarRightRing.Name = "trackBarRightRing";
            this.trackBarRightRing.Size = new System.Drawing.Size(93, 45);
            this.trackBarRightRing.TabIndex = 7;
            this.trackBarRightRing.TickFrequency = 0;
            // 
            // trackBarRightPinky
            // 
            this.trackBarRightPinky.Location = new System.Drawing.Point(158, 346);
            this.trackBarRightPinky.Maximum = 31;
            this.trackBarRightPinky.Name = "trackBarRightPinky";
            this.trackBarRightPinky.Size = new System.Drawing.Size(93, 45);
            this.trackBarRightPinky.TabIndex = 6;
            this.trackBarRightPinky.TickFrequency = 0;
            // 
            // rightHandLabel
            // 
            this.rightHandLabel.AutoSize = true;
            this.rightHandLabel.Location = new System.Drawing.Point(114, 18);
            this.rightHandLabel.Name = "rightHandLabel";
            this.rightHandLabel.Size = new System.Drawing.Size(54, 13);
            this.rightHandLabel.TabIndex = 5;
            this.rightHandLabel.Text = "right hand";
            this.rightHandLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // pinkyRight
            // 
            this.pinkyRight.Location = new System.Drawing.Point(30, 346);
            this.pinkyRight.Name = "pinkyRight";
            this.pinkyRight.Size = new System.Drawing.Size(112, 45);
            this.pinkyRight.TabIndex = 4;
            this.pinkyRight.Text = "pinky";
            this.pinkyRight.UseVisualStyleBackColor = true;
            this.pinkyRight.Click += new System.EventHandler(this.pinkyRight_Click);
            // 
            // ringRight
            // 
            this.ringRight.Location = new System.Drawing.Point(30, 283);
            this.ringRight.Name = "ringRight";
            this.ringRight.Size = new System.Drawing.Size(112, 43);
            this.ringRight.TabIndex = 3;
            this.ringRight.Text = "ring finger";
            this.ringRight.UseVisualStyleBackColor = true;
            this.ringRight.Click += new System.EventHandler(this.ringRight_Click);
            // 
            // middleRight
            // 
            this.middleRight.Location = new System.Drawing.Point(30, 213);
            this.middleRight.Name = "middleRight";
            this.middleRight.Size = new System.Drawing.Size(112, 47);
            this.middleRight.TabIndex = 2;
            this.middleRight.Text = "middle finger";
            this.middleRight.UseVisualStyleBackColor = true;
            this.middleRight.Click += new System.EventHandler(this.middleRight_Click);
            // 
            // thumbRight
            // 
            this.thumbRight.Location = new System.Drawing.Point(30, 68);
            this.thumbRight.Name = "thumbRight";
            this.thumbRight.Size = new System.Drawing.Size(112, 44);
            this.thumbRight.TabIndex = 0;
            this.thumbRight.Text = "thumb";
            this.thumbRight.UseVisualStyleBackColor = true;
            this.thumbRight.Click += new System.EventHandler(this.thumbRight_Click);
            // 
            // indexRight
            // 
            this.indexRight.Location = new System.Drawing.Point(30, 135);
            this.indexRight.Name = "indexRight";
            this.indexRight.Size = new System.Drawing.Size(112, 47);
            this.indexRight.TabIndex = 1;
            this.indexRight.Text = "index finger";
            this.indexRight.UseVisualStyleBackColor = true;
            this.indexRight.Click += new System.EventHandler(this.indexRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 748);
            this.Controls.Add(this.rightHandPanel);
            this.Controls.Add(this.log);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.lefthandPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.lefthandPanel.ResumeLayout(false);
            this.lefthandPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftThumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftRing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftPinky)).EndInit();
            this.rightHandPanel.ResumeLayout(false);
            this.rightHandPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRightThumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRightIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRightMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRightRing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRightPinky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button thumbLeft;
        private System.Windows.Forms.Button indexLeft;
        private System.Windows.Forms.Panel lefthandPanel;
        private System.Windows.Forms.Button middleLeft;
        private System.Windows.Forms.Label leftHandLabel;
        private System.Windows.Forms.Button pinkyLeft;
        private System.Windows.Forms.Button ringLeft;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TrackBar trackBarLeftThumb;
        private System.Windows.Forms.TrackBar trackBarLeftIndex;
        private System.Windows.Forms.TrackBar trackBarLeftMiddle;
        private System.Windows.Forms.TrackBar trackBarLeftRing;
        private System.Windows.Forms.TrackBar trackBarLeftPinky;
        private System.Windows.Forms.Panel rightHandPanel;
        private System.Windows.Forms.TrackBar trackBarRightThumb;
        private System.Windows.Forms.TrackBar trackBarRightIndex;
        private System.Windows.Forms.TrackBar trackBarRightMiddle;
        private System.Windows.Forms.TrackBar trackBarRightRing;
        private System.Windows.Forms.TrackBar trackBarRightPinky;
        private System.Windows.Forms.Label rightHandLabel;
        private System.Windows.Forms.Button pinkyRight;
        private System.Windows.Forms.Button ringRight;
        private System.Windows.Forms.Button middleRight;
        private System.Windows.Forms.Button thumbRight;
        private System.Windows.Forms.Button indexRight;
    }
}

