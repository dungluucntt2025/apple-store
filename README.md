# AppleStore - Hướng dẫn cài đặt và sử dụng

## Giới thiệu
AppleStore là một dự án web application được phát triển bằng .NET Framework, sử dụng mô hình nhiều lớp (multi-layer architecture).

## Yêu cầu hệ thống
- Microsoft Visual Studio 2010 trở lên
- .NET Framework 4.0 trở lên
- SQL Server 2008 R2 trở lên

## Cấu trúc dự án
Dự án được chia thành các module chính:
1. **Web** - Tầng giao diện người dùng (Presentation Layer)
2. **Apple.BusinessLogic** - Tầng xử lý nghiệp vụ (Business Logic Layer)
3. **Apple.DataAccess** - Tầng truy cập dữ liệu (Data Access Layer)
4. **Apple.Common** - Chứa các thành phần dùng chung
5. **Apple.Operational** - Module xử lý các hoạt động vận hành

## Hướng dẫn cài đặt

### Bước 1: Clone/Download Source Code
- Tải source code từ repository về máy local

### Bước 2: Cấu hình Database
1. Mở SQL Server Management Studio
2. Tạo database mới
3. Chạy script tạo database (nằm trong thư mục database)
4. Cập nhật connection string trong file Web.config của project Web

### Bước 3: Build và chạy ứng dụng
1. Mở file `AppleStore.sln` bằng Visual Studio
2. Chuột phải vào Solution trong Solution Explorer, chọn "Restore NuGet Packages"
3. Build toàn bộ solution (Ctrl + Shift + B)
4. Set project Web làm Startup Project
5. Nhấn F5 để chạy ứng dụng

## Xử lý lỗi thường gặp
1. Lỗi kết nối database:
   - Kiểm tra lại connection string
   - Đảm bảo SQL Server đang chạy
   - Kiểm tra quyền truy cập database

2. Lỗi thiếu reference:
   - Clean solution
   - Rebuild toàn bộ solution
   - Kiểm tra lại NuGet packages

## Thông tin liên hệ
Nếu gặp vấn đề trong quá trình cài đặt và sử dụng, vui lòng liên hệ dungluu.cntt@gmail.com để được hỗ trợ.
