# CourseProject-NT106.P22.ANTT-Group3
# Group 3
## Course: Basic Network Programming 
## Course ID: NT106.P22.ANTT
# Project: "Tiến lên Miền Nam" Game
---

## 📌 Mục tiêu
Xây dựng trò chơi bài nhiều người chơi với các chức năng: đăng nhập, tạo phòng, chơi trực tuyến. Giao diện trực quan, trải nghiệm người dùng mượt mà và hỗ trợ chơi với máy hoặc bạn bè qua mạng LAN.

---

## 🛠️ Công nghệ sử dụng

| Thành phần              | Công nghệ / Công cụ sử dụng                             |
|------------------------|----------------------------------------------------------|
| **Ngôn ngữ lập trình**  | C# (Windows Forms - WinForms)                            |
| **Giao diện người dùng**| WinForms (UI trên Windows Desktop)                       |
| **Cơ sở dữ liệu**       | MongoDB ( lưu thông tin người dùng, phòng chơi)   |
| **Kết nối Client-Server**| TCP/IP (`TcpClient` và `TcpListener`)                  |
| **Hệ thống chat**       | Giao tiếp TCP real-time giữa các client                 |
| **Xử lý luật chơi**     | Viết tay hoàn toàn bằng C#                              |
| **Thư viện sử dụng**    | MongoDB.Driver, System.Net.Sockets                      |

---

## 📡 Giao thức truyền thông (Protocol Code)

| Code | Ý nghĩa |
|------|--------|
| `0`  | Tạo phòng mới |
| `1`  | Vào phòng |
| `2`  | Nhận các lá bài |
| `3`  | Nhận các lá bài đã đánh của người khác |
| `4`  | Nhận lượt đánh tiếp theo |
| `5`  | Xóa các lá bài đã đánh ở giữa bàn |
| `6`  | Có người chơi thắng |
| `7`  | Gửi và nhận tin nhắn chat |
| `8`  | Nhận lượt đánh đầu tiên |
| `9`  | Gửi các lá bài còn lại sau khi có người thắng |
| `10` | Người chơi (trừ chủ phòng) thoát game |
| `11` | Chủ phòng thoát game |
| `12` | Kiểm tra sự tồn tại của phòng |
| `13` | Khởi tạo Form nếu phòng tồn tại |

---


### Group Member:
| Full Name | Student ID | Gmail |
|--------------|-------|------|
| Trần Viết Thắng | 23521433 | [23521433@gm.uit.edu.vn](mailto:23521433@gm.uit.edu.vn) |
| Nguyễn Quang Thắng | 23521425 | [23521425@gm.uit.edu.vn](mailto:23521425@gm.uit.edu.vn) | 
| Lê Minh Tấn | 23521398 | [23521398@gm.uit.edu.vn](mailto:23521398@gm.uit.edu.vn) | 



`Server` Branch: `Server`

`Client` Branch: `Cilent`
