<h4>1. Sobre Microserviços, explique qual a função dos seguintes verbos:</h4>
a. HTTP POST
<br>
b. HTTP PUT
<br>
c. HTTP PATCH
<br>
d. HTTP DELETE
<br>
e. HTTP GET

<h4>(Resposta):</h4>
a. HTTP POST: Tipo de requisição utilizada para criar um recurso em uma
determinada API. São chamados de recursos o objeto que está
sendo tratado naquela API.
<br><br>
b. HTTP PUT: Requisição utilizada para atualizar o recurso indicado com
alguma informação.
<br><br>
c. HTTP PATCH: Aplica modificações parciais a um recurso.
<br><br>
d. HTTP DELETE: Requisição para excluir um dado.
<br><br>
e. HTTP GET A requisição é um pedido de dados para a API. A API vai
buscar os dados solicitados em algum banco e, provavelmente,
vai retornar em formato JSON (formato de notação de objeto
JavaScript);
<br><br>

---

<h4>2. Sobre a classe Program.cs do projeto AspNet, explique a função das
seguintes linhas de código:</h4>
a) builder.Services.AddControllers();
<br>
b) builder.Services.AddEndpointsApiExplorer();
<br>
c) builder.Services.AddSwaggerGen();
<br>

<h4>(Resposta)</h4>
a) builder.Services.AddControllers();
<br>
Registra os serviços necessários para trabalhar com controllers em uma API.
<br><br>
b) builder.Services.AddEndpointsApiExplorer();
<br>
Permite descobrir e listar todos os endpoints da API.
<br><br>
c) builder.Services.AddSwaggerGen();
<br>
Habilita a geração da documentação da API usando Swagger.
<br><br>

---

<h4>3. Sobre o DDD, explique o que são:</h4>
a. Domain Models
<br>
b. Domain Services
<br>
c. Repository Contracts
<br>
d. InfraStructure Layer
<br>

<h4>(Resposta):</h4>
a. Domain Models
<br>
São representações das entidades e regras do negócio do sistema. Eles refletem o conhecimento e as práticas do domínio específico e são usados para resolver problemas do mundo real. Exemplos incluem objetos que representam clientes, produtos, ou qualquer outro conceito importante para o domínio.
<br><br>
b. Domain Services
<br>
São serviços que encapsulam lógica de negócio que não pertence a uma única entidade ou valor, mas que é fundamental para o domínio. Eles realizam operações complexas que envolvem múltiplas entidades. Exemplo: um serviço que calcula o preço total de um pedido, considerando diferentes regras de desconto.
<br><br>
c. Repository Contracts (Contratos de Repositório)
<br>
São interfaces ou abstrações que definem como acessar, armazenar ou recuperar objetos de domínio. O repositório abstrai o armazenamento de dados, oferecendo uma interface simples e limpa para o acesso a entidades. Exemplos: ICustomerRepository para buscar clientes em um banco de dados.
<br><br>
d. InfraStructure Layer
<br>
Essa camada é responsável por fornecer a implementação concreta dos contratos definidos na camada de domínio (como o repositório). Ela lida com coisas como persistência de dados, comunicação com serviços externos e outros detalhes técnicos, como bancos de dados ou filas de mensagens.
<br><br>

---

<h4>4. Qual a finalidade da biblioteca FluentValidations? Explique a diferença entre entidade de domínio rico e entidade de domínio anêmico.</h4>
<h4>(Resposta):</h4> FluentValidation é uma biblioteca usada para realizar validações de objetos de forma fluente e legível. Ela permite que você defina regras de validação para suas entidades de forma concisa e com mensagens personalizadas, melhorando a manutenção e a clareza do código. 
<br><br>
Entidade de domínio rica: É uma entidade que contém tanto dados quanto a lógica de negócio. Ela não apenas armazena informações, mas também é responsável por realizar ações que afetam seu próprio estado, mantendo a lógica de domínio encapsulada.
<br><br>
Entidade de domínio anêmica: É uma entidade que apenas contém dados e não tem comportamento ou lógica de domínio significativa. A lógica de negócio é separada e colocada em outro lugar, geralmente em serviços, o que pode resultar em código menos coeso e difícil de manter.
<br><br>

---

<h4>5. Qual o objetivo da abordagem CodeFirst utilizada pelo EntityFramework? Explique como é o seu processo.</h4>
<h4>(Resposta):</h4> O objetivo da abordagem CodeFirst no Entity Framework é criar o banco de dados a partir do código C# (modelos de classes) em vez de partir de um banco de dados existente. Nesse modelo, as classes do domínio são usadas para gerar o esquema do banco de dados.
<br><br>
O processo envolve a definição de classes e suas propriedades (como se fossem tabelas e colunas) e, em seguida, a execução de migrações para criar o banco de dados. As migrações geram os scripts SQL necessários para aplicar as mudanças no banco de dados, garantindo que o banco esteja sempre sincronizado com o código.
<br><br>

---

