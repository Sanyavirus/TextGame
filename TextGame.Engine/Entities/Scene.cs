using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TextGame.Engine.Entities
{
    public class Scene
    {
        [Key]
        public int ID { get; set; }
        public int? ParentID { get; set; }
        public string? Name { get; set; }
        public string? HashTag { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        /// <summary>
        /// Путь до картинок в сцене
        /// </summary>
       // public List<Image>? Images { get; set; }
        /// <summary>
        /// Задержка между переключением картинок  
        /// </summary>
        public int? Delay { get; set; }
        [ForeignKey(nameof(ParentID))]
        public List<Scene>? Scenes{get;set;}
        public SceneType SceneType { get; set; }
    }

    public enum SceneType
    {
        Simple,
        Quest,
        Battle
    }
}
