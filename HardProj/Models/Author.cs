using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HardProj.Models
{
    /// <summary>
    /// Сущность для автора
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Идентификатор автора
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя автора
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Год выпуска
        /// </summary>
        public int Year { get; set; }
    }
}