CREATE DATABASE IF NOT EXISTS insurance_policy;

CREATE USER IF NOT EXISTS 'app_user'@'localhost'
IDENTIFIED BY 'orchidflower';

GRANT SELECT, INSERT, UPDATE, DELETE
ON insurance_policy.*
TO 'app_user'@'localhost';

FLUSH PRIVILEGES;