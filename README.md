# Desafio-smn-roberto - Sistema de Gestão de Usuários e Tarefas

## Instalação
1. Clone o repositório: `git clone https://github.com/seu-repo/dotnet-app-roberto2.git`
2. Acesse a pasta do projeto: ` dotnet-smn-roberto`
3. Configure a string de conexão no `appsettings.json`
4. Execute a migração do banco: `dotnet ef database update`
5. Rode a aplicação: `dotnet  run`

## Funcionalidades
- Autenticação de usuários com ASP.NET Identity
- Cadastro e gerenciamento de tarefas com controle de permissão
- Notificações por e-mail automáticas
- Documentação da API com Swagger

## Endpoints
- `POST /api/usuario/register` - Criar usuário
- `POST /api/usuario/login` - Login
- `POST /api/tarefa` - Criar tarefa
- `GET /api/tarefa` - Listar tarefas
- `PUT /api/tarefa/{id}` - Atualizar tarefa
- `DELETE /api/tarefa/{id}` - Deletar tarefa
- `POST /api/tarefa/{id}/concluir` - Concluir tarefa
