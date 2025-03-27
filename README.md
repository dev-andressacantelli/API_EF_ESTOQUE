Olá, este projeto é de minha autoria, portanto solicito respeito pelo meu trabalho e que não o plagie,
mas fique a vontade para clona-lo para avaliação ou estudos.    

O objetivo desta API é gerenciar um estoque de produtos do tipo 'vestuário', 
sendo assim, criei um CRUD utilizando .net 8, Entity Framework (code-first) e Bogus Fake Data.       

Para que o projeto funcione em sua máquina, siga os passos a seguir:    
1 - Verifique a string de conexão do banco de dados em appsettings(raiz), altere para sua conexão de banco.  
2 - Certifique-se de que não há uma tabela nomeada 'Produtos' em sua instância de banco de dados.  
3 - Clone o projeto em sua máquina local.  
4 - Ao abrir o projeto no visual studio, DELETE a pasta 'Migrations' do projeto.  
5 - Vá até ferramentas > gerenciamento de pacotes nuget > package manager console.  
6 - Com o terminal aberto, digite o comando 'Add-migration INIT'.  
7 - Após rodar esse comando, note que aparecerá uma pasta chamada 'Migrations' abaixo da pasta 'Controllers' com algumas classes embutidas.
Essas classes são responsáveis por criar o script de banco de dados 'por baixo dos panos' através do EF, contendo os atributos da classe 'Produtos'.
Nesta etapa ainda não temos a tabela criada em banco, para que isso aconteça siga o próximo passo.  
8 - Volte ao terminal e digite o comando 'Update-database', e de acordo com a connectionStrings setada,
a tabela deverá aparecer na sua instância de banco de dados.  
9 - Com o Microsoft SQL Server Management Studio (ou sua IDE de preferência) aberto,
clique em atualizar base de dados, procure por 'Tabelas', e note que a tabela 'Produtos' aparecerá.    
10 - Com as conexões feitas, agora você já pode testar os endpoints via swagger.  

Para popular a tabela com dados prontos, execute o endpoint '/api/Produto/AddFakeData',
este método irá popular a tabela com 5 objetos à cada execução.  
Com a base populada, você poderá manipular os dados já insridos.   

Explicação sobre a organização do projeto:  
Esta API foi feita em padrão de arquitetura DDD baseado em minhas experiências profissionais, sendo assim, existem outras possibilidades de executar este padrão.     
- Camada API - Responsável pela inicialização principal do projeto, contendo todas as controllers, appsettings, program, dependencias, context e repositorios.  
As controllers determinam os verbos.  
O appsetthings contém as configurações de banco.  
As dependências contém as injeções de dependências.  
O context contém as configurações para a migrations.  
Repositories contém as funções de ações do banco de dados.    
- Camada Application - Responsável pela regra de negócio, ou seja, todas as validações de dados são verificadas aqui, podendo seguir ou não para as próximas camadas.    
- Camada Domain - Responsável pelas entidades principais do projeto, assim como as interfaces, a configuração da lib Bogus (responsável pela inserção de dados em massa) e o tratamento de resultados.    

Explicação do fluxo:  
Swagger > Controller > Dispatcher > Domain > Repositories > Dispatcher > Controller > Swagger.  

Obrigada pela visita!  
