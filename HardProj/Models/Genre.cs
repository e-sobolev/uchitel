using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HardProj.Models
{
    /// <summary>
    /// Сущность жанров
    /// </summary>
    public class Genre
    {
        /// <summary>
        /// Идентификатор жанра
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название жанра
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Список книг
        /// </summary>
        public ICollection<Book> Books { get; set; }
    }
}