CREATE TABLE IF NOT EXISTS autor(
id INT primary key not null,
nome varchar (100),
documento varchar (11) UNIQUE
);

select distinct
lower(autor)
from
livrod;

insert into autor (nome, documento)
values
('rafael sousa', '12345678901'),
('mark manson', '23456789012'),
('monteiro lobatto', '34567890123'),
('kanye west', '45678901234'),
('larissa matos', '56789012345'),
('marildo', '67890123456'),
('daniela machado', '78901234567'),
('j. k. rowling', '89012345678'),
('richard russell riordan jr.', '90123456789'),
('tony stark', '01234567890'),
('felipe oliveira', '11234567890'),
('thm', '12234567890'),
('j.r.r. tolkien', '13234567890'),
('george orwell', '14234567890'),
('guilherme diniz', '15234567890'),
('andré luiz', '16234567890'),
('ray bradbury', '17234567890');