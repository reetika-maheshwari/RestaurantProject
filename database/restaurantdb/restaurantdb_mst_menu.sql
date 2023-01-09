-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: restaurantdb
-- ------------------------------------------------------
-- Server version	5.7.9-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `mst_menu`
--

DROP TABLE IF EXISTS `mst_menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mst_menu` (
  `Dish_Name` varchar(45) DEFAULT NULL,
  `Category` varchar(45) DEFAULT NULL,
  `Food_Type` varchar(45) DEFAULT NULL,
  `Rate` int(5) DEFAULT NULL,
  `path_image` varchar(100) DEFAULT NULL,
  `Id` int(2) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_menu`
--

LOCK TABLES `mst_menu` WRITE;
/*!40000 ALTER TABLE `mst_menu` DISABLE KEYS */;
INSERT INTO `mst_menu` VALUES ('Burger','Veg','Burger',125,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\Burger.jpg',2),('Hakka Noodles','Veg','Chinese',135,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\hakka.jpg',6),('Vada Pav','Veg','North Indian',115,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\Bada Pav.jpg',9),('Cheese Burger','Veg','Burger',160,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\Cheese Burger.jpg',10),('Cheese Dosa','Veg','South Indian',220,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\cheese dosa.jpg',11),('Chhole Bhature','Veg','North Indian',120,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\Chhole Bhature.jpg',12),('Chowmein','Veg','Chinese',100,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\cho.jpg',13),('Cutlet','Veg','North Indian',120,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\Cutlet.jpg',14),('Dabeli','Veg','North Indian',110,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\Dabeli.jpg',15),('Idli','Veg','South Indian',140,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\idli_759.jpg',16),('Masala Dosa','Veg','South Indian',120,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\Masala Dosa.png',17),('Masala Paper Dosa','Veg','South Indian',140,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\Masala Paper Dosa.jpg',18),('Momos','Veg','Chinese',100,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\momo.jpg',19),('Noodles','Veg','Chinese',120,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\noodles.jpg',20),('Paneer Dosa','Veg','South Indian',240,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\paneer dosa.jpg',21),('Paneer Tikka','Veg','North Indian',320,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\Paneer-Tikka - Copy.jpg',22),('Pav Bhaji','Veg','North Indian',160,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\pav bhajiiii.jpg',23),('Regular Maggi','Veg','Chinese',110,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\Maggi - Copy.jpg',24),('Spring Rolls','Veg','Chinese',120,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\Spring Roll.jpg',25),('Super Spicy Burger','Veg','Burger',110,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\Super Spicy.jpg',26),('Sambhar Vada','Veg','South Indian',90,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\vada.jpg',27),('Deep Fried Prawns','Non-Veg','Thai',850,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\deep fried.jpg',28),('Chicken Cashew Nuts','Non-Veg','Thai',480,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\cashew-chicken-.jpg',29),('Prawns','Non-Veg','Thai',380,'C:\\Users\\hp\\Pictures\\Food Image\\Foods Images\\prwans.jpg',30);
/*!40000 ALTER TABLE `mst_menu` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-14 18:56:46
