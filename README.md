# 📚 Library Management System

A Windows Forms application built in **C# (.NET)** with **SQL Server (SSMS)** as the backend.  
This project is designed to manage books, members, borrowing, returning, and receipts in a library.

---

## 🔹 Features

### 🔑 Login System
- Validates user credentials from the **Users** table.
- Opens the **Dashboard** upon successful login.

### 🖥️ Dashboard
- Central navigation hub.
- Provides buttons to access Members, Books, Borrowing, Returning, History, Receipts, and Logout.

### 👥 Manage Members
- Add new members with details (name, email, phone).
- Update or delete existing members.
- View all members in a **DataGridView**.

### 📚 Manage Books
- Add new books with details (title, author, genre, year, quantity, availability).
- Update or delete existing books.
- View all books in a **DataGridView**.

### 📖 Borrow Books
- Select a member and a book from dropdown lists.
- Records borrowing details in the **BorrowHistory** table.
- Decreases available book quantity automatically.

### 📕 Return Books
- Marks a borrowed book as returned.
- Updates the return date in **BorrowHistory**.
- Increases book quantity.
- Generates a **receipt text file** for the return.

### 📊 Borrowing History
- Displays all borrow records (borrowed and returned).
- Shows whether a book is returned (**Yes/No**).

### 📈 Returning History
- Displays only returned books.
- Includes borrow and return dates.

### 📝 View Receipts
- Reads all generated receipts stored as `.txt` files.
- Displays them in a text box for easy viewing.

---

## 🛠️ Technologies Used
- **C# (.NET Windows Forms)**
- **Microsoft SQL Server (SSMS)**
- **ADO.NET (SqlConnection, SqlCommand, DataAdapter)**
- **File Handling** (for return receipts)

---

## 📂 Database Structure

### Users
| Column    | Type    |
|-----------|---------|
| UserID    | INT (PK) |
| Username  | NVARCHAR |
| Password  | NVARCHAR |
| Role      | NVARCHAR |

### Members
| Column    | Type    |
|-----------|---------|
| MemberID  | INT (PK) |
| FullName  | NVARCHAR |
| Email     | NVARCHAR |
| Phone     | NVARCHAR |

### Books
| Column        | Type    |
|---------------|---------|
| BookID        | INT (PK) |
| Title         | NVARCHAR |
| Author        | NVARCHAR |
| Genre         | NVARCHAR |
| YearPublished | INT |
| Quantity      | INT |
| Available     | BIT |

### BorrowHistory
| Column     | Type    |
|------------|---------|
| BorrowID   | INT (PK) |
| MemberID   | INT (FK) |
| BookID     | INT (FK) |
| BorrowDate | DATE |
| ReturnDate | DATE (NULL) |
| IsReturned | BIT |

---

## 🚀 How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/LibraryManagementSystem.git
