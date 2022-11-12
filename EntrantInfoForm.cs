using System;
using System.Drawing;
using System.Windows.Forms;
using DataGridView_Adm_Com.Models;

namespace DataGridView_Adm_Com
{
    public partial class EntrantInfoForm : Form
    {
        private readonly Entrant entrant;
        public EntrantInfoForm()
        {
            InitializeComponent();
            FillComboBoxes();
            Text = "Добавление абитуриента";
            entrant = new Entrant
            {
                BirthDate = DateTime.Now.AddYears(-16),
                Gender = Gender.Male,
                EducationForm = EducationForm.FullTime
            };
            comboBoxSex.SelectedItem = entrant.Gender;
            dateTimePicker_BirthDate.Value = entrant.BirthDate;
            comboBoxEducationForm.SelectedItem = entrant.EducationForm;
        }

        public EntrantInfoForm(Entrant source) : this()
        {
            Text = "Редактирование студента";
            textBoxFIO.Text = source.FullName;
            comboBoxSex.SelectedItem = source.Gender;
            dateTimePicker_BirthDate.Value = entrant.BirthDate;
            comboBoxEducationForm.SelectedItem = source.EducationForm;
            textBoxMathExams.Text = source.MathExams.ToString();
            textBoxRussianExams.Text = source.RussianExams.ToString();
            textBoxITExams.Text = source.ITExams.ToString();
        }

        public Entrant Entrant => entrant;

        private void FillComboBoxes()
        {
            foreach (Gender item in Enum.GetValues(typeof(Gender)))
            {
                comboBoxSex.Items.Add(item);
            }

            foreach (EducationForm item in Enum.GetValues(typeof(EducationForm)))
            {
                comboBoxEducationForm.Items.Add(item);
            }
        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {
            buttonSave.Enabled = !string.IsNullOrWhiteSpace(textBoxFIO.Text);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            entrant.FullName = textBoxFIO.Text.Trim();

            if (comboBoxSex.SelectedIndex >= 0)
            {
                entrant.Gender = (Gender)comboBoxSex.SelectedIndex;
            }
            else
            {
                entrant.Gender = Gender.Male;
            }

            entrant.BirthDate = dateTimePicker_BirthDate.Value;

            if (comboBoxEducationForm.SelectedIndex >= 0)
            {
                entrant.EducationForm = (EducationForm)comboBoxEducationForm.SelectedIndex;
            }
            else
            {
                entrant.EducationForm = EducationForm.FullTime;
            }

            if (!string.IsNullOrEmpty(textBoxMathExams.Text))
            {
                entrant.MathExams = int.Parse(textBoxMathExams.Text);
            }

            if (!string.IsNullOrEmpty(textBoxRussianExams.Text))
            {
                entrant.RussianExams = int.Parse(textBoxRussianExams.Text);
            }

            if (!string.IsNullOrEmpty(textBoxITExams.Text))
            {
                entrant.ITExams = int.Parse(textBoxITExams.Text);
            }

            DialogResult = DialogResult.OK;
        }

        private void textBoxMathExams_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxMathExams_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text) && int.Parse(((TextBox)sender).Text) > 100)
            {
                ((TextBox)sender).Text = "100";
            }
        }

        private void comboBoxSex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxSex_DrawItem(object sender, DrawItemEventArgs e)
        {
            var parent = sender as ComboBox;
            if (parent != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(parent.ForeColor);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }

                if (e.Index >= 0)
                {
                    if (parent.Items[e.Index] is Gender gender)
                    {
                        var text = gender == Gender.Male
                            ? "Мужской"
                            : "Женский";
                        e.Graphics.DrawString(
                            text,
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                    else
                    {
                        e.Graphics.DrawString(
                          parent.Items[e.Index].ToString(),
                          parent.Font,
                          brush,
                          e.Bounds);
                    }
                }

            }
        }

        private void comboBoxEducationForm_DrawItem(object sender, DrawItemEventArgs e)
        {
            var parent = sender as ComboBox;
            if (parent != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(parent.ForeColor);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }

                if (e.Index >= 0)
                {
                    if (parent.Items[e.Index] is EducationForm educationForm)
                    {
                        var text = educationForm == EducationForm.FullTime
                            ? "Очная"
                            : "Заочная";
                        e.Graphics.DrawString(
                            text,
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                    else
                    {
                        e.Graphics.DrawString(
                          parent.Items[e.Index].ToString(),
                          parent.Font,
                          brush,
                          e.Bounds);
                    }
                }

            }
        }

        private void textBoxFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
