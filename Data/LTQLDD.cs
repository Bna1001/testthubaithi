using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BuiNamAnh_33.Models;

    public class LTQLDD : DbContext
    {
        public LTQLDD (DbContextOptions<LTQLDD> options)
            : base(options)
        {
        }

        public DbSet<BuiNamAnh_33.Models.LopHoc> LopHoc { get; set; } = default!;

        public DbSet<BuiNamAnh_33.Models.SinhVien> SinhVien { get; set; } = default!;

        public DbSet<BuiNamAnh_33.Models.TTSV> TTSV { get; set; } = default!;
    }