<h4>6. Sobre a classe DbContext, explique a função dos métodos OnConfiguring() e OnModelCreating().</h4>
<h4>(Resposta):</h4> - OnConfiguring(): Esse método é responsável por configurar o contexto do banco de dados, como a string de conexão e outras opções relacionadas à comunicação com o banco de dados. Ele é chamado automaticamente pelo Entity Framework quando a aplicação é iniciada.
<br><br> 
- OnModelCreating(): Esse método é usado para configurar o modelo de dados, ou seja, ele é responsável por mapear as entidades para o banco de dados, definir restrições e relacionamentos, como chave primária, índices e relações entre tabelas.
<br><br>

---

<h4>7. Explique a função dos seguintes comandos utilizados pelo EntityFramework Migrations:</h4>
a. Add-Migration
<br>
b. Update-Database
<br>
c. Script-Migration
<br>
d. Bundle-Migration
<br>
e. Remove-Migration

<h4>(Resposta):</h4> a. Add-Migration: Cria uma nova migração com base nas alterações feitas nas classes de modelo. Ele gera um arquivo que descreve as alterações que precisam ser aplicadas no banco de dados.
<br><br>
b. Update-Database: Aplica as migrações pendentes no banco de dados, atualizando-o para o estado mais recente do modelo de dados.
<br><br>
c. Script-Migration: Gera um script SQL que contém as instruções necessárias para aplicar uma migração específica no banco de dados, sem precisar executar a migração diretamente.
<br><br>
d. Bundle-Migration: Esse comando é usado para combinar várias migrações em um único arquivo de migração. Ele é útil quando se quer agrupar várias mudanças para aplicar de uma vez.
<br><br>
e. Remove-Migration: Remove a migração mais recente que ainda não foi aplicada no banco de dados, revertendo a criação do arquivo de migração gerado anteriormente.
<br><br>

---

<h4>8. Que é FluentApi? Explique o uso nas bibliotecas FluentValidations e no mapeamento objeto relacional realizado pela interface IEntityTypeConfiguration do EntityFramework.
</h4> <h4>(Resposta):</h4>
FluentApi é um estilo de programação baseado em chamadas de método encadeadas que proporciona uma maneira mais fluente de configurar comportamentos. Ele permite que as regras de configuração ou validação sejam expressas de forma concisa e legível.
<br><br>
- FluentValidations: Usa a Fluent API para criar validações de forma fluente e expressiva, permitindo configurar regras de validação para diferentes propriedades de um objeto de forma fácil e legível.
<br><br>
- IEntityTypeConfiguration no EntityFramework: A Fluent API também é usada no mapeamento objeto-relacional (ORM) para configurar como as classes de modelo se relacionam com as tabelas do banco de dados. A interface `IEntityTypeConfiguration<T>` permite definir configurações como mapeamento de chaves primárias, relacionamentos entre entidades e restrições em propriedades, utilizando uma abordagem fluente para tornar o código mais organizado.
<br><br>

---

<h4>9. Sobre o TDD, explique a função dos testes unitários e dos testes de integração.</h4>
<h4>(Resposta):</h4> 
- Testes unitários: São usados para testar unidades específicas do código de forma isolada, como métodos ou funções. O objetivo é garantir que cada componente do sistema funcione de maneira independente. Testes unitários são rápidos e focados em verificar se a lógica interna de cada parte do código está correta. 
<br><br>
- Testes de integração: Verificam a interação entre diferentes partes do sistema, como banco de dados, APIs externas ou serviços. O objetivo é garantir que os componentes funcionem corretamente quando combinados e que a integração entre os sistemas seja bem-sucedida. Testes de integração são mais lentos, pois envolvem mais recursos, como conexões com o banco de dados ou serviços externos.
<br><br>

---

<h4>10. Explique os 5 princípios do SOLID (SRP, OCP, LSP, ISP e DIP)</h4>
<h4>(Resposta):</h4> - SRP (Single Responsibility Principle): Um princípio que afirma que uma classe deve ter apenas uma razão para mudar, ou seja, deve ter apenas uma responsabilidade. Isso melhora a coesão e facilita a manutenção do código.
<br><br>
- OCP (Open/Closed Principle): As classes devem ser abertas para extensão, mas fechadas para modificação. Ou seja, você deve ser capaz de adicionar funcionalidades a uma classe sem modificar seu código original.
<br><br>
- LSP (Liskov Substitution Principle): Objetos de uma classe derivada devem ser substituíveis por objetos da classe base sem afetar o funcionamento do sistema. Isso garante que a herança seja usada corretamente.
<br><br> - ISP (Interface Segregation Principle): Uma classe não deve ser forçada a implementar interfaces que ela não usa. O objetivo é evitar interfaces grandes e complexas, preferindo várias interfaces menores e específicas.
<br><br> - DIP (Dependency Inversion Principle): As dependências devem ser invertidas, ou seja, as classes de alto nível não devem depender de classes de baixo nível. Ambas devem depender de abstrações (interfaces ou classes abstratas). Além disso, as abstrações não devem depender de detalhes; os detalhes devem depender das abstrações. Isso facilita a extensibilidade e o desacoplamento do sistema.
