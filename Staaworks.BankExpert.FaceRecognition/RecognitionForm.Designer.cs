﻿namespace Staaworks.BankExpert.FaceRecognition
{
    partial class RecognitionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.RegBtn = new System.Windows.Forms.Button();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(12, 56);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(360, 235);
            this.imageBoxFrameGrabber.TabIndex = 5;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // RegBtn
            // 
            this.RegBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RegBtn.Location = new System.Drawing.Point(149, 297);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(80, 40);
            this.RegBtn.TabIndex = 6;
            this.RegBtn.Text = "Register Face";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Click += new System.EventHandler(this.AddFaceButton_Click);
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedbackLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.FeedbackLabel.Location = new System.Drawing.Point(129, 25);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(0, 13);
            this.FeedbackLabel.TabIndex = 7;
            // 
            // RecognitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.MaximumSize = new System.Drawing.Size(400, 380);
            this.Name = "RecognitionForm";
            this.Text = "FacialRecognition";
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.Label FeedbackLabel;
    }
}

