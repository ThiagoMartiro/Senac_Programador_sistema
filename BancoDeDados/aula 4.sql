CREATE TABLE IF NOT EXISTS editora (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    documento VARCHAR (30) UNIQUE NOT NULL
);
select distinct
lower(editora)
from
livrod;

insert into editora (nome,documento)
values
('intrínseca', '23456789000112'),
('abril', '34567890000123'),
('globo', '45678901000134'),
('panini', '56789012000145'),
('rocco ltda.', '67890123000156'),
('darkside', '78901234000167'),
('marvel', '89012345000178'),
('harpercollins', '11234568000101'),
('companhia das letras', '12234569000112'),
('senac', '14234571000134'),
('biblioteca azul', '15234572000145');