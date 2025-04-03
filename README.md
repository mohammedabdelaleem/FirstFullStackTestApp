# 🎓 Student Management API

This is a simple **ASP.NET Core Web API** for managing student records. It provides endpoints to retrieve student data, including:  
- **Get all students**  
- **Get all passed students (Grade ≥ 50)**  
- **Get all failed students (Grade < 50)**  
- **Find a student by ID**  

## 🚀 Endpoints

- `GET /api/students` → Get all students  
- `GET /api/students/passed` → Get all students who passed  
- `GET /api/students/failed` → Get all students who failed  
- `GET /api/students/{id}` → Find a student by ID  

## 🛠 Technologies Used
- **Backend:** ASP.NET Core Web API  
- **Database:** SQL Server / Entity Framework Core  
- **Tools:** Visual Studio, Postman, Swagger  

## 📌 How to Run
1. Clone the repository  
   ```bash
   git clone https://github.com/yourusername/your-repo-name.git
