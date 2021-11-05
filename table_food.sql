-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 30, 2021 at 06:13 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `foodapp`
--

-- --------------------------------------------------------

--
-- Table structure for table `table_food`
--

CREATE TABLE `table_food` (
  `FOODID` int(11) NOT NULL,
  `BARCODE` varchar(250) NOT NULL,
  `DESCRIPTION` varchar(250) NOT NULL,
  `QUANTITY` varchar(250) NOT NULL,
  `PRICE` varchar(250) NOT NULL,
  `IMAGE` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `table_food`
--

INSERT INTO `table_food` (`FOODID`, `BARCODE`, `DESCRIPTION`, `QUANTITY`, `PRICE`, `IMAGE`) VALUES
(1, '4802100000002', 'Stew-Food', '10', '650', 'Stew-food.jpg'),
(2, '4802100000003', 'Barbecue-food', '10', '250', 'Barbecue-food.jpg'),
(3, '4802100000004', 'Brownie-cake', '5', '150', 'Brownie-cake.jpg'),
(4, '4802100000001', 'Casserole-food', '12', '500', 'Casserole-food.jpg'),
(5, '4802100000005', 'Cereal-food', '10', '380', 'Cereal-food.jpg'),
(6, '4802100000006', 'Cheeseboard-food', '10', '562', 'Cheeseboard-food.jpg'),
(7, '4802100000007', 'Cheeseburger-food', '5', '75', 'Cheeseburger-food.jpg'),
(8, '4802100000008', 'Dumpling-food', '5', '78', 'Dumpling-food.jpg'),
(9, '4802100000009', 'Fish-cake', '5', '89', 'Fish-cake.jpg'),
(10, '4802100000010', 'Ice-cream', '8', '145', 'Ice-cream.jpg'),
(11, '4802100000011', 'Lemon-curd-food', '15', '95', 'Lemon-curd-food.jpg'),
(12, '4802100000012', 'Marmalade', '12', '78', 'Marmalade.jpg'),
(13, '4802551222222', 'Pasta', '2', '56', 'Pasta.jpg'),
(14, '4820541122222', 'Meat-loaf', '5', '79', 'Meat-loaf.jpg'),
(15, '4802554122222', 'Sourdough-bread', '10', '234', 'Sourdough-bread.jpg'),
(16, '4802566000000', 'Meatball-food', '16', '225', 'Meatball-food.jpg');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `table_food`
--
ALTER TABLE `table_food`
  ADD PRIMARY KEY (`FOODID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `table_food`
--
ALTER TABLE `table_food`
  MODIFY `FOODID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
