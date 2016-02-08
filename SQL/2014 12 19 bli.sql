/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : bli

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2014-12-19 22:42:35
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
  `fechadesde` date NOT NULL,
  `fechahasta` date NOT NULL,
  `colorencintado` varchar(50) NOT NULL,
  `colorcosecha` varchar(50) NOT NULL,
  `sem10` varchar(50) NOT NULL,
  `sem11` varchar(50) NOT NULL,
  `sem12` varchar(50) NOT NULL,
  `sem13` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of calendarioencintado
-- ----------------------------
INSERT INTO `calendarioencintado` VALUES ('15', '2014', '45', '2014-11-17', '2014-11-23', 'AMARILLA', 'AZUL', 'BLANCA', 'GRIS', 'MARRON', 'MARRON');
INSERT INTO `calendarioencintado` VALUES ('16', '2014', '16', '2014-11-24', '2014-11-23', 'BLANCA', 'GRIS', 'NEGRA', 'ROJA', 'AZUL', 'VERDE');

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
  `lineas` int(11) NOT NULL,
  `plantas` int(11) NOT NULL,
  `aspersores` int(11) NOT NULL,
  `mangueras` int(11) NOT NULL,
  PRIMARY KEY (`id_campo`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of campos
-- ----------------------------
INSERT INTO `campos` VALUES ('1', 'CAMPO 1', '64.25', '55.00', '1', '73', '3815', '463', '48');
INSERT INTO `campos` VALUES ('2', 'CAMPO 2', '89.00', '55.00', '1', '145', '7403', '903', '97');
INSERT INTO `campos` VALUES ('3', 'CAMPO 3', '0.00', '0.00', '1', '113', '8038', '782', '67');
INSERT INTO `campos` VALUES ('4', 'CAMPO 4', '0.00', '0.00', '1', '0', '0', '0', '0');
INSERT INTO `campos` VALUES ('5', 'CAMPO 5', '0.00', '0.00', '1', '45', '2507', '228', '24');
INSERT INTO `campos` VALUES ('6', 'CAMPO 6', '0.00', '0.00', '1', '80', '84', '13', '1');
INSERT INTO `campos` VALUES ('7', 'CAMPO 7', '0.00', '0.00', '1', '93', '7733', '783', '76');
INSERT INTO `campos` VALUES ('8', 'CAMPO 8', '0.00', '0.00', '1', '57', '3713', '406', '36');

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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

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
INSERT INTO `cintas` VALUES ('9', 'SIN CINTA', 'none');

-- ----------------------------
-- Table structure for `cosecha`
-- ----------------------------
DROP TABLE IF EXISTS `cosecha`;
CREATE TABLE `cosecha` (
  `idcosecha` int(11) NOT NULL AUTO_INCREMENT,
  `fechacorte` date NOT NULL,
  `semana` int(11) NOT NULL,
  `campo` int(11) NOT NULL,
  `cinta_verde` int(11) NOT NULL,
  `cinta_azul` int(11) NOT NULL,
  `cinta_amarilla` int(11) NOT NULL,
  `cinta_marron` int(11) NOT NULL,
  `cinta_gris` int(11) NOT NULL,
  `cinta_roja` int(11) NOT NULL,
  `cinta_blanca` int(11) NOT NULL,
  `cinta_negra` int(11) NOT NULL,
  `cantidadtotal` int(11) NOT NULL,
  `cantidadrechazos` int(11) NOT NULL,
  `cinta_verdeR` int(11) NOT NULL,
  `cinta_azulR` int(11) NOT NULL,
  `cinta_amarillaR` int(11) NOT NULL,
  `cinta_marronR` int(11) NOT NULL,
  `cinta_grisR` int(11) NOT NULL,
  `cinta_rojaR` int(11) NOT NULL,
  `cinta_blancaR` int(11) NOT NULL,
  `cinta_negraR` int(11) NOT NULL,
  PRIMARY KEY (`idcosecha`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of cosecha
-- ----------------------------
INSERT INTO `cosecha` VALUES ('1', '2014-11-14', '15', '2', '12', '14', '25', '0', '0', '0', '19', '44', '114', '15', '0', '1', '13', '0', '1', '0', '0', '0');
INSERT INTO `cosecha` VALUES ('2', '2014-12-19', '50', '1', '25', '64', '32', '8', '0', '128', '0', '211', '468', '42', '0', '0', '0', '5', '0', '12', '0', '25');

-- ----------------------------
-- Table structure for `embolse`
-- ----------------------------
DROP TABLE IF EXISTS `embolse`;
CREATE TABLE `embolse` (
  `fecha` date NOT NULL,
  `semana` int(2) NOT NULL,
  `colorcinta` int(11) NOT NULL,
  `campo` int(11) NOT NULL,
  `cantidadracimos` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of embolse
-- ----------------------------
INSERT INTO `embolse` VALUES ('2014-10-02', '1', '4', '1', '12');
INSERT INTO `embolse` VALUES ('2014-10-04', '1', '4', '1', '456');
INSERT INTO `embolse` VALUES ('2014-10-03', '1', '4', '1', '125');
INSERT INTO `embolse` VALUES ('2014-10-03', '1', '4', '2', '125');
INSERT INTO `embolse` VALUES ('2014-10-03', '1', '4', '1', '300');
INSERT INTO `embolse` VALUES ('2014-10-03', '1', '4', '2', '245');
INSERT INTO `embolse` VALUES ('2014-10-02', '1', '4', '1', '45');
INSERT INTO `embolse` VALUES ('2014-10-02', '1', '4', '2', '54');
INSERT INTO `embolse` VALUES ('2014-11-11', '25', '6', '1', '34');
INSERT INTO `embolse` VALUES ('2014-11-11', '25', '6', '2', '65');

-- ----------------------------
-- Table structure for `insumos`
-- ----------------------------
DROP TABLE IF EXISTS `insumos`;
CREATE TABLE `insumos` (
  `insumos_id` int(11) NOT NULL AUTO_INCREMENT,
  `insumos_descripcion` varchar(100) NOT NULL,
  `insumos_unidadmedida` int(11) NOT NULL,
  PRIMARY KEY (`insumos_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of insumos
-- ----------------------------

-- ----------------------------
-- Table structure for `registroinsumos`
-- ----------------------------
DROP TABLE IF EXISTS `registroinsumos`;
CREATE TABLE `registroinsumos` (
  `idregistroinsumos` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date NOT NULL,
  `campo` int(11) NOT NULL,
  `detalle` int(11) NOT NULL,
  `cantidad` decimal(10,0) NOT NULL,
  PRIMARY KEY (`idregistroinsumos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of registroinsumos
-- ----------------------------

-- ----------------------------
-- Table structure for `registro_exportacion`
-- ----------------------------
DROP TABLE IF EXISTS `registro_exportacion`;
CREATE TABLE `registro_exportacion` (
  `idregistro` int(11) NOT NULL AUTO_INCREMENT,
  `paletas` int(11) NOT NULL,
  `libras` int(11) NOT NULL,
  `cajas` int(11) NOT NULL,
  `racimos` int(11) NOT NULL,
  `venta` decimal(9,2) NOT NULL,
  `vendidoa` varchar(50) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`idregistro`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of registro_exportacion
-- ----------------------------
INSERT INTO `registro_exportacion` VALUES ('1', '10', '20160', '480', '956', '7.60', 'PLANTACIONES DEL NORTE', '2014-09-17');
INSERT INTO `registro_exportacion` VALUES ('2', '12', '25980', '432', '254', '9.00', 'Plantaciones del Norte', '2014-12-19');

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
