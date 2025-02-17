# 📦 Microservices with MassTransit & RabbitMQ 🐰  
#### Building a Scalable Microservices Architecture with ASP.NET Core  

![Microservices](https://img.shields.io/badge/Microservices-ASP.NET_Core-blue)  
![MassTransit](https://img.shields.io/badge/MassTransit-7.x-green)  
![RabbitMQ](https://img.shields.io/badge/RabbitMQ-3.x-orange)  
![License](https://img.shields.io/badge/License-MIT-lightgrey)  

🚀 This project demonstrates a microservices architecture using **ASP.NET Core**, **MassTransit**, and **RabbitMQ** for robust message-driven communication. It provides a practical implementation of **event-driven microservices**, enabling **scalability**, **loose coupling**, and **fault tolerance**.

---

## ✨ Features  
✔️ **Microservices-based architecture** with independent services  
✔️ **MassTransit integration** for message handling and event-driven communication  
✔️ **RabbitMQ as the message broker** for asynchronous messaging  
✔️ **Docker support** for easy deployment  
✔️ **Resilient communication** with retry and circuit breaker patterns  
✔️ **Entity Framework Core** for database persistence  
✔️ **Swagger UI** for easy API exploration  

---

## 🛠 Tech Stack  

| Category        | Technology |
|----------------|-----------|
| Backend        | ASP.NET Core 7+ |
| Messaging      | MassTransit, RabbitMQ |
| Database       | PostgreSQL (EF Core) |
| API Docs       | Swagger (Swashbuckle) |
| Containerization | Docker, Docker Compose |

---

## 📌 Setup & Installation  

### 🔧 Prerequisites  
Ensure you have the following installed before proceeding:  
- [.NET SDK 7.0+](https://dotnet.microsoft.com/en-us/download)  
- [Docker & Docker Compose](https://www.docker.com/get-started)  
- [RabbitMQ (via Docker)](https://www.rabbitmq.com/download.html)  

### 🚀 Installation Steps  

1️⃣ **Clone the repository**  
\`\`\`sh
git clone https://github.com/twalker-codes/MicroservicesWithMassTransitandRabbitMQ.git
cd MicroservicesWithMassTransitandRabbitMQ
\`\`\`

2️⃣ **Run RabbitMQ using Docker**  
\`\`\`sh
docker-compose up -d
\`\`\`

3️⃣ **Run the microservices**  
\`\`\`sh
dotnet run --project Services/OrderService
dotnet run --project Services/PaymentService
\`\`\`

4️⃣ **Verify the services**  
- Open `http://localhost:5000/swagger` in the browser.  
- Send test requests via Swagger UI.  

---

## 📡 API Endpoints  

| Service       | Method | Endpoint               | Description                  |
|--------------|--------|------------------------|------------------------------|
| OrderService | \`GET\`  | \`/api/orders\`          | Get all orders               |
| OrderService | \`POST\` | \`/api/orders\`          | Create a new order           |
| PaymentService | \`POST\` | \`/api/payments\`       | Process a payment            |

> 📌 **Note**: The endpoints communicate asynchronously via RabbitMQ.

---

## 📦 NuGet Packages  

| Package | Description |
|---------|-------------|
| [MassTransit](https://www.nuget.org/packages/MassTransit/) | Distributed application framework for messaging |
| [MassTransit.RabbitMQ](https://www.nuget.org/packages/MassTransit.RabbitMQ/) | RabbitMQ transport for MassTransit |
| [Swashbuckle.AspNetCore](https://www.nuget.org/packages/Swashbuckle.AspNetCore/) | Swagger integration for API documentation |
| [EF Core](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/) | ORM for database operations |

---

## 🤝 Contributing  

Contributions are welcome! 🚀  
1. Fork the repository  
2. Create a feature branch (\`git checkout -b feature-name\`)  
3. Commit changes (\`git commit -m "Add new feature"\`)  
4. Push to the branch (\`git push origin feature-name\`)  
5. Create a Pull Request  

---

## 📜 License  

This project is open-source and available under the **MIT License**.  
