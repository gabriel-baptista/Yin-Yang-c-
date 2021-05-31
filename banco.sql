create database projetoDB;
use projetoDB;

create table usuarios(
usuario_id int not null auto_increment primary key,
nome_usuario varchar(100) not null,
login_usuario varchar(100) not null,
senha_usuario varchar(100) not null,
nivel_acesso varchar(20) not null
);

create table cliente(
cliente_id int not null auto_increment,
user_cliente varchar(100) not null,
senha_cliente varchar(100) not null,
nivel_acesso varchar(10) not null,
nome_cliente varchar(100) not null,
cpf_cliente double not null,
idade_cliente double not null,
peso_cliente double not null,
peso_atual double not null,
massa_magra double not null,
massa_gorda double not null,
sexo_cliente varchar (10),
primary key (cliente_id)
);

create table desjejum(
desjejum_id int primary key not null auto_increment,
opcao1 varchar(1000),
opcao2 varchar(1000),
opcao3 varchar(1000),
id_cliente int not null,
constraint fk_idcliente foreign key(id_cliente) references cliente(cliente_id)
ON DELETE CASCADE ON UPDATE CASCADE
-- constraint id_cliente foreign key(id_cliente) references cliente(cliente_id)
);

create table almoco(
almoco_id int primary key not null auto_increment,
opcao1 varchar(1000),
opcao2 varchar(1000),
opcao3 varchar(1000),
id_cliente int not null,
constraint fk_idclientealmoco foreign key(id_cliente) references cliente(cliente_id)
ON DELETE CASCADE ON UPDATE CASCADE
);

create table lancheTarde(
lancheTarde_id int primary key not null auto_increment,
opcao1 varchar(1000),
opcao2 varchar(1000),
opcao3 varchar(1000),
id_cliente int not null,
constraint fk_idclienteLT foreign key(id_cliente) references cliente(cliente_id)
ON DELETE CASCADE ON UPDATE CASCADE
);

create table jantar(
jantar_id int primary key not null auto_increment,
opcao1 varchar(1000),
opcao2 varchar(1000),
opcao3 varchar(1000),
id_cliente int not null,
constraint fk_idclientejantar foreign key(id_cliente) references cliente(cliente_id)
ON DELETE CASCADE ON UPDATE CASCADE
);

create table ceia(
ceia_id int primary key not null auto_increment,
opcao1 varchar(1000),
opcao2 varchar(1000),
opcao3 varchar(1000),
id_cliente int not null,
constraint fk_idclienteceia foreign key(id_cliente) references cliente(cliente_id)
ON DELETE CASCADE ON UPDATE CASCADE
);

create table consulta(
agenda_id int not null auto_increment,
agenda_idpaciente int not null,
agenda_paciente varchar(200),
agenda_data date,
agenda_hora time,
primary key(agenda_id),
CONSTRAINT agenda_agenda_idpaciente_fkey FOREIGN KEY (agenda_idpaciente) REFERENCES cliente(cliente_id)
ON UPDATE NO ACTION ON DELETE NO ACTION
);

insert into usuarios (usuario_id, nome_usuario, login_usuario, senha_usuario, nivel_acesso) value ("1", "master", "master", "master", "nutricionista");
select * from usuarios;

-- drop database projetoDB;
/*
insert into usuarios (usuario_id, nome_usuario, login_usuario, senha_usuario, nivel_acesso) value ("2", "Joao Pedro", "joao", "teste", "nutricionista");
INSERT INTO cliente(user_cliente, senha_cliente, nivel_acesso, nome_cliente, cpf_cliente, idade_cliente , peso_cliente, peso_atual, massa_magra, massa_gorda, sexo_cliente) VALUES("rodrigo","teste", "cliente", "Rodrigo Augusto", "12345678910", "18", "60", "60", "55", "5", "Masculino");
INSERT INTO cliente(user_cliente, senha_cliente, nivel_acesso, nome_cliente, cpf_cliente, idade_cliente , peso_cliente, peso_atual, massa_magra, massa_gorda, sexo_cliente) VALUES("jao", "teste", "cliente", "João Pedro", "2843464486", "18", "70", "70", "60", "10", "Masculino");
INSERT INTO cliente(user_cliente, senha_cliente, nivel_acesso, nome_cliente, cpf_cliente, idade_cliente , peso_cliente, peso_atual, massa_magra, massa_gorda, sexo_cliente) VALUES("mari", "teste", "cliente", "Mariane", "4838468", "19", "55", "55", "48", "7", "Feminino");
INSERT INTO cliente(user_cliente, senha_cliente, nivel_acesso, nome_cliente, cpf_cliente, idade_cliente , peso_cliente, peso_atual, massa_magra, massa_gorda, sexo_cliente) VALUES("sa", "teste", "cliente", "Sabrina", "76468468", "20", "55", "55", "49", "6", "Feminino");
INSERT INTO cliente(user_cliente, senha_cliente, nivel_acesso, nome_cliente, cpf_cliente, idade_cliente , peso_cliente, peso_atual, massa_magra, massa_gorda, sexo_cliente) VALUES("clara", "teste", "cliente", "Clara", "164867", "18", "48", "48", "45", "3", "Feminino");
INSERT INTO cliente(user_cliente, senha_cliente, nivel_acesso, nome_cliente, cpf_cliente, idade_cliente , peso_cliente, peso_atual, massa_magra, massa_gorda, sexo_cliente) VALUES("lucas", "teste", "cliente", "Lucas", "164384", "18", "80", "80", "70", "5", "Masculino");
INSERT INTO cliente(user_cliente, senha_cliente, nivel_acesso, nome_cliente, cpf_cliente, idade_cliente , peso_cliente, peso_atual, massa_magra, massa_gorda, sexo_cliente) VALUES("gabs", "teste", "cliente", "Gabriel", "12235134", "20", "80", "80", "70", "10", "Masculino");
INSERT INTO cliente(user_cliente, senha_cliente, nivel_acesso, nome_cliente, cpf_cliente, idade_cliente , peso_cliente, peso_atual, massa_magra, massa_gorda, sexo_cliente) VALUES("gabi", "teste", "cliente", "Gabriela", "15643381", "20", "50", "50", "45", "5", "Feminino");
INSERT INTO cliente(user_cliente, senha_cliente, nivel_acesso, nome_cliente, cpf_cliente, idade_cliente , peso_cliente, peso_atual, massa_magra, massa_gorda, sexo_cliente) VALUES("david", "teste", "cliente", "David", "13516438", "20", "70", "70", "55", "15", "Masculino");
select * from cliente;
*/

