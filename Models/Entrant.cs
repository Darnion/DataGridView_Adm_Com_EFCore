using System;

namespace DataGridView_Adm_Com.Models
{
    /// <summary>
    /// Сущность абитуриента
    /// </summary>
    public class Entrant
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

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

        /// <summary>
        /// Лишнее свойство
        /// </summary>
        public string UselessProperty { get; set; }
    }
}
