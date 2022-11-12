using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataGridView_Adm_Com.Models;
using Microsoft.EntityFrameworkCore;

namespace DataGridView_Adm_Com
{
    public partial class AdmissionCommiteeForm : Form
    {
        private bool sortedByAlphabet = false;
        private bool sortedByMark = false;
        public DbContextOptions<ApplicationContext> options;
        public AdmissionCommiteeForm()
        {
            InitializeComponent();
            options = ConnectJSON.Option();
            dataGridView_Adm_Com.AutoGenerateColumns = false;
            dataGridView_Adm_Com.DataSource = ReadDB(options);
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
                CreateDB(options, infoForm.Entrant);
                dataGridView_Adm_Com.DataSource = ReadDB(options);
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
                id.FullName = infoForm.Entrant.FullName;
                id.Gender = infoForm.Entrant.Gender;
                id.BirthDate = infoForm.Entrant.BirthDate;
                id.EducationForm = infoForm.Entrant.EducationForm;
                id.MathExams = infoForm.Entrant.MathExams;
                id.RussianExams = infoForm.Entrant.RussianExams;
                id.ITExams = infoForm.Entrant.ITExams;
                UpdateDB(options, id);
                dataGridView_Adm_Com.DataSource = ReadDB(options);
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
                RemoveDB(options, id);
                dataGridView_Adm_Com.DataSource = ReadDB(options);
            }
        }

        private void dataGridView_Adm_Com_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            labelAmountEntrant.Text = $"Количество абитуриентов: {ReadDB(options).Count}";

            labelAmountPassGrade.Text = $"Количество абитуриентов с проходным баллом (>150): {ReadDB(options).Where(pE => pE.MathExams + pE.RussianExams + pE.ITExams > 150).Count()}";

            if (dataGridView_Adm_Com.SelectedCells.Count > 0)
            {
                buttonSort.Enabled = true;
            }
            else
            {
                buttonSort.Enabled = false;
            }
        }

        private static void CreateDB(DbContextOptions<ApplicationContext> options, Entrant entrant)
        {
            using (var db = new ApplicationContext(options))
            {
                Entrant t = new Entrant();
                entrant.Id = t.Id;
                db.AdmComDB.Add(entrant);
                db.SaveChanges();
            }
        }
        private static void RemoveDB(DbContextOptions<ApplicationContext> options, Entrant entrant)
        {
            using (var db = new ApplicationContext(options))
            {
                var value = db.AdmComDB.FirstOrDefault(u => u.Id == entrant.Id);
                if (value != null)
                {
                    db.AdmComDB.Remove(value);
                    db.SaveChanges();
                }

            }
        }
        private static void UpdateDB(DbContextOptions<ApplicationContext> options, Entrant entrant)
        {
            using (var db = new ApplicationContext(options))
            {
                var value = db.AdmComDB.FirstOrDefault(u => u.Id == entrant.Id);
                if (value != null)
                {
                    value.FullName = entrant.FullName;
                    value.Gender = entrant.Gender;
                    value.BirthDate = entrant.BirthDate;
                    value.EducationForm = entrant.EducationForm;
                    value.MathExams = entrant.MathExams;
                    value.RussianExams = entrant.RussianExams;
                    value.ITExams = entrant.ITExams;
                    db.SaveChanges();
                }
            }
        }
        private static List<Entrant> ReadDB(DbContextOptions<ApplicationContext> options)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                return db.AdmComDB
                    .OrderByDescending(x => x.Id)
                    .ToList();
            }
        }

        private static List<Entrant> SortAlphabetUpDB(DbContextOptions<ApplicationContext> options)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                return db.AdmComDB
                    .OrderBy(x => x.FullName)
                    .ToList();
            }
        }

        private static List<Entrant> SortAlphabetDownDB(DbContextOptions<ApplicationContext> options)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                return db.AdmComDB
                    .OrderByDescending(x => x.FullName)
                    .ToList();
            }
        }

        private static List<Entrant> SortMarkUpDB(DbContextOptions<ApplicationContext> options)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                return db.AdmComDB
                    .OrderBy(x => x.MathExams + x.RussianExams + x.ITExams)
                    .ToList();
            }
        }

        private static List<Entrant> SortMarkDownDB(DbContextOptions<ApplicationContext> options)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                return db.AdmComDB
                    .OrderByDescending(x => x.MathExams + x.RussianExams + x.ITExams)
                    .ToList();
            }
        }

        private void buttonSort_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == buttonAlphabetSort)
            {
                if (!sortedByAlphabet)
                {
                    dataGridView_Adm_Com.DataSource = SortAlphabetUpDB(options);
                    sortedByAlphabet = !sortedByAlphabet;
                }
                else
                {
                    dataGridView_Adm_Com.DataSource = SortAlphabetDownDB(options);
                    sortedByAlphabet = !sortedByAlphabet;
                }
            }
            else if (e.ClickedItem == buttonMarkSort)
            {
                if (!sortedByMark)
                {
                    dataGridView_Adm_Com.DataSource = SortMarkUpDB(options);
                    sortedByMark = !sortedByMark;
                }
                else
                {
                    dataGridView_Adm_Com.DataSource = SortMarkDownDB(options);
                    sortedByMark = !sortedByMark;
                }
            }
        }
    }
}
