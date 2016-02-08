/*
Navicat MySQL Data Transfer

Source Server         : DebianServer
Source Server Version : 50538
Source Host           : 192.168.0.25:3306
Source Database       : bli

Target Server Type    : MYSQL
Target Server Version : 50538
File Encoding         : 65001

Date: 2014-10-07 08:16:41
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `calendarioencintado`
-- ----------------------------
DROP TABLE IF EXISTS `calendarioencintado`;
CREATE TABLE `calendarioencintado` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `year` int(4) NOT NULL,
  `semana` varchar(2) NOT NULL,
  `fechadesde` datetime NOT NULL,
  `fechahasta` datetime NOT NULL,
  `colorencintado` int(11) NOT NULL,
  `colorcosecha` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of calendarioencintado
-- ----------------------------
INSERT INTO `calendarioencintado` VALUES ('6', '2014', '1', '2014-10-01 22:16:51', '2014-10-05 22:16:51', '4', '8');

-- ----------------------------
-- Table structure for `campos`
-- ----------------------------
DROP TABLE IF EXISTS `campos`;
CREATE TABLE `campos` (
  `id_campo` int(11) NOT NULL AUTO_INCREMENT,
  `desc_campo` varchar(50) NOT NULL,
  `areacampo` decimal(9,2) NOT NULL DEFAULT '0.00',
  `areasembrada` decimal(9,2) NOT NULL DEFAULT '0.00',
  `unidad` int(11) NOT NULL,
  PRIMARY KEY (`id_campo`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of campos
-- ----------------------------
INSERT INTO `campos` VALUES ('1', 'CAMPO 1', '64.25', '55.00', '1');
INSERT INTO `campos` VALUES ('2', 'CAMPO 2', '86.00', '60.25', '1');

-- ----------------------------
-- Table structure for `cintas`
-- ----------------------------
DROP TABLE IF EXISTS `cintas`;
CREATE TABLE `cintas` (
  `id_cinta` int(11) NOT NULL AUTO_INCREMENT,
  `color` varchar(50) NOT NULL,
  `rgb` varchar(50) NOT NULL,
  PRIMARY KEY (`id_cinta`),
  UNIQUE KEY `color_UNIQUE` (`color`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of cintas
-- ----------------------------
INSERT INTO `cintas` VALUES ('1', 'ROJA', 'FF0000');
INSERT INTO `cintas` VALUES ('2', 'NEGRA', '000000');
INSERT INTO `cintas` VALUES ('3', 'GRIS', '808080');
INSERT INTO `cintas` VALUES ('4', 'AZUL', '0000FF');
INSERT INTO `cintas` VALUES ('5', 'VERDE', '008000');
INSERT INTO `cintas` VALUES ('6', 'AMARILLA', 'FFFF00');
INSERT INTO `cintas` VALUES ('7', 'MARRON', '800000');
INSERT INTO `cintas` VALUES ('8', 'BLANCA', 'FFFFFF');

-- ----------------------------
-- Table structure for `cosecha`
-- ----------------------------
DROP TABLE IF EXISTS `cosecha`;
CREATE TABLE `cosecha` (
  `id_cosecha` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` datetime NOT NULL,
  `semana` int(2) NOT NULL,
  `estatus` varchar(1) NOT NULL,
  `campo` int(11) NOT NULL,
  `cinta_verde` int(11) NOT NULL,
  `cinta_azul` int(11) NOT NULL,
  `cinta_amarilla` int(11) NOT NULL,
  `cinta_marron` int(11) NOT NULL,
  `cinta_gris` int(11) NOT NULL,
  `cinta_roja` int(11) NOT NULL,
  `cinta_blanca` int(11) NOT NULL,
  `cinta_negra` int(11) NOT NULL,
  `totalcosecha` int(11) NOT NULL,
  PRIMARY KEY (`id_cosecha`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of cosecha
-- ----------------------------

-- ----------------------------
-- Table structure for `embolse`
-- ----------------------------
DROP TABLE IF EXISTS `embolse`;
CREATE TABLE `embolse` (
  `fecha` datetime NOT NULL,
  `semana` int(2) NOT NULL,
  `colorcinta` int(11) NOT NULL,
  `campo` int(11) NOT NULL,
  `cantidadracimos` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of embolse
-- ----------------------------

-- ----------------------------
-- Table structure for `unidadmedidas`
-- ----------------------------
DROP TABLE IF EXISTS `unidadmedidas`;
CREATE TABLE `unidadmedidas` (
  `id_unidad` int(11) NOT NULL AUTO_INCREMENT,
  `desc_unidad` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_unidad`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of unidadmedidas
-- ----------------------------
INSERT INTO `unidadmedidas` VALUES ('1', 'TAREAS');
INSERT INTO `unidadmedidas` VALUES ('2', 'METROS');
INSERT INTO `unidadmedidas` VALUES ('3', 'YARDAS');

-- ----------------------------
-- Table structure for `usuarios`
-- ----------------------------
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(25) NOT NULL,
  `userpassword` varchar(25) NOT NULL,
  `user` varchar(75) NOT NULL,
  `status` bit(1) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of usuarios
-- ----------------------------
