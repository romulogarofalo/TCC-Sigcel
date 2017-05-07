-- Faltando: presensa, pergunta, alternativa, resposta

-- select * from escolaridade;

insert into escolaridade
values
(1,'Não sabe ler nem escrever'),
(2,'Ensino fundamental incompleto'),
(3,'Ensino fundamental completo'),
(4,'Ensino médio incompleto'),
(5,'Ensino médio completo'),
(6,'Ensino superior incompleto'),
(7,'Ensino superior completo'),
(8,'Pós-graduação');

insert into participante
values
(1,3500,30,6,true),
(2,2000,22,5,false),
(3,1000,20,5,null),
(4,2500,22,7,true),
(5,3000,20,6,false),
(6,800,18,6,true),
(7,1000,25,5,true),
(8,3500,32,6,false),
(9,4000,30,6,false),
(10,4000,28,7,true);
-- fazer ate 40 participantes


insert into funcao
values
(1,'Coordenador geral'),
(2,'Coordenador de pesquisa'),
(3,'Coordenador de mobilização'),
(4,'Coordenador de compromisso'),
(5,'Panfleteiro'),
(6,'Motorista de carro de som'),
(7,'Pesquisador');

insert into funcionario
values
('627.365.530-80','robson','robson@email.com','santos','gonzaga','Rua Tolentino Filgueiras','n°30','ap 2','(13)998456321',null,null,md5('senha123'),1),
('093.253.821-56','bob','bob@hotmail.com','santos','embare','rua aleatoria','nº250','ap 20','(13)998454511',null,null,md5('senha123'),2),
('100.770.903-06','astolfo','astolfinho@uol.com','santos','ponta da praia','rua do astolfo','nº3000','ap 30','(13)159357456',null,null,md5('senha123'),3),
('453.338.648-29','facebokison','face@bokison.com','santos','pompeia','rua do facebook','nº3064',null,'(76)789589663',null,null,md5('senha123'),4),
('307.436.926-40', 'Andre', 'andre.13@hotmail.com','santos','sabuo','rua sebastiao','nº301',null,'(11)997505652', null, null,md5(null) ,5),
('837.543.006-44', 'Jorge', 'jorge.lucas@hotmail.com','santos','gonzaga','rua jose de abreu','nº2004',null,'(11)97881447','2016-08-02','2016-08-09',md5(null),7),
('449.340.555-41', 'Arthur', 'arthur.silva@hotmail.com','santos','pompeia','rua chrocrane','nº658',null, '(11)97556932', '2016-08-06', '2016-08-15',md5(null), 7),
('061.361.565-47', 'Raphael', 'raphael.rodrigues@hotmail.com','santos','embare','rua sao jogao','nº853','ap 25', '(11)997415263', null, null,md5(null), 6),
('140.799.431-05', 'Rodrigo', 'rodrigo.silva@hotmail.com','santos','gonzaga','rua gonzaguinha','nº657','ap 544','(11)997562378', null, null, md5(null), 6),
('574.805.424-88','Jose', 'jose.roberto@hotmail.com','santos','embare','rua biquinha','nº879',null, '(11)997695847', null, null, md5(null), 5),
('546.711.515-45', 'matheus', 'matheus.silva@hotmail.com','santos','pompeia','rua da amargura','nº63','ap 99', '(11)997745263', null, null, md5(null), 5),
('773.191.182-97', '123', '123','santos','gonzaga','rua da amargura','nº63',null,'(11)997745263', null, null, md5('123'), 1);
-- select u.cd_cpf_funcionario as 'CPF', u.nm_funcionario as 'Funcionario',u.nm_email_funcionario as 'Email', u.nm_cidade_funcionario as 'Cidade', u.nm_bairro_funcionario as 'Bairro', u.nm_rua_funcionairo as 'Rua', u.nm_numero_funcionario as 'Numero', u.nm_complemento_funcionario as 'Complemento',u.nm_celular_funcionario as 'Celular',dt_contratacao as 'Data Contratação', dt_fim_contratacao as 'Data Fim Contratação', c.nm_funcao as 'Função' from funcionario u inner join funcao c on u.cd_funcao = c.cd_funcao;
-- update funcionario set nm_funcionario = 'robson', nm_email_funcionario = 'robson@hotmail.com', nm_cidade_funcionario = 'santos', nm_bairro_funcionario = 'macuco', nm_rua_funcionairo = 'rua da paz', nm_numero_funcionario = 'n° 157', nm_complemento_funcionario = 'ap 123', nm_celular_funcionario = '(15)123123123', dt_contratacao = null, dt_fim_contratacao = null,cd_funcao = 7 where cd_cpf_funcionario = '627.365.530-80';
-- select * from funcionario where cd_cpf_funcionario = '627.365.530-80';
insert into modulo
values
(1, 'cadastro de tipo usuario', 'btnCadTipoUsuario'),
(2, 'cadastro de usuario', 'btnCadUsuario'),
(3, 'permissoes de acesso', 'btnConfiguracao');

