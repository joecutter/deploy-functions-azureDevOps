using Microsoft.Build.Framework;

namespace Calculate.Dto
{
    public class Quadrilateral
    {
        [Required]
        public float Length { get; set; }
        [Required]
        public float Width { get; set; }
    }
}