
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
    percen decimal (5,2) not null,
    codCond int,
    codForma Int,
    foreign key (codForma) references FormaPag (idForma),
    foreign key(codCond) references CondPag (idCond),
    primary key (codCond, nParc)
);


create table Cargos (
    idCargo int auto_increment primary key,
    cargo varchar(30) not null,
    externo varchar(1) not null,
    datCad datetime,
    datAlt datetime,
    idUser int
);
drop table Clientes;
drop table funcionarios;
drop table fornecedores;

create table Clientes (
    idCliente int auto_increment primary key,
    nome varchar (50) not null,
    cpfCnpj  varchar (18) not null,
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
	fk_condPag int not null,
    foreign key (fk_condPag) references Condpag (idCond),
    foreign key (fk_cidade) references Cidades (idCidade)
);

create table Fornecedores (
    idForn int auto_increment primary key,
    nome varchar (50) not null,
    cpfCnpj  varchar (18) not null,
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
	fk_condPag int not null,
    foreign key (fk_condPag) references Condpag (idCond),
    foreign key (fk_cidade) references Cidades(idCidade)
);


create table Funcionarios (
    idFunc int auto_increment primary key,
    nome varchar (50) not null,
    cpfCnpj  varchar (18) not null,
    rg varchar (12),
    cnh varchar (11),
    dataCnh datetime,
    categoriaCnh varchar (5),
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
    dataAd datetime not null, 
    dataDemiss datetime,
    salario double not null,
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
    fk_uMedida varchar (6),
    foreign key (fk_uMedida) references Medidas (uMedida)
);

create table Medidas (
	uMedida varchar(6) primary key,
    descricao varchar(50) not null,
    ativo varchar (1) not null,
	datAlt datetime,
    idUser int
);

create table Servicos (
    idServ int auto_increment primary key,
    serv varchar (100) not null,
    valor float,
    datCad datetime,
    datAlt datetime,
    idUser int not null
);

INSERT INTO Medidas (uMedida, descricao, ativo, datAlt, idUser)
VALUES
('AMPOLA', 'AMPOLA', 'N', NOW(), 0),
('BALDE', 'BALDE', 'N', NOW(), 0),
('BANDEJ', 'BANDEJA', 'N', NOW(), 0),
('BARRA', 'BARRA', 'N', NOW(), 0),
('BISNAG', 'BISNAGA', 'N', NOW(), 0),
('BLOCO', 'BLOCO', 'N', NOW(), 0),
('BOBINA', 'BOBINA', 'N', NOW(), 0),
('BOMB', 'BOMBONA', 'N', NOW(), 0),
('CAPS', 'CAPSULA', 'N', NOW(), 0),
('CART', 'CARTELA', 'N', NOW(), 0),
('CENTO', 'CENTO', 'N', NOW(), 0),
('CJ', 'CONJUNTO', 'N', NOW(), 0),
('CM', 'CENTIMETRO', 'N', NOW(), 0),
('CM2', 'CENTIMETRO QUADRADO', 'N', NOW(), 0),
('CX', 'CAIXA', 'N', NOW(), 0),
('CX2', 'CAIXA COM 2 UNIDADES', 'N', NOW(), 0),
('CX3', 'CAIXA COM 3 UNIDADES', 'N', NOW(), 0),
('CX5', 'CAIXA COM 5 UNIDADES', 'N', NOW(), 0),
('CX10', 'CAIXA COM 10 UNIDADES', 'N', NOW(), 0),
('CX15', 'CAIXA COM 15 UNIDADES', 'N', NOW(), 0),
('CX20', 'CAIXA COM 20 UNIDADES', 'N', NOW(), 0),
('CX25', 'CAIXA COM 25 UNIDADES', 'N', NOW(), 0),
('CX50', 'CAIXA COM 50 UNIDADES', 'N', NOW(), 0),
('CX100', 'CAIXA COM 100 UNIDADES', 'N', NOW(), 0),
('DISP', 'DISPLAY', 'N', NOW(), 0),
('DUZIA', 'DUZIA', 'N', NOW(), 0),
('EMBAL', 'EMBALAGEM', 'N', NOW(), 0),
('FARDO', 'FARDO', 'N', NOW(), 0),
('FOLHA', 'FOLHA', 'N', NOW(), 0),
('FRASCO', 'FRASCO', 'N', NOW(), 0),
('GALAO', 'GALÃO', 'N', NOW(), 0),
('GF', 'GARRAFA', 'N', NOW(), 0),
('GRAMAS', 'GRAMAS', 'N', NOW(), 0),
('JOGO', 'JOGO', 'N', NOW(), 0),
('KG', 'QUILOGRAMA', 'N', NOW(), 0),
('KIT', 'KIT', 'N', NOW(), 0),
('LATA', 'LATA', 'N', NOW(), 0),
('LITRO', 'LITRO', 'N', NOW(), 0),
('M', 'METRO', 'N', NOW(), 0),
('M2', 'METRO QUADRADO', 'N', NOW(), 0),
('M3', 'METRO CÚBICO', 'N', NOW(), 0),
('MILHEI', 'MILHEIRO', 'N', NOW(), 0),
('ML', 'MILILITRO', 'N', NOW(), 0),
('MWH', 'MEGAWATT HORA', 'N', NOW(), 0),
('PACOTE', 'PACOTE', 'N', NOW(), 0),
('PALETE', 'PALETE', 'N', NOW(), 0),
('PARES', 'PARES', 'N', NOW(), 0),
('PC', 'PEÇA', 'N', NOW(), 0),
('POTE', 'POTE', 'N', NOW(), 0),
('K', 'QUILATE', 'N', NOW(), 0),
('RESMA', 'RESMA', 'N', NOW(), 0),
('ROLO', 'ROLO', 'N', NOW(), 0),
('SACO', 'SACO', 'N', NOW(), 0),
('SACOLA', 'SACOLA', 'N', NOW(), 0),
('TAMBOR', 'TAMBOR', 'N', NOW(), 0),
('TANQUE', 'TANQUE', 'N', NOW(), 0),
('TON', 'TONELADA', 'N', NOW(), 0),
('TUBO', 'TUBO', 'N', NOW(), 0),
('UNID', 'UNIDADE', 'N', NOW(), 0),
('VASIL', 'VASILHAME', 'N', NOW(), 0),
('VIDRO', 'VIDRO', 'N', NOW(), 0);

create table NotaEntrada (
nNota int not null,
serieNota varchar(20) not null,
modeloNota Varchar (02) not null,
cod_Emit int not null,
dtEmissao datetime not null,
dtChegada datetime not null,
vItensBruto float not null,
vDescItens float not null,
vFrete float not null,
vSeguro float not null,
vOutros float not null,
vTotalNota float not null,
datCad datetime,
datAlt datetime,
idUser int not null,
foreign key (cod_Emit) References Fornecedores (idForn),
primary key(nNota, serieNota, modeloNota, cod_Emit)
);

create table ItensNotaEntrada (
nNota int not null,
serieNota varchar (20) not null,
modeloNota varchar (2) not null,
cod_Emit int not null,
cod_produto int not null,
precoUnit  float not null,
descUnit float not null,
descPercent float not null,
qtd int not null,
totalProd float not null,
foreign key (nNota, serieNota, modeloNota, cod_Emit) references NotaEntrada (nNota, serieNota, modeloNota, cod_Emit),
foreign key (cod_produto) references produtos (idProduto),
primary key (nNota, serieNota, modeloNota, cod_Emit, cod_produto)
);
