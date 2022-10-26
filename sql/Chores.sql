-- Active: 1666715462927@@SG-fossil-throne-24-6835-mysql-master.servers.mongodirector.com@3306@FossilThrone

CREATE TABLE
    IF NOT EXISTS chores (
        id int NOT NULL AUTO_INCREMENT PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name VARCHAR(255) NOT NULL,
        DONE bool NOT NULL,
        AMOUNT int NOT NULL CHECK (amount > 0),
        TYPE ENUM NOT NULL,
    )