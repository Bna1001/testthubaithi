using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BuiNamAnh_33.Models
{
    public class SinhVien
    {
        [Key]
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public string MaLop { get; set; }
    }
}