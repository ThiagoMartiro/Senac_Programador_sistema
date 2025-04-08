CREATE TABLE PRODUTO (
    id INT AUTO_INCREMENT PRIMARY KEY, -- ID único para cada eletrônico
    nome VARCHAR(100) NOT NULL,        -- Nome do eletrônico
    categoria VARCHAR(50) NOT NULL,    -- Categoria, como "TV", "Laptop", etc.
    preco DECIMAL(10,2) NOT NULL,      -- Preço com 2 casas decimais
    estoque INT NOT NULL,              -- Quantidade em estoque
    fornecedor_id INT NOT NULL         -- ID do fornecedor relacionado
);

insert into PRODUTO (nome,categoria,preco,estoque,fornecedor_id)
values
('Celular X','Eletronicos',2500.00,30,1),
('Notebook Y','Eletronicos',4800.00,15,2),
('Mesa de Madeira','Moveis',750.00,10,3),
('Cadeira Z','Moveis',300.00,25,3),
('Tv 50','Eletronicos',3500.00,8,1);
