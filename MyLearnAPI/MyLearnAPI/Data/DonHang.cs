namespace MyLearnAPI.Data
{
    public class DonHang
    {
        public enum TinhTrangDonDatHang
        {
            New = 0, Payment = 1, Complete = 2,Cancel = -1
        }
        public Guid MaDH { get; set; }
        public DateTime NgayDH { get; set; }    
        public DateTime? NgayGiao { get; set; }
        public TinhTrangDonDatHang TinhTrangDonHang { get; set; }   
        public string NguoiNhan { get; set; }   
        public string DiaChiGiao { get; set; }
        public string SoDienThoai { get; set; } 
        public ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public DonHang()
        {
            ChiTietDonHangs = new List<ChiTietDonHang>();   
        }
    }
}
