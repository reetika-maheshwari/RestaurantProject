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
-- Table structure for table `mst_staff`
--

DROP TABLE IF EXISTS `mst_staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mst_staff` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Emp_Name` varchar(45) DEFAULT NULL,
  `F_Name` varchar(45) DEFAULT NULL,
  `M_Name` varchar(45) DEFAULT NULL,
  `DOB` varchar(45) DEFAULT NULL,
  `DOJ` varchar(45) DEFAULT NULL,
  `Salary` int(11) DEFAULT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `Designation` varchar(45) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `Contact_No` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_staff`
--

LOCK TABLES `mst_staff` WRITE;
/*!40000 ALTER TABLE `mst_staff` DISABLE KEYS */;
INSERT INTO `mst_staff` VALUES (1,'Anil Kumar','Mr. Mukesh Kumar','Mr. Meena Kumari','0001-01-01','0001-01-01',45000,'0','Restaurant Manager','Noida, UP','7684787890'),(2,'Suman Srivastava','Mr. Mahesh','Mrs. Bina','0001-01-01','0001-01-01',38000,'1','Restaurant Manager','Delhi, South','7878978790'),(3,'kajal verma','mr. suresh verma','mrs. malti verma','0001-01-01','0001-01-01',10000,'1','Server','hathras','8976543210'),(4,'Reena Kumari ','Mr. Rajesh Kumar','Mrs. Rani','0001-01-01','0001-01-01',10000,'1','Server','agra','7896543201'),(5,'Pankaj Sharma','Mr. Suneel Sharma','Mrs. Kavita Sharma','0001-01-01','0001-01-01',10000,'0','Server','Gaziabad','8975463900'),(6,'Raj Kumar','Manish','Minesh','0001-01-01','0001-01-01',11000,'0','Server','Delhi, North','6943869090'),(7,'Vivek','Parth','Rita','0001-01-01','0001-01-01',12000,'0','Server','Firozabad, UP','6767658070'),(8,'Muskan Mittal','Vivek Mittal','Rajesh Kumari','0001-01-01','0001-01-01',9000,'1','Server','Mathura, UP','7000777899'),(9,'Ram Charan','Daulat Ram','Rama Devi','0001-01-01','0001-01-01',10500,'0','Server','Aligarh','7878006611'),(10,'Rita Sharma','Mr. Sarvesh','Mrs. Malti','0001-01-01','0001-01-01',15000,'0','Host','Agra, UP','6767676717'),(11,'Mukesh Sharma','Vivek','Mala','0001-01-01','0001-01-01',15500,'0','Host','Firozabad, UP','7878997001'),(12,'Abhishek','Kapoor Chand','Doli','0001-01-01','0001-01-01',10500,'0','Busser','Kasganj, UP','7568879900'),(13,'Pulkit','Tushar','Yogyata','0001-01-01','0001-01-01',10500,'0','Busser','Kasganj, UP','9110898900'),(14,'Deepankar Singh','Rajesh','Kamla','0001-01-01','0001-01-01',8500,'0','Runner','Mathura, Farah, UP','8989989980'),(15,'Gopal Soni','Pulkit Soni','Soni Roy','0001-01-01','0001-01-01',9200,'0','Runner','Govardhan, UP','9869469900'),(16,'Avinash Sharma','Mr. Kapoor Sharma','Mr. Meera Devi','0001-01-01','0001-01-01',25000,'0','Account Executive','Rajpur Chungi, Agra','8898809801'),(17,'Abhilash Sharma','Mr. Naveen Chand Sharma','Mrs. Savitri Devi','0001-01-01','0001-01-01',25800,'0','Account Executive','Mohalla Duli, Firozabad, UP','8988999000'),(18,'Seema','Charan Singh','Bhudevi','0001-01-01','0001-01-01',7500,'1','Dishwasher','Noida, Wajidpur, UP','7879770011'),(19,'Suresh','Dharmendra','Praveena','0001-01-01','0001-01-01',8000,'0','Dishwasher','Noida, Wazidpur, UP','8980809892'),(20,'Veena Dogra','Dharmesh','Bhatti devi','0001-01-01','0001-01-01',7900,'1','Dishwasher','Noida, Sec-137, UP','8989989000'),(21,'Ritika Maheshawari','Mr. Mukesh','Mrs. Manju','0001-01-01','0001-01-01',32000,'1','Chef','Kasganj, UP','6398159447'),(22,'Nitin Bhatia','Mr. Vivek','Mrs. Sarmila','0001-01-01','0001-01-01',28000,'0','Chef','Noida, Sec- 142, UP','8997797800'),(23,'Love Sharma','Mr. Navin Sharma','Mrs. Neha Sharma','0001-01-01','0001-01-01',36000,'0','IT Executive','Noida, Sec- 18, UP','7888688600'),(24,'Tushar Chauhan','Mahesh Chand','Neha Devi','0001-01-01','0001-01-01',18000,'0','Clerk','Jagner, UP','9090887770'),(25,'Mr. Ankur Upadhayay','Mr. Girija Shankar Upadhayay','Mrs. Gaytri Devi','0001-01-01','0001-01-01',85000,'0','CEO','Rajpur Chungi, Shamshabad Road, Agra- 282001','8439742038'),(26,'AbhilashSharma','NaveenSharma','Neha','0001-01-01','0001-01-01',70000,'0','Clerk','Firozabad, UP','8989578899'),(27,'Sudhir','Manoj','Mala','16-06-2004','14-11-2022',12000,'Male','Restaurant Manager','Agra','7878897895');
/*!40000 ALTER TABLE `mst_staff` ENABLE KEYS */;
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
