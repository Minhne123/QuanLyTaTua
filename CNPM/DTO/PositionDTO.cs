﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.DTO
{
    public class PositionDTO
    {
        private int maChucVu;
        private string tenChucVu;

        public int MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }

        public PositionDTO(int maChucVu, string tenChucVu)
        {
            this.MaChucVu = maChucVu;
            this.TenChucVu = tenChucVu;
        }

        public PositionDTO(DataRow row)
        {
            this.MaChucVu = (int)row["machucvu"];
            this.TenChucVu = row["tenchucvu"].ToString();
        }
    }
}
