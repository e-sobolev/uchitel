using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HardProj.Models
{
    /// <summary>
    /// Сущность жанров
    /// </summary>
    public class Ganre
    {
        /// <summary>
        /// Идентификатор жанра
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название жанра
        /// </summary>
        public string Name { get; set; }
    }
}