-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 13, 2020 at 11:10 AM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `frizerski`
--

-- --------------------------------------------------------

--
-- Table structure for table `aktivnosti`
--

CREATE TABLE `aktivnosti` (
  `id` int(10) UNSIGNED NOT NULL,
  `broj_telefona` varchar(10) DEFAULT NULL,
  `delatnost_id` int(11) DEFAULT NULL,
  `dan` varchar(45) DEFAULT NULL,
  `sat` varchar(4) DEFAULT NULL,
  `status` int(11) DEFAULT NULL,
  `mesec` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `aktivnosti`
--

INSERT INTO `aktivnosti` (`id`, `broj_telefona`, `delatnost_id`, `dan`, `sat`, `status`, `mesec`) VALUES
(1, '2', 2, '23', '1544', 1, '4'),
(2, '4421341', 3, '32', '3232', 0, '2'),
(3, '123323', 1, '23', '3111', 0, '1'),
(4, '643213123', 1, '5', '9', 0, '3');

-- --------------------------------------------------------

--
-- Table structure for table `delatnosti`
--

CREATE TABLE `delatnosti` (
  `id` int(10) UNSIGNED NOT NULL,
  `naziv` varchar(45) NOT NULL,
  `cena` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `delatnosti`
--

INSERT INTO `delatnosti` (`id`, `naziv`, `cena`) VALUES
(1, 'sminkanje', 200);

-- --------------------------------------------------------

--
-- Table structure for table `klijenti`
--

CREATE TABLE `klijenti` (
  `id` int(11) NOT NULL,
  `broj` varchar(15) DEFAULT NULL,
  `ime_prezime` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `klijenti`
--

INSERT INTO `klijenti` (`id`, `broj`, `ime_prezime`) VALUES
(1, '064100828', 'Djordje Milosevic'),
(2, '063131233', 'Miodrag Stevan');

-- --------------------------------------------------------

--
-- Table structure for table `radnici`
--

CREATE TABLE `radnici` (
  `id` int(10) UNSIGNED NOT NULL,
  `ime_prezime` varchar(45) DEFAULT NULL,
  `broj_telefona` varchar(45) DEFAULT NULL,
  `jmbg` varchar(45) DEFAULT NULL,
  `delatnost_id` int(11) DEFAULT NULL,
  `lozinka` varchar(45) DEFAULT NULL,
  `plata` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `radnici`
--

INSERT INTO `radnici` (`id`, `ime_prezime`, `broj_telefona`, `jmbg`, `delatnost_id`, `lozinka`, `plata`) VALUES
(1, 'D D', '123', '123', 123, '123', 20000),
(2, 'A A ', '321', '321', 321, '321', 25000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aktivnosti`
--
ALTER TABLE `aktivnosti`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `delatnosti`
--
ALTER TABLE `delatnosti`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `klijenti`
--
ALTER TABLE `klijenti`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `radnici`
--
ALTER TABLE `radnici`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aktivnosti`
--
ALTER TABLE `aktivnosti`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `delatnosti`
--
ALTER TABLE `delatnosti`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `klijenti`
--
ALTER TABLE `klijenti`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `radnici`
--
ALTER TABLE `radnici`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
