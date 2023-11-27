CREATE TABLE Licitacao
(
    Id int IDENTITY(1,1) NOT NULL,
    Numero varchar(255) NOT NULL,
    Descrição varchar(255) NOT NULL,
    DataAbertura datetime NOT NULL,
    Status varchar(255) NOT NULL
);
