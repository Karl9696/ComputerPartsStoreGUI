ALTER USER 'root'@'localhost' IDENTIFIED BY 'mike';
CREATE DATABASE IF NOT EXISTS demodb;
GRANT ALL PRIVILEGES ON demodb.* TO 'root'@'localhost';
FLUSH PRIVILEGES;
