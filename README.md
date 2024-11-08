Projeto Sinistro

Visão Geral do Projeto

Sinistro Odonto é uma plataforma odontológica inovadora que utiliza tecnologias de Inteligência Artificial (IA) e Machine Learning (ML) para diagnosticar sintomas bucais. O objetivo do sistema é permitir que os usuários enviem imagens de sua cavidade bucal e informações sobre sintomas, para que o sistema, por meio de análise inteligente, forneça diagnósticos preditivos e sugestões de cuidados preventivos, com base em uma vasta base de dados odontológicos.

A plataforma visa não só a melhoria do diagnóstico clínico, mas também a prevenção de problemas odontológicos, ao sugerir medidas preventivas e a possibilidade de indicação de profissionais odontológicos qualificados. A integração com APIs externas de IA permite um diagnóstico preciso e baseado em aprendizado de máquina, para garantir a confiabilidade e eficácia das recomendações fornecidas.

Funcionalidades Principais

- Upload de Imagens: O sistema permite que os usuários façam upload de imagens relacionadas aos sintomas bucais.
- Análise de Sintomas: A plataforma processa as imagens utilizando IA para realizar o reconhecimento de sintomas e condições bucais.
- Diagnóstico Preditivo: Com base nas imagens e informações fornecidas, o sistema gera um diagnóstico preditivo, informando a doença potencial e sua gravidade.
- Recomendações Preventivas: O sistema sugere medidas preventivas para evitar agravamento dos sintomas e indica profissionais odontológicos recomendados.
- Integração com APIs Externas: O sistema se integra com APIs de IA e outros serviços odontológicos para validação de sintomas e diagnósticos.

Tecnologias Utilizadas

- C# (.NET Core) para a construção da aplicação backend.
- ASP.NET MVC para renderização de Views e comunicação com o backend.
- Machine Learning (ML) para análise e diagnóstico preditivo (via APIs externas de IA).
- Entity Framework para acesso a banco de dados.
- Bootstrap para design responsivo e fácil usabilidade nas Views.
- Docker (opcional, para uso de containers e facilitar a configuração do ambiente de desenvolvimento).

Instruções de Instalação e Configuração

Pré-Requisitos

Antes de iniciar a instalação, verifique se você possui os seguintes softwares instalados:

- .NET Core SDK (versão 6.0 ou superior) – Para rodar a aplicação localmente. Você pode baixar aqui.
- SQL Server ou SQLite para o banco de dados (caso use banco local).
- Visual Studio (ou outro IDE) com suporte a C# e ASP.NET Core (opcional, mas recomendado).
- Docker (opcional, para facilitar o processo de desenvolvimento e implantação).

Passos para Instalação

1. Clone o Repositório:
   git clone https://github.com/JMafuso/sinistro-odonto.git
   cd sinistro-odonto

2. Restaure as Dependências:

   Execute o comando abaixo para restaurar todas as dependências do projeto:

   dotnet restore

3. Configuração do Banco de Dados:

   Se você estiver utilizando o SQL Server ou SQLite, configure a string de conexão no arquivo appsettings.json:

   "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=SinistroOdontoDb;Trusted_Connection=True;"
   }

   Ou, se estiver utilizando o SQLite, a configuração será algo como:

   "ConnectionStrings": {
       "DefaultConnection": "Data Source=sinistro_odonto.db;"
   }

4. Executar as Migrações (Se necessário):

   Se o banco de dados ainda não estiver configurado, você pode executar as migrações para criar o banco de dados e as tabelas necessárias. Execute:

   dotnet ef database update

5. Configuração de API de IA (Opcional):

   Se o sistema utilizar uma API de IA externa para análise de imagens e diagnóstico, você precisará configurar a chave da API e o endpoint da IA. Isso pode ser feito no arquivo appsettings.json:

   "IAService": {
       "ApiKey": "sua-chave-da-api-aqui",
       "Endpoint": "https://api.ia.exemplo.com/diagnostico"
   }

6. Executar a Aplicação:

   Depois de configurado, você pode executar o projeto com o seguinte comando:

   dotnet run

   A aplicação será executada no http://localhost:5000 por padrão. Você pode abrir o navegador e testar a plataforma localmente.

Estrutura de Pastas

A estrutura de diretórios do projeto segue a arquitetura Clean Architecture para garantir uma organização clara e modularização do código:

SinistroOdontoApp/
|-- Controllers/               # Controladores para as Views
|-- Domain/                    # Entidades e lógica de negócio
|-- Application/               # Serviços e casos de uso
|-- Infrastructure/            # Acesso a dados e integração com APIs externas
|-- Views/                     # Views (interface com o usuário)
|-- wwwroot/                   # Arquivos estáticos
|-- Tests/                     # Testes unitários e de integração
|-- Startup.cs / Program.cs    # Configurações de inicialização

Executando Testes

Para rodar os testes automatizados, você pode executar os testes com o comando:

dotnet test

Os testes estão organizados nas pastas de DomainTests, ApplicationTests e InfrastructureTests.

Contribuições

Se você deseja contribuir com o desenvolvimento deste projeto, siga as instruções abaixo:

1. Faça um fork deste repositório.
2. Crie uma branch para sua feature (git checkout -b minha-feature).
3. Faça suas alterações e comite-as (git commit -am 'Adicionando nova funcionalidade').
4. Envie sua branch para o repositório remoto (git push origin minha-feature).
5. Abra um Pull Request para revisão.

Licença

Este projeto está sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.

Sinistro Odonto - Seu diagnóstico inteligente e prevenção odontológica de forma simples e eficaz.
