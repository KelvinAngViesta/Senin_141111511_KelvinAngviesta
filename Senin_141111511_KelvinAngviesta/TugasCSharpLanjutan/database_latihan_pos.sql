-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 30 Des 2016 pada 15.35
-- Versi Server: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `database_latihan_pos`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblbarang`
--

CREATE TABLE `tblbarang` (
  `id` int(10) NOT NULL,
  `kode` varchar(20) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `jumlahAwal` int(10) NOT NULL,
  `hargaHpp` decimal(16,2) NOT NULL,
  `hargajual` decimal(16,2) NOT NULL,
  `tglbuatbarang` datetime NOT NULL,
  `tglupdatebarang` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tblbarang`
--

INSERT INTO `tblbarang` (`id`, `kode`, `nama`, `jumlahAwal`, `hargaHpp`, `hargajual`, `tglbuatbarang`, `tglupdatebarang`) VALUES
(1231, '123', 'PepsiRed', 2, '2000.00', '2000.00', '2016-12-30 19:12:51', '2016-12-30 19:12:51');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblcustomer`
--

CREATE TABLE `tblcustomer` (
  `KodeCust` int(20) NOT NULL,
  `NamaCust` varchar(100) NOT NULL,
  `AlamatCust` varchar(100) NOT NULL,
  `HpCust` int(12) NOT NULL,
  `EmailCust` varchar(100) NOT NULL,
  `Datenow` datetime NOT NULL,
  `DateUpdate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tblcustomer`
--

INSERT INTO `tblcustomer` (`KodeCust`, `NamaCust`, `AlamatCust`, `HpCust`, `EmailCust`, `Datenow`, `DateUpdate`) VALUES
(1231, 'KelvinAng', 'Jln Sana Sini', 1234567123, 'testing@yahoo.com', '2016-12-30 19:13:37', '2016-12-30 19:13:37');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblsell`
--

CREATE TABLE `tblsell` (
  `id` int(100) NOT NULL,
  `namaBarang` varchar(100) NOT NULL,
  `namaCustomer` varchar(100) NOT NULL,
  `banyakTrade` int(100) NOT NULL,
  `hargaSatuan` decimal(50,0) NOT NULL,
  `totalHarga` decimal(50,0) NOT NULL,
  `waktuTrade` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tblsell`
--

INSERT INTO `tblsell` (`id`, `namaBarang`, `namaCustomer`, `banyakTrade`, `hargaSatuan`, `totalHarga`, `waktuTrade`) VALUES
(0, 'PepsiRed', '1231', 1, '2000', '2000', '2016-12-30 21:34:20');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblsupplier`
--

CREATE TABLE `tblsupplier` (
  `KodeSup` int(10) NOT NULL,
  `NamaSup` varchar(100) NOT NULL,
  `AlamatSup` varchar(100) NOT NULL,
  `HpSup` int(12) NOT NULL,
  `EmailSup` varchar(100) NOT NULL,
  `Datenow` datetime NOT NULL,
  `DateUpdate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tblsupplier`
--

INSERT INTO `tblsupplier` (`KodeSup`, `NamaSup`, `AlamatSup`, `HpSup`, `EmailSup`, `Datenow`, `DateUpdate`) VALUES
(1231, 'KelvinAja', 'Jln Sini sana', 1234567812, 'iniaja@yahoo.com', '2016-12-30 19:14:23', '2016-12-30 19:14:23');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbltrade`
--

CREATE TABLE `tbltrade` (
  `id` int(100) NOT NULL,
  `namaBarang` varchar(100) NOT NULL,
  `namaSupp` varchar(100) NOT NULL,
  `banyakTrade` int(100) NOT NULL,
  `hargaSatuan` decimal(50,0) NOT NULL,
  `totalHarga` decimal(50,0) NOT NULL,
  `waktuTrade` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbltrade`
--

INSERT INTO `tbltrade` (`id`, `namaBarang`, `namaSupp`, `banyakTrade`, `hargaSatuan`, `totalHarga`, `waktuTrade`) VALUES
(0, 'PepsiRed', '1231', 1, '2000', '2000', '2016-12-30 21:20:14'),
(0, 'PepsiRed', '1231', 1, '2000', '2000', '2016-12-30 21:30:26'),
(0, 'PepsiRed', '1231', 1, '2000', '2000', '2016-12-30 21:30:37');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
