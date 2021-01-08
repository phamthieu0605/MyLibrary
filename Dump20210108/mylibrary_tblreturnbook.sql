-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: mylibrary
-- ------------------------------------------------------
-- Server version	8.0.22

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
-- Table structure for table `tblreturnbook`
--

DROP TABLE IF EXISTS `tblreturnbook`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblreturnbook` (
  `MaTraSach` varchar(45) NOT NULL,
  `MaSV` varchar(45) DEFAULT NULL,
  `TenSV` varchar(45) DEFAULT NULL,
  `SoDienThoai` int DEFAULT NULL,
  `TenSach` varchar(45) DEFAULT NULL,
  `SoLuong` int DEFAULT NULL,
  `NgayMuon` varchar(45) DEFAULT NULL,
  `NgayTra` date DEFAULT NULL,
  PRIMARY KEY (`MaTraSach`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblreturnbook`
--

LOCK TABLES `tblreturnbook` WRITE;
/*!40000 ALTER TABLE `tblreturnbook` DISABLE KEYS */;
INSERT INTO `tblreturnbook` VALUES ('1','69ht20111','pham quang thieu',335601670,'JavaScript 2',2,'12/13/2020 12:00:00 AM','2020-12-13'),('2','69ht20111','pham quang thieu',335601670,'JavaScript 2',3,'12/13/2020 12:00:00 AM','2020-12-13'),('3','69ht20111','pham quang thieu',335601670,'JavaScript 2',1,'12/13/2020 12:00:00 AM','2020-12-13'),('4','69ht20111','pham quang thieu',335601670,'JavaScript 2',2,'12/13/2020 12:00:00 AM','2020-12-15'),('5','ht20112','nguyen van a',987654321,'JavaScript 1',1,'12/22/2020 12:00:00 AM','2020-12-22'),('6','ht20111','pham quang thieu',335601670,'javascript',2,'12/27/2020 12:00:00 AM','2020-12-27');
/*!40000 ALTER TABLE `tblreturnbook` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-01-08 18:42:09
