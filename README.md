# Arquitetura Completa Angular 19, Dot.Net 8, Jwt e PostgreSQL 13 - Projeto Completo com Docker

Este repositório contém a solução completa, com o backend, frontend e os testes automatizados e banco de dados.

---

## Estrutura do Repositório

- `/frontend/src/main.ts` — Frontend em Angular (configurado para consumir o backend).
- `/backend/src/JwtAuthDemo.API` — Backend em ASP.NET Core 8.0 com autenticação JWT.
- `/backend/JwtAuthDemo.API.Tests` — Testes unitários e de integração para o backend.

---

## Como rodar

### Banco de Dados PostgreSQL
```bash
docker run -d   --name jwt-postgres   -e POSTGRES_USER=andi   -e POSTGRES_PASSWORD=suaSenhaSegura123   -e POSTGRES_DB=jwtAuthDemoDb   -p 5432:5432   postgres
```
```bash
docker exec -it jwt-postgres bash -c "echo \"listen_addresses='*'\" >> /var/lib/postgresql/data/postgresql.conf"
```
Acessar o banco pelo terminal
   ```bash
   psql -h localhost -U andi -d jwtAuthDemoDb
   ```
Entrar no bash do docker
   ```bash
   docker exec -it jwt-postgres bash
   ```
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
### Swagger API:
   ```bash
   http://localhost:5000/swagger/index.html
   ```

### Frontend
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

### Testes
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


