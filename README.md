# Credit Marketplace System

---

## Overview

A web-based platform that connects buyers and sellers of store credits issued after product returns.
The system allows users to list credits for sale and enables others to purchase them in a structured, transparent, and efficient way.

---

## Mission

* Enable efficient trading of store credits
* Connect users with unused credits to potential buyers
* Improve utilization of unused credit value
* Create a clear and accessible digital marketplace

---

## Technologies

* Frontend: React
* Backend: C# / ASP.NET Core
* Database: SQL Server
* API: REST

---

## Project Structure

```
client
  src
    components
    pages
    services
    App.js

server
  Controllers
  Models
  Services
  Program.cs

database
  schema.sql
```

---

## Installation and Run

### Client

```
npm install
npm start
```

### Server

```
dotnet restore
dotnet run
```

---

## Database Schema

* Users – system users
* Credits – credits listed for sale
* Stores – source stores of credits

---

## Core Features

* User registration and authentication
* Listing credits for sale
* Searching credits by store or amount
* Performing transactions between users

---

## System Architecture

```
React Client
     ↓
REST API
     ↓
ASP.NET Core Server
     ↓
SQL Server Database
```

---

## System Flow

```
User logs into the system
     ↓
Views or creates credit listings
     ↓
Searches available credits
     ↓
Selects a credit and initiates purchase
     ↓
System processes and completes the transaction
```

---

## About the Project

This project was developed as a full-stack system for managing and trading store credits between users, with a focus on usability, structure, and scalability.

---

## GitHub Setup

```
git init
git add .
git commit -m "Initial commit"
git branch -M main
git remote add origin <your-repository-url>
git push -u origin main
```

---

## Status

MVP version – ready for further development and production improvements
