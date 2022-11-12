using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView_Adm_Com.Models
{
    /// <summary>
    /// Сущность абитуриента
    /// </summary>
    public class Entrant
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Форма обучения
        /// </summary>
        public EducationForm EducationForm { get; set; }

        /// <summary>
        /// Баллы по математике
        /// </summary>
        public int MathExams { get; set; }

        /// <summary>
        /// Баллы по русскому
        /// </summary>
        public int RussianExams { get; set; }

        /// <summary>
        /// Баллы по информатике
        /// </summary>
        public int ITExams { get; set; }
    }
}
