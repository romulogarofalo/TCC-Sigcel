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
(10,4000,28,7,true),
(11,900,18,5,true),
(12,1500,20,6,true),
(13,2000,30,1,false),
(14,500,16,4,false),
(15,900,18,5,true),
(16,1000,20,5,true),
(17,4000,51,6,true),
(18,1000,42,7,false),
(19,5000,45,7,true),
(20,5500,61,7,true),
(21,8000,45,5,true),
(22,2000,42,5,false),
(23,2000,77,2,true),
(24,2800,43,8,true),
(25,8000,52,8,false),
(26,550,17,4,false),
(27,2000,55,5,true),
(28,2100,53,5,false),
(29,1500,56,5,false),
(30,650,21,5,true),
(31,1000,59,7,true),
(32,2500,60,1,true),
(33,7000,25,7,false),
(34,2000,57,5,true),
(35,1000,61,7,false),
(36,800,24,5,true),
(37,650,17,4,true),
(38,800,25,4,false),
(39,3000,87,5,false),
(40,6000,58,7,true),
(41,1500,25,5,true),
(42,1500,30,4,true),
(43,1500,35,4,true),
(44,1500,35,4,false),
(45,1500,35,4,false);


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
('627.365.530-80','Robson','robson@email.com','Santos','Gonzaga','Rua Tolentino Filgueiras',30,'ap 2','(13)998456321',null,null,md5('senha123'),1),
('093.253.821-56','Bob','bob@hotmail.com','Santos','Embaré','Rua Aleatoria',250,'ap 20','(13)998454511',null,null,md5('senha123'),2),
('100.770.903-06','Astolfo','astolfinho@uol.com','Santos','Ponta da praia','Rua do Astolfo',3000,'ap 30','(13)159357456',null,null,md5('senha123'),3),
('453.338.648-29','Facebokison','face@bokison.com','Santos','Pompeia','Rua do Facebook',3064,null,'(76)789589663',null,null,md5('senha123'),4),
('307.436.926-40','Andre', 'andre.13@hotmail.com','Santos','sabuo','Rua Sebastião',301,null,'(11)997505652', null, null,md5(null) ,5),
('837.543.006-44','Jorge', 'jorge.lucas@hotmail.com','Santos','Gonzaga','Rua Jose de Abreu',2004,null,'(11)97881447','2016-08-02','2016-08-09',md5(null),7),
('449.340.555-41','Arthur', 'arthur.silva@hotmail.com','Santos','Pompeia','Rua Chrocrane',658,null, '(11)97556932', '2016-08-06', '2016-08-15',md5(null), 7),
('061.361.565-47','Raphael', 'raphael.rodrigues@hotmail.com','Santos','Embaré','Rua São Jogão',853,'ap 25', '(11)997415263', null, null,md5(null), 6),
('140.799.431-05','Rodrigo', 'rodrigo.silva@hotmail.com','Santos','Gonzaga','Rua Gonzaguinha',657,'ap 544','(11)997562378', null, null, md5(null), 6),
('574.805.424-88','Jose', 'jose.roberto@hotmail.com','Santos','Embaré','Rua Biquinha',879,null, '(11)997695847', null, null, md5(null), 5),
('546.711.515-45','Matheus', 'matheus.silva@hotmail.com','Santos','Pompeia','Rua da Amargura',63,'ap 99', '(11)997745263', null, null, md5(null), 5),
('773.191.182-97','123', '123','Santos','Gonzaga','Rua da Amargura',63,null,'(11)997745263', null, null, md5('123'), 1);
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

insert into pesquisa
values
(1,'Pesquisa Segurança', 'Embaré', '2016-09-12',true),
(2,'Pesquisa Saneamento', 'Gonzaga', '2016-09-11',true),
(3,'Pesquisa Segurança 2', 'Embaré', '2016-09-22',true),
(4,'Pesquisa Saneamento 2', 'Gonzaga', '2016-09-28',true),
(5,'Pesquisa Saneamento 3', 'Gonzaga', '2016-09-30',false);


insert into pergunta 
values
(1,'Qual a Sua opinião sobre a Segurança?',1),
(2,'Acha que um Vereador delegado faria melhorar a segurança?',1),
(3,'O que você acha do saneamento no bairro?',2),
(4,'Qual a Sua opinião sobre a Segurança?',3),
(5,'Acha que um Vereador delegado faria melhorar a segurança?',3),
(6,'O que você acha do saneamento no bairro?',4),
(7,'O que você acha do saneamento no bairro?',5);

