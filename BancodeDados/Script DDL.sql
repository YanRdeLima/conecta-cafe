create database ConectaCafe;
go

use ConectaCafe;
go

create table Categoria 
(
	id		int	not null identity,
	Nome	varchar(30) not null,
	constraint PK_Categoria primary key (Id)
);

create table Produto
(
	id		int	not null identity,
	Nome	varchar(60) not null,
	Descrição varchar(200),
	Preco	decimal(8,2) not null,
	Foto	varchar(200)
	CategoriaId int not null,
	constraint PK_Produto primary key (Id)
	constraint FK_Produto_Categoria
			   foreign key(CategoriaId) references Categoria(Id)
);

create table Avaliacao
(
	id		int	not null identity,
	Pessoa	varchar(60) not null,
	Título  varchar(100) not null,
	Texto   varchar(700) not null,
	Nota    decimal(1,0),
	DataAvaliacao date,
	constraint PK_Avaliacao primary key (Id)
);

create table Blog
(
	id		int	not null identity,
	Título  varchar(100) not null,
	Texto   varchar(700) not null,
	Foto	varchar(200),
	DataBlog datetime,
	constraint PK_Blog primary key (Id)
);

create table Tag
(
	id		int	not null identity,
	Nome	varchar(30) not null,
	constraint PK_Tag primary key (Id)
);

create table BlogTag
(
	BlogId	int not null,
	TagId	int not null,
	constraint PK_BlogTag primary key (BlogId, tagId),
	constraint FK_BlogTag_Blog
			   foreign key(BlogId) references Blog(Id),
	constraint FK_BlogTag_Tag
			   foreign key(TagId) references Tag(Id),

);

create table Configuracao
(
	id		 int	not null identity,
	Horario  varchar(300),
	Telefone varchar(20),
	constraint PK_Configuracao primary key (Id)
);

