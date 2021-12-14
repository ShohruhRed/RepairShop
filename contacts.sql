-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Дек 14 2021 г., 23:06
-- Версия сервера: 10.4.22-MariaDB
-- Версия PHP: 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `contacts`
--

-- --------------------------------------------------------

--
-- Структура таблицы `admin`
--

CREATE TABLE `admin` (
  `login` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `admin`
--

INSERT INTO `admin` (`login`, `password`) VALUES
('admin', 'admin');

-- --------------------------------------------------------

--
-- Структура таблицы `personal`
--

CREATE TABLE `personal` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Number` varchar(25) NOT NULL,
  `Post` varchar(50) NOT NULL,
  `Subdivision` varchar(50) NOT NULL,
  `Birth` varchar(10) NOT NULL,
  `createdAt` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `personal`
--

INSERT INTO `personal` (`ID`, `Name`, `LastName`, `Email`, `Number`, `Post`, `Subdivision`, `Birth`, `createdAt`) VALUES
(1, 'Iago', 'Van Dijk', 'ivandijk0@hubpages.com', '456-721-3942', 'Construction Manager', 'Research and Development', '1983-02-15', '2021-12-14 21:39:44'),
(2, 'Том', 'Круз', 'tcrouse@gmail.com', '+9612345698', '', '', '', '2021-12-11 21:54:41'),
(3, 'Джонни9', 'Деп', 'jd@gmail.com1', '+12357999998', '', '', '', '2021-12-11 23:14:20'),
(4, 'Ezechiel', 'Rewbottom', 'erewbottom3@blinklist.com', '914-433-6796', 'Construction Foreman', 'Services', '1984-11-24', '2021-12-14 21:39:44'),
(5, 'REds', 'asdasdasd', '111', '9999', '', 'dfx', '1998', '2021-12-11 23:14:49'),
(6, 'ShohruhRed', 'Red', '!qwert@.com', '+999989000', '', '', '', '2021-12-11 23:36:33'),
(7, 'Джон', 'Уик', 'jw@.mail.ru', 'q123123222', '', '', '', '2021-12-12 23:21:05'),
(8, 'Marleen', 'Ibbett', 'mibbett7@europa.eu', '357-919-0894', 'Engineer', 'Sales', '1998-06-18', '2021-12-14 21:39:44'),
(9, 'Muslim', 'Boltaev', 'muslim444@mail.ru', '+3752571111111', '', '', '', '2021-12-14 20:09:13'),
(11, 'Janean', 'Ackenson', 'jackensona@arizona.edu', '726-466-5639', 'Construction Expeditor', 'Accounting', '1994-07-26', '2021-12-14 21:39:44'),
(12, 'Ursula', 'Bambrough', 'ubambroughb@technorati.com', '322-208-6186', 'Subcontractor', 'Sales', '1990-04-06', '2021-12-14 21:39:44'),
(13, 'Kerrie', 'Bordessa', 'kbordessac@privacy.gov.au', '632-856-5183', 'Project Manager', 'Training', '1998-09-05', '2021-12-14 21:39:44'),
(14, 'Torey', 'Beazey', 'tbeazeyd@oracle.com', '531-900-7997', 'Project Manager', 'Engineering', '1998-01-25', '2021-12-14 21:39:44'),
(15, 'Lorine', 'Fend', 'lfende@hugedomains.com', '887-697-6881', 'Supervisor', 'Services', '1985-02-21', '2021-12-14 21:39:44'),
(16, 'Dana', 'Giuron', 'dgiuronf@china.com.cn', '408-688-6324', 'Architect', 'Training', '1987-08-28', '2021-12-14 21:39:44'),
(17, 'Gena', 'Domaschke', 'gdomaschkeg@jiathis.com', '968-173-5030', 'Construction Manager', 'Human Resources', '1990-07-12', '2021-12-14 21:39:44'),
(18, 'Rowen', 'Burkin', 'rburkinh@studiopress.com', '293-397-6595', 'Construction Foreman', 'Training', '1985-05-31', '2021-12-14 21:39:44'),
(19, 'Ferd', 'Meharry', 'fmeharryi@ox.ac.uk', '467-937-8757', 'Engineer', 'Sales', '1996-10-24', '2021-12-14 21:39:44'),
(20, 'Tiebold', 'Eades', 'teadesj@geocities.jp', '807-333-4981', 'Subcontractor', 'Accounting', '1988-06-30', '2021-12-14 21:39:44'),
(21, 'Deborah', 'Tappington', 'dtappingtonk@behance.net', '338-383-9484', 'Surveyor', 'Sales', '1983-06-02', '2021-12-14 21:39:44'),
(22, 'Maye', 'Kerbey', 'mkerbeyl@bloglines.com', '171-688-6221', 'Architect', 'Marketing', '1988-02-11', '2021-12-14 21:39:44'),
(23, 'Lacey', 'House', 'lhousem@wp.com', '852-506-4204', 'Construction Foreman', 'Sales', '1999-10-22', '2021-12-14 21:39:44'),
(24, 'Rhys', 'Taylerson', 'rtaylersonn@wufoo.com', '293-276-2355', 'Engineer', 'Business Development', '1991-12-23', '2021-12-14 21:39:44'),
(25, 'Carita', 'Dillon', 'cdillono@mozilla.org', '330-424-5184', 'Engineer', 'Product Management', '1984-12-05', '2021-12-14 21:39:44'),
(26, 'Darbee', 'Horche', 'dhorchep@examiner.com', '972-787-6968', 'Surveyor', 'Engineering', '1991-12-31', '2021-12-14 21:39:44'),
(27, 'Ronda', 'Coggin', 'rcogginq@i2i.jp', '261-173-9593', 'Construction Expeditor', 'Support', '1990-04-15', '2021-12-14 21:39:44'),
(28, 'Eloisa', 'Whyteman', 'ewhytemanr@drupal.org', '975-129-3511', 'Construction Manager', 'Services', '1996-03-04', '2021-12-14 21:39:44'),
(29, 'Blake', 'Challiss', 'bchallisss@drupal.org', '869-899-3352', 'Surveyor', 'Legal', '1999-12-23', '2021-12-14 21:39:45'),
(30, 'Benedikta', 'Jori', 'bjorit@bigcartel.com', '377-391-9527', 'Engineer', 'Product Management', '1997-07-22', '2021-12-14 21:39:45'),
(31, 'Allie', 'Stubbs', 'astubbsu@hexun.com', '731-510-1998', 'Construction Manager', 'Training', '1991-09-14', '2021-12-14 21:39:45'),
(32, 'Levi', 'MacGillicuddy', 'lmacgillicuddyv@bloomberg.com', '583-131-5320', 'Supervisor', 'Research and Development', '1989-05-20', '2021-12-14 21:39:45'),
(33, 'Tiphany', 'Tiffin', 'ttiffinw@marriott.com', '693-707-9414', 'Supervisor', 'Product Management', '1994-01-26', '2021-12-14 21:39:45'),
(34, 'Aliza', 'Wem', 'awemx@booking.com', '445-515-9419', 'Subcontractor', 'Legal', '1993-01-01', '2021-12-14 21:39:45'),
(35, 'Gleda', 'Strick', 'gstricky@chronoengine.com', '932-345-4306', 'Subcontractor', 'Accounting', '1986-05-20', '2021-12-14 21:39:45'),
(36, 'Arny', 'Oxtaby', 'aoxtabyz@360.cn', '590-991-2625', 'Construction Worker', 'Research and Development', '1987-11-17', '2021-12-14 21:39:45'),
(37, 'Audrie', 'Capelin', 'acapelin10@tamu.edu', '708-959-7607', 'Project Manager', 'Accounting', '1989-01-14', '2021-12-14 21:39:45'),
(38, 'Ashli', 'Fearnyough', 'afearnyough11@zdnet.com', '916-965-9639', 'Construction Worker', 'Research and Development', '2000-03-26', '2021-12-14 21:39:45'),
(39, 'Esmeralda', 'Hanshawe', 'ehanshawe12@japanpost.jp', '368-192-8959', 'Construction Foreman', 'Engineering', '1986-03-19', '2021-12-14 21:39:45'),
(40, 'Ara', 'Philps', 'aphilps13@cbslocal.com', '671-988-7825', 'Surveyor', 'Human Resources', '1998-09-15', '2021-12-14 21:39:45'),
(41, 'Charmain', 'Pattemore', 'cpattemore14@google.ru', '508-489-8561', 'Construction Foreman', 'Business Development', '1995-07-02', '2021-12-14 21:39:45'),
(42, 'Carolee', 'Fideler', 'cfideler15@topsy.com', '434-168-6717', 'Construction Foreman', 'Marketing', '1986-10-09', '2021-12-14 21:39:45'),
(43, 'Karlen', 'Chappelle', 'kchappelle16@statcounter.com', '269-814-7266', 'Electrician', 'Sales', '1989-10-01', '2021-12-14 21:39:45'),
(44, 'Ravi', 'Randal', 'rrandal17@joomla.org', '803-803-5637', 'Project Manager', 'Sales', '1995-09-06', '2021-12-14 21:39:45'),
(45, 'Corny', 'Wrangle', 'cwrangle18@homestead.com', '635-148-5697', 'Construction Manager', 'Marketing', '1992-09-23', '2021-12-14 21:39:45'),
(46, 'Larry', 'Brookson', 'lbrookson19@cbc.ca', '641-625-9606', 'Subcontractor', 'Services', '1981-07-20', '2021-12-14 21:39:45'),
(47, 'Zena', 'Strickett', 'zstrickett1a@instagram.com', '181-421-0902', 'Project Manager', 'Marketing', '1991-10-13', '2021-12-14 21:39:45'),
(48, 'Jodi', 'Casoni', 'jcasoni1b@upenn.edu', '173-952-7424', 'Project Manager', 'Training', '1988-06-24', '2021-12-14 21:39:45'),
(49, 'Mick', 'Vernazza', 'mvernazza1c@desdev.cn', '795-843-0527', 'Subcontractor', 'Services', '1983-11-21', '2021-12-14 21:39:45'),
(50, 'Thayne', 'Sigg', 'tsigg1d@oakley.com', '209-718-4140', 'Estimator', 'Marketing', '1992-01-05', '2021-12-14 21:39:45'),
(51, 'Corabelle', 'Kellegher', 'ckellegher0@bing.com', '628-393-5947', 'Construction Worker', 'Engineering', '1982-06-01', '2021-12-14 21:40:56'),
(52, 'Melody', 'Baelde', 'mbaelde1@webeden.co.uk', '327-913-7365', 'Construction Manager', 'Legal', '1990-03-14', '2021-12-14 21:40:56'),
(53, 'Casie', 'Judkins', 'cjudkins2@salon.com', '716-882-3744', 'Construction Foreman', 'Marketing', '1997-07-23', '2021-12-14 21:40:56'),
(54, 'Nedi', 'Delort', 'ndelort3@ifeng.com', '530-150-8845', 'Construction Foreman', 'Marketing', '1991-02-04', '2021-12-14 21:40:56'),
(55, 'Engracia', 'Sperling', 'esperling4@ftc.gov', '649-102-4500', 'Construction Foreman', 'Training', '1997-04-06', '2021-12-14 21:40:56'),
(56, 'Rhys', 'Liepins', 'rliepins5@utexas.edu', '708-977-8281', 'Surveyor', 'Business Development', '1982-09-27', '2021-12-14 21:40:56'),
(57, 'Margy', 'Brooking', 'mbrooking6@digg.com', '992-540-1451', 'Surveyor', 'Legal', '1981-04-20', '2021-12-14 21:40:56'),
(58, 'Merrily', 'Ravenscraft', 'mravenscraft7@java.com', '422-126-6202', 'Subcontractor', 'Sales', '1995-09-20', '2021-12-14 21:40:56'),
(59, 'Hollyanne', 'Munnery', 'hmunnery8@reddit.com', '139-686-3655', 'Supervisor', 'Accounting', '1998-06-05', '2021-12-14 21:40:56'),
(60, 'Percival', 'Wonham', 'pwonham9@mapy.cz', '326-553-2173', 'Architect', 'Support', '1995-01-05', '2021-12-14 21:40:56'),
(61, 'Shelby', 'Muglestone', 'smuglestonea@archive.org', '442-269-7097', 'Engineer', 'Marketing', '1995-11-08', '2021-12-14 21:40:56'),
(62, 'Linnell', 'Haborn', 'lhabornb@acquirethisname.com', '935-836-4290', 'Subcontractor', 'Sales', '1984-12-23', '2021-12-14 21:40:56'),
(63, 'Ortensia', 'Hicklingbottom', 'ohicklingbottomc@webs.com', '901-116-7920', 'Architect', 'Product Management', '1982-10-01', '2021-12-14 21:40:56'),
(64, 'Klarika', 'Coskerry', 'kcoskerryd@tiny.cc', '730-624-0269', 'Surveyor', 'Product Management', '1997-11-26', '2021-12-14 21:40:56'),
(65, 'Gus', 'Cox', 'gcoxe@creativecommons.org', '854-232-9215', 'Architect', 'Engineering', '1995-01-02', '2021-12-14 21:40:56'),
(66, 'Basil', 'Kenaway', 'bkenawayf@mail.ru', '585-157-3581', 'Construction Manager', 'Product Management', '1992-02-01', '2021-12-14 21:40:56'),
(67, 'Noak', 'Davison', 'ndavisong@phpbb.com', '464-714-0097', 'Architect', 'Engineering', '1996-07-21', '2021-12-14 21:40:56'),
(68, 'Amalea', 'Penquet', 'apenqueth@rakuten.co.jp', '831-221-9329', 'Supervisor', 'Product Management', '1998-04-19', '2021-12-14 21:40:56'),
(69, 'Myer', 'Cail', 'mcaili@ask.com', '199-194-5640', 'Estimator', 'Marketing', '1993-08-05', '2021-12-14 21:40:56'),
(70, 'Shawnee', 'Benardet', 'sbenardetj@wordpress.com', '450-331-5434', 'Construction Manager', 'Marketing', '1989-04-19', '2021-12-14 21:40:56'),
(71, 'Ruttger', 'Clark', 'rclarkk@xrea.com', '279-421-7856', 'Construction Worker', 'Accounting', '1982-12-23', '2021-12-14 21:40:56'),
(72, 'Batholomew', 'Hawksworth', 'bhawksworthl@topsy.com', '708-710-4913', 'Estimator', 'Training', '1987-01-31', '2021-12-14 21:40:56'),
(73, 'Alexia', 'Cambridge', 'acambridgem@slate.com', '722-750-4307', 'Subcontractor', 'Accounting', '1985-02-21', '2021-12-14 21:40:56'),
(74, 'Isadore', 'Gigg', 'igiggn@noaa.gov', '352-288-6559', 'Subcontractor', 'Training', '1987-04-11', '2021-12-14 21:40:56'),
(75, 'Leslie', 'Danahar', 'ldanaharo@who.int', '593-107-7553', 'Architect', 'Services', '1981-12-25', '2021-12-14 21:40:56'),
(76, 'Meagan', 'Walbrook', 'mwalbrookp@accuweather.com', '410-482-3170', 'Supervisor', 'Legal', '1985-07-18', '2021-12-14 21:40:56'),
(77, 'Emelita', 'Kennon', 'ekennonq@rakuten.co.jp', '924-185-6345', 'Engineer', 'Engineering', '1992-10-03', '2021-12-14 21:40:56'),
(78, 'Tan', 'Scawton', 'tscawtonr@meetup.com', '436-400-4189', 'Construction Expeditor', 'Training', '1995-02-28', '2021-12-14 21:40:56'),
(79, 'Konstantine', 'Lummasana', 'klummasanas@jugem.jp', '468-926-4507', 'Estimator', 'Support', '1981-03-10', '2021-12-14 21:40:56'),
(80, 'Jehu', 'Coggeshall', 'jcoggeshallt@chron.com', '928-410-2086', 'Engineer', 'Training', '1993-04-07', '2021-12-14 21:40:56'),
(81, 'Pietro', 'McDyer', 'pmcdyeru@unblog.fr', '144-333-3193', 'Architect', 'Training', '1987-10-12', '2021-12-14 21:40:56'),
(82, 'Stefania', 'Curness', 'scurnessv@wp.com', '264-662-6844', 'Architect', 'Marketing', '1986-08-22', '2021-12-14 21:40:56'),
(83, 'Gibby', 'Scarce', 'gscarcew@desdev.cn', '179-244-6242', 'Subcontractor', 'Sales', '1996-03-28', '2021-12-14 21:40:56'),
(84, 'Candy', 'McQuin', 'cmcquinx@sciencedirect.com', '130-960-5535', 'Subcontractor', 'Human Resources', '1999-12-03', '2021-12-14 21:40:56'),
(85, 'Adelheid', 'Christofor', 'achristofory@gravatar.com', '800-705-2203', 'Construction Expeditor', 'Legal', '1997-09-15', '2021-12-14 21:40:56'),
(86, 'Lynnet', 'Rushbrooke', 'lrushbrookez@unblog.fr', '959-987-3857', 'Electrician', 'Legal', '1999-09-30', '2021-12-14 21:40:56'),
(87, 'Gabriella', 'Server', 'gserver10@nydailynews.com', '411-805-4743', 'Project Manager', 'Support', '1993-05-29', '2021-12-14 21:40:56'),
(88, 'Cal', 'Tufts', 'ctufts11@tamu.edu', '221-402-7399', 'Construction Foreman', 'Human Resources', '1991-11-21', '2021-12-14 21:40:56'),
(89, 'Colette', 'Slay', 'cslay12@indiatimes.com', '722-273-2920', 'Estimator', 'Marketing', '1999-01-09', '2021-12-14 21:40:56'),
(90, 'Candis', 'Hazell', 'chazell13@ehow.com', '743-314-1931', 'Architect', 'Human Resources', '1984-10-23', '2021-12-14 21:40:56'),
(91, 'Maurizia', 'Fowlston', 'mfowlston14@shinystat.com', '260-876-2432', 'Construction Foreman', 'Product Management', '1992-01-10', '2021-12-14 21:40:56'),
(92, 'Gus', 'Hawyes', 'ghawyes15@reference.com', '426-741-0370', 'Architect', 'Accounting', '1985-01-20', '2021-12-14 21:40:56'),
(93, 'Chere', 'Finlow', 'cfinlow16@alexa.com', '477-216-4823', 'Construction Manager', 'Accounting', '1997-11-25', '2021-12-14 21:40:56'),
(94, 'Kendrick', 'Sivier', 'ksivier17@xrea.com', '199-981-2381', 'Estimator', 'Services', '1994-08-21', '2021-12-14 21:40:56'),
(95, 'Ode', 'Cavanagh', 'ocavanagh18@yandex.ru', '495-984-6873', 'Construction Expeditor', 'Support', '1993-11-10', '2021-12-14 21:40:56'),
(96, 'Shelli', 'Geerits', 'sgeerits19@fotki.com', '952-643-4388', 'Project Manager', 'Legal', '1996-04-16', '2021-12-14 21:40:56'),
(97, 'Ruthann', 'McGifford', 'rmcgifford1a@mail.ru', '513-285-0349', 'Subcontractor', 'Human Resources', '1994-09-02', '2021-12-14 21:40:56'),
(98, 'Donnell', 'Veryard', 'dveryard1b@gov.uk', '557-250-6602', 'Construction Foreman', 'Business Development', '1984-07-31', '2021-12-14 21:40:56'),
(99, 'Janith', 'Bess', 'jbess1c@umich.edu', '286-678-8861', 'Engineer', 'Marketing', '1989-04-12', '2021-12-14 21:40:56'),
(100, 'Barby', 'Extall', 'bextall1d@theatlantic.com', '199-264-0169', 'Supervisor', 'Business Development', '1996-05-21', '2021-12-14 21:40:56'),
(101, 'WAyne', 'Rooney', 'wrooney@gmail.com', '+998866666', 'Тренер', 'Менеджер', '1986', '2021-12-14 21:51:58');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `personal`
--
ALTER TABLE `personal`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `personal`
--
ALTER TABLE `personal`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=102;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
