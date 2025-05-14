using Microsoft.AspNetCore.Mvc;
using NvkLesson04.Models;

namespace NvkLesson04.Controllers
{
    public class NvkBookController : Controller
    {

        private List<NvkBook> nvkBooks = new List<NvkBook>
        {
            new NvkBook
            {
                NvkId = "B001",
                NvkTitle = "Lập trình C# cơ bản",
                NvkDescription = "Cuốn sách hướng dẫn lập trình C# từ cơ bản đến nâng cao.",
                NvkImage = "images/sach1.jpg",
                NvkPrice = 150000,
                NvkPage = 320
            },
            new NvkBook
            {
                NvkId = "B002",
                NvkTitle = "Học ASP.NET Core",
                NvkDescription = "Giới thiệu và hướng dẫn xây dựng ứng dụng web với ASP.NET Core.",
                NvkImage = "images/sach2.jpg",
                NvkPrice = 180000,
                NvkPage = 400
            },
            new NvkBook
            {
                NvkId = "B003",
                NvkTitle = "Cấu trúc dữ liệu và giải thuật",
                NvkDescription = "Nền tảng vững chắc về cấu trúc dữ liệu và thuật toán cho lập trình viên.",
                NvkImage = "images/sach3.jpg",
                NvkPrice = 200000,
                NvkPage = 500
            },
            new NvkBook
            {
                NvkId = "B004",
                NvkTitle = "Thiết kế phần mềm",
                NvkDescription = "Các mẫu thiết kế phần mềm phổ biến và cách áp dụng.",
                NvkImage = "images/sach4.jpg",
                NvkPrice = 170000,
                NvkPage = 350
            },
            new NvkBook
            {
                NvkId = "B005",
                NvkTitle = "SQL cho người mới bắt đầu",
                NvkDescription = "Hướng dẫn học SQL từ cơ bản để truy vấn và quản lý dữ liệu.",
                NvkImage = "images/sach5.jpg",
                NvkPrice = 130000,
                NvkPage = 280
            }
        };

        //GET: /NvkBook/NvkIndex => lay tat ca cuon sach
        public IActionResult NvkIndex()
        {
            //Dua du lieu len view
            return View(nvkBooks);
        }
    }
}
