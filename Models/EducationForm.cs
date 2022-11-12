using System.ComponentModel;

namespace DataGridView_Adm_Com.Models
{
    /// <summary>
    /// Форма обучения
    /// </summary>
    public enum EducationForm
    {
        /// <summary>
        /// очная
        /// </summary>
        [Description("Очная")]
        FullTime,
        /// <summary>
        /// заочная
        /// </summary>
        [Description("Заочная")]
        Distant,
    }
}
