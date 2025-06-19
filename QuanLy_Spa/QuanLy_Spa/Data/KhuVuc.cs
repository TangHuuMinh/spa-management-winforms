using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Spa.DuLieu
{
    internal class KhuVuc
    {
        string[][] Quan = new string[63][];
        public string[] TP = new string[]//"Hậu Giang","Nam Định".
        {
           "An Giang", "Bà Rịa - Vũng Tàu", "Bắc Giang", "Bắc Kạn", "Bắc Ninh", "Bạc Liêu", 
           "Bến Tre", "Bình Định", "Bình Dương", "Bình Phước", "Bình Thuận", 
           "Cà Mau", "Cần Thơ", "Cao Bằng", "Đà Nẵng", "Đắk Lắk", 
           "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Gia Lai", 
           "Hà Giang", "Hà Nam", "Hà Nội", "Hà Tĩnh", "Hải Dương", 
           "Hậu Giang", "Hòa Bình", "Hưng Yên", "Khánh Hòa", 
           "Kiên Giang", "Kon Tum", "Lai Châu", "Lâm Đồng", "Lạng Sơn", 
           "Lào Cai", "Long An", "Nam Định", "Nghệ An", "Ninh Bình", 
           "Ninh Thuận", "Phú Quốc", "Phú Thọ", "Phú Yên", "Quảng Bình",
           "Quảng Nam", "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng", 
           "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên", "Thanh Hóa", 
           "Thừa Thiên Huế", "Tiền Giang", "TP Hồ Chí Minh", "Trà Vinh", 
           "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái"

        };
        public KhuVuc()
        {
            // An Giang
            Quan[0] = new string[]
            {
    "Long Xuyên", "Châu Đốc", "Tân Châu", "An Phú", "Châu Phú",
    "Châu Thành", "Phú Tân", "Thoại Sơn", "Tri Tôn", "Tịnh Biên"
            };
            // Bà Rịa - Vũng Tàu
            Quan[1] = new string[]
            {
    "Vũng Tàu", "Bà Rịa", "Châu Đức", "Côn Đảo", "Đất Đỏ",
    "Long Điền", "Phú Mỹ", "Xuyên Mộc"
            };
            // Bắc Giang
            Quan[2] = new string[]
            {
    "Bắc Giang", "Hiệp Hòa", "Lạng Giang", "Lục Nam", "Lục Ngạn",
    "Sơn Động", "Tân Yên", "Việt Yên", "Yên Dũng", "Yên Thế"
            };
            // Bắc Kạn
            Quan[3] = new string[]
            {
    "Bắc Kạn", "Ba Bể", "Bạch Thông", "Chợ Đồn", "Chợ Mới",
    "Na Rì", "Ngân Sơn", "Pác Nặm"
            };
            // Bắc Ninh
            Quan[4] = new string[]
            {
    "Bắc Ninh", "Gia Bình", "Lương Tài", "Quế Võ", "Thuận Thành",
    "Tiên Du", "Từ Sơn", "Yên Phong"
            };
            // Bạc Liêu
            Quan[5] = new string[]
            {
    "Bạc Liêu", "Giá Rai", "Đông Hải", "Hòa Bình", "Hồng Dân",
    "Phước Long", "Vĩnh Lợi"
            };         
            // Bến Tre
            Quan[6] = new string[]
            {
    "Bến Tre", "Ba Tri", "Bình Đại", "Châu Thành", "Chợ Lách",
    "Giồng Trôm", "Mỏ Cày Bắc", "Mỏ Cày Nam", "Thạnh Phú"
            };
            // Bình Định
            Quan[7] = new string[]
            {
    "Quy Nhơn", "An Lão", "An Nhơn", "Hoài Ân", "Hoài Nhơn",
    "Phù Cát", "Phù Mỹ", "Tây Sơn", "Tuy Phước", "Vân Canh", "Vĩnh Thạnh"
            };
            // Bình Dương
            Quan[8] = new string[]
            {
    "Thủ Dầu Một", "Bàu Bàng", "Bến Cát", "Dầu Tiếng", "Dĩ An",
    "Phú Giáo", "Tân Uyên", "Thuận An"
            };
            // Bình Phước
            Quan[9] = new string[]
            {
    "Đồng Xoài", "Bình Long", "Chơn Thành", "Đồng Phú", "Bù Đăng",
    "Bù Đốp", "Bù Gia Mập", "Hớn Quản", "Lộc Ninh", "Phú Riềng"
            };
            // Bình Thuận
            Quan[10] = new string[]
            {
    "Phan Thiết", "La Gi", "Bắc Bình", "Đức Linh", "Hàm Tân",
    "Hàm Thuận Bắc", "Hàm Thuận Nam", "Phú Quý", "Tánh Linh"
            };
            // Cà Mau
            Quan[11] = new string[]
            {
    "Cà Mau", "Cái Nước", "Đầm Dơi", "Năm Căn", "Ngọc Hiển",
    "Phú Tân", "Thới Bình", "Trần Văn Thời", "U Minh"
            };
            // Cần Thơ
            Quan[12] = new string[]
            {
    "Ninh Kiều", "Bình Thủy", "Cái Răng", "Ô Môn", "Thốt Nốt",
    "Phong Điền", "Cờ Đỏ", "Thới Lai", "Vĩnh Thạnh"
            };
            // Cao Bằng
            Quan[13] = new string[]
            {
    "Cao Bằng", "Bảo Lạc", "Bảo Lâm", "Hạ Lang", "Hà Quảng",
    "Hòa An", "Nguyên Bình", "Phục Hòa", "Quảng Hòa", "Thạch An", "Trùng Khánh"
            };
            // Đà Nẵng
            Quan[14] = new string[]
            {
                "Hải Châu","Thanh Khê","Sơn Trà","Ngũ Hành Sơn","Liên Chiểu","Cẩm Lệ",
                "Hòa Vang","Hoàng Sa"
            };
            // Đắk Lắk
            Quan[15] = new string[]
            {
    "Buôn Ma Thuột", "Buôn Đôn", "Cư Kuin", "Cư M'gar", "Ea H'leo",
    "Ea Kar", "Ea Súp", "Krông Ana", "Krông Bông", "Krông Buk",
    "Krông Năng", "Krông Pắc", "Lắk", "M'Đrắk"
            };
            // Đắk Nông
            Quan[16] = new string[]
            {
    "Gia Nghĩa", "Cư Jút", "Đắk Glong", "Đắk Mil", "Đắk R'Lấp",
    "Đắk Song", "Krông Nô", "Tuy Đức"
            };
            // Điện Biên
            Quan[17] = new string[]
            {
    "Điện Biên Phủ", "Mường Lay", "Điện Biên", "Điện Biên Đông",
    "Mường Ảng", "Mường Chà", "Mường Nhé", "Nậm Pồ", "Tủa Chùa", "Tuần Giáo"
            };
            // Đồng Nai
            Quan[18] = new string[]
            {
    "Biên Hòa", "Long Khánh", "Cẩm Mỹ", "Định Quán", "Long Thành",
    "Nhơn Trạch", "Tân Phú", "Thống Nhất", "Trảng Bom", "Vĩnh Cửu", "Xuân Lộc"
            };
            // Đồng Tháp
            Quan[19] = new string[]
            {
    "Cao Lãnh", "Hồng Ngự", "Sa Đéc", "Châu Thành", "Hồng Ngự",
    "Lai Vung", "Lấp Vò", "Tam Nông", "Tân Hồng", "Thanh Bình", "Tháp Mười"
            };
            // Gia Lai
            Quan[20] = new string[]
            {
    "Pleiku", "An Khê", "Ayun Pa", "Chư Păh", "Chư Prông",
    "Chư Sê", "Chư Pưh", "Đăk Đoa", "Đăk Pơ", "Đức Cơ",
    "Ia Grai", "Ia Pa", "KBang", "Kông Chro", "Krông Pa", "Mang Yang", "Phú Thiện"
            };
            // Hà Giang
            Quan[21] = new string[]
            {
    "Hà Giang", "Bắc Mê", "Bắc Quang", "Đồng Văn", "Hoàng Su Phì",
    "Mèo Vạc", "Quản Bạ", "Quang Bình", "Vị Xuyên", "Xín Mần", "Yên Minh"
            };
            // Hà Nam
            Quan[22] = new string[]
            {
    "Phủ Lý", "Bình Lục", "Duy Tiên", "Kim Bảng", "Lý Nhân", "Thanh Liêm"
            };
            //Hà nội
            Quan[23] = new string[]
            {
                "Ba Đình", "Hoàn Kiếm", "Đống Đa", "Hai Bà Trưng", "Hoàng Mai",
                "Thanh Xuân", "Long Biên", "Nam Từ Liêm", "Bắc Từ Liêm",
                "Hà Đông", "Cầu Giấy", "Tây Hồ", "Sóc Sơn", "Đông Anh",
                "Gia Lâm", "Thanh Trì", "Mê Linh", "Sơn Tây", "Phúc Thọ",
                "Thạch Thất", "Quốc Oai", "Chương Mỹ", "Đan Phượng", "Hoài Đức",
                "Thanh Oai", "Mỹ Đức", "Ứng Hòa", "Thường Tín", "Phú Xuyên", "Ba Vì"
            };
            // Hà Tĩnh
            Quan[24] = new string[]
            {
    "Hà Tĩnh", "Hồng Lĩnh", "Kỳ Anh", "Hương Khê", "Hương Sơn",
    "Cẩm Xuyên", "Can Lộc", "Đức Thọ", "Nghi Xuân", "Thạch Hà",
    "Lộc Hà", "Vũ Quang"
            };
            // Hải Dương
            Quan[25] = new string[]
            {
    "Hải Dương", "Chí Linh", "Bình Giang", "Cẩm Giàng", "Gia Lộc",
    "Kim Thành", "Kinh Môn", "Nam Sách", "Ninh Giang", "Thanh Hà",
    "Thanh Miện", "Tứ Kỳ"
            };
            // Hậu Giang
            Quan[26] = new string[]
            {
    "Vị Thanh", "Ngã Bảy", "Long Mỹ", "Châu Thành", "Châu Thành A",
    "Phụng Hiệp", "Vị Thủy"
            };
            // Hòa Bình
            Quan[27] = new string[]
            {
    "Hòa Bình", "Cao Phong", "Đà Bắc", "Kim Bôi", "Kỳ Sơn",
    "Lạc Sơn", "Lạc Thủy", "Lương Sơn", "Mai Châu", "Tân Lạc", "Yên Thủy"
            };
            // Hưng Yên
            Quan[28] = new string[]
            {
    "Hưng Yên", "Ân Thi", "Khoái Châu", "Kim Động", "Mỹ Hào",
    "Phù Cừ", "Tiên Lữ", "Văn Giang", "Văn Lâm", "Yên Mỹ"
            };
            // Khánh Hòa
            Quan[29] = new string[]
            {
    "Nha Trang", "Cam Ranh", "Ninh Hòa", "Diên Khánh", "Khánh Sơn",
    "Khánh Vĩnh", "Trường Sa", "Vạn Ninh"
            };
            // Kiên Giang
            Quan[30] = new string[]
            {
    "Rạch Giá", "Hà Tiên", "Giang Thành", "Gò Quao", "Giồng Riềng",
    "Hòn Đất", "Kiên Hải", "Kiên Lương", "Phú Quốc", "Tân Hiệp",
    "U Minh Thượng", "Vĩnh Thuận", "An Biên", "An Minh"
            };
            // Kon Tum
            Quan[31] = new string[]
            {
    "Kon Tum", "Đắk Glei", "Đắk Hà", "Đắk Tô", "Ia H'Drai",
    "Kon Plông", "Kon Rẫy", "Ngọc Hồi", "Sa Thầy", "Tu Mơ Rông"
            };
            // Lai Châu
            Quan[32] = new string[]
            {
    "Lai Châu", "Mường Tè", "Phong Thổ", "Sìn Hồ", "Tam Đường",
    "Tân Uyên", "Than Uyên", "Nậm Nhùn"
            };
            // Lâm Đồng
            Quan[33] = new string[]
            {
    "Đà Lạt", "Bảo Lộc", "Bảo Lâm", "Cát Tiên", "Di Linh",
    "Đạ Huoai", "Đạ Tẻh", "Đam Rông", "Đơn Dương", "Đức Trọng",
    "Lạc Dương", "Lâm Hà"
            };
            // Lạng Sơn
            Quan[34] = new string[]
            {
    "Lạng Sơn", "Bắc Sơn", "Bình Gia", "Cao Lộc", "Chi Lăng",
    "Đình Lập", "Hữu Lũng", "Lộc Bình", "Tràng Định", "Văn Lãng", "Văn Quan"
            };
            // Lào Cai
            Quan[35] = new string[]
            {
    "Lào Cai", "Bảo Thắng", "Bảo Yên", "Bát Xát", "Mường Khương",
    "Sa Pa", "Si Ma Cai", "Văn Bàn"
            };
            // Long An
            Quan[36] = new string[]
            {
    "Tân An", "Bến Lức", "Cần Đước", "Cần Giuộc", "Châu Thành",
    "Đức Hòa", "Đức Huệ", "Mộc Hóa", "Tân Hưng", "Tân Thạnh",
    "Tân Trụ", "Thạnh Hóa", "Thủ Thừa", "Vĩnh Hưng"
            };
            // Nam Định
            Quan[37] = new string[]
            {
                "Bà Triệu","Cửa Bắc","Cửa Nam","Hạ Long","Lộc Hạ","Lộc Vượng",
                "Mỹ Xá","Nguyễn Du","Ngô Quyền","Năng Tĩnh","Phan Đình Phùng","Thống Nhất",
                "Trần Đăng Ninh","Trần Hưng Đạo","Trần Tế Xương","Vị Hoàng","Vị Xuyên"
            };
            // Nghệ An
            Quan[38] = new string[]
            {
    "Vinh", "Cửa Lò", "Thái Hòa", "Hoàng Mai", "Quế Phong",
    "Quỳ Châu", "Kỳ Sơn", "Tương Dương", "Nghĩa Đàn", "Quỳ Hợp",
    "Quỳnh Lưu", "Con Cuông", "Anh Sơn", "Diễn Châu", "Yên Thành",
    "Đô Lương", "Thanh Chương", "Nghi Lộc", "Hưng Nguyên"
            };
            // Ninh Bình
            Quan[39] = new string[]
            {
    "Ninh Bình", "Tam Điệp", "Gia Viễn", "Hoa Lư", "Kim Sơn",
    "Nho Quan", "Yên Khánh", "Yên Mô"
            };
            // Ninh Thuận
            Quan[40] = new string[]
            {
    "Phan Rang – Tháp Chàm", "Bác Ái", "Ninh Hải", "Ninh Phước", "Ninh Sơn", "Thuận Bắc", "Thuận Nam"
            };
            // Phú Quốc
            Quan[41] = new string[]
            {
    "Phú Quốc"
            };
            // Phú Thọ
            Quan[42] = new string[]
            {
    "Việt Trì", "Phú Thọ", "Cẩm Khê", "Đoan Hùng", "Hạ Hòa",
    "Lâm Thao", "Phù Ninh", "Tam Nông", "Tân Sơn", "Thanh Ba",
    "Thanh Sơn", "Thanh Thủy", "Yên Lập"
            };
            // Phú Yên
            Quan[43] = new string[]
            {
    "Tuy Hòa", "Sông Cầu", "Đồng Xuân", "Phú Hòa", "Sơn Hòa",
    "Sông Hinh", "Tây Hòa", "Tuy An"
            };
            // Quảng Bình
            Quan[44] = new string[]
            {
    "Đồng Hới", "Ba Đồn", "Bố Trạch", "Lệ Thủy", "Minh Hóa",
    "Quảng Ninh", "Quảng Trạch", "Tuyên Hóa"
            };
            // Quảng Nam
            Quan[45] = new string[]
            {
    "Tam Kỳ", "Hội An", "Điện Bàn", "Đại Lộc", "Duy Xuyên",
    "Hiệp Đức", "Nam Giang", "Nam Trà My", "Nông Sơn", "Núi Thành",
    "Phú Ninh", "Phước Sơn", "Quế Sơn", "Tây Giang", "Thăng Bình",
    "Tiên Phước", "Đông Giang"
            };
            // Quảng Ngãi
            Quan[46] = new string[]
            {
    "Quảng Ngãi", "Ba Tơ", "Bình Sơn", "Đức Phổ", "Lý Sơn",
    "Minh Long", "Mộ Đức", "Nghĩa Hành", "Sơn Hà", "Sơn Tây",
    "Sơn Tịnh", "Tây Trà", "Trà Bồng", "Tư Nghĩa"
            };
            // Quảng Ninh
            Quan[47] = new string[]
            {
    "Hạ Long", "Cẩm Phả", "Móng Cái", "Uông Bí", "Bình Liêu",
    "Ba Chẽ", "Cô Tô", "Đầm Hà", "Đông Triều", "Hải Hà", "Hoành Bồ",
    "Quảng Yên", "Tiên Yên", "Vân Đồn"
            };
            // Quảng Trị
            Quan[48] = new string[]
            {
    "Đông Hà", "Quảng Trị", "Cam Lộ", "Cồn Cỏ", "Đa Krông",
    "Gio Linh", "Hải Lăng", "Hướng Hóa", "Triệu Phong", "Vĩnh Linh"
            };
            // Sóc Trăng
            Quan[49] = new string[]
            {
    "Sóc Trăng", "Ngã Năm", "Vĩnh Châu", "Cù Lao Dung", "Kế Sách",
    "Long Phú", "Mỹ Tú", "Mỹ Xuyên", "Thạnh Trị", "Trần Đề", "Châu Thành"
            };
            // Sơn La
            Quan[50] = new string[]
            {
    "Sơn La", "Bắc Yên", "Mai Sơn", "Mộc Châu", "Mường La",
    "Phù Yên", "Quỳnh Nhai", "Sông Mã", "Sốp Cộp", "Thuận Châu", "Vân Hồ", "Yên Châu"
            };
            // Tây Ninh
            Quan[51] = new string[]
            {
    "Tây Ninh", "Bến Cầu", "Châu Thành", "Dương Minh Châu", "Gò Dầu",
    "Hòa Thành", "Tân Biên", "Tân Châu", "Trảng Bàng"
            };
            // Thái Bình
            Quan[52] = new string[]
            {
    "Thái Bình", "Đông Hưng", "Hưng Hà", "Kiến Xương", "Quỳnh Phụ",
    "Thái Thụy", "Tiền Hải", "Vũ Thư"
            };
            // Thái Nguyên
            Quan[53] = new string[]
            {
    "Thái Nguyên", "Sông Công", "Phổ Yên", "Đại Từ", "Định Hóa",
    "Đồng Hỷ", "Phú Bình", "Phú Lương", "Võ Nhai"
            };
            // Thanh Hóa
            Quan[54] = new string[]
            {
    "Thanh Hóa", "Bỉm Sơn", "Sầm Sơn", "Bá Thước", "Cẩm Thủy",
    "Đông Sơn", "Hà Trung", "Hậu Lộc", "Hoằng Hóa", "Lang Chánh",
    "Mường Lát", "Nga Sơn", "Ngọc Lặc", "Như Thanh", "Như Xuân",
    "Nông Cống", "Quan Hóa", "Quan Sơn", "Quảng Xương", "Thạch Thành",
    "Thiệu Hóa", "Thọ Xuân", "Thường Xuân", "Triệu Sơn", "Vĩnh Lộc",
    "Yên Định"
            };
            // Thừa Thiên - Huế
            Quan[55] = new string[]
            {
    "Huế", "A Lưới", "Nam Đông", "Phong Điền", "Phú Lộc",
    "Phú Vang", "Quảng Điền", "Hương Trà", "Hương Thủy"
            };
            // Tiền Giang
            Quan[56] = new string[]
            {
    "Mỹ Tho", "Gò Công", "Cai Lậy", "Cái Bè", "Châu Thành",
    "Chợ Gạo", "Gò Công Đông", "Gò Công Tây", "Tân Phú Đông", "Tân Phước"
            };
            // TP Hồ Chí Minh
            Quan[57] = new string[]
            {
                "Quận 1", "Quận 2", "Quận 3", "Quận 4", "Quận 5", "Quận 6",
                "Quận 7", "Quận 8", "Quận 9", "Quận 10", "Quận 11", "Quận 12",
                "Bình Tân", "Bình Thạnh", "Gò Vấp", "Phú Nhuận", "Tân Bình",
                "Tân Phú", "Thủ Đức", "Bình Chánh", "Cần Giờ", "Củ Chi",
                "Hóc Môn", "Nhà Bè"
            };
            // Trà Vinh
            Quan[58] = new string[]
            {
    "Trà Vinh", "Càng Long", "Cầu Kè", "Cầu Ngang", "Châu Thành",
    "Duyên Hải", "Tiểu Cần", "Trà Cú"
            };
            // Tuyên Quang
            Quan[59] = new string[]
            {
    "Tuyên Quang", "Chiêm Hóa", "Hàm Yên", "Lâm Bình", "Nà Hang", "Sơn Dương", "Yên Sơn"
            };
            // Vĩnh Long
            Quan[60] = new string[]
            {
    "Vĩnh Long", "Bình Minh", "Bình Tân", "Long Hồ", "Mang Thít",
    "Tam Bình", "Trà Ôn", "Vũng Liêm"
            };
            // Vĩnh Phúc
            Quan[61] = new string[]
            {
    "Vĩnh Yên", "Phúc Yên", "Bình Xuyên", "Lập Thạch", "Sông Lô",
    "Tam Đảo", "Tam Dương", "Vĩnh Tường", "Yên Lạc"
            };
            // Yên Bái
            Quan[62] = new string[]
            {
    "Yên Bái", "Nghĩa Lộ", "Lục Yên", "Mù Cang Chải", "Trạm Tấu",
    "Trấn Yên", "Văn Chấn", "Văn Yên", "Yên Bình"
            };
            
            
            
        }
        public string[] KHUVUC(int k)
        {
            return Quan[k];
        }
    }
}
