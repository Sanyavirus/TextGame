using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Engine.Entities
{
    public class Image
    {
        [Key]
        public int ID { get; set; }
        public int? SceneID { get; set; }
        [ForeignKey(nameof(SceneID))]
        public Scene? Scene { get; set; }
        public byte[] Data { get; set; }

    }
}
