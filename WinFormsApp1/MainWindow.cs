using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tsmiCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime birthDate = DateTime.Parse(maskedTextBox.Text);

                TimeSpan interval = DateTime.Today - birthDate;

                string result = $"Дата рождения: {birthDate.ToShortDateString().ToString()}. ";

                if (rbYear.Checked)
                {
                    listBox.Items.Add(result + $"Количество полных лет: {(interval.Days / 365).ToString()}");
                    return;
                }

                if (rbMonth.Checked)
                {
                    listBox.Items.Add(result + $"Количество полных месяцев: {((interval.Days / 365) * 12).ToString()}");
                    return;
                }

                if (rbDay.Checked)
                {
                    listBox.Items.Add(result + $"Количество дней: {interval.Days.ToString()}");
                    return;
                }

                if (rbHour.Checked)
                {
                    listBox.Items.Add(result + $"Количество часов: {interval.TotalHours.ToString()}");
                    return;
                }

                if (rbMinute.Checked)
                {
                    listBox.Items.Add(result + $"Количество минут: {interval.TotalMinutes.ToString()}");
                    return;
                }

                if (rbSecond.Checked)
                {
                    listBox.Items.Add(result + $"Количество секунд: {interval.TotalSeconds.ToString()}");
                    return;
                }

                MessageBox.Show("Выберите необходимую единицу измерения");
            }
            catch (FormatException formatException)
            {
                MessageBox.Show
                    (
                        "Введите правильную дату!",
                        "Ошибка валидации",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
            }
        }

        private void clearDate_Click(object sender, EventArgs e)
        {
            maskedTextBox.Clear();
        }

        private void clearResult_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void getAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                (
                    "Программа расчета бессмысленного существования в различных единицах измерения",
                    "О программе",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
        }
    }
}
