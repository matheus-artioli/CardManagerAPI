-----

# API de Gerenciamento de Cartão de Crédito

### Visão Geral do Projeto

Este projeto é uma API RESTful desenvolvida em Java com o framework Spring Boot. O objetivo é simular as principais operações de um sistema de gerenciamento de cartão de crédito, utilizando um back-end robusto e funcional. O sistema permite o cadastro de clientes, a criação de cartões, o processamento de transações e a consulta de histórico, ideal para demonstrar minhas habilidades em desenvolvimento de sistemas para o setor financeiro.

### Tecnologias Utilizadas

  * **Java 17+**
  * **Spring Boot**
  * **PostgreSQL** (para o banco de dados)
  * **Maven** (para gerenciamento de dependências)
  * **Docker** (opcional, para rodar o banco de dados)

### Funcionalidades Implementadas

  * **Cadastro de Clientes:** `POST /clientes`
      * Cria um novo cliente no sistema.
  * **Criação de Cartões:** `POST /cartoes`
      * Emite um novo cartão de crédito para um cliente existente, com um limite inicial.
  * **Processamento de Compras:** `POST /transacoes`
      * Processa uma nova compra, verificando o limite do cartão antes de aprovar ou negar a transação.
  * **Consulta de Dados:** `GET /clientes/{id}` e `GET /cartoes/{id}`
      * Permite a consulta de dados de clientes e detalhes dos cartões.
  * **Consulta de Histórico:** `GET /cartoes/{id}/transacoes`
      * Retorna o histórico de todas as transações de um cartão específico.

### Como Executar o Projeto

1.  **Clone o Repositório:**
    ```bash
    git clone https://github.com/matheus-artioli/CardManagerAPI.git
    ```
2.  **Configurar o Banco de Dados:**
      * Instale e configure o **PostgreSQL** localmente.
      * Você também pode usar o Docker com o seguinte comando:
        ```bash
        docker run --name pg-api -e POSTGRES_USER=user -e POSTGRES_PASSWORD=password -e POSTGRES_DB=creditcard_db -p 5432:5432 -d postgres
        ```
3.  **Configurar a Aplicação:**
      * Abra o arquivo `src/main/resources/application.properties`.
      * Ajuste as configurações do banco de dados (URL, usuário, senha) para corresponderem às suas.
4.  **Executar a Aplicação:**
      * Navegue até o diretório raiz do projeto no terminal.
      * Execute o comando do Maven para iniciar a aplicação:
    <!-- end list -->
    ```bash
    mvn spring-boot:run
    ```
      * A API estará rodando em `http://localhost:8080`.

### Autor

  * **Matheus Souza Artioli Antonio**
      * [**LinkedIn:**](https://www.linkedin.com/in/matheusartioli/)
      * [**GitHub:**](https://github.com/matheus-artioli)
![Fluxograma](https://i.imgur.com/ad8ii7A.jpeg)
