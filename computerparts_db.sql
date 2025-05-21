CREATE DATABASE  IF NOT EXISTS `computerparts_db` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `computerparts_db`;
-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: localhost    Database: computerparts_db
-- ------------------------------------------------------
-- Server version	8.0.42

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Temporary view structure for view `customer_information`
--

DROP TABLE IF EXISTS `customer_information`;
/*!50001 DROP VIEW IF EXISTS `customer_information`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `customer_information` AS SELECT 
 1 AS `customer_id`,
 1 AS `first_name`,
 1 AS `last_name`,
 1 AS `email`,
 1 AS `phone`,
 1 AS `address`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `customer_orders`
--

DROP TABLE IF EXISTS `customer_orders`;
/*!50001 DROP VIEW IF EXISTS `customer_orders`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `customer_orders` AS SELECT 
 1 AS `customer_id`,
 1 AS `first_name`,
 1 AS `last_name`,
 1 AS `order_id`,
 1 AS `order_date`,
 1 AS `product_name`,
 1 AS `total_amount`,
 1 AS `status`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `customer_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `phone` varchar(15) DEFAULT NULL,
  `address` text,
  PRIMARY KEY (`customer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (1,'Jollibee','Smith','johnsmith21@gmail.com','09171432765','456 New Street, NY'),(2,'Jane','Smith','jane.smith@gmail.com','09181234567','4567 Elm St, Manila, Philippines'),(3,'Alice','Johnson','alice.johnson@gmail.com','09191234567','7890 Oak St, Makati, Philippines'),(4,'Bob','Brown','bob.brown@gmail.com','09201234567','1357 Pine St, Cebu City, Philippines'),(5,'Charlie','Davis','charlie.davis@gmail.com','09211234567','2468 Maple St, Davao City, Philippines'),(6,'David','Miller','david.miller@gmail.com','09221234567','3690 Birch St, Baguio City, Philippines'),(7,'Eve','Wilson','eve.wilson@gmail.com','09231234567','4821 Cedar St, Taguig, Philippines'),(8,'Frank','Taylor','frank.taylor@gmail.com','09241234567','5790 Pine St, Quezon City, Philippines'),(9,'Grace','Martinez','grace.martinez@gmail.com','09251234567','6823 Oak St, Cebu City, Philippines'),(10,'Hannah','Garcia','hannah.garcia@gmail.com','09261234567','7945 Birch St, Manila, Philippines');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventory`
--

DROP TABLE IF EXISTS `inventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inventory` (
  `inventory_id` int NOT NULL AUTO_INCREMENT,
  `product_id` int DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  PRIMARY KEY (`inventory_id`),
  KEY `product_id` (`product_id`),
  CONSTRAINT `inventory_ibfk_1` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory`
--

LOCK TABLES `inventory` WRITE;
/*!40000 ALTER TABLE `inventory` DISABLE KEYS */;
INSERT INTO `inventory` VALUES (1,1,30),(2,2,20),(3,3,50),(4,4,15),(5,5,25),(6,6,40),(7,7,100),(8,8,50),(9,9,30),(10,10,20);
/*!40000 ALTER TABLE `inventory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_items`
--

DROP TABLE IF EXISTS `order_items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order_items` (
  `order_item_id` int NOT NULL AUTO_INCREMENT,
  `order_id` int DEFAULT NULL,
  `product_id` int DEFAULT NULL,
  `quantity` int NOT NULL,
  `price` decimal(10,2) NOT NULL,
  PRIMARY KEY (`order_item_id`),
  KEY `order_id` (`order_id`),
  KEY `product_id` (`product_id`),
  CONSTRAINT `order_items_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `order_items_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_items`
--

LOCK TABLES `order_items` WRITE;
/*!40000 ALTER TABLE `order_items` DISABLE KEYS */;
INSERT INTO `order_items` VALUES (1,1,1,1,499.99),(2,1,2,1,799.99),(3,2,3,2,79.99),(4,3,6,1,35.99),(5,4,5,1,99.99),(6,5,7,2,149.99),(7,6,4,1,129.99),(8,7,8,1,149.99),(9,8,9,1,349.99),(10,9,10,1,299.99),(11,11,1,2,1658.86),(12,12,4,1,129.99),(13,13,59,1,342.14),(14,14,4,1,129.99),(15,15,1,2,1040.00),(16,16,1,2,989.98),(17,16,1,1,494.99),(18,17,2,2,1599.98),(19,18,1,1,508.24),(20,19,2,1,799.99),(21,20,1,1,508.24);
/*!40000 ALTER TABLE `order_items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `order_id` int NOT NULL AUTO_INCREMENT,
  `customer_id` int DEFAULT NULL,
  `order_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `total_amount` decimal(10,2) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`order_id`),
  KEY `customer_id` (`customer_id`),
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,1,'2025-02-07 12:17:16',799.99,'Shipped'),(2,2,'2025-02-07 12:17:16',229.99,'Processing'),(3,3,'2025-02-07 12:17:16',149.99,'Shipped'),(4,4,'2025-02-07 12:17:16',499.99,'Delivered'),(5,5,'2025-02-07 12:17:16',189.99,'Processing'),(6,6,'2025-02-07 12:17:16',799.99,'Shipped'),(7,7,'2025-02-07 12:17:16',99.99,'Processing'),(8,8,'2025-02-07 12:17:16',349.99,'Shipped'),(9,9,'2025-02-07 12:17:16',399.99,'Delivered'),(10,10,'2025-02-07 12:17:16',299.99,'Processing'),(11,1,'2025-02-21 12:51:28',1658.86,'Pending'),(12,2,'2025-02-21 12:54:45',129.99,'Pending'),(13,10,'2025-02-21 13:08:46',342.14,'Pending'),(14,9,'2025-02-21 13:14:38',129.99,'Pending'),(15,7,'2025-02-21 13:27:32',1040.00,'Pending'),(16,10,'2025-02-28 12:04:06',1484.97,'Pending'),(17,1,'2025-02-28 12:24:58',1599.98,'Pending'),(18,1,'2025-05-21 09:39:10',508.24,'Pending'),(19,8,'2025-05-21 09:45:39',799.99,'Pending'),(20,1,'2025-05-21 09:53:10',508.24,'Pending');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product_categories`
--

DROP TABLE IF EXISTS `product_categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product_categories` (
  `category_id` int NOT NULL AUTO_INCREMENT,
  `category_name` varchar(100) NOT NULL,
  `description` text,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_categories`
--

LOCK TABLES `product_categories` WRITE;
/*!40000 ALTER TABLE `product_categories` DISABLE KEYS */;
INSERT INTO `product_categories` VALUES (1,'Processors','High-performance computing units for modern systems.'),(2,'Graphics Cards','Essential components for rendering high-quality graphics and gaming.'),(3,'Memory','RAM for improved system performance and multitasking.'),(4,'Power Supply Units','Reliable power supplies for gaming PCs and workstations.'),(5,'Motherboards','Essential component for building PCs with cutting-edge technology.'),(6,'Cooling Systems','Cooling solutions to keep systems running efficiently.'),(7,'Peripherals','Gaming and productivity accessories like mice and keyboards.'),(8,'Storage','High-speed and reliable storage solutions for all systems.'),(9,'Networking','Routers, switches, and network accessories.'),(10,'Audio','High-quality audio systems for gaming and professional use.');
/*!40000 ALTER TABLE `product_categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `product_prices`
--

DROP TABLE IF EXISTS `product_prices`;
/*!50001 DROP VIEW IF EXISTS `product_prices`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `product_prices` AS SELECT 
 1 AS `product_id`,
 1 AS `product_name`,
 1 AS `price`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `product_id` int NOT NULL AUTO_INCREMENT,
  `product_name` varchar(100) NOT NULL,
  `category_id` int DEFAULT NULL,
  `price` decimal(10,2) NOT NULL,
  `stock_quantity` int NOT NULL,
  `supplier_id` int DEFAULT NULL,
  `description` text,
  `is_active` tinyint(1) DEFAULT '1',
  `original_price` decimal(10,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`product_id`),
  KEY `category_id` (`category_id`),
  KEY `supplier_id` (`supplier_id`),
  CONSTRAINT `products_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `product_categories` (`category_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `products_ibfk_2` FOREIGN KEY (`supplier_id`) REFERENCES `suppliers` (`supplier_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=84 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'Intel Core i9 Processor',1,508.24,7,1,'High-performance processor for gaming and multitasking.',1,0.00),(2,'NVIDIA GeForce RTX 3080',2,799.99,13,2,'Graphics card for 4K gaming and AI acceleration.',1,0.00),(3,'Corsair Vengeance 16GB RAM',3,79.99,36,3,'High-performance memory for gaming PCs.',1,0.00),(4,'EVGA 750W Power Supply',5,129.99,0,4,'Reliable power supply for gaming and workstations.',1,0.00),(5,'MSI B450 TOMAHAWK Motherboard',7,99.99,18,5,'ATX motherboard with great performance and durability.',1,0.00),(6,'Cooler Master Hyper 212',6,35.99,33,6,'Cooling system for high-end processors.',1,0.00),(7,'Logitech G Pro Wireless Mouse',9,149.99,86,7,'Wireless mouse for esports and gaming enthusiasts.',1,0.00),(8,'Samsung 970 EVO Plus 1TB SSD',4,149.99,43,8,'Ultra-fast storage solution for gaming and workstations.',1,0.00),(9,'TP-Link Archer AX6000 Router',9,349.99,23,9,'High-speed router for next-gen Wi-Fi performance.',1,0.00),(10,'Bose QuietComfort 35 II',10,299.99,13,10,'Noise-cancelling headphones with superior audio quality.',1,0.00),(59,'Intel Core i5-13600K Processor',1,830.08,25,1,'High-performance processor for gaming and multitasking.',1,0.00),(60,'Intel Core i3-13100F Processor',1,330.36,35,1,'High-performance processor for gaming and multitasking.',1,0.00),(61,'Intel Optane SSD 905P 960GB',4,1270.44,10,1,'Reliable and fast storage for PCs, laptops, and gaming consoles.',1,0.00),(62,'NVIDIA GeForce RTX 4090 Founders Edition',2,1599.99,8,2,'Graphics card for high-resolution gaming and AI acceleration.',1,0.00),(63,'NVIDIA GeForce RTX 4060 Founders Edition',2,399.99,20,2,'Graphics card for high-resolution gaming and AI acceleration.',1,0.00),(64,'NVIDIA Titan RTX Graphics Card',2,2499.99,5,2,'Graphics card for high-resolution gaming and AI acceleration.',1,0.00),(65,'Corsair Dominator Platinum RGB 64GB (2x32GB) DDR5-5600',3,299.99,25,3,'High-speed RAM for gaming and professional applications.',1,0.00),(66,'Corsair RM850x 850W 80+ Gold PSU',5,149.99,40,3,'Efficient power supply unit for stable and reliable performance.',1,0.00),(67,'Corsair iCUE H150i Elite Capellix 360mm AIO',NULL,179.99,30,3,NULL,1,0.00),(68,'Samsung 870 EVO 2TB SATA SSD',4,199.99,50,4,'Reliable and fast storage for PCs, laptops, and gaming consoles.',1,0.00),(69,'Samsung T7 Shield 1TB Portable SSD',4,129.99,45,4,'Reliable and fast storage for PCs, laptops, and gaming consoles.',1,0.00),(70,'Samsung 970 EVO Plus 2TB NVMe SSD',4,249.99,30,4,'Reliable and fast storage for PCs, laptops, and gaming consoles.',1,0.00),(71,'MSI MEG Z790 Godlike Motherboard',7,699.99,15,5,'Feature-rich motherboard with great performance and durability.',1,0.00),(72,'MSI Radeon RX 6800 XT Gaming Trio',2,649.99,18,5,'Graphics card for high-resolution gaming and AI acceleration.',1,0.00),(73,'MSI MAG CoreLiquid 360R V2 AIO Cooler',6,129.99,20,5,'Effective cooling solutions for processors and gaming rigs.',1,0.00),(74,'Seasonic PRIME TX-1000 1000W 80+ Titanium PSU',5,289.99,25,6,'Efficient power supply unit for stable and reliable performance.',1,0.00),(75,'Seasonic Focus GX-750 750W 80+ Gold PSU',5,119.99,40,6,'Efficient power supply unit for stable and reliable performance.',1,0.00),(76,'Cooler Master NR200P Max ITX Case',6,179.99,25,7,'Effective cooling solutions for processors and gaming rigs.',1,0.00),(77,'Cooler Master Hyper 212 Black Edition CPU Cooler',6,49.99,35,7,'Effective cooling solutions for processors and gaming rigs.',1,0.00),(78,'Gigabyte AORUS GeForce RTX 4080 Master',7,1249.99,12,8,'Feature-rich motherboard with great performance and durability.',1,0.00),(79,'Gigabyte X570 AORUS Elite WiFi Motherboard',7,189.99,30,8,'Feature-rich motherboard with great performance and durability.',1,0.00),(80,'ASUS ROG Maximus Z790 Hero Motherboard',7,599.99,18,9,'Feature-rich motherboard with great performance and durability.',1,0.00),(81,'ASUS TUF Gaming VG279QM 27\" 280Hz Monitor',8,349.99,25,9,'High refresh rate and resolution monitor for smooth gaming.',1,0.00),(82,'Kingston FURY Renegade 32GB (2x16GB) DDR5-6400',3,229.99,40,10,'High-speed RAM for gaming and professional applications.',1,0.00),(83,'Kingston NV2 1TB PCIe 4.0 NVMe SSD',4,79.99,50,10,'Reliable and fast storage for PCs, laptops, and gaming consoles.',1,0.00);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `prevent_processor_deletion` BEFORE DELETE ON `products` FOR EACH ROW BEGIN
    IF OLD.category_id = 1 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Deletion of processor products is not allowed.';
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Temporary view structure for view `supplier_product_count`
--

DROP TABLE IF EXISTS `supplier_product_count`;
/*!50001 DROP VIEW IF EXISTS `supplier_product_count`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `supplier_product_count` AS SELECT 
 1 AS `supplier_id`,
 1 AS `supplier_name`,
 1 AS `total_products`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `supplier_product_list`
--

DROP TABLE IF EXISTS `supplier_product_list`;
/*!50001 DROP VIEW IF EXISTS `supplier_product_list`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `supplier_product_list` AS SELECT 
 1 AS `supplier_id`,
 1 AS `supplier_name`,
 1 AS `product_id`,
 1 AS `product_name`,
 1 AS `price`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suppliers` (
  `supplier_id` int NOT NULL AUTO_INCREMENT,
  `supplier_name` varchar(100) NOT NULL,
  `contact_name` varchar(100) DEFAULT NULL,
  `contact_email` varchar(100) DEFAULT NULL,
  `contact_phone` varchar(15) DEFAULT NULL,
  `address` text,
  PRIMARY KEY (`supplier_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
INSERT INTO `suppliers` VALUES (1,'Intel Corporation','John Adams','john.adams@intel.com','09171234567','2200 Mission College Blvd, Santa Clara, CA'),(2,'NVIDIA Corporation','Sarah Lee','sarah.lee@nvidia.com','09181234567','2788 San Tomas Expressway, Santa Clara, CA'),(3,'Corsair','Mark Taylor','mark.taylor@corsair.com','09191234567','4701 Goodyear Loop, Fremont, CA'),(4,'Samsung Electronics','Anna Kim','anna.kim@samsung.com','09201234567','85 Challenger Road, Ridgefield Park, NJ'),(5,'MSI','Tom Nguyen','tom.nguyen@msi.com','09211234567','11F, No. 69, Lide Road, New Taipei City'),(6,'Seasonic','Kevin Brown','kevin.brown@seasonic.com','09221234567','Shenzhen, China'),(7,'Cooler Master','Jessica White','jessica.white@coolermaster.com','09231234567','Room 502, 5F, Building B, Huarun Bldg., 1288 Yindu Road, Shanghai'),(8,'Gigabyte','Peter Lee','peter.lee@gigabyte.com','09241234567','12F, No. 6, Baoyuan Road, Taipei'),(9,'Asus','Sophia Wong','sophia.wong@asus.com','09251234567','5F, No. 88, Li-de Road, Taipei'),(10,'Kingston','Lucas Green','lucas.green@kingston.com','09261234567','1768 Pyramid Blvd, Fountain Valley, CA');
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(100) NOT NULL,
  `password_hash` char(64) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `reset_code` varchar(10) DEFAULT NULL,
  `reset_code_expiry` datetime DEFAULT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Karl','5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5','Karl@gmail.com','2025-05-21 09:34:04',NULL,NULL);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'computerparts_db'
--

--
-- Dumping routines for database 'computerparts_db'
--
/*!50003 DROP FUNCTION IF EXISTS `GetAveragePrice` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `GetAveragePrice`() RETURNS double
    DETERMINISTIC
BEGIN
    DECLARE avg_price DOUBLE;
    SELECT AVG(price) INTO avg_price FROM products;
    RETURN avg_price;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `GetCategoryName` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `GetCategoryName`(cat_id INT) RETURNS char(50) CHARSET utf8mb4
    DETERMINISTIC
BEGIN
    DECLARE cat_name CHAR(50);
    SELECT category_name INTO cat_name FROM product_categories WHERE category_id = cat_id;
    RETURN cat_name;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `GetProductDiscount` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `GetProductDiscount`(prodID INT, percentage DECIMAL(5,2)) RETURNS decimal(10,2)
    DETERMINISTIC
BEGIN  
    DECLARE original_price DECIMAL(10,2);  
    DECLARE new_price DECIMAL(10,2);  

    SELECT price INTO original_price  
    FROM products  
    WHERE product_id = prodID;  

    IF original_price IS NOT NULL THEN  
        IF percentage < 0 THEN
            SET new_price = original_price * (1 + ABS(percentage) / 100);
        ELSE
            SET new_price = original_price * (1 - percentage / 100);
        END IF;
    ELSE  
        SET new_price = NULL; 
    END IF;  

    RETURN new_price;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `GetSupplierName` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `GetSupplierName`(sup_id INT) RETURNS char(100) CHARSET utf8mb4
    DETERMINISTIC
BEGIN
    DECLARE sup_name CHAR(100);
    SELECT supplier_name INTO sup_name FROM supplier_product_list WHERE supplier_id = sup_id LIMIT 1;
    RETURN sup_name;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `GetTotalItemPrice` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `GetTotalItemPrice`(prod_id INT, quantity INT) RETURNS decimal(10,2)
    DETERMINISTIC
BEGIN
    DECLARE unit_price DECIMAL(10,2);
    DECLARE total_price DECIMAL(10,2);

    SELECT price INTO unit_price FROM products WHERE product_id = prod_id;

    SET total_price = unit_price * quantity;

    RETURN total_price;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `GetTotalOrderPrice` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `GetTotalOrderPrice`(prod_id INT, quantity INT) RETURNS decimal(10,2)
    DETERMINISTIC
BEGIN
    DECLARE unit_price DECIMAL(10,2);
    DECLARE total_price DECIMAL(10,2);

    SELECT price INTO unit_price FROM products WHERE product_id = prod_id;

    SET total_price = unit_price * quantity;

    RETURN total_price;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `add_order_with_products` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `add_order_with_products`(
    IN p_customer_id INT,
    IN p_products TEXT
)
BEGIN
    DECLARE done INT DEFAULT FALSE;
    DECLARE v_product_id INT;
    DECLARE v_quantity INT;
    DECLARE v_price DECIMAL(10,2);
    DECLARE v_total_amount DECIMAL(10,2) DEFAULT 0;
    DECLARE new_order_id INT;

    DECLARE order_cursor CURSOR FOR 
    SELECT product_id, quantity FROM temp_order_items;

    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;

    CREATE TEMPORARY TABLE IF NOT EXISTS temp_order_items (
        product_id INT,
        quantity INT
    );

    DELETE FROM temp_order_items;

    INSERT INTO temp_order_items (product_id, quantity)
    SELECT 
        SUBSTRING_INDEX(SUBSTRING_INDEX(p_products, ';', numbers.n), ',', 1) AS product_id,
        SUBSTRING_INDEX(SUBSTRING_INDEX(p_products, ';', numbers.n), ',', -1) AS quantity
    FROM (
        SELECT 1 n UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL SELECT 4 UNION ALL SELECT 5 
        UNION ALL SELECT 6 UNION ALL SELECT 7 UNION ALL SELECT 8 UNION ALL SELECT 9 UNION ALL SELECT 10
    ) numbers
    WHERE CHAR_LENGTH(p_products) - CHAR_LENGTH(REPLACE(p_products, ';', '')) >= numbers.n - 1;

    INSERT INTO orders (customer_id, order_date, total_amount, status)
    VALUES (p_customer_id, NOW(), 0, 'Pending');

    SET new_order_id = LAST_INSERT_ID();

    OPEN order_cursor;
    
    order_loop: LOOP
        FETCH order_cursor INTO v_product_id, v_quantity;
        IF done THEN 
            LEAVE order_loop;
        END IF;
        
        SET v_price = GetTotalItemPrice(v_product_id, v_quantity);

        INSERT INTO order_items (order_id, product_id, quantity, price)
        VALUES (new_order_id, v_product_id, v_quantity, v_price);

        SET v_total_amount = v_total_amount + v_price;
    END LOOP;

    CLOSE order_cursor;

    UPDATE orders SET total_amount = v_total_amount WHERE order_id = new_order_id;

    DROP TEMPORARY TABLE IF EXISTS temp_order_items;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `discount_supplier_products` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `discount_supplier_products`(
    IN supplierID INT, 
    IN prodID INT, 
    IN percentage DECIMAL(5,2)
)
BEGIN
    DECLARE new_price DECIMAL(10,2);

    SET new_price = GetProductDiscount(prodID, percentage);

    IF new_price IS NOT NULL THEN
        UPDATE products
        SET price = new_price
        WHERE supplier_id = supplierID AND product_id = prodID;
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `increase_supplier_prices` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `increase_supplier_prices`(
    IN supplier_id_param INT, 
    IN percentage_increase DECIMAL(5,2)
)
BEGIN
    UPDATE products
    SET price = price * (1 + (percentage_increase / 100))
    WHERE supplier_id = supplier_id_param;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `update_stock` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_stock`()
BEGIN
    DECLARE done INT DEFAULT FALSE;
    DECLARE v_product_id INT;
    DECLARE v_total_sold INT;

    DECLARE sales_cursor CURSOR FOR 
    SELECT product_id, SUM(quantity) 
    FROM order_items
    GROUP BY product_id;

    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;

    OPEN sales_cursor;

    sales_loop: LOOP
        FETCH sales_cursor INTO v_product_id, v_total_sold;
        IF done THEN 
            LEAVE sales_loop;
        END IF;

        UPDATE products
        SET stock_quantity = GREATEST(stock_quantity - v_total_sold, 0)
        WHERE product_id = v_product_id;
    END LOOP;

    CLOSE sales_cursor;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `customer_information`
--

/*!50001 DROP VIEW IF EXISTS `customer_information`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `customer_information` AS select `customers`.`customer_id` AS `customer_id`,`customers`.`first_name` AS `first_name`,`customers`.`last_name` AS `last_name`,`customers`.`email` AS `email`,`customers`.`phone` AS `phone`,`customers`.`address` AS `address` from `customers` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `customer_orders`
--

/*!50001 DROP VIEW IF EXISTS `customer_orders`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `customer_orders` AS select `c`.`customer_id` AS `customer_id`,`c`.`first_name` AS `first_name`,`c`.`last_name` AS `last_name`,`o`.`order_id` AS `order_id`,`o`.`order_date` AS `order_date`,`p`.`product_name` AS `product_name`,(`oi`.`quantity` * `oi`.`price`) AS `total_amount`,`o`.`status` AS `status` from (((`customers` `c` join `orders` `o` on((`c`.`customer_id` = `o`.`customer_id`))) join `order_items` `oi` on((`o`.`order_id` = `oi`.`order_id`))) join `products` `p` on((`oi`.`product_id` = `p`.`product_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `product_prices`
--

/*!50001 DROP VIEW IF EXISTS `product_prices`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `product_prices` AS select `products`.`product_id` AS `product_id`,`products`.`product_name` AS `product_name`,`products`.`price` AS `price` from `products` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `supplier_product_count`
--

/*!50001 DROP VIEW IF EXISTS `supplier_product_count`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `supplier_product_count` AS select `s`.`supplier_id` AS `supplier_id`,`s`.`supplier_name` AS `supplier_name`,count(`p`.`product_id`) AS `total_products` from (`suppliers` `s` left join `products` `p` on((`s`.`supplier_id` = `p`.`supplier_id`))) group by `s`.`supplier_id`,`s`.`supplier_name` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `supplier_product_list`
--

/*!50001 DROP VIEW IF EXISTS `supplier_product_list`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `supplier_product_list` AS select `s`.`supplier_id` AS `supplier_id`,`s`.`supplier_name` AS `supplier_name`,`p`.`product_id` AS `product_id`,`p`.`product_name` AS `product_name`,`p`.`price` AS `price` from (`suppliers` `s` join `products` `p` on((`s`.`supplier_id` = `p`.`supplier_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-21 18:07:02
