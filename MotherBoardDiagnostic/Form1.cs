﻿using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace MotherBoardDiagnostic
{
  public partial class Form1 : Form
  {
    Random random = new Random();
    string selectedTool;

    public Form1()
    {
      InitializeComponent();
      InitializeCustomComponents();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void InitializeCustomComponents()
    {

      buttonVoltage.Click += new EventHandler(SelectTool);
      buttonResistance.Click += new EventHandler(SelectTool);
      buttonContinuity.Click += new EventHandler(SelectTool);
      buttonSignals.Click += new EventHandler(SelectTool);
      buttonTemperature.Click += new EventHandler(SelectTool);
      buttonRAM.Click += new EventHandler(SelectTool);


      buttonArea1.Click += new EventHandler(SelectArea);
      buttonArea2.Click += new EventHandler(SelectArea);
      buttonArea3.Click += new EventHandler(SelectArea);
      buttonArea4.Click += new EventHandler(SelectArea);
      buttonArea5.Click += new EventHandler(SelectArea);
      buttonArea6.Click += new EventHandler(SelectArea);
    }

    private void SelectArea(object sender, EventArgs e)
    {
      var button = sender as Button;
      var areaTag = button.Tag.ToString();
      var answer = 0;

      if (selectedTool != null)
      {
        if (selectedTool == "Осциллограф")
        {
          if (random.Next(0, 2) > 0)
          {
            pictureBox2.Image = MotherBoardDiagnostic.Properties.Resources.OscilogramFalse;
            answer = 1;

          }
          else
          {
            pictureBox2.Image = MotherBoardDiagnostic.Properties.Resources.OscilogramTrue;
            answer = 2;
          }

          pictureBox2.Visible = true;

          var userResponse = MessageBox.Show("Это правильная осцилограмма?", "Проверка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

          if (userResponse == DialogResult.Yes)
          {
            var answ = answer;
            if (answ == 2)
            {
              MessageBox.Show("Правильно!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
              MessageBox.Show("Неправильно!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          }
          else if (answer == 1)
          {
            MessageBox.Show("Правильно!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);

          }
          else
          {
            MessageBox.Show("Неправильно!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }

        }
        else
        {
          string measurement = "";
          double deviationPercentage = 0;

          switch (selectedTool)
          {
            case "Вольтметр":
              measurement = GetRandomMeasurement(selectedTool, areaTag);
              if (areaTag == "Area1")
              {
                deviationPercentage = CalculateDeviationPercentage(measurement, 3);
              }
              else if (areaTag == "Area7")
              {
                deviationPercentage = CalculateDeviationPercentage(measurement, 5);
              }
              else
              {
                deviationPercentage = CalculateDeviationPercentage(measurement, 12);
              }
              break;
            case "Проверка КЗ":
              measurement = GetRandomMeasurement(selectedTool);
              deviationPercentage = CalculateDeviationPercentage(measurement, 1);
              break;
            case "Диодная прозвонка":
              measurement = GetRandomMeasurement(selectedTool);
              deviationPercentage = CalculateDeviationPercentage(measurement, 450);
              break;
            case "Осциллограф":
              measurement = GetRandomMeasurement(selectedTool);
              deviationPercentage = CalculateDeviationPercentage(measurement, 0);
              break;
            case "Термометр":
              measurement = GetRandomMeasurement(selectedTool);
              deviationPercentage = CalculateDeviationPercentage(measurement, 35);
              break;
            case "Тестер ОЗУ":
              measurement = GetRandomMeasurement(selectedTool);
              deviationPercentage = CalculateDeviationPercentage(measurement, 100);
              break;
            default:
              measurement = "Неизвестное значение";
              break;
          }

          var userResponse = MessageBox.Show($"Измерение используя {selectedTool}: {measurement}\n\nКак вы думаете, это нормальное значение?", "Результат измерения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

          if (userResponse == DialogResult.Yes)
          {
            if (selectedTool == "Проверка КЗ")
            {
              if (Math.Abs(deviationPercentage) > 10)
              {
                MessageBox.Show("Неправильно!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
              } else
              {
                MessageBox.Show("Правильно!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }
            else if (Math.Abs(deviationPercentage) <= 15)
            {
              MessageBox.Show("Правильно!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
              MessageBox.Show("Неправильно!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          }
          else
          {
            if (selectedTool == "Проверка КЗ")
            {
              if (Math.Abs(deviationPercentage) > 10)
              {
                MessageBox.Show("Правильно!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              else
              {
                MessageBox.Show("Неправильно!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }
           else if (Math.Abs(deviationPercentage) > 15)
            {
              MessageBox.Show("Правильно!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
              MessageBox.Show("Неправильно!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          }
        }
      }

      ClearSelectedTool();
      HideAreaButtons();
    }

    private double CalculateDeviationPercentage(string measuredValue, double referenceValue)
    {

      Console.WriteLine($"Measured Value: {measuredValue}");

      double measuredNumber;

      string[] parts = measuredValue.Split(' ');
      if (parts.Length == 0 || !double.TryParse(parts[0], out measuredNumber))
      {
        return 0;

      }
      return ((measuredNumber - referenceValue) / referenceValue) * 100;
    }


    private void ShowAreaButtons(string tool)
    {
      HideAreaButtons();
      switch (tool)
      {
        case "Вольтметр":
          buttonArea1.Visible = true;
          buttonArea7.Visible = true;
          buttonArea8.Visible = true;
          break;
        case "Проверка КЗ":
          buttonArea2.Visible = true;
          break;
        case "Диодная прозвонка":
          buttonArea3.Visible = true;
          break;
        case "Осциллограф":
          buttonArea4.Visible = true;
          break;
        case "Термометр":
          buttonArea5.Visible = true;
          break;
        case "Тестер ОЗУ":
          buttonArea6.Visible = true;
          break;
      }
    }

    private void SelectTool(object sender, EventArgs e)
    {
      var button = sender as Button;
      selectedTool = button.Text;
      pictureBox2.Image = null;

      ShowAreaButtons(selectedTool);
    }

    private void ClearSelectedTool()
    {
      selectedTool = null;
    }

    private void HideAreaButtons()
    {
      buttonArea1.Visible = false;
      buttonArea2.Visible = false;
      buttonArea3.Visible = false;
      buttonArea4.Visible = false;
      buttonArea5.Visible = false;
      buttonArea6.Visible = false;
      buttonArea7.Visible = false;
      buttonArea8.Visible = false;
      buttonArea9.Visible = false;
      pictureBox2.Visible = false;
    }

    private string GetRandomMeasurement(string tool, string area = null)
    {
      switch (tool)
      {
        case "Вольтметр":
          switch (area)
          {
            case "Area1":
              return random.Next(0, 6) + " В";
            case "Area7":
              return random.Next(2, 9) + " В";
            default:
              return random.Next(6, 17) + " В";
          }
        case "Проверка КЗ":
          return random.Next(0, 2) + " Ом";
        case "Диодная прозвонка":
          return random.Next(200, 500) + " ";
        case "Осциллограф":
          return random.Next(0, 5) + " В";
        case "Термометр":
          return random.Next(30, 100) + " °C";
        case "Тестер ОЗУ":
          return random.Next(0, 100) + " % исправно";
        default:
          return "Неизвестный инструмент";
      }
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }
  }
}