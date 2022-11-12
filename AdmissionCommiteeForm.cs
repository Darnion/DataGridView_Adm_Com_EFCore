using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataGridView_Adm_Com.Models;

namespace DataGridView_Adm_Com
{
    public partial class AdmissionCommiteeForm : Form
    {
        private readonly List<Entrant> entrants;
        private readonly BindingSource bindingSource;
        public AdmissionCommiteeForm()
        {
            InitializeComponent();
            dataGridView_Adm_Com.AutoGenerateColumns = false;
            entrants = new List<Entrant>();
            bindingSource = new BindingSource();
            bindingSource.DataSource = entrants;
            dataGridView_Adm_Com.DataSource = bindingSource;
        }

        private void toolStripMenuItem_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var infoForm = new EntrantInfoForm();

            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                entrants.Add(infoForm.Entrant);
                bindingSource.ResetBindings(false);
            }
        }

        private void dataGridView_Adm_Com_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_Adm_Com.Columns[e.ColumnIndex].Name == "SexColumn")
            {
                switch ((Gender)e.Value)
                {
                    case Gender.Male:
                        e.Value = "Мужской";
                        break;
                    case Gender.Female:
                        e.Value = "Женский";
                        break;
                }
            }

            if (dataGridView_Adm_Com.Columns[e.ColumnIndex].Name == "EducationFormColumn")
            {
                switch ((EducationForm)e.Value)
                {
                    case EducationForm.FullTime:
                        e.Value = "Очная";
                        break;
                    case EducationForm.Distant:
                        e.Value = "Заочная";
                        break;
                }
            }

            if (dataGridView_Adm_Com.Columns[e.ColumnIndex].Name == "SumExamsColumn")
            {
                var id = (Entrant)dataGridView_Adm_Com.Rows[e.RowIndex].DataBoundItem;
                e.Value = id.MathExams + id.RussianExams + id.ITExams;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var id = (Entrant)dataGridView_Adm_Com.Rows[dataGridView_Adm_Com.SelectedRows[0].Index].DataBoundItem;
            var infoForm = new EntrantInfoForm(id);
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                var index = entrants.IndexOf(id);
                entrants[index] = infoForm.Entrant;
                bindingSource.ResetBindings(false);
            }
        }

        private void dataGridView_Adm_Com_SelectionChanged(object sender, EventArgs e)
        {
            buttonEdit.Enabled = buttonDelete.Enabled = toolStripMenuItem_Edit.Enabled = toolStripMenuItem_Delete.Enabled = dataGridView_Adm_Com.SelectedRows.Count == 1;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var id = (Entrant)dataGridView_Adm_Com.Rows[dataGridView_Adm_Com.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить {id.FullName}?",
                "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                entrants.Remove(id);
                bindingSource.ResetBindings(false);
            }
        }

        private void dataGridView_Adm_Com_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            labelAmountEntrant.Text = $"Количество абитуриентов: {entrants.Count()}";

            labelAmountPassGrade.Text = $"Количество абитуриентов с проходным баллом (>150): {entrants.Where(pE => pE.MathExams + pE.RussianExams + pE.ITExams > 150).Count()}";
        }
    }
}
