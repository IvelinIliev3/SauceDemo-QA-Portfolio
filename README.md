# 🛒 SauceDemo: Manual & Automation Testing Project

Hi! I used [SauceDemo](https://www.saucedemo.com) to practice writing test cases and later transformed them into automated scripts. This project demonstrates a full testing lifecycle.

---

## 📝 Manual Testing Phase
In this phase, I focused on identifying test scenarios and documenting them clearly.
*   **Manual Test Cases**: Detailed test cases are available in the PDF/Excel file uploaded in this repository.
*   **Scenarios covered**: Login (Positive/Negative), Cart management, and Navigation.
*   **Tools used**: 
    *   **Microsoft Excel** (for documentation)
    *   **GitHub** (for version control)
    
  ---
  
## 📝 Manual Testing (TimeWise Project)
I performed comprehensive manual testing on the **TimeWise Web App**, documenting everything from initial navigation to complex user registrations.
*   **Artifacts:** [View Test Cases & Bug Reports (PDF)](./Manual_Testing_Test_Cases_and_Bugs_TimeWise.pdf)
*   **Key Findings:** Logged **10 critical and high-severity bugs**, including authentication failures and UI inconsistencies.
*   **Skills:** Boundary Value Analysis (BVA), Functional Testing, and detailed Bug Reporting.


---

## 🤖 Automation Testing Phase
I automated the critical manual scenarios to ensure rapid regression and functional reliability.

---

## 🗄️ SQL & Database Testing
Validated backend data integrity for the **TimeWise** project using SQL queries.
*   **Scenarios Covered:** 
    *   Verifying successful user registration in the database.
    *   Investigating timezone/timestamp bugs (related to Bug ID 10).
    *   Identifying data truncation or validation issues (e.g., name length exceeding 40 characters).
*   **Tool used:** MS SQL Server / PostgreSQL
*   **File:** Check `SQL-Testing/queries.sql` for the full script.

---

### 🛠 Tech Stack
*   **Language**: `C# (.NET)`
*   **Framework**: `NUnit` (for test organization and assertions)
*   **Engine**: `Selenium WebDriver` (Chrome)

### 🚀 Key Implementation Details
*   **Life-cycle Management**: Used `[SetUp]` and `[TearDown]` methods for automated browser initialization and clean-up.
*   **Validation**: Automated **Successful Login** verification by validating the final URL address.
*   **Smart Locators**: Elements are targeted using stable IDs (`user-name`, `password`, `login-button`).

---

## 📂 Project Structure
*   `LoginTests.cs` – Automated test scripts for login functionality.
*   `Manual_Test_Cases.pdf` – Full manual documentation.
*   `Drivers/` – Chrome WebDriver configuration.

---


📫 **Connect with me:** [LinkedIn](https://www.linkedin.com) | 📧 iliev.ivn@gmail.com
