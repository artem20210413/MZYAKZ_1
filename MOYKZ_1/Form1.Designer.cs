namespace MOYKZ_1
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
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonGray = new System.Windows.Forms.Button();
            this.buttonInversion = new System.Windows.Forms.Button();
            this.sizeInput = new System.Windows.Forms.Label();
            this.sizeOutput = new System.Windows.Forms.Label();
            this.buttonBinarization = new System.Windows.Forms.Button();
            this.buttonIncreaseSize = new System.Windows.Forms.Button();
            this.buttonСontrasting = new System.Windows.Forms.Button();
            this.buttonIntropolation = new System.Windows.Forms.Button();
            this.buttonHistogram = new System.Windows.Forms.Button();
            this.textBoxBinarization = new System.Windows.Forms.TextBox();
            this.cumulativeHistogram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.Location = new System.Drawing.Point(12, 28);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(795, 570);
            this.pictureBoxInput.TabIndex = 0;
            this.pictureBoxInput.TabStop = false;
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.Location = new System.Drawing.Point(834, 28);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Size = new System.Drawing.Size(795, 570);
            this.pictureBoxOutput.TabIndex = 1;
            this.pictureBoxOutput.TabStop = false;
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(12, 604);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(795, 201);
            this.buttonUpload.TabIndex = 2;
            this.buttonUpload.Text = "Upload picture";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonGray
            // 
            this.buttonGray.Location = new System.Drawing.Point(834, 604);
            this.buttonGray.Name = "buttonGray";
            this.buttonGray.Size = new System.Drawing.Size(239, 52);
            this.buttonGray.TabIndex = 3;
            this.buttonGray.Text = "Convert to gray";
            this.buttonGray.UseVisualStyleBackColor = true;
            this.buttonGray.Click += new System.EventHandler(this.buttonGray_Click);
            // 
            // buttonInversion
            // 
            this.buttonInversion.Location = new System.Drawing.Point(834, 662);
            this.buttonInversion.Name = "buttonInversion";
            this.buttonInversion.Size = new System.Drawing.Size(239, 52);
            this.buttonInversion.TabIndex = 5;
            this.buttonInversion.Text = "Color inversion";
            this.buttonInversion.UseVisualStyleBackColor = true;
            this.buttonInversion.Click += new System.EventHandler(this.buttonInversion_Click);
            // 
            // sizeInput
            // 
            this.sizeInput.AutoSize = true;
            this.sizeInput.Location = new System.Drawing.Point(12, 9);
            this.sizeInput.Name = "sizeInput";
            this.sizeInput.Size = new System.Drawing.Size(61, 16);
            this.sizeInput.TabIndex = 6;
            this.sizeInput.Text = "SizeInput";
            // 
            // sizeOutput
            // 
            this.sizeOutput.AutoSize = true;
            this.sizeOutput.Location = new System.Drawing.Point(831, 9);
            this.sizeOutput.Name = "sizeOutput";
            this.sizeOutput.Size = new System.Drawing.Size(71, 16);
            this.sizeOutput.TabIndex = 7;
            this.sizeOutput.Text = "SizeOutput";
            // 
            // buttonBinarization
            // 
            this.buttonBinarization.Location = new System.Drawing.Point(1112, 604);
            this.buttonBinarization.Name = "buttonBinarization";
            this.buttonBinarization.Size = new System.Drawing.Size(239, 52);
            this.buttonBinarization.TabIndex = 8;
            this.buttonBinarization.Text = "Binarization";
            this.buttonBinarization.UseVisualStyleBackColor = true;
            this.buttonBinarization.Click += new System.EventHandler(this.buttonBinarization_Click);
            // 
            // buttonIncreaseSize
            // 
            this.buttonIncreaseSize.Location = new System.Drawing.Point(1390, 604);
            this.buttonIncreaseSize.Name = "buttonIncreaseSize";
            this.buttonIncreaseSize.Size = new System.Drawing.Size(239, 52);
            this.buttonIncreaseSize.TabIndex = 10;
            this.buttonIncreaseSize.Text = "Extropolation";
            this.buttonIncreaseSize.UseVisualStyleBackColor = true;
            this.buttonIncreaseSize.Click += new System.EventHandler(this.buttonIncreaseSize_Click);
            // 
            // buttonСontrasting
            // 
            this.buttonСontrasting.Location = new System.Drawing.Point(834, 720);
            this.buttonСontrasting.Name = "buttonСontrasting";
            this.buttonСontrasting.Size = new System.Drawing.Size(239, 52);
            this.buttonСontrasting.TabIndex = 11;
            this.buttonСontrasting.Text = "Сontrasting";
            this.buttonСontrasting.UseVisualStyleBackColor = true;
            this.buttonСontrasting.Click += new System.EventHandler(this.buttonСontrasting_Click);
            // 
            // buttonIntropolation
            // 
            this.buttonIntropolation.Location = new System.Drawing.Point(1390, 662);
            this.buttonIntropolation.Name = "buttonIntropolation";
            this.buttonIntropolation.Size = new System.Drawing.Size(239, 52);
            this.buttonIntropolation.TabIndex = 12;
            this.buttonIntropolation.Text = "Intropolation";
            this.buttonIntropolation.UseVisualStyleBackColor = true;
            this.buttonIntropolation.Click += new System.EventHandler(this.buttonIntropolation_Click);
            // 
            // buttonHistogram
            // 
            this.buttonHistogram.Location = new System.Drawing.Point(1112, 695);
            this.buttonHistogram.Name = "buttonHistogram";
            this.buttonHistogram.Size = new System.Drawing.Size(239, 52);
            this.buttonHistogram.TabIndex = 13;
            this.buttonHistogram.Text = "linear histogram";
            this.buttonHistogram.UseVisualStyleBackColor = true;
            this.buttonHistogram.Click += new System.EventHandler(this.buttonLinearHistogram_Click);
            // 
            // textBoxBinarization
            // 
            this.textBoxBinarization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBinarization.Location = new System.Drawing.Point(1112, 662);
            this.textBoxBinarization.Name = "textBoxBinarization";
            this.textBoxBinarization.Size = new System.Drawing.Size(239, 27);
            this.textBoxBinarization.TabIndex = 9;
            this.textBoxBinarization.Text = "127";
            this.textBoxBinarization.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cumulativeHistogram
            // 
            this.cumulativeHistogram.Location = new System.Drawing.Point(1112, 753);
            this.cumulativeHistogram.Name = "cumulativeHistogram";
            this.cumulativeHistogram.Size = new System.Drawing.Size(239, 52);
            this.cumulativeHistogram.TabIndex = 14;
            this.cumulativeHistogram.Text = "cumulative histogram";
            this.cumulativeHistogram.UseVisualStyleBackColor = true;
            this.cumulativeHistogram.Click += new System.EventHandler(this.cumulativeHistogram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 815);
            this.Controls.Add(this.cumulativeHistogram);
            this.Controls.Add(this.buttonСontrasting);
            this.Controls.Add(this.buttonIncreaseSize);
            this.Controls.Add(this.buttonBinarization);
            this.Controls.Add(this.buttonGray);
            this.Controls.Add(this.buttonHistogram);
            this.Controls.Add(this.buttonIntropolation);
            this.Controls.Add(this.textBoxBinarization);
            this.Controls.Add(this.sizeOutput);
            this.Controls.Add(this.sizeInput);
            this.Controls.Add(this.buttonInversion);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.pictureBoxOutput);
            this.Controls.Add(this.pictureBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.PictureBox pictureBoxOutput;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonGray;
        private System.Windows.Forms.Button buttonInversion;
        private System.Windows.Forms.Label sizeInput;
        private System.Windows.Forms.Label sizeOutput;
        private System.Windows.Forms.Button buttonBinarization;
        private System.Windows.Forms.Button buttonIncreaseSize;
        private System.Windows.Forms.Button buttonСontrasting;
        private System.Windows.Forms.Button buttonIntropolation;
        private System.Windows.Forms.Button buttonHistogram;
        private System.Windows.Forms.TextBox textBoxBinarization;
        private System.Windows.Forms.Button cumulativeHistogram;
    }
}

