-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Apr 17, 2019 at 11:42 AM
-- Server version: 5.7.25
-- PHP Version: 7.2.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ReactCRM`
--

DELIMITER $$
--
-- Procedures
--
CREATE PROCEDURE `spDeleteUser` (IN `_UserID` INT)  DELETE FROM tbUser WHERE UserID = _UserID$$

CREATE PROCEDURE `spGetUserEmail` ()  SELECT UserEmail FROM tbUser
WHERE `UserStatus` = 1$$

CREATE PROCEDURE `spGetUserID` ()  SELECT UserID FROM tbUser
WHERE `UserStatus` = 1$$

CREATE PROCEDURE `spGetUserInfo` ()  SELECT UserID, UserEmail, UserRegDate FROM tbUser$$

CREATE PROCEDURE `spSignIN` (IN `_UserEmail` VARCHAR(255), IN `_UserPwd` VARCHAR(255))  SELECT * FROM tbUser 
WHERE `UserEmail` = _UserEmail AND `UserPwd` = _UserPwd$$

CREATE PROCEDURE `spSignUp` (IN `_UserID` INT, IN `_UserEmail` VARCHAR(100), IN `_UserPwd` VARCHAR(255))  INSERT INTO tbUser(userEmail, userPwd)
VALUES (_UserEmail,_UserPwd)$$

CREATE PROCEDURE `spUpdateSignIn` (IN `_UserEmail` VARCHAR(255), IN `_UserPwd` VARCHAR(255))  UPDATE tbUser
SET UserStatus = 1
Where `UserEmail` = _UserEmail AND `UserPwd` = _UserPwd$$

CREATE PROCEDURE `spUpdateSignOut` ()  UPDATE tbUser
SET UserStatus = 0
Where `UserStatus` = 1$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tbClient`
--

