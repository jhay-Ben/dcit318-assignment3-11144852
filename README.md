# dcit318-assignment3-11144852

# DCIT 318 - Assignment 3

**Repository Name:** dcit318-assignment3-11144852

This repository contains solutions for **Assignment 3** of the DCIT 318 (Programming II) course.  
All 5 questions are implemented as **separate C# files** and run from a single **menu-based** console application (`Program.cs`).

---

## 📋 Main Menu
When the application runs, you will see:
=== Assignment 3 Main Menu ===

1. Finance Management System (Q1)

2. Healthcare System (Q2)

3. Warehouse Inventory Management (Q3)

4. School Grading System (Q4)

5. Inventory Records System (Q5)

6. Exit


Selecting an option runs the corresponding question’s program.

---

## 1️⃣ Question 1 – Finance Management System
**Concepts Used:**  
- Records  
- Interfaces  
- Sealed Classes  
- Inheritance & Method Overriding

**Description:**  
Implements a finance tracking system that:
- Records transactions as immutable `Transaction` records.
- Processes payments via different processors:
  - `MobileMoneyProcessor`
  - `BankTransferProcessor`
  - `CryptoWalletProcessor`
- Uses a `SavingsAccount` (sealed) to apply transactions with balance checks.

---

## 2️⃣ Question 2 – Healthcare System
**Concepts Used:**  
- Generics  
- Collections (`List`, `Dictionary`)  
- Repository Pattern

**Description:**  
Manages patients and prescriptions using:
- `Repository<T>` for generic data storage.
- A dictionary mapping patient IDs to their prescriptions.
- Displays all patients, then shows prescriptions for a selected patient.

---

## 3️⃣ Question 3 – Warehouse Inventory Management
**Concepts Used:**  
- Marker Interfaces  
- Generics  
- Custom Exceptions  
- Exception Handling

**Description:**  
Manages grocery and electronic inventory:
- `IInventoryItem` as a marker interface.
- `InventoryRepository<T>` for generic storage.
- Custom exceptions:
  - `DuplicateItemException`
  - `ItemNotFoundException`
  - `InvalidQuantityException`
- Handles adding, removing, updating, and listing items.

---

## 4️⃣ Question 4 – School Grading System
**Concepts Used:**  
- File I/O (`StreamReader`, `StreamWriter`)  
- Custom Exceptions  
- Data Validation

**Description:**  
Reads student records from `students.txt`, assigns grades, and writes to `report.txt`.  
Handles:
- Missing fields (`MissingFieldException`)
- Invalid scores (`InvalidScoreFormatException`)
- Missing file (`FileNotFoundException`)

**Example Input (`students.txt`):**
101, Alice Smith, 84
102, Bob Johnson, 73
103, Carol White, 59

---

## 5️⃣ Question 5 – Inventory Records System
**Concepts Used:**  
- Records for Immutable Data  
- Generics  
- File Serialization (JSON)  
- Interface Implementation

**Description:**  
Logs inventory records with:
- `InventoryItem` record implementing `IInventoryEntity`.
- `InventoryLogger<T>` for generic file operations.
- Saves inventory to `inventory.json` and loads it back.

---

## 🛠 Setup & Running
1. Clone the repository:
   ```bash
   git clone https://github.com/jhay-Ben/dcit318-assignment3-11144852.git

