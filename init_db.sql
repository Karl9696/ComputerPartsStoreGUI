ALTER USER 'root'@'localhost' IDENTIFIED BY 'mike';
CREATE DATABASE IF NOT EXISTS computerparts_db;
GRANT ALL PRIVILEGES ON computerparts_db.* TO 'root'@'localhost';
FLUSH PRIVILEGES;