/*SELECT c.nome_cliente, c.cliente_id, pa.PlanoAlimentar_id, pa.desjejum1, pa.desjejum2, pa.desjejum3, pa.almoco1, pa.almoco2, pa.almoco3, 
pa.lancheTarde1, pa.lancheTarde2, pa.lancheTarde3, pa.jantar1, pa.jantar2, pa.jantar3, pa.ceia1, pa.ceia2, pa.ceia3 FROM cliente AS c INNER JOIN 
PlanoAlimentar AS pa ON pa.desjejum1 = pa.desjejum1 AND pa.desjejum2 = pa.desjejum2 AND pa.desjejum3 = pa.desjejum3 AND pa.almoco1 = pa.almoco1 AND 
pa.almoco2 = pa.almoco2 AND pa.almoco3 = pa.almoco3 AND pa.lancheTarde1 = pa.lancheTarde1 AND pa.lancheTarde2 = pa.lancheTarde2 AND pa.lancheTarde3 = 
pa.lancheTarde3 AND pa.jantar1 = pa.jantar1 AND  pa.jantar2 = pa.jantar2 AND pa.jantar3 = pa.jantar3 AND pa.ceia1 = pa.ceia1 AND pa.ceia2 = pa.ceia2 
AND pa.ceia3 = pa.ceia3 WHERE PlanoAlimentar_id = cliente_id;*/

/*
INSERT INTO desjejum(opcao1, opcao2, opcao3, id_cliente) values ("cafe1", "cafe2", "cafe3", "1");
INSERT INTO almoco(opcao1, opcao2, opcao3, id_cliente) values ("asdadsds", "asdas", "ads", "1");
INSERT INTO lancheTarde(opcao1, opcao2, opcao3, id_cliente) values ("dasa", "lancheTasddaarde2", "asdas", "1");
INSERT INTO jantar(opcao1, opcao2, opcao3, id_cliente) values ("bdgsfa", "dasda", "dasda", "1");
INSERT INTO ceia(opcao1, opcao2, opcao3, id_cliente) values ("asada", "cddasdaeia2", "asdas", "1");

INSERT INTO desjejum(opcao1, opcao2, opcao3, id_cliente) values ("cafe1", "cafe2", "cafe3", "2");
INSERT INTO almoco(opcao1, opcao2, opcao3, id_cliente) values ("asdadsds", "asdas", "ads", "2");
INSERT INTO lancheTarde(opcao1, opcao2, opcao3, id_cliente) values ("dasa", "lancheTasddaarde2", "asdas", "2");
INSERT INTO jantar(opcao1, opcao2, opcao3, id_cliente) values ("bdgsfa", "dasda", "dasda", "2");
INSERT INTO ceia(opcao1, opcao2, opcao3, id_cliente) values ("asada", "cddasdaeia2", "asdas", "2");

SELECT c.cliente_id, c.nome_cliente, de.desjejum_id, de.id_cliente, de.opcao1, de.opcao2, de.opcao3, al.almoco_id, al.id_cliente, al.opcao1, 
al.opcao2, al.opcao3, la.lancheTarde_id, la.id_cliente, la.opcao1, la.opcao2, la.opcao3, ja.jantar_id, ja.id_cliente, ja.opcao1, ja.opcao2, 
ja.opcao3, ce.ceia_id, ce.id_cliente, ce.opcao1, ce.opcao2, ce.opcao3 FROM cliente AS c
INNER JOIN desjejum AS de ON c.cliente_id = de.id_cliente AND de.opcao1 = de.opcao1 AND de.opcao2 = de.opcao2 AND de.opcao3 = de.opcao3
INNER JOIN almoco AS al ON c.cliente_id = al.id_cliente AND al.opcao1 = al.opcao1 AND al.opcao2 = al.opcao2 AND al.opcao3 = al.opcao3
INNER JOIN lancheTarde AS la ON c.cliente_id = la.id_cliente AND la.opcao1 = la.opcao1 AND la.opcao2 = la.opcao2 AND la.opcao3 = la.opcao3
INNER JOIN jantar AS ja ON c.cliente_id = ja.id_cliente AND ja.opcao1 = ja.opcao1 AND ja.opcao2 = ja.opcao2 AND ja.opcao3 = ja.opcao3
INNER JOIN ceia AS ce ON c.cliente_id = ce.id_cliente AND ce.opcao1 = ce.opcao1 AND ce.opcao2 = ce.opcao2 AND ce.opcao3 = ce.opcao3;
*/