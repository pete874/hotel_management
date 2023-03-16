-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Host: sql8.freesqldatabase.com
-- Generation Time: 12.03.2023 klo 20:33
-- Palvelimen versio: 5.5.62-0ubuntu0.14.04.1
-- PHP Version: 7.0.33-0ubuntu0.16.04.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sql8603367`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `asiakkaat`
--

CREATE TABLE `asiakkaat` (
  `kayttajanimi` varchar(25) NOT NULL,
  `etunimi` varchar(35) NOT NULL,
  `sukunimi` varchar(25) NOT NULL,
  `lahiosoite` varchar(35) NOT NULL,
  `postinumero` varchar(25) NOT NULL,
  `postitoimipaikka` varchar(25) NOT NULL,
  `salasana` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Vedos taulusta `asiakkaat`
--

INSERT INTO `asiakkaat` (`kayttajanimi`, `etunimi`, `sukunimi`, `lahiosoite`, `postinumero`, `postitoimipaikka`, `salasana`) VALUES
('admin', 'Matti', 'Meikäläinen', 'Keskikatu 3', '04300', 'Tuusula', 'admin'),
('johsmith', 'John', 'Smithers', 'Koivukyläntie', '10', '01350', 'MCoxdsduAj'),
('mathämäl', 'Matti', 'Hämäläinen', 'maantientie 60 f', '04560', 'Turku', 'WvTPrCdL5x'),
('pekmuhon', 'Pekka', 'Muhonen', 'porkkanatie 12 a', '00900', 'Kempele', 'Yr47y9vLdd'),
('petnurmi', 'Petri', 'Nurmi', 'lähitie 1 a', '00700', 'Helsinki', 'xSvwJ7Bg4S'),
('vilsaari', 'Ville', 'Saarinen', 'maapallontie 25 c', '09990', 'Tuusula', 'X4MMi5ZoPv');

-- --------------------------------------------------------

--
-- Rakenne taululle `huoneet`
--

CREATE TABLE `huoneet` (
  `huonenro` int(11) NOT NULL,
  `huonetyyppi` int(11) NOT NULL,
  `puhelin` varchar(15) NOT NULL,
  `vapaa` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Vedos taulusta `huoneet`
--

INSERT INTO `huoneet` (`huonenro`, `huonetyyppi`, `puhelin`, `vapaa`) VALUES
(101, 1, '100', 'kylla'),
(102, 1, '102', 'kylla'),
(103, 1, '103', 'kylla'),
(104, 1, '104', 'kylla'),
(105, 1, '105', 'kylla'),
(201, 2, '201', 'kylla'),
(202, 2, '202', 'ei'),
(203, 2, '203', 'kylla'),
(204, 2, '204', 'kylla'),
(301, 3, '301', 'ei'),
(302, 3, '302', 'kylla'),
(303, 3, '303', 'kylla'),
(401, 4, '401', 'ei'),
(402, 4, '402', 'kylla');

-- --------------------------------------------------------

--
-- Rakenne taululle `huonekategoriat`
--

CREATE TABLE `huonekategoriat` (
  `kategoriaid` int(5) NOT NULL,
  `huonetyyppi` varchar(25) NOT NULL,
  `hinta` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Vedos taulusta `huonekategoriat`
--

INSERT INTO `huonekategoriat` (`kategoriaid`, `huonetyyppi`, `hinta`) VALUES
(1, 'yhden hengen', 125),
(2, 'kahden hengen', 150),
(3, 'kolmen hengen', 200),
(4, 'sviitti', 500);

-- --------------------------------------------------------

--
-- Rakenne taululle `varaukset`
--

CREATE TABLE `varaukset` (
  `varausnumero` int(25) NOT NULL,
  `tyontekija` varchar(25) NOT NULL,
  `huonetyyppi` varchar(25) NOT NULL,
  `huonenro` int(15) NOT NULL,
  `sisaan` date NOT NULL,
  `ulos` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Vedos taulusta `varaukset`
--

INSERT INTO `varaukset` (`varausnumero`, `tyontekija`, `huonetyyppi`, `huonenro`, `sisaan`, `ulos`) VALUES
(143, 'Petri Nurmi', 'kolmen hengen', 301, '2023-04-01', '2023-04-05'),
(144, 'John Smithers', 'yhden hengen', 104, '2023-03-15', '2024-03-21'),
(145, 'John Smithers', 'yhden hengen', 105, '2023-03-26', '2024-04-20'),
(146, 'Pekka Muhonen', 'sviitti', 401, '2023-03-26', '2024-04-20'),
(147, 'Pekka Muhonen', 'kolmen hengen', 301, '2023-03-26', '2024-04-20'),
(148, 'Matti Hämäläinen', 'kolmen hengen', 301, '2023-03-31', '2023-04-20'),
(149, 'Petri Nurmi', 'kolmen hengen', 301, '2023-03-15', '2023-03-17');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  ADD PRIMARY KEY (`kayttajanimi`);

--
-- Indexes for table `huoneet`
--
ALTER TABLE `huoneet`
  ADD PRIMARY KEY (`huonenro`),
  ADD KEY `huonetyyppi` (`huonetyyppi`);

--
-- Indexes for table `huonekategoriat`
--
ALTER TABLE `huonekategoriat`
  ADD PRIMARY KEY (`kategoriaid`);

--
-- Indexes for table `varaukset`
--
ALTER TABLE `varaukset`
  ADD PRIMARY KEY (`varausnumero`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `varaukset`
--
ALTER TABLE `varaukset`
  MODIFY `varausnumero` int(25) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=150;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
