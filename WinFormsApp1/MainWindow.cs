using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetLabs.Dtos;
using DotNetLabs.Services;

namespace WinFormsApp1
{
    public partial class MainWindow : Form
    {
        private readonly ComparePersonsDateService _comparePersonsDateService;
        public MainWindow()
        {
            InitializeComponent();
            firstFIO.Hide();
            secondFIO.Hide();
            secondFIODate.Hide();
            comboBox.Hide();
            _comparePersonsDateService = ComparePersonsDateService.GetInstance();
        }

        private void tsmiCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if(!cbExtendForm.Checked)
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
                }
                else
                {
                    if (firstFIO.Text.Length == 0 || secondFIO.Text.Length == 0 || comboBox.Text.Length == 0) throw new FormatException();

                    PersonDto person1 = new PersonDto
                    {
                        Date = DateTime.Parse(maskedTextBox.Text),
                        Fio = firstFIO.Text
                    };

                    PersonDto person2 = new PersonDto
                    {
                        Date = DateTime.Parse(secondFIODate.Text),
                        Fio = secondFIO.Text
                    };
                    
                    listBox.Items.Add(_comparePersonsDateService.GetResult(person1, person2, comboBox.SelectedItem.ToString()));
                    return;
                }



                MessageBox.Show("Выберите необходимую единицу измерения");
            }
            catch (FormatException formatException)
            {
                MessageBox.Show
                    (
                        "Ошибка валидации!",
                        "Ошибка валидации",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
            }
        }

        private void clearDate_Click(object sender, EventArgs e)
        {
            maskedTextBox.Clear();
            secondFIODate.Clear();
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

        private void cbExtendForm_CheckedChanged(object sender, EventArgs e)
        {
            if(cbExtendForm.Checked)
            {
                firstFIO.Show();
                secondFIO.Show();
                secondFIODate.Show();
                comboBox.Show();
            }
            else
            {
                firstFIO.Hide();
                secondFIO.Hide();
                secondFIODate.Hide();
                comboBox.Hide();
            }
        }
    }
}
