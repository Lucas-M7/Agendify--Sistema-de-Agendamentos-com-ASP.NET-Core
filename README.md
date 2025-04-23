# 📅 Agendify (ainda em desenvolvimento)

Sistema completo de agendamentos entre clientes e pequenos negócios. Desenvolvido com arquitetura em camadas (Clean Architecture), foco em boas práticas (SOLID) e uso das tecnologias modernas do ecossistema .NET.

---

## 🚀 Descrição

**Agendify** é uma API que permite que clientes agendem serviços com empresas ou profissionais autônomos. A aplicação lida com agendamentos, clientes e empresas, cuidando da integridade dos dados, validações de conflitos de horário e gestão de relacionamentos entre as partes envolvidas.

O sistema é ideal para barbearias, clínicas, estúdios, salões e qualquer pequeno negócio que necessite de uma gestão de horários confiável e automatizada.

---

## 🛠️ Tecnologias Utilizadas

| Camada         | Tecnologias                               |
|----------------|-------------------------------------------|
| API            | ASP.NET Core 9, Swagger, FluentValidation |
| Application    | DTOs, Services, Interfaces                |
| Domain         | Entidades, Enums, ValueObjects, Regras    |
| Infrastructure | EF Core, PostgreSQL, Repositórios         |

---

## 📂 Estrutura do Projeto

```bash
Agendify.sln
├── Agendify.API           # Projeto principal (Web API)
├── Agendify.Application   # Casos de uso, DTOs, validações
├── Agendify.Domain        # Entidades, regras de negócio
├── Agendify.Infrastructure # Persistência, repositórios
```

## 🧩 Funcionalidades
- Cadastro de clientes e empresas
- Agendamento de serviços
- Detcção de conflitos de horários
- Consulta de agendamentos
- Cancelamento de agendamentos

## 🔖 Padrão de Commits
Nesse projeto, está sendo utilizado o padrão Conventional Commits:
```
<tipo>(escopo opcional): descrição curta
```
### Exemplos:
- feat(client): adicionar criação de clientes
- fix(appointment): corrigir conflito de horário
- refactor: melhorar lógica de verificação de disponibilidade

## 🤝 Como Contribuir
1. Faça um fork do repositório
2. Crie uma branch com sua feature:
    ```
   git checkout -b feat/nova-funcionalidade
   ```
3. Faça commit seguindo o padrão acima
4. Faça push para a sua branch:
    ```
   git push origin feat/nova-funcionalidade
   ```
5. Abra um Pull Request explicando sua contribuição

## 🏁 Roadmap Futuro
- Autenticação com JWT
- Notificações por e-mail/WhatsApp
- Disponibilizar via Docker