CREATE TABLE `tbClient` (
  `ClientID` int(11) NOT NULL,
  `Name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Phone` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Institute` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Source` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Pipeline` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `AddDate` date NOT NULL,
  `ContactDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `tbClient`
--

INSERT INTO `tbClient` (`ClientID`, `Name`, `Email`, `Phone`, `Institute`, `Source`, `Pipeline`, `AddDate`, `ContactDate`) VALUES
(1, 'Mike Brown', 'brown@gmail.com', '07416348665', 'CU Coventry', 'Partner', 'Action', '2019-01-01', '2019-01-01'),
(2, 'Jeremy Clarkson', 'clark@gmail.com', '07566421336', 'TGT', 'Referal', 'Decision', '2019-03-10', '2019-03-10'),
(3, 'James May', 'may@yahoo.com', '07412345665', 'TGT', 'Email', 'Action', '2019-02-20', '2019-02-20'),
(4, 'Richard Hammond', 'ham@hotmail.com', '07414189552', 'TGT', 'Call', 'Interest', '2019-04-10', '2019-04-10'),
(5, 'Edward Jones', 'edward@hotmail.com', '07548987445', 'Coventry University', 'Campaign', 'Interest', '2019-01-05', '2019-01-05'),
(6, 'Emily Jones', 'emily@hotmail.com', '07578945366', 'Warwick University', 'WebForm', 'Awareness', '2019-02-10', '2019-02-10'),
(7, 'Grant Hill', 'grant@yahoo.com', '07896614575', 'Birmingham University', 'SocialMedia', 'Decision', '2019-01-26', '2019-01-26'),
(8, 'Carley McLaughlin', 'CarleyMcLaughlin_Jones@gmail.com', '585.740.3784', 'Brakus - Fahey', 'Campaign', 'Awareness', '2019-02-23', '2019-02-24'),
(9, 'Michaela Jerde', 'MichaelaJerde_Stracke@yahoo.com', '(542) 873-3546 x628', 'Langworth - Cassin', 'Campaign', 'Awareness', '2019-04-01', '2019-04-08'),
(10, 'Felix Kautzer', 'FelixKautzer81@hotmail.com', '734-207-3165', 'Ankunding and Sons', 'Email', 'Awareness', '2019-03-13', '2019-03-14'),
(11, 'Amely Nicolas', 'AmelyNicolas28@hotmail.com', '391.408.2991 x5501', 'Kuvalis - Kovacek', 'Referal', 'Awareness', '2019-01-12', '2019-01-16'),
(12, 'Maxime Littel', 'MaximeLittel.Feest14@hotmail.com', '957-853-7821 x8310', 'Mann - Moore', 'Partner', 'Awareness', '2019-03-25', '2019-03-29'),
(13, 'Nicolette Jaskolski', 'NicoletteJaskolski22@gmail.com', '1-411-672-8460 x934', 'Parisian Inc', 'Referal', 'Awareness', '2019-02-02', '2019-02-02'),
(14, 'Maymie Stamm', 'MaymieStamm_Kling@gmail.com', '573-962-2136 x540', 'Ritchie, West and Beer', 'WebForm', 'Awareness', '2019-02-03', '2019-02-03'),
(15, 'Arely Huel', 'ArelyHuel.Schultz84@hotmail.com', '(578) 784-5872 x121', 'Hodkiewicz Group', 'WebForm', 'Awareness', '2019-04-05', '2019-04-11'),
(16, 'Bob Brown', 'able24@qq.com', '04758695335', 'CU Coventry', 'Referal', 'Interest', '2019-04-12', '2019-04-12'),
(17, 'Estell Volkman', 'EstellVolkman_Wunsch@hotmail.com', '353-534-9975', 'Collier - McGlynn', 'Partner', 'Awareness', '2019-04-12', '2019-04-15'),
(18, 'Britney Harber', 'BritneyHarber50@hotmail.com', '1-749-804-5313 x09244', 'Goodwin, Buckridge and Balistreri', 'WebForm', 'Awareness', '2019-03-19', '2019-03-21'),
(19, 'Cara Marquardt', 'CaraMarquardt.Waelchi62@hotmail.com', '1-955-940-0820', 'Abshire Inc', 'Referal', 'Decision', '2019-01-27', '2019-02-04'),
(20, 'Marcus Mitchell', 'MarcusMitchell75@yahoo.com', '(923) 935-6052 x0068', 'Pacocha, Ferry and Franecki', 'WebForm', 'Awareness', '2019-03-21', '2019-03-25'),
(21, 'Ansel Metz', 'AnselMetz47@gmail.com', '986-970-8926 x2813', 'Beier Group', 'WebForm', 'Awareness', '2019-01-08', '2019-01-10'),
(22, 'Shanny Feeney', 'ShannyFeeney.Yundt30@hotmail.com', '543.774.7196 x457', 'McClure, Feil and Dach', 'Call', 'Action', '2019-04-03', '2019-04-07'),
(23, 'Alisa Wiegand', 'AlisaWiegand.Sporer90@gmail.com', '1-970-735-3181 x4192', 'Runolfsdottir, Lind and Nicolas', 'Campaign', 'Interest', '2019-03-18', '2019-03-22'),
(24, 'Caterina Nolan', 'CaterinaNolan91@hotmail.com', '(263) 821-1135 x89002', 'Mueller - O\'Conner', 'Referal', 'Awareness', '2019-04-08', '2019-04-10'),
(25, 'Bert Cartwright', 'BertCartwright_Yost@yahoo.com', '(430) 474-8830', 'Steuber - Kuphal', 'Partner', 'Awareness', '2019-01-08', '2019-01-08'),
(26, 'Raphael Considine', 'RaphaelConsidine88@hotmail.com', '896.757.2741 x12592', 'Kemmer - Leannon', 'Email', 'Awareness', '2019-03-31', '2019-04-05'),
(27, 'London Luettgen', 'LondonLuettgen.Mante24@gmail.com', '843.310.5136 x8943', 'Medhurst - Anderson', 'SocialMedia', 'Awareness', '2019-03-03', '2019-03-04'),
(28, 'Murray Stokes', 'MurrayStokes.Frami@gmail.com', '590.946.3981', 'Funk, Adams and Grant', 'Email', 'Awareness', '2019-02-26', '2019-02-28'),
(29, 'Raven Gibson', 'RavenGibson_Padberg@gmail.com', '702-411-5917 x3684', 'Baumbach, Kiehn and Runolfsson', 'WebForm', 'Awareness', '2019-03-06', '2019-03-12'),
(30, 'Chance Lemke', 'ChanceLemke_Mertz@gmail.com', '342-838-3277 x02385', 'West, Tremblay and Hodkiewicz', 'Call', 'Awareness', '2019-01-14', '2019-01-16'),
(31, 'Maximilian Olson', 'MaximilianOlson53@yahoo.com', '670-799-8446', 'Sawayn LLC', 'Call', 'Awareness', '2019-01-23', '2019-01-30'),
(32, 'Nicholaus Mitchell', 'NicholausMitchell.Hackett70@yahoo.com', '675-807-2761 x3528', 'Ziemann - Kuhlman', 'Partner', 'Awareness', '2019-03-31', '2019-04-09');

-- --------------------------------------------------------

--
-- Table structure for table `tbExpense`
--

CREATE TABLE `tbExpense` (
  `ExpenseID` int(11) NOT NULL,
  `Type` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Amount` decimal(15,3) NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `tbExpense`
--

INSERT INTO `tbExpense` (`ExpenseID`, `Type`, `Amount`, `Date`) VALUES
(1, 'Consultancy Fees', '500.000', '2019-04-05'),
(2, 'Equipment Expenses', '1000.000', '2019-03-10'),
(3, 'Business Insurances', '750.000', '2019-02-10'),
(4, 'Office Expenses', '2500.000', '2019-01-05'),
(5, 'Vehicles Expenses', '250.000', '2019-02-20'),
(6, 'Maintenance Expenses', '873.000', '2019-01-08'),
(7, 'Office Expenses', '1111.000', '2019-02-07'),
(8, 'Business Insurances', '1791.000', '2019-02-22');

-- --------------------------------------------------------

--
-- Table structure for table `tbSale`
--

CREATE TABLE `tbSale` (
  `SaleID` int(11) NOT NULL,
  `Client` int(11) NOT NULL,
  `Product` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Price` decimal(15,3) NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `tbSale`
--

INSERT INTO `tbSale` (`SaleID`, `Client`, `Product`, `Price`, `Date`) VALUES
(1, 1, 'Interactive Timetabling', '1500.000', '2019-04-05'),
(2, 1, 'Automated Timetabling', '1000.000', '2019-03-20'),
(3, 1, 'Attendance Monitoring', '1000.000', '2019-02-10'),
(4, 1, 'Room Booking', '565.000', '2019-01-10'),
(5, 2, 'Consultancy', '500.000', '2019-03-10'),
(6, 5, 'Attendance Monitoring', '2616.000', '2019-02-11'),
(7, 1, 'Automated Timetabling', '2821.000', '2019-01-18'),
(8, 7, 'Automated Timetabling', '4808.000', '2019-02-12'),
(9, 19, 'Consultancy', '2387.000', '2019-04-05'),
(10, 3, 'Interactive Timetabling', '3315.000', '2019-04-03'),
(11, 7, 'Consultancy', '4852.000', '2019-03-19'),
(12, 22, 'Room Booking', '2520.000', '2019-03-13');

-- --------------------------------------------------------

--
-- Table structure for table `tbTicket`
--

CREATE TABLE `tbTicket` (
  `TicketID` int(11) NOT NULL,
  `ClientID` int(11) NOT NULL,
  `Detail` text COLLATE utf8mb4_unicode_ci,
  `Type` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Status` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `ReportDate` datetime NOT NULL,
  `RespondDate` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `tbTicket`
--

INSERT INTO `tbTicket` (`TicketID`, `ClientID`, `Detail`, `Type`, `Status`, `ReportDate`, `RespondDate`) VALUES
(1, 1, 'Veritatis rerum tempora hic sed eos cum iste totam dolores aliquid sed rerum quae odit sed qui maiores culpa laborum atque repellat est animi non facilis.', 'Technical Support', 'Responding', '2019-04-08 00:00:00', '2019-04-08 00:00:00'),
(2, 5, 'Veritatis rerum tempora hic sed eos cum iste totam dolores aliquid sed rerum quae odit sed qui maiores culpa laborum atque repellat est animi non facilis.', 'Technical Support', 'Solved', '2019-01-31 00:00:00', '2019-02-05 00:00:00'),
(3, 5, 'Non aperiam iure praesentium cumque optio iure eveniet et architecto nostrum minus et ratione eos deleniti voluptates animi et soluta nesciunt deserunt sit natus et aut fuga nihil natus iure quaerat magnam aut aut qui ipsum aliquam.', 'Feature Request', 'Responding', '2019-02-21 00:00:00', '2019-02-23 00:00:00'),
(4, 4, 'Nisi odit architecto consequatur distinctio est adipisci ut quia occaecati est et et autem id quis itaque exercitationem a sequi maiores enim aut quis dolor nisi beatae necessitatibus dicta expedita dolorem nihil minus cum ipsa eveniet modi aut ut facilis labore dolorem ipsam veniam et.', 'Feature Request', 'Solved', '2019-01-31 00:00:00', '2019-02-01 00:00:00'),
(5, 3, 'Occaecati eum et quasi ullam repellendus officia voluptatem est nemo illum nam aliquid aliquid quia consequuntur placeat voluptas ratione sapiente qui ipsam repudiandae illum a cupiditate quidem enim iusto tempore quia iusto exercitationem tempore ut ut officiis.', 'Technical Support', 'Unsolved', '2019-02-11 00:00:00', '2019-02-14 00:00:00'),
(6, 3, 'Dolor aperiam id ut quaerat non voluptatem voluptatem necessitatibus suscipit aperiam consequatur reiciendis adipisci ipsam maiores consectetur aspernatur ducimus numquam odit ipsa corrupti possimus officiis praesentium ut tempore dolore cupiditate voluptatem numquam eius nisi consectetur ad quaerat nam repellat perspiciatis est consequatur.', 'Technical_Support', 'Pending', '2019-03-20 00:00:00', '2019-03-22 00:00:00'),
(7, 5, 'Non quo alias autem provident eos dolorum dicta et quis facere unde labore natus eos neque voluptas necessitatibus cupiditate velit fuga in doloribus sed rem et voluptas velit laudantium quia tempora ea quisquam.', 'Bug_Report', 'Pending', '2019-01-20 00:00:00', '2019-01-22 00:00:00'),
(8, 5, 'Voluptatem et molestiae sit quos hic dolor aut sequi ad ex optio odio minus eum est deserunt quod iusto sed accusamus in dolor quod deleniti veniam officia similique quos.', 'Feature_Request', 'Responding', '2019-02-25 00:00:00', '2019-02-26 00:00:00'),
(9, 16, 'Occaecati eum et quasi ullam repellendus officia voluptatem est nemo illum nam aliquid aliquid quia consequuntur placeat voluptas ratione sapiente qui ipsam repudiandae illum a cupiditate quidem enim iusto tempore quia iusto exercitationem tempore ut ut officiis.', 'Bug Report', 'Pending', '2019-04-12 00:00:00', '2019-04-12 00:00:00'),
(10, 23, 'Excepturi iste facere magni debitis voluptatibus dignissimos placeat voluptatem aut animi molestiae similique dolor qui adipisci unde rerum sit inventore maiores quod impedit dolorem fugit et quia facilis libero officia sunt quas consequuntur aspernatur.', 'Order_Status', 'Pending', '2019-04-08 00:00:00', '2019-04-09 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `tbUser`
--

CREATE TABLE `tbUser` (
  `UserID` int(11) NOT NULL,
  `UserEmail` varchar(255) NOT NULL,
  `UserPwd` varchar(255) NOT NULL,
  `UserStatus` int(11) NOT NULL DEFAULT '0',
  `UserRegDate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbUser`
--

INSERT INTO `tbUser` (`UserID`, `UserEmail`, `UserPwd`, `UserStatus`, `UserRegDate`) VALUES
(1, 'able24@qq.com', '999000', 0, '2019-03-11 22:14:10'),
(2, 'admin@gmail.com', 'admin', 0, '2019-03-11 22:15:10'),
(3, 'cuc@coventry.ac.uk', 'cucollege', 0, '2019-03-11 22:16:10');

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewClient`
-- (See below for the actual view)
--
CREATE TABLE `viewClient` (
`ClientID` int(11)
,`Name` varchar(255)
,`Email` varchar(255)
,`Phone` varchar(255)
,`Institute` varchar(255)
,`Source` varchar(255)
,`Pipeline` varchar(255)
,`Value` decimal(37,3)
,`AddDate` date
,`ContactDate` date
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewSale`
-- (See below for the actual view)
--
CREATE TABLE `viewSale` (
`ClientID` int(11)
,`Value` decimal(37,3)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewTicket`
-- (See below for the actual view)
--
CREATE TABLE `viewTicket` (
`TicketID` int(11)
,`ClientID` int(11)
,`Name` varchar(255)
,`Email` varchar(255)
,`Phone` varchar(255)
,`Detail` text
,`Type` varchar(255)
,`Status` varchar(255)
,`ReportDate` datetime
,`RespondDate` datetime
);

-- --------------------------------------------------------

--
-- Structure for view `viewClient`
--
DROP TABLE IF EXISTS `viewClient`;

CREATE ALGORITHM=UNDEFINED DEFINER=`wangh86`@`localhost` SQL SECURITY DEFINER VIEW `viewClient`  AS  select `c`.`ClientID` AS `ClientID`,`c`.`Name` AS `Name`,`c`.`Email` AS `Email`,`c`.`Phone` AS `Phone`,`c`.`Institute` AS `Institute`,`c`.`Source` AS `Source`,`c`.`Pipeline` AS `Pipeline`,`s`.`Value` AS `Value`,`c`.`AddDate` AS `AddDate`,`c`.`ContactDate` AS `ContactDate` from (`tbClient` `c` left join `viewSale` `s` on((`c`.`ClientID` = `s`.`ClientID`))) ;

-- --------------------------------------------------------

--
-- Structure for view `viewSale`
--
DROP TABLE IF EXISTS `viewSale`;

CREATE ALGORITHM=UNDEFINED DEFINER=`wangh86`@`localhost` SQL SECURITY DEFINER VIEW `viewSale`  AS  select `tbSale`.`Client` AS `ClientID`,sum(`tbSale`.`Price`) AS `Value` from `tbSale` group by `tbSale`.`Client` ;

-- --------------------------------------------------------

--
-- Structure for view `viewTicket`
--
DROP TABLE IF EXISTS `viewTicket`;

CREATE ALGORITHM=UNDEFINED DEFINER=`wangh86`@`localhost` SQL SECURITY DEFINER VIEW `viewTicket`  AS  select `t`.`TicketID` AS `TicketID`,`t`.`ClientID` AS `ClientID`,`c`.`Name` AS `Name`,`c`.`Email` AS `Email`,`c`.`Phone` AS `Phone`,`t`.`Detail` AS `Detail`,`t`.`Type` AS `Type`,`t`.`Status` AS `Status`,`t`.`ReportDate` AS `ReportDate`,`t`.`RespondDate` AS `RespondDate` from (`tbTicket` `t` join `tbClient` `c` on((`t`.`ClientID` = `c`.`ClientID`))) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbClient`
--
ALTER TABLE `tbClient`
  ADD PRIMARY KEY (`ClientID`),
  ADD UNIQUE KEY `ClientEmail` (`Email`);

--
-- Indexes for table `tbExpense`
--
ALTER TABLE `tbExpense`
  ADD PRIMARY KEY (`ExpenseID`);

--
-- Indexes for table `tbSale`
--
ALTER TABLE `tbSale`
  ADD PRIMARY KEY (`SaleID`),
  ADD KEY `Client` (`Client`);

--
-- Indexes for table `tbTicket`
--
ALTER TABLE `tbTicket`
  ADD PRIMARY KEY (`TicketID`),
  ADD KEY `tbTicket_ibfk_1` (`ClientID`);

--
-- Indexes for table `tbUser`
--
ALTER TABLE `tbUser`
  ADD PRIMARY KEY (`UserID`),
  ADD UNIQUE KEY `UserEmail` (`UserEmail`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbClient`
--
ALTER TABLE `tbClient`
  MODIFY `ClientID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `tbExpense`
--
ALTER TABLE `tbExpense`
  MODIFY `ExpenseID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tbSale`
--
ALTER TABLE `tbSale`
  MODIFY `SaleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tbTicket`
--
ALTER TABLE `tbTicket`
  MODIFY `TicketID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tbUser`
--
ALTER TABLE `tbUser`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbSale`
--
ALTER TABLE `tbSale`
  ADD CONSTRAINT `tbSale_ibfk_1` FOREIGN KEY (`Client`) REFERENCES `tbClient` (`ClientID`);

--
-- Constraints for table `tbTicket`
--
ALTER TABLE `tbTicket`
  ADD CONSTRAINT `tbTicket_ibfk_1` FOREIGN KEY (`ClientID`) REFERENCES `tbClient` (`ClientID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
