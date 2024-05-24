using System.Resources;

namespace MotherBoardDiagnostic
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button buttonVoltage;
    private System.Windows.Forms.Button buttonResistance;
    private System.Windows.Forms.Button buttonContinuity;
    private System.Windows.Forms.Button buttonSignals;
    private System.Windows.Forms.Button buttonTemperature;
    private System.Windows.Forms.Button buttonRAM;
    private System.Windows.Forms.Button buttonArea1;
    private System.Windows.Forms.Button buttonArea2;
    private System.Windows.Forms.Button buttonArea3;
    private System.Windows.Forms.Button buttonArea4;
    private System.Windows.Forms.Button buttonArea5;
    private System.Windows.Forms.Button buttonArea6;
    private System.Windows.Forms.Button buttonArea7;
    private System.Windows.Forms.Button buttonArea8;
    private System.Windows.Forms.Button buttonArea9;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.buttonVoltage = new System.Windows.Forms.Button();
      this.buttonResistance = new System.Windows.Forms.Button();
      this.buttonContinuity = new System.Windows.Forms.Button();
      this.buttonSignals = new System.Windows.Forms.Button();
      this.buttonTemperature = new System.Windows.Forms.Button();
      this.buttonRAM = new System.Windows.Forms.Button();
      this.buttonArea1 = new System.Windows.Forms.Button();
      this.buttonArea2 = new System.Windows.Forms.Button();
      this.buttonArea3 = new System.Windows.Forms.Button();
      this.buttonArea4 = new System.Windows.Forms.Button();
      this.buttonArea5 = new System.Windows.Forms.Button();
      this.buttonArea6 = new System.Windows.Forms.Button();
      this.buttonArea7 = new System.Windows.Forms.Button();
      this.buttonArea8 = new System.Windows.Forms.Button();
      this.buttonArea9 = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonVoltage
      // 
      this.buttonVoltage.Location = new System.Drawing.Point(10, 10);
      this.buttonVoltage.Name = "buttonVoltage";
      this.buttonVoltage.Size = new System.Drawing.Size(75, 23);
      this.buttonVoltage.TabIndex = 0;
      this.buttonVoltage.Text = "Вольтметр";
      this.buttonVoltage.UseVisualStyleBackColor = true;
      this.buttonVoltage.Click += new System.EventHandler(this.SelectTool);
      // 
      // buttonResistance
      // 
      this.buttonResistance.Location = new System.Drawing.Point(100, 10);
      this.buttonResistance.Name = "buttonResistance";
      this.buttonResistance.Size = new System.Drawing.Size(84, 23);
      this.buttonResistance.TabIndex = 1;
      this.buttonResistance.Text = "Проверка КЗ";
      this.buttonResistance.UseVisualStyleBackColor = true;
      this.buttonResistance.Click += new System.EventHandler(this.SelectTool);
      // 
      // buttonContinuity
      // 
      this.buttonContinuity.Location = new System.Drawing.Point(190, 3);
      this.buttonContinuity.Name = "buttonContinuity";
      this.buttonContinuity.Size = new System.Drawing.Size(75, 39);
      this.buttonContinuity.TabIndex = 2;
      this.buttonContinuity.Text = "Диодная прозвонка";
      this.buttonContinuity.UseVisualStyleBackColor = true;
      this.buttonContinuity.Click += new System.EventHandler(this.SelectTool);
      // 
      // buttonSignals
      // 
      this.buttonSignals.Location = new System.Drawing.Point(280, 10);
      this.buttonSignals.Name = "buttonSignals";
      this.buttonSignals.Size = new System.Drawing.Size(75, 23);
      this.buttonSignals.TabIndex = 3;
      this.buttonSignals.Text = "Осциллограф";
      this.buttonSignals.UseVisualStyleBackColor = true;
      this.buttonSignals.Click += new System.EventHandler(this.SelectTool);
      // 
      // buttonTemperature
      // 
      this.buttonTemperature.Location = new System.Drawing.Point(370, 10);
      this.buttonTemperature.Name = "buttonTemperature";
      this.buttonTemperature.Size = new System.Drawing.Size(75, 23);
      this.buttonTemperature.TabIndex = 4;
      this.buttonTemperature.Text = "Термометр";
      this.buttonTemperature.UseVisualStyleBackColor = true;
      this.buttonTemperature.Click += new System.EventHandler(this.SelectTool);
      // 
      // buttonRAM
      // 
      this.buttonRAM.Location = new System.Drawing.Point(460, 10);
      this.buttonRAM.Name = "buttonRAM";
      this.buttonRAM.Size = new System.Drawing.Size(99, 23);
      this.buttonRAM.TabIndex = 5;
      this.buttonRAM.Text = "Тестер ОЗУ";
      this.buttonRAM.UseVisualStyleBackColor = true;
      this.buttonRAM.Click += new System.EventHandler(this.SelectTool);
      // 
      // buttonArea1
      // 
      this.buttonArea1.BackColor = System.Drawing.SystemColors.ControlLight;
      this.buttonArea1.Location = new System.Drawing.Point(385, 613);
      this.buttonArea1.Name = "buttonArea1";
      this.buttonArea1.Size = new System.Drawing.Size(48, 23);
      this.buttonArea1.TabIndex = 6;
      this.buttonArea1.Tag = "Area1";
      this.buttonArea1.Text = "3,3 В";
      this.buttonArea1.UseVisualStyleBackColor = false;
      this.buttonArea1.Visible = false;
      this.buttonArea1.Click += new System.EventHandler(this.SelectArea);
      // 
      // buttonArea2
      // 
      this.buttonArea2.Location = new System.Drawing.Point(416, 594);
      this.buttonArea2.Name = "buttonArea2";
      this.buttonArea2.Size = new System.Drawing.Size(96, 42);
      this.buttonArea2.TabIndex = 7;
      this.buttonArea2.Tag = "Area2";
      this.buttonArea2.Text = "Сопротивление питания";
      this.buttonArea2.UseVisualStyleBackColor = true;
      this.buttonArea2.Visible = false;
      this.buttonArea2.Click += new System.EventHandler(this.SelectArea);
      // 
      // buttonArea3
      // 
      this.buttonArea3.Location = new System.Drawing.Point(358, 127);
      this.buttonArea3.Name = "buttonArea3";
      this.buttonArea3.Size = new System.Drawing.Size(75, 23);
      this.buttonArea3.TabIndex = 8;
      this.buttonArea3.Tag = "Area3";
      this.buttonArea3.Text = "Usb тест";
      this.buttonArea3.UseVisualStyleBackColor = true;
      this.buttonArea3.Visible = false;
      this.buttonArea3.Click += new System.EventHandler(this.SelectArea);
      // 
      // buttonArea4
      // 
      this.buttonArea4.Location = new System.Drawing.Point(206, 277);
      this.buttonArea4.Name = "buttonArea4";
      this.buttonArea4.Size = new System.Drawing.Size(75, 23);
      this.buttonArea4.TabIndex = 9;
      this.buttonArea4.Tag = "Area4";
      this.buttonArea4.Text = "Кварц";
      this.buttonArea4.UseVisualStyleBackColor = true;
      this.buttonArea4.Visible = false;
      this.buttonArea4.Click += new System.EventHandler(this.SelectArea);
      // 
      // buttonArea5
      // 
      this.buttonArea5.Location = new System.Drawing.Point(165, 48);
      this.buttonArea5.Name = "buttonArea5";
      this.buttonArea5.Size = new System.Drawing.Size(190, 58);
      this.buttonArea5.TabIndex = 10;
      this.buttonArea5.Tag = "Area5";
      this.buttonArea5.Text = "Пиковая температура";
      this.buttonArea5.UseVisualStyleBackColor = true;
      this.buttonArea5.Visible = false;
      this.buttonArea5.Click += new System.EventHandler(this.SelectArea);
      // 
      // buttonArea6
      // 
      this.buttonArea6.BackColor = System.Drawing.SystemColors.ControlLight;
      this.buttonArea6.Location = new System.Drawing.Point(382, 536);
      this.buttonArea6.Name = "buttonArea6";
      this.buttonArea6.Size = new System.Drawing.Size(51, 28);
      this.buttonArea6.TabIndex = 11;
      this.buttonArea6.Tag = "Area6";
      this.buttonArea6.Text = "ОЗУ";
      this.buttonArea6.UseVisualStyleBackColor = false;
      this.buttonArea6.Visible = false;
      this.buttonArea6.Click += new System.EventHandler(this.SelectArea);
      // 
      // buttonArea7
      // 
      this.buttonArea7.Location = new System.Drawing.Point(439, 613);
      this.buttonArea7.Name = "buttonArea7";
      this.buttonArea7.Size = new System.Drawing.Size(43, 23);
      this.buttonArea7.TabIndex = 12;
      this.buttonArea7.Tag = "Area7";
      this.buttonArea7.Text = "5 В";
      this.buttonArea7.UseVisualStyleBackColor = true;
      this.buttonArea7.Visible = false;
      this.buttonArea7.Click += new System.EventHandler(this.SelectArea);
      // 
      // buttonArea8
      // 
      this.buttonArea8.Location = new System.Drawing.Point(488, 613);
      this.buttonArea8.Name = "buttonArea8";
      this.buttonArea8.Size = new System.Drawing.Size(41, 23);
      this.buttonArea8.TabIndex = 13;
      this.buttonArea8.Tag = "Area8";
      this.buttonArea8.Text = "12 В";
      this.buttonArea8.UseVisualStyleBackColor = true;
      this.buttonArea8.Visible = false;
      this.buttonArea8.Click += new System.EventHandler(this.SelectArea);
      // 
      // buttonArea9
      // 
      this.buttonArea9.Location = new System.Drawing.Point(12, 619);
      this.buttonArea9.Name = "buttonArea9";
      this.buttonArea9.Size = new System.Drawing.Size(75, 23);
      this.buttonArea9.TabIndex = 14;
      this.buttonArea9.Tag = "Area9";
      this.buttonArea9.Text = "Область";
      this.buttonArea9.UseVisualStyleBackColor = true;
      this.buttonArea9.Visible = false;
      this.buttonArea9.Click += new System.EventHandler(this.SelectArea);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::MotherBoardDiagnostic.Properties.Resources.MotherBoard600;
      this.pictureBox1.Location = new System.Drawing.Point(10, 39);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(577, 603);
      this.pictureBox1.TabIndex = 15;
      this.pictureBox1.TabStop = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Location = new System.Drawing.Point(0, 3);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(972, 673);
      this.pictureBox2.TabIndex = 16;
      this.pictureBox2.TabStop = false;
      this.pictureBox2.Visible = false;
      this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(964, 672);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.buttonArea9);
      this.Controls.Add(this.buttonArea8);
      this.Controls.Add(this.buttonArea7);
      this.Controls.Add(this.buttonVoltage);
      this.Controls.Add(this.buttonResistance);
      this.Controls.Add(this.buttonContinuity);
      this.Controls.Add(this.buttonSignals);
      this.Controls.Add(this.buttonTemperature);
      this.Controls.Add(this.buttonRAM);
      this.Controls.Add(this.buttonArea1);
      this.Controls.Add(this.buttonArea2);
      this.Controls.Add(this.buttonArea3);
      this.Controls.Add(this.buttonArea4);
      this.Controls.Add(this.buttonArea5);
      this.Controls.Add(this.buttonArea6);
      this.Controls.Add(this.pictureBox1);
      this.Name = "Form1";
      this.Text = "Диагностика материнской платы";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);

    }

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
  }
}

