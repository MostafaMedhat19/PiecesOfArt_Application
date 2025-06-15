# 🎨 PiecesOfArt Web API – ASP.NET Core Case Study

An ASP.NET Core Web API project for managing a unique online **Pieces of Art store**, where users can explore and purchase rare artwork. Each piece is one-of-a-kind, and users can manage their purchases and loyalty cards.

---

## 📌 Objective

Develop a backend Web API using ASP.NET Core that enables:
- Viewing art pieces and their categories.
- Purchasing unique pieces.
- Associating users with loyalty cards that offer discounts.

---

## 📆 Deadline

🕓 This project was delivered individually before **Thursday, 24/10/2024, at 11:59 PM**.

---

## 🧩 Entities & Models

### 👤 User
| Property | Type     |
|----------|----------|
| Id       | int      |
| Name     | string   |
| Email    | string   |
| Age      | int      |

---

### 🖼️ PieceOfArt
| Property        | Type     |
|----------------|----------|
| Id             | int      |
| Title          | string   |
| Price          | decimal  |
| PublicationDate| DateTime |

---

### 🗂️ Category
| Property    | Type     |
|-------------|----------|
| Id          | int      |
| Name        | string   |
| Description | string   |

---

### 💳 LoyaltyCard
| Property    | Type     |
|-------------|----------|
| Id          | int      |
| Name        | string   |
| Description | string   |

---

## 🔄 Relationships

- **User (1) ↔ (N) PieceOfArt** – Each user can buy multiple art pieces.
- **PieceOfArt (N) ↔ (1) Category** – Each art piece belongs to one category.
- **User (N) ↔ (1) LoyaltyCard** – Each user has one loyalty card; a loyalty card can apply to many users.

---

## 📋 Requirements

✅ Minimum of **5 records seeded** for each model.  
✅ Retrieve:
- A user including their **loyalty card**.
- A piece of art including its **category**.

✅ **Update** user with ID = 4:
- Name → `SEWEDY`
- Age → `100`
- PieceOfArt → `"Small Pyramid"` (Category: `Ancient`)
- LoyaltyCard → `Crystal`

✅ **Delete** the second record from all tables.

✅ **Main Goal**:
Display all users, along with:
- Their owned art pieces,
- The category of each piece,
- The loyalty card for each user.

---

## 🎨 Sample Art Pieces

| Title                      | Price     | Category      |
|---------------------------|-----------|---------------|
| Starry Night              | $100,000  | Impressionism |
| The Mona Lisa             | $500,000  | Renaissance   |
| Composition VIII          | $120,000  | Abstract      |
| The Persistence of Memory | $200,000  | Modern        |
| Small Pyramid             | $150,000  | Ancient       |

---

## 🏷️ Sample Categories

| Name          | Description                                                                 |
|---------------|-----------------------------------------------------------------------------|
| Impressionism | A 19th-century art movement with thin brush strokes and focus on movement. |
| Renaissance   | A revival of classical wisdom and art in Europe.                           |
| Abstract      | Uses shapes and colors rather than realistic forms.                        |
| Modern        | Artistic styles from the late 19th to mid-20th century.                    |
| Ancient       | Art from early civilizations like Egypt and Greece.                        |

---

## 💎 Sample Loyalty Cards

| Name      | Discount     |
|-----------|--------------|
| Bronze    | 10% Off      |
| Silver    | 20% Off      |
| Gold      | 30% Off      |
| Platinum  | 40% Off      |
| Crystal   | 50% Off      |

---

## 🛠️ Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server (or SQLite/InMemory for demo)
- LINQ for querying
- C#

---

## 📦 How to Run

1. Clone the repo:
   ```bash
   git clone https://github.com/yourusername/PiecesOfArt-API.git
   cd PiecesOfArt-API
## API Endpoints 
![image](https://github.com/user-attachments/assets/9fac8a5f-08d7-46c3-a1ed-afe106d9231b)
