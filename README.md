# Angular Dot.Net Jwt Login - Projeto Completo

Este repositório contém a solução completa do JwtAuthDemo, com o backend, frontend e os testes automatizados.

---

## Estrutura do Repositório

- `/frontend/src/main.ts` — Frontend em Angular (configurado para consumir o backend).
- `/backend/src/JwtAuthDemo.API` — Backend em ASP.NET Core 8.0 com autenticação JWT.
- `/backend/JwtAuthDemo.API.Tests` — Testes unitários e de integração para o backend.

---

## Como rodar

### Backend

1. Acesse a pasta do backend:

   ```bash
   cd /backend/src/JwtAuthDemo.API
    ```
Configure a string de conexão e as variáveis no appsettings.json (exemplo: conexão com PostgreSQL, JWT, etc).

Execute o backend:

```bash
dotnet run
```
O backend estará disponível em http://localhost:5000 (ou a porta configurada).

Para acessar a documentação Swagger, acesse: http://localhost:5000/swagger

ou docker
   ```bash
   docker build -t jwt-auth-demo-api .
   ```
   ```bash
   docker run -p 5000:5000 jwt-auth-demo-api
   ```
Swagger API:
   ```bash
   http://localhost:5000/swagger/index.html
   ```

Frontend
Acesse a pasta do frontend:

   ```bash
   cd frontend
   ```

Instale as dependências:
   ```bash
   npm install
   ```

Execute o frontend:
   ```bash
   npm start
   ```
ou
   ```bash
   ng serve
   ```

O frontend estará disponível em http://localhost:4200

Testes
Acesse a pasta dos testes do backend:

   ```bash
   cd /backend/JwtAuthDemo.API.Tests
   ```

Rode os testes:
   ```bash
   dotnet test
   ```

Tecnologias usadas
Backend: ASP.NET Core 8.0, Entity Framework Core, JWT Authentication

Frontend: Angular

Banco de Dados: PostgreSQL (configurável)

Testes: xUnit, Moq


