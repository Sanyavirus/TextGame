using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TextGame.Engine.Entities;

namespace TextGame.Engine.Models
{
    public class SceneDTO
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string HashTag { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        /// <summary>
        /// Путь до картинок в сцене
        /// </summary>
        public List<string> Images { get; set; }
        /// <summary>
        /// Задержка между переключением картинок  
        /// </summary>
        public int Delay { get; set; }

        public SceneType SceneType { get; set; }
        public List<SceneDTO> Scenes { get; set; }

    }
}