insert into permicao
values
(1,1),
(1,2),
(1,3),
(2,1),
(2,2),
(3,2);

insert into Pesquisa
values
(1,'Pesquisa segurança', 'Embare', '2016-09-12'),
(2,'Pesquisa Saneamento', 'Gonzaga', '2016-09-11'),
(3,'Pesquisa segunrança 2', 'Embare', '2016-09-22'),
(4,'Pesquisa Saneamento 2', 'Gonzaga', '2016-09-28');

insert into pergunta 
values
(1,'Qual a Sua opinião sobre a Segurança',1),
(2,'Acha que um Vereador delegado faria melhorar a segurança ?',1),
(3,'O que você acha do saneamento no bairro',2),
(4,'Qual a Sua opinião sobre a Segurança',3),
(5,'Acha que um Vereador delegado faria melhorar a segurança ?',3),
(6,'O que você acha do saneamento no bairro',4);

insert into alternativa
value 
(1,'boa',1),
(2,'regular',1),
(3,'ruim',1),
(4,'sim',2),
(5,'nao',2),
(6,'boa',3),
(7,'regular',3),
(8,'ruim',3),
(9,'boa',4),
(10,'regular',4),
(11,'ruim',4),
(12,'sim',5),
(13,'nao',5),
(14,'boa',6),
(15,'regular',6),
(16,'ruim',6);

insert into resposta
value
(1,1,1,3),
(1,1,2,4),
(2,1,1,5),
(2,1,2,2),
(3,1,1,1),
(3,1,2,5),
(4,1,1,2),
(4,1,2,4),
(5,1,1,3),
(5,1,2,4);
-- colocar ate 10 sobre a primeira pesquisa



insert into funcionario_pesquisa
values
('837.543.006-44',1),
('449.340.555-41',1),
('449.340.555-41',2),
('449.340.555-41',3),
('449.340.555-41',4),
('140.799.431-05',2),
('140.799.431-05',1),
('140.799.431-05',3),
('140.799.431-05',4);

-- segunda parte 

insert into tipo_compromisso
values
(1, 'Passeata'),
(2, 'Comício'),
(3, 'Reunião'),
(4, 'Visita');

insert into material
values
(1, 'Panfleto', 1000000),
(2, 'Adesivos(Internos)', 5890),
(3, 'Adesivos(Externos)', 10),
(4, 'Bandeiras', 800);

insert into compromisso
values
('2016-05-22', '15:00', 'Passeata Gonzaga','Santos','Gonzaga','Av. Ana Costa','45', true, true, 1),
('2016-06-15', '18:00', 'Reunião Partido','Santos','Embaré','Rua dos Prazeres','69', false, false, 3),
('2016-07-11', '13:00', 'Comício', 'Santos','Aquele lá','Av. Conselheiro Nebias','23', false, true, 2),
('2016-06-23', '16:00', 'Visita ao Senhor João','Santos','Gonzaga','Av. Ana Costa','55', false, false, 4);

insert into material_compromisso
values
('2016-05-22', '15:00',1,5000),
('2016-05-22', '15:00',2,300),
('2016-07-11', '13:00',1,10000),
('2016-07-11', '13:00',2,400),
('2016-07-11', '13:00',3,5),
('2016-07-11', '13:00',4,200);

-- select max(cd_material) + 1 from material;

-- select nm_material, qt_atual from material where cd_material = 1;

-- select cd_material as 'Código', nm_material as 'Nome', qt_atual as 'Quantidade Atual' from material where nm_material like '%pa%';  

-- update material set nm_material = 'papelao', qt_atual = 800 where cd_material = 4;

-- select * from material;

-- select cd_material from material_compromisso where cd_material = 5;

-- delete from material where cd_material = 5;