insert into alternativa
value 
(1,'Boa',1,1),
(2,'Regular',1,1),
(3,'Ruim',1,1),
(4,'Sim',2,1),
(5,'Não',2,1),
(6,'Boa',3,2),
(7,'Regular',3,2),
(8,'Ruim',3,2),
(9,'Boa',4,3),
(10,'Regular',4,3),
(11,'Ruim',4,3),
(12,'Sim',5,3),
(13,'Não',5,3),
(14,'Boa',6,4),
(15,'Regular',6,4),
(16,'Ruim',6,4),
(17,'Boa',7,5),
(18,'Regular',7,5),
(19,'Ruim',7,5);




insert into resposta
value
(1,1,1,3),
(2,1,1,2),
(3,1,1,1),
(4,1,1,2),
(5,1,1,3),
(1,1,2,4),
(2,1,2,5),
(3,1,2,5),
(4,1,2,4),
(5,1,2,4),
(6,2,3,6),
(7,2,3,6),
(8,2,3,6),
(9,2,3,6),
(10,2,3,7),
(11,2,3,7),
(12,2,3,7),
(13,2,3,6),
(14,2,3,6),
(15,2,3,8),
(16,3,4,9),
(16,3,5,13),
(17,3,4,9),
(17,3,5,13),
(18,3,4,9),
(18,3,5,13),
(19,3,4,10),
(19,3,5,12),
(20,3,4,11),
(20,3,5,12),
(21,4,6,14),
(22,4,6,14),
(23,4,6,14),
(24,4,6,14),
(25,4,6,14),
(26,4,6,14),
(27,4,6,14),
(28,4,6,15),
(29,4,6,15),
(30,4,6,14),
(31,4,6,16),
(32,4,6,15),
(33,5,7,17),
(34,5,7,17),
(35,5,7,17),
(36,5,7,17),
(37,5,7,18),
(38,5,7,18),
(39,5,7,18),
(40,5,7,18),
(41,5,7,18),
(42,5,7,18),
(43,5,7,19),
(44,5,7,19),
(45,5,7,19);

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
('140.799.431-05',4),
('140.799.431-05',5);
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
('2016-05-22', '15:00','14:30','Passeata Gonzaga','Santos','Gonzaga','Av. Ana Costa',45 , true, true, 1,null),
('2016-06-15', '18:00','20:00','Reunião Partido','Santos','Embaré','Rua dos Prazeres',69 , false, false, 3,'reuniao inicial todos devem ir'),
('2016-07-11', '13:00','15:30','Comício', 'Santos','Aquele lá','Av. Conselheiro Nébias',23 , false, true, 2,null),
('2016-06-23', '16:00','17:30', 'Visita ao Senhor João','Santos','Gonzaga','Av. Ana Costa',55 , false, false, 4,null);

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

-- select * from material_compromisso;

-- select cd_material from material_compromisso where cd_material = 5;

-- delete from material where cd_material = 5;insert into resposta value (1,1,1,3), (2,1,1,2), (3,1,1,1), (4,1,1,2), (5,1,1,3), (1,1,2,4), (2,1,2,5), (3,1,2,5), (4,1,2,4), (5,1,2,4), (6,2,3,6), (7,2,3,6), (8,2,3,6), (9,2,3,6), (10,2,3,7), (11,2,3,7), (12,2,3,7), (13,2,3,6), (14,2,3,6), (15,2,3,8), (16,3,4,9), (16,3,5,13), (17,3,4,9), (17,3,5,13), (18,3,4,9), (18,3,5,13), (19,3,4,10), (19,3,5,12), (20,3,4,11), (20,3,5,12), (21,4,6,14), (22,4,6,14), (23,4,6,14), (24,4,6,14), (25,4,6,14), (26,4,6,14), (27,4,6,14), (28,4,6,15), (29,4,6,15), (30,4,6,14), (31,4,6,16), (32,4,6,15), (33,5,7,17), (34,5,7,17), (35,5,7,17), (36,5,7,17), (37,5,7,18), (38,5,7,18), (39,5,7,18), (40,5,7,18), (41,5,7,18), (42,5,7,18), (43,5,7,19), (44,5,7,19), (45,5,7,19)


/*delete from material_compromisso where dt_compromisso = '2016-05-22' and hr_compromisso = '15:00';

delete from compromisso where dt_compromisso = '2016-05-22' and hr_compromisso = '15:00';

select * from compromisso;*/
