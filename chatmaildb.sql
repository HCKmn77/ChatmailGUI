-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 22. Jul 2020 um 10:39
-- Server-Version: 10.4.11-MariaDB
-- PHP-Version: 7.2.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `chatmaildb`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `benutzer`
--

CREATE TABLE `benutzer` (
  `BenutzerID` int(11) NOT NULL,
  `Namen` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `benutzer`
--

INSERT INTO `benutzer` (`BenutzerID`, `Namen`) VALUES
(1, 'Jeremia Haackmann'),
(2, 'Jonas Kaufmann'),
(5, 'Max Mustermann'),
(7, 'Robert Bosch'),
(8, 'Bassem Serhan'),
(11, 'Marie-Luise Müller');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `chatverlauf`
--

CREATE TABLE `chatverlauf` (
  `EmpfängerID` int(11) NOT NULL,
  `NachrichtenID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `chatverlauf`
--

INSERT INTO `chatverlauf` (`EmpfängerID`, `NachrichtenID`) VALUES
(1, 2),
(1, 9),
(2, 1),
(2, 11),
(5, 6),
(7, 3),
(7, 4),
(7, 5),
(7, 7),
(11, 8),
(11, 10);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `nachrichten`
--

CREATE TABLE `nachrichten` (
  `NachrichtenID` int(11) NOT NULL,
  `NachrichtenInhalt` text NOT NULL,
  `Zeitstempel` timestamp NOT NULL DEFAULT current_timestamp(),
  `SenderID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `nachrichten`
--

INSERT INTO `nachrichten` (`NachrichtenID`, `NachrichtenInhalt`, `Zeitstempel`, `SenderID`) VALUES
(1, 'Hallo Jonas, wie geht es dir?', '2020-06-19 12:26:30', 1),
(2, 'Hallo Jeremia, mir geht es sehr gut! Danke der Nachfrage', '2020-06-19 12:27:15', 2),
(3, 'Hallo Robert, danke das ich für dich arbeiten darf!', '2020-06-19 12:27:47', 1),
(4, 'Hallo Robert, wann kommt die besprochene Gehaltserhöhung?', '2020-06-19 12:28:39', 2),
(5, 'Hi Robert, ich muss deine Azubis sehr loben, sie haben ein hervorragendes Chat Programm entwickelt! :)', '2020-06-19 12:30:27', 8),
(6, 'Hallo mein Freund', '2020-06-19 12:34:55', 7),
(7, '', '2020-07-06 09:55:41', 7),
(8, 'Hallo Marie', '2020-07-06 09:58:46', 7),
(9, 'Hallo Jeremia', '2020-07-06 10:08:11', 7),
(10, 'HI ', '2020-07-08 10:48:08', 7),
(11, 'Hi', '2020-07-08 12:17:34', 7);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `verbindungstest`
--

CREATE TABLE `verbindungstest` (
  `Status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `verbindungstest`
--

INSERT INTO `verbindungstest` (`Status`) VALUES
(1);

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `benutzer`
--
ALTER TABLE `benutzer`
  ADD PRIMARY KEY (`BenutzerID`);

--
-- Indizes für die Tabelle `chatverlauf`
--
ALTER TABLE `chatverlauf`
  ADD UNIQUE KEY `arbitrary_index_name` (`EmpfängerID`,`NachrichtenID`),
  ADD KEY `NachrichtenID` (`NachrichtenID`);

--
-- Indizes für die Tabelle `nachrichten`
--
ALTER TABLE `nachrichten`
  ADD PRIMARY KEY (`NachrichtenID`),
  ADD KEY `SenderID` (`SenderID`);

--
-- Indizes für die Tabelle `verbindungstest`
--
ALTER TABLE `verbindungstest`
  ADD PRIMARY KEY (`Status`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `benutzer`
--
ALTER TABLE `benutzer`
  MODIFY `BenutzerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT für Tabelle `nachrichten`
--
ALTER TABLE `nachrichten`
  MODIFY `NachrichtenID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT für Tabelle `verbindungstest`
--
ALTER TABLE `verbindungstest`
  MODIFY `Status` tinyint(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `chatverlauf`
--
ALTER TABLE `chatverlauf`
  ADD CONSTRAINT `chatverlauf_ibfk_1` FOREIGN KEY (`EmpfängerID`) REFERENCES `benutzer` (`BenutzerID`),
  ADD CONSTRAINT `chatverlauf_ibfk_2` FOREIGN KEY (`NachrichtenID`) REFERENCES `nachrichten` (`NachrichtenID`);

--
-- Constraints der Tabelle `nachrichten`
--
ALTER TABLE `nachrichten`
  ADD CONSTRAINT `nachrichten_ibfk_1` FOREIGN KEY (`SenderID`) REFERENCES `benutzer` (`BenutzerID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
