# iRespond — Gender Equality Awareness App (Desktop)

A **C# WinForms desktop application** that raises awareness of gender-inequality issues in the Philippines through informative content and data visualisation. Built with the **Bunifu UI** framework and backed by a **SQL Server** database, with accounts, email verification, and an admin-style dashboard. An [Android companion](https://github.com/rogercnyn/iRespond-Android) shares the mission.

## Overview

iRespond presents gender-inequality data and articles in a polished, animated Windows UI. Users register (with email verification) and sign in; the app then surfaces awareness content, tips, campaigns, and a **heat-map visualisation** of the data, plus reporting.

## Features

- **Accounts** — registration with **email verification**, login, splash screen
- **Dashboard** — central hub for the app's modules
- **HeatMap** — visualisation of gender-inequality data
- **Articles & Tips** — informational content on gender issues
- **Campaign** — awareness campaign section
- **User Report** — reporting module (separate `userReport` project)
- **About** — project/credits info

## Built With

| Concern | Technology |
|---------|-----------|
| Language | **C#** (.NET Framework 4.7.2) |
| UI | **Windows Forms** + **Bunifu UI WinForms 5.3.0** |
| Database | **SQL Server** (`System.Data.SqlClient`) |
| IDE | Visual Studio |

## Solution Structure
```
GenderEqualityApp/
  GenderEqualityApp.sln
  GenderEqualityApp/        # main app — Dashboard, HeatMap, Articles, Tips,
                            #   Campaign, LogIn, RegForm, EmailRegister, Verification, About
  userReport/               # user-reporting project
  packages/                 # Bunifu UI WinForms 5.3.0
```

## Getting Started

### Prerequisites
- **Visual Studio** (2019/2022) with **.NET desktop development**
- **SQL Server** (Express/LocalDB) for the database
- **Bunifu UI WinForms** (bundled in `packages/`)

### Build & run
```bash
git clone https://github.com/rogercnyn/Gender-Equality-App.git
```
1. Open `GenderEqualityApp/GenderEqualityApp.sln` in Visual Studio.
2. Configure the **SQL Server** connection string (see `Settings`/connection usage in the forms). 
3. Restore packages and press **F5**.

## Companion App
- **Android:** [rogercnyn/iRespond-Android](https://github.com/rogercnyn/iRespond-Android)

## Developed At

Software Development project at **iACADEMY (Senior High School)**.

## License

MIT — see [`LICENSE`](LICENSE). 
