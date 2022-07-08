-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Июл 08 2022 г., 10:20
-- Версия сервера: 5.5.25
-- Версия PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `rosatomlogistics`
--

-- --------------------------------------------------------

--
-- Структура таблицы `заказчик`
--

CREATE TABLE IF NOT EXISTS `заказчик` (
  `Номер заявки` int(10) NOT NULL,
  `Наименование` varchar(255) NOT NULL,
  `Адрес точки отправления` varchar(255) NOT NULL,
  `ИНН` int(11) NOT NULL,
  `Ответственный` varchar(255) NOT NULL,
  `Телефон` varchar(11) NOT NULL,
  `E-mail` varchar(50) NOT NULL,
  `Дата и время отправления` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `заявка`
--

CREATE TABLE IF NOT EXISTS `заявка` (
  `Номер заявки` int(10) NOT NULL AUTO_INCREMENT,
  `Дата заявки` date NOT NULL,
  PRIMARY KEY (`Номер заявки`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Структура таблицы `получатель`
--

CREATE TABLE IF NOT EXISTS `получатель` (
  `Номер заявки` int(10) NOT NULL,
  `Наименование` varchar(255) NOT NULL,
  `Адрес точки получения` varchar(255) NOT NULL,
  `Ответственный` varchar(255) NOT NULL,
  `Телефон` varchar(11) NOT NULL,
  `Дата и время прибытия` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `спецификация заявки`
--

CREATE TABLE IF NOT EXISTS `спецификация заявки` (
  `Номер заявки` int(10) NOT NULL,
  `Наименование` varchar(255) NOT NULL,
  `Кол-во` int(16) NOT NULL,
  `Вес, кг` float NOT NULL,
  `Объем, м3` float NOT NULL,
  `Особые требования` varchar(255) NOT NULL DEFAULT 'Нет'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
