create database sigcel;
use sigcel; 
 -- drop schema `sigcel`;


create table Escolaridade
(
cd_escolaridade int not null,
nm_escolaridade varchar(40) not null,

constraint pk_Escolaridade primary key (cd_escolaridade)
);

create table funcao
(
cd_funcao int not null,
nm_funcao varchar (40) not null,

constraint pk_funcao primary key (cd_funcao)
);
-- permição -- modulo
create table modulo
(
cd_modulo int not null,
nm_modulo varchar (100),
nm_componente varchar (100),

constraint pk_modulo primary key (cd_modulo)
);

create table permicao
(
cd_funcao int not null,
cd_modulo int not null,

constraint pk_permicao primary key (cd_funcao,cd_modulo),
constraint fk_permicao_modulo foreign key (cd_modulo) references modulo (cd_modulo),
constraint fk_permicao_funcao foreign key (cd_funcao) references funcao (cd_funcao)
);



create table funcionario 
(
cd_cpf_funcionario varchar(14) not null,
nm_funcionario varchar(45) not null,
nm_email_funcionario varchar(99) not null,
nm_cidade_funcionario varchar(50) not null,-- colocar cidade 
nm_bairro_funcionario varchar(50) not null,-- bairro
nm_rua_funcionairo varchar(50) not null,-- rua
nm_numero_funcionario varchar(10) not null,-- numero 
nm_complemento_funcionario varchar(10) null,-- complemento
nm_celular_funcionario varchar(14) not null,
dt_contratacao date null,
dt_fim_contratacao date null,
cd_senha_funcionario varchar(64) null,
cd_funcao int not null,

constraint pk_funcionario primary key (cd_cpf_funcionario),
constraint fk_funcionario_funcao foreign key (cd_funcao) references funcao (cd_funcao)
);


create table presenca
(
dt_presenca date not null ,
cd_cpf_funcionario varchar(14) not null,
ic_presenca bool not null,

constraint pk_presenca primary key (dt_presenca,cd_cpf_funcionario),
constraint fk_presenca_funcao foreign key (cd_cpf_funcionario) references funcionario (cd_cpf_funcionario)
);

create table pesquisa
(
cd_pesquisa int not null,
nm_pesquisa varchar (45) not null,
nm_bairro varchar(45) not null,
dt_pesquisa date null,

constraint pk_pesquisa primary key (cd_pesquisa)
);

create table funcionario_pesquisa
(
cd_cpf_funcionario varchar(14) not null,
cd_pesquisa int not null,
constraint pk_funcionario_pesquisa primary key (cd_cpf_funcionario, cd_pesquisa),
constraint fk_funcionario_pesquisa_funcionario foreign key (cd_cpf_funcionario) references funcionario (cd_cpf_funcionario),
constraint fk_funcionario_pesquisa_pesquisa foreign key (cd_pesquisa) references pesquisa (cd_pesquisa)
);


create table pergunta 
(
cd_pergunta int not null,
nm_pergunta varchar(100) not null,
cd_pesquisa int not null,

constraint pk_pergunta primary key (cd_pergunta,cd_pesquisa),
constraint fk_pergunta_pesquisa	foreign key (cd_pesquisa) references pesquisa (cd_pesquisa)
);


create table participante
(
cd_participante int auto_increment,
qt_salario int not null,
qt_idade int not null,
cd_escolaridade int not null,
ic_sexo_masculino bool null,

constraint pk_participante primary key (cd_participante),
constraint fk_participante_escolaridade foreign key (cd_escolaridade) references escolaridade (cd_escolaridade)
);

create table alternativa
(
cd_alternativa int not null,
nm_alternativa varchar(90),
cd_pergunta int not null,

constraint pk_alternativa primary key (cd_alternativa),
constraint fk_alternativa_pergunta foreign key (cd_pergunta) references pergunta (cd_pergunta)
);

create table resposta
(
cd_participante int not null,
cd_pesquisa int not null,
cd_pergunta int not null,
cd_alternativa int not null,


constraint pk_resposta primary key (cd_participante,cd_pergunta,cd_pesquisa),
constraint fk_resposta_participante foreign key (cd_participante) references participante (cd_participante),
constraint fk_resposta_pergunta foreign key (cd_pergunta,cd_pesquisa) references pergunta (cd_pergunta,cd_pesquisa)
);

-- primeira parte pronta 
-- insersao de dados


-- segunda parte 

create table tipo_compromisso
(
cd_tipo_compromisso int not null,
nm_tipo_compromisso varchar(45) not null,
constraint pk_tipo_compromisso primary key(cd_tipo_compromisso)
);

create table material
(
cd_material int not null,
nm_material varchar(45) not null,
qt_atual long not null,
constraint pk_material primary key(cd_material)
);

create table compromisso
(
dt_compromisso date not null,
hr_compromisso time not null,
nm_compromisso varchar(55) not null,
nm_cidade_compromisso varchar (33) not null,
nm_bairro_compromisso varchar (20) not null,
nm_rua_funcionario varchar (33) not null,
nm_numero_compromisso varchar (10) not null,
ic_chama_funcionario bool,
ic_chama_militancia bool,
cd_tipo_compromisso int not null,
constraint pk_compromisso primary key(dt_compromisso, hr_compromisso),
constraint fk_compromisso_tipo_compromisso foreign key (cd_tipo_compromisso) references tipo_compromisso(cd_tipo_compromisso)
);


create table material_compromisso
(
dt_compromisso date not null,
hr_compromisso time not null,
cd_material int not null,
qt_levar int null,
constraint pk_material_compromisso primary key(dt_compromisso, hr_compromisso, cd_material),
constraint fk_material_compromisso_material foreign key (cd_material) references material (cd_material),
constraint fk_material_compromisso_compromisso foreign key (dt_compromisso, hr_compromisso) references compromisso(dt_compromisso, hr_compromisso)
);
