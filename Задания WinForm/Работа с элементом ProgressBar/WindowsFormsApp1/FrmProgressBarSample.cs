using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmProgressBarSample: Form
    {
        class ProgressStep
        {
            public string StepText { get; set; }
            public int StepValue { get; set; }
            public ProgressStep(string stepText, int stepValue)
            {
                StepText = stepText;
                StepValue = stepValue;
            }
            public override string ToString()
            {
                return StepText;
            }
        }
        public FrmProgressBarSample()
        {
            InitializeComponent();
        }
        private void FrmProgressBarSample_Load(object sender, EventArgs e)
        {
            UpdateProgressBarPercentComplete();
            FillProgressSteps();
        }
        private void FillProgressSteps()
        {
            ComboBoxProgressStep.Items.Add(new ProgressStep("10%", 10));
            ComboBoxProgressStep.Items.Add(new ProgressStep("20%", 20));
            ComboBoxProgressStep.Items.Add(new ProgressStep("30%", 30));
            ComboBoxProgressStep.Items.Add(new ProgressStep("40%", 40));
            ComboBoxProgressStep.Items.Add(new ProgressStep("50%", 50));
        }
        private void UpdateProgressBarPercentComplete()
        {
            LabelPercentCompleteText.Text = ProgressBarProcess.Value + "%";
            if (ProgressBarProcess.Value >= 0 && ProgressBarProcess.Value < 20)
            {
                LabelStatusText.Text = "Инициализация...";
            }
            else if (ProgressBarProcess.Value >= 20 && ProgressBarProcess.Value <
            40)
            {
                LabelStatusText.Text = "Подготовка примера...";
            }
            else if (ProgressBarProcess.Value >= 40 && ProgressBarProcess.Value <
            60)
            {
                LabelStatusText.Text = "Выполнение задачи #1...";
            }
            else if (ProgressBarProcess.Value >= 60 && ProgressBarProcess.Value <
            80)
            {
                LabelStatusText.Text = "Выполнение задачи #2...";
            }
            else if (ProgressBarProcess.Value >= 80 && ProgressBarProcess.Value <
            100)
            {
                LabelStatusText.Text = "Почти готово, завершение...";
            }
            else
            {
                LabelStatusText.Text = "Выполнено.";
            }
        }

        private void TimerForProgressBar_Tick(object sender, EventArgs e)
        {
            ProgressBarProcess.PerformStep();
            UpdateProgressBarPercentComplete();
            ButtonStop.Enabled = ProgressBarProcess.Value != 100;
            if (ProgressBarProcess.Value >= 100)
                TimerForProgressBar.Stop();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ProgressBarProcess.Value = 0;
            UpdateProgressBarPercentComplete();
            if (!TimerForProgressBar.Enabled)
                TimerForProgressBar.Start();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            if (TimerForProgressBar.Enabled)
            {
                TimerForProgressBar.Stop();
                ButtonStop.Text = "&Продолжить";
            }
            else
            {
                TimerForProgressBar.Start();
                ButtonStop.Text = "&Остановить";
            }
        }

        private void ComboBoxProgressStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxProgressStep.SelectedItem != null)
            {
                ProgressStep step =
                (ProgressStep)ComboBoxProgressStep.SelectedItem;
                ProgressBarProcess.Step = step.StepValue;
            }
        }
    }
}
