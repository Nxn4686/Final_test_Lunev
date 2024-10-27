CREATE DATABASE human_friends;

USE human_friends;

CREATE TABLE Animals (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(100),
    Type VARCHAR(50),
    BirthDate DATE
);

CREATE TABLE Commands (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    AnimalId INT,
    Command VARCHAR(100),
    FOREIGN KEY (AnimalId) REFERENCES Animals(Id)
);
