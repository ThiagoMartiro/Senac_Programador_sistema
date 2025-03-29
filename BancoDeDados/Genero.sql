CREATE TABLE IF NOT EXISTS genero(
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL
);
select distinct
lower(genero)
from
livrod;

insert into genero (nome)
values
('tecnologia'),
('documentário cinematográfico'),
('terror'),
('drama'),
('entrevista'),
('aventura'),
('fantasia'),
('ação'),
('ficção científica'),
('romance distópico');