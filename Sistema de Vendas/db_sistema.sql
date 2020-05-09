'produto', 'CREATE TABLE `produto` (\n  `id` int NOT NULL AUTO_INCREMENT,\n  `descricao` varchar(50) DEFAULT NULL,\n  `valor` double NOT NULL,\n  `id_categoria` int NOT NULL,\n  PRIMARY KEY (`id`)\n) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci'

'categoria', 'CREATE TABLE `categoria` (\n  `id` int NOT NULL AUTO_INCREMENT,\n  `descricao` varchar(50) DEFAULT NULL,\n  PRIMARY KEY (`id`)\n) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci'

insert into categoria (descricao) values ('jogo de quarto');
insert into categoria (descricao) values ('jogo de cozinha');
insert into categoria (descricao) values ('jogo de sala');

insert into produto (descricao, valor, id_categoria) values ('Cama de Solteiro', 120, 1);
insert into produto (descricao, valor, id_categoria) values ('Cozinha bartira', 520, 2);
insert into produto (descricao, valor, id_categoria) values ('Sofa 3 lugares', 120, 3);
insert into produto (descricao, valor, id_categoria) values ('Cama de casal', 120, 1);