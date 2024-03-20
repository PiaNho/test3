namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KhachHang_TimViec_CheDoPhucLoi_2022
    {
        [Key]
        public int KhachHang_CheDoPhucLoi_ID { get; set; }

        public int? TimViec_ID { get; set; }

        public int? CheDoPhucLoi_ID { get; set; }

        [StringLength(500)]
        public string MoTaCheDoPhucLoi { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }
    }
}