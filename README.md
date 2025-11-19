# Sistema de Controle de Estoque

Aplicação desktop desenvolvida em **C# (.NET 6 – Windows Forms)** para gerenciamento de estoque, permitindo o cadastro de produtos, categorias, unidades de medida, fornecedores, funcionários e o registro de movimentações de entrada (compras) e saída (vendas).

## Funcionalidades

- Cadastro de categorias de produtos
- Cadastro de unidades de medida
- Cadastro de produtos (com estoque mínimo e observações)
- Cadastro de fornecedores
- Cadastro de funcionários
- Cadastro de usuários (login/senha)
- Registro de entradas de estoque (compras)
- Registro de saídas de estoque (vendas)
- Atualização automática da tabela de estoque
- Tela principal com menu para navegação entre os módulos

## Tecnologias Utilizadas

- C#
- .NET 6 (Windows Forms)
- MySQL
- Biblioteca `MySql.Data`
- Visual Studio 2022 (ou superior)

## Estrutura do Projeto

- `controleEstoque/` – código-fonte principal da aplicação
  - `entity/` – classes de entidade (Produto, Categoria, Fornecedor, etc.)
  - Formulários de cadastro e movimentação (Windows Forms)
- Script do banco de dados: `bdSistemaEstoque.txt` (schema `sistemaestoque`)

## Banco de Dados

O banco de dados utilizado é o **MySQL**.

As principais tabelas são:

- `categoria`
- `unidademedida`
- `produto`
- `estoque`
- `fornecedor`
- `funcionario`
- `movimenta_estoque_compra`
- `movimenta_estoque_venda`
- `usuario`

Também são utilizados **triggers** para:

- Criar registro inicial em `estoque` ao cadastrar um produto;
- Atualizar a data de movimentação sempre que a quantidade em estoque for alterada.

### Importando o banco de dados

1. Crie um banco de dados no MySQL chamado `sistemaestoque` (se ainda não existir).
2. Abra o script `bdSistemaEstoque.txt` em um cliente MySQL (MySQL Workbench, DBeaver, etc.).
3. Execute o script para criar as tabelas e triggers.

## Configuração da Conexão com o Banco

A string de conexão é configurada na classe `Conexao` (pasta `entity`):

```csharp
server = "localhost";
database = "sistemaestoque";
uid = "root";
password = "SUA_SENHA_AQUI";
```

> **Importante:** altere o usuário (`uid`) e a senha (`password`) conforme a configuração do seu MySQL.

## Como Executar o Projeto

1. Certifique-se de ter instalado:
   - [.NET 6 SDK](https://dotnet.microsoft.com/)
   - MySQL Server e um cliente para execução do script SQL
   - Visual Studio 2022 (ou equivalente) com suporte a .NET Desktop Development

2. Clone este repositório:

```bash
git clone https://github.com/SEU_USUARIO/sistemaestoque.git
```

3. Importe o banco de dados executando o script `bdSistemaEstoque.txt`.

4. Abra o arquivo `controleEstoque.sln` no Visual Studio.

5. Configure o projeto `controleEstoque` como projeto de inicialização (Startup Project).

6. Ajuste, se necessário, a string de conexão na classe `Conexao`.

7. Execute o projeto (F5).

## Melhorias Futuras

- Relatórios gerenciais (PDF/Excel)
- Controle de permissões por tipo de usuário
- Tela de alerta para produtos abaixo do estoque mínimo
- Migração para aplicação web (ASP.NET Core) ou API + frontend
