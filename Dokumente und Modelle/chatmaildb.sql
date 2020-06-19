-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 17. Apr 2020 um 12:13
-- Server-Version: 10.4.11-MariaDB
-- PHP-Version: 7.2.29

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
(8, 'Dieter Bohlen');

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
(2, 1),
(2, 7),
(7, 1),
(8, 1);

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
(1, 'Hallo Welt!', '2020-04-17 09:01:48', 1),
(4, 'Hello World', '2020-04-17 09:24:24', 2),
(7, 'Hi', '2020-04-17 09:24:26', 8);

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
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `benutzer`
--
ALTER TABLE `benutzer`
  MODIFY `BenutzerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT für Tabelle `nachrichten`
--
ALTER TABLE `nachrichten`
  MODIFY `NachrichtenID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

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
