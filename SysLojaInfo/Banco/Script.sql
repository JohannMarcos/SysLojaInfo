
CREATE DATABASE BD_loja;


CREATE USER 'SYSDBAPRO'@'%' IDENTIFIED BY 'masterkey';

GRANT ALL ON *.* TO 'SYSDBAPRO'@'%' WITH GRANT OPTION;


flush privileges;


USE BD_loja;


CREATE TABLE Paises (
  idPais int auto_increment primary key,
  nome varchar(100),
  sigla varchar(3),
  ddi varchar(3),
  datCad datetime,
  datAlt datetime,
  idUser int
);

create table Estados (
    idEstado int auto_increment primary key,
    estado varchar (18) not null,
    uf varchar (2) not null,
    fk_pais int not null, 
    datCad datetime,
    datAlt datetime,
    idUser int,
    foreign key (fk_pais) references Paises (idPais)
);

create table Cidades (
    idCidade int auto_increment primary key,
    cidade varchar (21) not null,
    ddd varchar (3) not null,
    fk_estado int not null,
    datCad datetime,
    datAlt datetime,
    idUser int,
    foreign key (fk_estado) references Estados(idEstado)
);

create table Cargos (
    idCargo int auto_increment primary key,
    cargo varchar(30) not null,
    externo varchar(1) not null,
    datCad datetime,
    datAlt datetime,
    idUser int
);

create table Clientes (
    idCliente int auto_increment primary key,
    nome varchar (50) not null,
    cpfCnpj  varchar (11) not null,
    rg varchar (12),
    logr varchar (140) not null,
    num int not null,
    natPes varchar (10) not null,
    bairro varchar (34) not null,
    limCred decimal (10,2),
    fk_cidade int ,
    telRes varchar (14),
    telCel varchar (14),
    email varchar (255),
    datCad datetime,
    datAlt datetime,
    idUser int not null,
    foreign key (fk_cidade) references Cidades (idCidade)
);

create table Fornecedores (
    idForn int auto_increment primary key,
    nome varchar (50) not null,
    cpfCnpj  varchar (11) not null,
    rg varchar (12),
    logr varchar (140) not null,
    num int not null,
    natPes varchar (10) not null,
    bairro varchar (34) not null,
    fk_cidade int,
    telRes varchar (14),
    telCel varchar (14),
    email varchar (255),
    datCad datetime,
    datAlt datetime,
    idUser int,
    foreign key (fk_cidade) references Cidades(idCidade)
);

create table Funcionarios (
    idFunc int auto_increment primary key,
    nome varchar (50) not null,
    cpfCnpj  varchar (11) not null,
    rg varchar (12),
    cnh varchar (11),
    logr varchar (140) not null,
    num int not null,
    natPes varchar (10) not null,
    bairro varchar (34) not null,
    fk_cargos int,
    fk_cidade int,
    telRes varchar (14),
    telCel varchar (14),
    email varchar (255),
    datCad datetime,
    datAlt datetime,
    idUser int,
	foreign key (fk_cargos) references Cargos (idCargo),
    foreign key (fk_cidade) references Cidades(idCidade)
);

create table Produtos (
    idProduto int auto_increment primary key,
    prod varchar (35) not null,
    custo float,
    custoMedio float,
    precoVenda float,
    estoque int,
    datCad datetime,
    datAlt datetime,
    idUser int not null,
    fk_uMedida varchar (6) not null
);

create table Medidas (
	uMedida varchar(6) primary key,
    descricao varchar(50) not null,
    ativo varchar (1) not null
);

create table Servicos (
    idServ int auto_increment primary key,
    serv varchar (100) not null,
    valor float,
    datCad datetime,
    datAlt datetime,
    idUser int not null
);

create table FormaPag (
    idForma int auto_increment primary key,
    forma varchar (100) not null,
    datCad datetime,
    datAlt datetime,
    idUser int not null
);

create table CondPag (
    idCond int auto_increment primary key,
    condicao varchar (100) not null,
    taxa float,
    multa float,
    desconto float,
    datCad datetime,
    datAlt datetime,
    idUser int not null
);

create table Parcelas (
    nParc int not null,
    dias  int not null,
    percen decimal (3,2) not null,
    cod_Cond int references CondPag (codCond) not null,
    primary key (cod_Cond, nParc)
);

INSERT INTO Medidas (uMedida, descricao, ativo)
VALUES
('AMPOLA', 'AMPOLA', 'N'),
('BALDE', 'BALDE', 'N'),
('BANDEJ', 'BANDEJA', 'N'),
('BARRA', 'BARRA', 'N'),
('BISNAG', 'BISNAGA', 'N'),
('BLOCO', 'BLOCO', 'N'),
('BOBINA', 'BOBINA', 'N'),
('BOMB', 'BOMBONA', 'N'),
('CAPS', 'CAPSULA', 'N'),
('CART', 'CARTELA', 'N'),
('CENTO', 'CENTO', 'N'),
('CJ', 'CONJUNTO', 'N'),
('CM', 'CENTIMETRO', 'N'),
('CM2', 'CENTIMETRO QUADRADO', 'N'),
('CX', 'CAIXA', 'N'),
('CX2', 'CAIXA COM 2 UNIDADES', 'N'),
('CX3', 'CAIXA COM 3 UNIDADES', 'N'),
('CX5', 'CAIXA COM 5 UNIDADES', 'N'),
('CX10', 'CAIXA COM 10 UNIDADES', 'N'),
('CX15', 'CAIXA COM 15 UNIDADES', 'N'),
('CX20', 'CAIXA COM 20 UNIDADES', 'N'),
('CX25', 'CAIXA COM 25 UNIDADES', 'N'),
('CX50', 'CAIXA COM 50 UNIDADES', 'N'),
('CX100', 'CAIXA COM 100 UNIDADES', 'N'),
('DISP', 'DISPLAY', 'N'),
('DUZIA', 'DUZIA', 'N'),
('EMBAL', 'EMBALAGEM', 'N'),
('FARDO', 'FARDO', 'N'),
('FOLHA', 'FOLHA', 'N'),
('FRASCO', 'FRASCO', 'N'),
('GALAO', 'GALÃO', 'N'),
('GF', 'GARRAFA', 'N'),
('GRAMAS', 'GRAMAS', 'N'),
('JOGO', 'JOGO', 'N'),
('KG', 'QUILOGRAMA', 'N'),
('KIT', 'KIT', 'N'),
('LATA', 'LATA', 'N'),
('LITRO', 'LITRO', 'N'),
('M', 'METRO', 'N'),
('M2', 'METRO QUADRADO', 'N'),
('M3', 'METRO CÚBICO', 'N'),
('MILHEI', 'MILHEIRO', 'N'),
('ML', 'MILILITRO', 'N'),
('MWH', 'MEGAWATT HORA', 'N'),
('PACOTE', 'PACOTE', 'N'),
('PALETE', 'PALETE', 'N'),
('PARES', 'PARES', 'N'),
('PC', 'PEÇA', 'N'),
('POTE', 'POTE', 'N'),
('K', 'QUILATE', 'N'),
('RESMA', 'RESMA', 'N'),
('ROLO', 'ROLO', 'N'),
('SACO', 'SACO', 'N'),
('SACOLA', 'SACOLA', 'N'),
('TAMBOR', 'TAMBOR', 'N'),
('TANQUE', 'TANQUE', 'N'),
('TON', 'TONELADA', 'N'),
('TUBO', 'TUBO', 'N'),
('UNID', 'UNIDADE', 'N'),
('VASIL', 'VASILHAME', 'N'),
('VIDRO', 'VIDRO', 'N');




select * from cargos


