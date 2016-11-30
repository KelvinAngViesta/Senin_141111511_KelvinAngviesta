-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 30, 2016 at 06:22 PM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `database_project`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblbarang`
--

CREATE TABLE `tblbarang` (
  `id` int(10) NOT NULL,
  `kode` varchar(20) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `jumlahAwal` int(10) NOT NULL,
  `hargaHpp` decimal(16,2) NOT NULL,
  `hargajual` decimal(16,2) NOT NULL,
  `tglbuatbarang` date NOT NULL,
  `tglupdatebarang` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbarang`
--

INSERT INTO `tblbarang` (`id`, `kode`, `nama`, `jumlahAwal`, `hargaHpp`, `hargajual`, `tglbuatbarang`, `tglupdatebarang`) VALUES
(1, '1d', 'd', 1, '1.00', '1.00', '0000-00-00', '0000-00-00'),
(123, 'TestingProject123', 'Testing', 1, '2555.00', '25555.00', '0000-00-00', '0000-00-00');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
