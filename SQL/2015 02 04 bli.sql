/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : bli

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2015-02-04 23:10:17
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `calendarioencintado`
-- ----------------------------
DROP TABLE IF EXISTS `calendarioencintado`;
CREATE TABLE `calendarioencintado` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `year` int(4) NOT NULL DEFAULT '0',
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
) ENGINE=InnoDB AUTO_INCREMENT=71 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of calendarioencintado
-- ----------------------------
INSERT INTO `calendarioencintado` VALUES ('15', '2014', '45', '2014-11-17', '2014-11-23', 'AMARILLA', 'AZUL', 'BLANCA', 'GRIS', 'MARRON', 'MARRON');
INSERT INTO `calendarioencintado` VALUES ('16', '2014', '16', '2014-11-24', '2014-11-23', 'BLANCA', 'GRIS', 'NEGRA', 'ROJA', 'AZUL', 'VERDE');
INSERT INTO `calendarioencintado` VALUES ('17', '2014', '52', '2014-12-22', '2014-12-28', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE');
INSERT INTO `calendarioencintado` VALUES ('18', '2015', '1', '2014-12-29', '2015-01-04', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA');
INSERT INTO `calendarioencintado` VALUES ('19', '2015', '2', '2015-01-05', '2015-01-11', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON');
INSERT INTO `calendarioencintado` VALUES ('20', '2015', '3', '2015-01-12', '2015-01-18', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA');
INSERT INTO `calendarioencintado` VALUES ('21', '2015', '4', '2015-01-19', '2015-01-25', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA');
INSERT INTO `calendarioencintado` VALUES ('22', '2015', '5', '2015-01-26', '2015-02-01', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA');
INSERT INTO `calendarioencintado` VALUES ('23', '2015', '6', '2015-02-02', '2015-02-08', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS');
INSERT INTO `calendarioencintado` VALUES ('24', '2015', '7', '2015-02-09', '2015-02-15', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL');
INSERT INTO `calendarioencintado` VALUES ('25', '2015', '8', '2015-02-16', '2015-02-22', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE');
INSERT INTO `calendarioencintado` VALUES ('26', '2015', '9', '2015-02-23', '2015-03-01', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA');
INSERT INTO `calendarioencintado` VALUES ('27', '2015', '10', '2015-03-02', '2015-03-08', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON');
INSERT INTO `calendarioencintado` VALUES ('28', '2015', '11', '2015-03-09', '2015-03-15', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA');
INSERT INTO `calendarioencintado` VALUES ('29', '2015', '12', '2015-03-16', '2015-03-22', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA');
INSERT INTO `calendarioencintado` VALUES ('30', '2015', '13', '2015-03-23', '2015-03-29', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA');
INSERT INTO `calendarioencintado` VALUES ('31', '2015', '14', '2015-03-30', '2015-04-05', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS');
INSERT INTO `calendarioencintado` VALUES ('32', '2015', '15', '2015-04-06', '2015-04-12', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL');
INSERT INTO `calendarioencintado` VALUES ('33', '2015', '16', '2015-04-13', '2015-04-19', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE');
INSERT INTO `calendarioencintado` VALUES ('34', '2015', '17', '2015-04-20', '2015-04-26', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA');
INSERT INTO `calendarioencintado` VALUES ('35', '2015', '18', '2015-04-27', '2015-05-03', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON');
INSERT INTO `calendarioencintado` VALUES ('36', '2015', '19', '2015-05-04', '2015-05-10', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA');
INSERT INTO `calendarioencintado` VALUES ('37', '2015', '20', '2015-05-11', '2015-05-17', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA');
INSERT INTO `calendarioencintado` VALUES ('38', '2015', '21', '2015-05-18', '2015-05-24', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA');
INSERT INTO `calendarioencintado` VALUES ('39', '2015', '22', '2015-05-25', '2015-05-31', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS');
INSERT INTO `calendarioencintado` VALUES ('40', '2015', '23', '2015-06-01', '2015-06-07', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL');
INSERT INTO `calendarioencintado` VALUES ('41', '2015', '24', '2015-06-08', '2015-06-14', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE');
INSERT INTO `calendarioencintado` VALUES ('42', '2015', '25', '2015-06-15', '2015-06-21', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA');
INSERT INTO `calendarioencintado` VALUES ('43', '2015', '26', '2015-06-22', '2015-06-28', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON');
INSERT INTO `calendarioencintado` VALUES ('44', '2015', '27', '2015-06-29', '2015-07-05', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA');
INSERT INTO `calendarioencintado` VALUES ('45', '2015', '28', '2015-07-06', '2015-07-12', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA');
INSERT INTO `calendarioencintado` VALUES ('46', '2015', '29', '2015-07-13', '2015-07-19', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA');
INSERT INTO `calendarioencintado` VALUES ('47', '2015', '30', '2015-07-20', '2015-07-26', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS');
INSERT INTO `calendarioencintado` VALUES ('48', '2015', '31', '2015-07-27', '2015-08-02', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL');
INSERT INTO `calendarioencintado` VALUES ('49', '2015', '32', '2015-08-03', '2015-08-09', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE');
INSERT INTO `calendarioencintado` VALUES ('50', '2015', '33', '2015-08-10', '2015-08-16', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA');
INSERT INTO `calendarioencintado` VALUES ('51', '2015', '34', '2015-08-17', '2015-08-23', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON');
INSERT INTO `calendarioencintado` VALUES ('52', '2015', '35', '2015-08-24', '2015-08-30', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA');
INSERT INTO `calendarioencintado` VALUES ('53', '2015', '36', '2015-08-31', '2015-09-06', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA');
INSERT INTO `calendarioencintado` VALUES ('54', '2015', '37', '2015-09-07', '2015-09-13', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA');
INSERT INTO `calendarioencintado` VALUES ('55', '2015', '38', '2015-09-14', '2015-09-20', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS');
INSERT INTO `calendarioencintado` VALUES ('56', '2015', '39', '2015-09-21', '2015-09-27', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL');
INSERT INTO `calendarioencintado` VALUES ('57', '2015', '40', '2015-09-28', '2015-10-04', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE');
INSERT INTO `calendarioencintado` VALUES ('58', '2015', '41', '2015-10-05', '2015-10-11', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA');
INSERT INTO `calendarioencintado` VALUES ('59', '2015', '42', '2015-10-12', '2015-10-18', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON');
INSERT INTO `calendarioencintado` VALUES ('60', '2015', '43', '2015-10-19', '2015-10-25', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA');
INSERT INTO `calendarioencintado` VALUES ('61', '2015', '44', '2015-10-26', '2015-11-01', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA');
INSERT INTO `calendarioencintado` VALUES ('62', '2015', '45', '2015-11-02', '2015-11-08', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA');
INSERT INTO `calendarioencintado` VALUES ('63', '2015', '46', '2015-11-09', '2015-11-15', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS');
INSERT INTO `calendarioencintado` VALUES ('64', '2015', '47', '2015-11-16', '2015-11-22', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL');
INSERT INTO `calendarioencintado` VALUES ('65', '2015', '48', '2015-11-23', '2015-11-29', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE');
INSERT INTO `calendarioencintado` VALUES ('66', '2015', '49', '2015-11-30', '2015-12-06', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA');
INSERT INTO `calendarioencintado` VALUES ('67', '2015', '50', '2015-12-07', '2015-12-13', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON');
INSERT INTO `calendarioencintado` VALUES ('68', '2015', '51', '2015-12-14', '2015-12-20', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA');
INSERT INTO `calendarioencintado` VALUES ('69', '2015', '52', '2015-12-21', '2015-12-27', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA');
INSERT INTO `calendarioencintado` VALUES ('70', '2015', '53', '2015-12-28', '2016-01-03', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA');

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
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of campos
-- ----------------------------
INSERT INTO `campos` VALUES ('1', 'CAMPO 1', '61.07', '55.00', '1', '73', '3815', '463', '48');
INSERT INTO `campos` VALUES ('2', 'CAMPO 2', '71.47', '55.00', '1', '145', '7403', '903', '97');
INSERT INTO `campos` VALUES ('3', 'CAMPO 3', '77.51', '0.00', '1', '113', '8038', '782', '67');
INSERT INTO `campos` VALUES ('4', 'CAMPO 4', '42.22', '0.00', '1', '60', '3064', '395', '36');
INSERT INTO `campos` VALUES ('5', 'CAMPO 5', '44.18', '0.00', '1', '57', '3389', '469', '35');
INSERT INTO `campos` VALUES ('6', 'CAMPO 6', '71.81', '0.00', '1', '80', '5452', '566', '52');
INSERT INTO `campos` VALUES ('7', 'CAMPO 7', '77.40', '0.00', '1', '93', '7733', '783', '76');
INSERT INTO `campos` VALUES ('8', 'CAMPO 8', '66.82', '0.00', '1', '57', '3713', '406', '36');
INSERT INTO `campos` VALUES ('9', 'CAMPO 9', '97.00', '0.00', '1', '72', '4100', '444', '44');
INSERT INTO `campos` VALUES ('10', 'CAMPO 10', '28.74', '0.00', '1', '67', '5019', '556', '42');
INSERT INTO `campos` VALUES ('11', 'CAMPO 11', '47.53', '0.00', '1', '69', '1832', '296', '42');
INSERT INTO `campos` VALUES ('12', 'CAMPO 12', '49.08', '0.00', '1', '44', '3374', '251', '23');
INSERT INTO `campos` VALUES ('13', 'CAMPO 13', '25.41', '0.00', '1', '54', '4227', '404', '32');
INSERT INTO `campos` VALUES ('14', 'CAMPO 14', '97.00', '0.00', '1', '52', '4867', '686', '29');
INSERT INTO `campos` VALUES ('15', 'CAMPO 15', '92.00', '0.00', '1', '54', '4740', '542', '35');
INSERT INTO `campos` VALUES ('16', 'CAMPO 16', '85.00', '0.00', '1', '49', '4366', '622', '27');

-- ----------------------------
-- Table structure for `categorias`
-- ----------------------------
DROP TABLE IF EXISTS `categorias`;
CREATE TABLE `categorias` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of categorias
-- ----------------------------
INSERT INTO `categorias` VALUES ('1', 'EQUIPOS DE OFIMATICA');
INSERT INTO `categorias` VALUES ('2', 'MAQUINAS EXPENDEDORAS');
INSERT INTO `categorias` VALUES ('3', 'EQUIPAMIENTO PARA OFICINA');

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
-- Table structure for `clientes`
-- ----------------------------
DROP TABLE IF EXISTS `clientes`;
CREATE TABLE `clientes` (
  `idclientes` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(150) NOT NULL,
  `rnc` varchar(25) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `telefono2` varchar(15) DEFAULT NULL,
  `fax` varchar(15) DEFAULT NULL,
  `direccion` varchar(150) DEFAULT NULL,
  `provincia` int(11) NOT NULL,
  `correo` varchar(150) DEFAULT NULL,
  `status` int(1) NOT NULL,
  PRIMARY KEY (`idclientes`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of clientes
-- ----------------------------
INSERT INTO `clientes` VALUES ('1', 'PLANTACIONES DEL NORTE', '24233243223', '(999) 999-9999', '(999) 999-9999', '(999) 999-9999', 'AVENIDA DEL NORTE', '30', 'PLANTACIONES@GMAIL.COM', '1');

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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of cosecha
-- ----------------------------
INSERT INTO `cosecha` VALUES ('1', '2014-11-14', '15', '2', '12', '14', '25', '0', '0', '0', '19', '44', '114', '15', '0', '1', '13', '0', '1', '0', '0', '0');
INSERT INTO `cosecha` VALUES ('2', '2014-12-19', '50', '1', '25', '64', '32', '8', '1', '128', '22', '211', '491', '42', '0', '0', '0', '5', '0', '12', '0', '25');
INSERT INTO `cosecha` VALUES ('3', '2014-12-19', '50', '3', '45', '204', '35', '48', '0', '0', '0', '0', '332', '5', '0', '0', '0', '5', '0', '0', '0', '0');
INSERT INTO `cosecha` VALUES ('4', '2015-01-02', '24', '3', '12', '187', '0', '0', '0', '0', '0', '29', '228', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `cosecha` VALUES ('5', '2015-01-19', '45', '2', '12', '12', '12', '67', '8', '0', '0', '0', '111', '1', '0', '0', '0', '0', '1', '0', '0', '0');
INSERT INTO `cosecha` VALUES ('6', '2015-02-03', '4', '1', '24', '56', '56', '578', '9', '65', '64', '23', '875', '105', '23', '76', '1', '1', '1', '1', '1', '1');

-- ----------------------------
-- Table structure for `embolse`
-- ----------------------------
DROP TABLE IF EXISTS `embolse`;
CREATE TABLE `embolse` (
  `idembolse` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` date NOT NULL,
  `semana` int(2) NOT NULL,
  `colorcinta` int(11) NOT NULL,
  `cmp1` int(11) DEFAULT NULL,
  `cmp2` int(11) DEFAULT NULL,
  `cmp3` int(11) DEFAULT NULL,
  `cmp4` int(11) DEFAULT NULL,
  `cmp5` int(11) DEFAULT NULL,
  `cmp6` int(11) DEFAULT NULL,
  `cmp7` int(11) DEFAULT NULL,
  `cmp8` int(11) DEFAULT NULL,
  `cmp9` int(11) DEFAULT NULL,
  `cmp10` int(11) DEFAULT NULL,
  `cmp11` int(11) DEFAULT NULL,
  `cmp12` int(11) DEFAULT NULL,
  `cmp13` int(11) DEFAULT NULL,
  `cmp14` int(11) DEFAULT NULL,
  `cmp15` int(11) DEFAULT NULL,
  `cmp16` int(11) DEFAULT NULL,
  PRIMARY KEY (`idembolse`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of embolse
-- ----------------------------
INSERT INTO `embolse` VALUES ('1', '2015-02-02', '12', '6', '1', '1', '123', '1', '1', '1', '1', '1', '1', '1', '1', '1', '250', '1', '1', '1');

-- ----------------------------
-- Table structure for `insumos`
-- ----------------------------
DROP TABLE IF EXISTS `insumos`;
CREATE TABLE `insumos` (
  `insumos_id` int(11) NOT NULL AUTO_INCREMENT,
  `insumos_descripcion` varchar(100) NOT NULL,
  `insumos_unidadmedida` int(11) NOT NULL,
  PRIMARY KEY (`insumos_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of insumos
-- ----------------------------
INSERT INTO `insumos` VALUES ('1', 'INSUMO DE DISTRIBUCION 1', '7');
INSERT INTO `insumos` VALUES ('2', 'INSUMO DE DISTRIBUCION 2', '4');
INSERT INTO `insumos` VALUES ('3', 'INSUMO DE DISTRIBUCION 3', '6');
INSERT INTO `insumos` VALUES ('4', 'INSUMO DE DISTRIBUCION 4', '6');
INSERT INTO `insumos` VALUES ('5', 'INSUMO DE DISTRIBUCION 5', '7');

-- ----------------------------
-- Table structure for `productos`
-- ----------------------------
DROP TABLE IF EXISTS `productos`;
CREATE TABLE `productos` (
  `id_productos` int(11) NOT NULL AUTO_INCREMENT,
  `subcategoria` int(11) NOT NULL,
  `desc_productos` varchar(100) NOT NULL,
  `medida` int(11) NOT NULL,
  `existencia` decimal(9,2) NOT NULL,
  PRIMARY KEY (`id_productos`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of productos
-- ----------------------------
INSERT INTO `productos` VALUES ('1', '1', 'IMPRESORA HP LASERJET 8700', '8', '0.00');
INSERT INTO `productos` VALUES ('2', '3', 'FOTOCOPIADORA SHARP', '8', '0.00');

-- ----------------------------
-- Table structure for `provincias`
-- ----------------------------
DROP TABLE IF EXISTS `provincias`;
CREATE TABLE `provincias` (
  `idprovincia` int(11) NOT NULL AUTO_INCREMENT,
  `provincia` varchar(50) NOT NULL,
  PRIMARY KEY (`idprovincia`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of provincias
-- ----------------------------
INSERT INTO `provincias` VALUES ('1', 'AZUA');
INSERT INTO `provincias` VALUES ('2', 'BAHORUCO');
INSERT INTO `provincias` VALUES ('3', 'BARAHONA');
INSERT INTO `provincias` VALUES ('4', 'DAJABON');
INSERT INTO `provincias` VALUES ('5', 'DUARTE');
INSERT INTO `provincias` VALUES ('6', 'ELIAS PIÑA');
INSERT INTO `provincias` VALUES ('7', 'EL SEIBO');
INSERT INTO `provincias` VALUES ('8', 'ESPAILLAT');
INSERT INTO `provincias` VALUES ('9', 'HATO MAYOR');
INSERT INTO `provincias` VALUES ('10', 'INDEPENDENCIA');
INSERT INTO `provincias` VALUES ('11', 'LA ALTAGRACIA');
INSERT INTO `provincias` VALUES ('12', 'LA ROMANA');
INSERT INTO `provincias` VALUES ('13', 'LA VEGA');
INSERT INTO `provincias` VALUES ('14', 'MARIA TRINIDAD SANCHEZ');
INSERT INTO `provincias` VALUES ('15', 'MONSEÑOR NOUEL');
INSERT INTO `provincias` VALUES ('16', 'MONTE CRISTI');
INSERT INTO `provincias` VALUES ('17', 'MONTE PLATA');
INSERT INTO `provincias` VALUES ('18', 'PEDERNALES');
INSERT INTO `provincias` VALUES ('19', 'PERAVIA');
INSERT INTO `provincias` VALUES ('20', 'PUERTO PLATA');
INSERT INTO `provincias` VALUES ('21', 'HERMANAS MIRABAL');
INSERT INTO `provincias` VALUES ('22', 'SAMANA');
INSERT INTO `provincias` VALUES ('23', 'SANCHEZ RAMIREZ');
INSERT INTO `provincias` VALUES ('24', 'SAN JOSE DE OCOA');
INSERT INTO `provincias` VALUES ('25', 'SAN JUAN');
INSERT INTO `provincias` VALUES ('26', 'SAN PEDRO DE MACORIS');
INSERT INTO `provincias` VALUES ('27', 'SANTIAGO');
INSERT INTO `provincias` VALUES ('28', 'SANTIAGO RODRIGUEZ');
INSERT INTO `provincias` VALUES ('29', 'SANTO DOMINGO');
INSERT INTO `provincias` VALUES ('30', 'VALVERDE');
INSERT INTO `provincias` VALUES ('31', 'DISTRITO NACIONAL');
INSERT INTO `provincias` VALUES ('32', 'SAN CRISTOBAL');

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
-- Table structure for `semanas`
-- ----------------------------
DROP TABLE IF EXISTS `semanas`;
CREATE TABLE `semanas` (
  `idsemana` int(11) NOT NULL AUTO_INCREMENT,
  `semana` varchar(2) NOT NULL,
  PRIMARY KEY (`idsemana`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of semanas
-- ----------------------------
INSERT INTO `semanas` VALUES ('1', '1');
INSERT INTO `semanas` VALUES ('2', '2');
INSERT INTO `semanas` VALUES ('3', '3');
INSERT INTO `semanas` VALUES ('4', '4');
INSERT INTO `semanas` VALUES ('5', '5');
INSERT INTO `semanas` VALUES ('6', '6');
INSERT INTO `semanas` VALUES ('7', '7');
INSERT INTO `semanas` VALUES ('8', '8');
INSERT INTO `semanas` VALUES ('9', '9');
INSERT INTO `semanas` VALUES ('10', '10');
INSERT INTO `semanas` VALUES ('11', '11');
INSERT INTO `semanas` VALUES ('12', '12');
INSERT INTO `semanas` VALUES ('13', '13');
INSERT INTO `semanas` VALUES ('14', '14');
INSERT INTO `semanas` VALUES ('15', '15');
INSERT INTO `semanas` VALUES ('16', '16');
INSERT INTO `semanas` VALUES ('17', '17');
INSERT INTO `semanas` VALUES ('18', '18');
INSERT INTO `semanas` VALUES ('19', '19');
INSERT INTO `semanas` VALUES ('20', '20');
INSERT INTO `semanas` VALUES ('21', '21');
INSERT INTO `semanas` VALUES ('22', '22');
INSERT INTO `semanas` VALUES ('23', '23');
INSERT INTO `semanas` VALUES ('24', '24');
INSERT INTO `semanas` VALUES ('25', '25');
INSERT INTO `semanas` VALUES ('26', '26');
INSERT INTO `semanas` VALUES ('27', '27');
INSERT INTO `semanas` VALUES ('28', '28');
INSERT INTO `semanas` VALUES ('29', '29');
INSERT INTO `semanas` VALUES ('30', '30');
INSERT INTO `semanas` VALUES ('31', '31');
INSERT INTO `semanas` VALUES ('32', '32');
INSERT INTO `semanas` VALUES ('33', '33');
INSERT INTO `semanas` VALUES ('34', '34');
INSERT INTO `semanas` VALUES ('35', '35');
INSERT INTO `semanas` VALUES ('36', '36');
INSERT INTO `semanas` VALUES ('37', '37');
INSERT INTO `semanas` VALUES ('38', '38');
INSERT INTO `semanas` VALUES ('39', '39');
INSERT INTO `semanas` VALUES ('40', '40');
INSERT INTO `semanas` VALUES ('41', '41');
INSERT INTO `semanas` VALUES ('42', '42');
INSERT INTO `semanas` VALUES ('43', '43');
INSERT INTO `semanas` VALUES ('44', '44');
INSERT INTO `semanas` VALUES ('45', '45');
INSERT INTO `semanas` VALUES ('46', '46');
INSERT INTO `semanas` VALUES ('47', '47');
INSERT INTO `semanas` VALUES ('48', '48');
INSERT INTO `semanas` VALUES ('49', '49');
INSERT INTO `semanas` VALUES ('50', '50');
INSERT INTO `semanas` VALUES ('51', '51');
INSERT INTO `semanas` VALUES ('52', '52');

-- ----------------------------
-- Table structure for `subcategorias`
-- ----------------------------
DROP TABLE IF EXISTS `subcategorias`;
CREATE TABLE `subcategorias` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `categoria` int(11) NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of subcategorias
-- ----------------------------
INSERT INTO `subcategorias` VALUES ('1', '1', 'IMPRESORAS');
INSERT INTO `subcategorias` VALUES ('2', '1', 'ESCANERES');
INSERT INTO `subcategorias` VALUES ('3', '1', 'FOTOCOPIADORAS');
INSERT INTO `subcategorias` VALUES ('4', '1', 'DESTRUCTORAS DE DOCUMENTOS');
INSERT INTO `subcategorias` VALUES ('5', '2', 'EXPENDEDORAS DE CAFE');
INSERT INTO `subcategorias` VALUES ('6', '2', 'FUENTES DE AGUA');
INSERT INTO `subcategorias` VALUES ('7', '3', 'MOBILIARIOS DE OFICINAS');
INSERT INTO `subcategorias` VALUES ('8', '3', 'ARTICULOS DE ESCRITORIO');
INSERT INTO `subcategorias` VALUES ('9', '3', 'CAJAS FUERTES');

-- ----------------------------
-- Table structure for `suplidores`
-- ----------------------------
DROP TABLE IF EXISTS `suplidores`;
CREATE TABLE `suplidores` (
  `idsuplidores` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(75) NOT NULL,
  `razonsocial` varchar(75) NOT NULL,
  `marca` varchar(50) DEFAULT NULL,
  `rnc` varchar(25) NOT NULL DEFAULT 'x',
  `telefono` varchar(14) NOT NULL DEFAULT '(000) 000-0000',
  `fax` varchar(14) NOT NULL DEFAULT '(000) 000-0000',
  `direccion` varchar(75) NOT NULL DEFAULT 'No tiene',
  `provincia` int(11) NOT NULL DEFAULT '0',
  `correo` varchar(75) NOT NULL DEFAULT '@',
  `contacto` varchar(50) NOT NULL DEFAULT 'Ninguno',
  `telcontacto` varchar(14) NOT NULL DEFAULT '(000) 000-0000',
  `extension` varchar(5) NOT NULL DEFAULT '#####',
  `correocontacto` varchar(75) NOT NULL DEFAULT '@',
  `celcontacto` varchar(14) NOT NULL DEFAULT '(000) 000-0000',
  `telefono2` varchar(14) DEFAULT NULL,
  PRIMARY KEY (`idsuplidores`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of suplidores
-- ----------------------------
INSERT INTO `suplidores` VALUES ('1', 'COMBUSTIBLE DEL CIBAO ,S.A.', '', '', '1-02-34730-1', '(809) 724-8744', '(809) 581-5026', 'AUTOPISTA DUARTE KM 1, STGO', '27', '', 'JAZMIN', '(   )    -', '', '', '(809) 991-1512', '(809) 582-0390');
INSERT INTO `suplidores` VALUES ('2', 'AEROSERVA', '', '', '', '(809) 224-5251', '(   )    -', 'CERRO GORDO, MONTECRISTI', '16', 'AEROSERVA@HOTMAIL.COM', 'DAVID', '(   )    -', '', '', '(829) 962-8185', '(   )    -');
INSERT INTO `suplidores` VALUES ('3', 'AGROVETERINARIA SAN FELIPE, SRL', 'PRODUCTOS (ABONOS, FURMIGACION, INSTRUMENTOS TRABAJO)', '', '130334791', '(809) 572-2666', '(   )    -', 'CARRET. MAO-STGO RODRIGUEZ KM 3', '30', 'AGROVETERINARIASANFELIPE001@HOTMAIL.COM', 'JOSE ANDRES', '(   )    -', '', '', '(809) 258-2458', '(809) 572-5080');

-- ----------------------------
-- Table structure for `temp`
-- ----------------------------
DROP TABLE IF EXISTS `temp`;
CREATE TABLE `temp` (
  `Del` date DEFAULT NULL,
  `Al` date DEFAULT NULL,
  `SEMANA` double DEFAULT NULL,
  `COLOR_CINTA` varchar(255) DEFAULT NULL,
  `F5` varchar(255) DEFAULT NULL,
  `F6` varchar(255) DEFAULT NULL,
  `F7` varchar(255) DEFAULT NULL,
  `F8` varchar(255) DEFAULT NULL,
  `F9` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of temp
-- ----------------------------
INSERT INTO `temp` VALUES ('2014-12-22', '2014-12-28', '52', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE');
INSERT INTO `temp` VALUES ('2014-12-29', '2015-01-04', '1', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA');
INSERT INTO `temp` VALUES ('2015-01-05', '2015-01-11', '2', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON');
INSERT INTO `temp` VALUES ('2015-01-12', '2015-01-18', '3', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA');
INSERT INTO `temp` VALUES ('2015-01-19', '2015-01-25', '4', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA');
INSERT INTO `temp` VALUES ('2015-01-26', '2015-02-01', '5', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA');
INSERT INTO `temp` VALUES ('2015-02-02', '2015-02-08', '6', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS');
INSERT INTO `temp` VALUES ('2015-02-09', '2015-02-15', '7', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL');
INSERT INTO `temp` VALUES ('2015-02-16', '2015-02-22', '8', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE');
INSERT INTO `temp` VALUES ('2015-02-23', '2015-03-01', '9', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA');
INSERT INTO `temp` VALUES ('2015-03-02', '2015-03-08', '10', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON');
INSERT INTO `temp` VALUES ('2015-03-09', '2015-03-15', '11', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA');
INSERT INTO `temp` VALUES ('2015-03-16', '2015-03-22', '12', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA');
INSERT INTO `temp` VALUES ('2015-03-23', '2015-03-29', '13', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA');
INSERT INTO `temp` VALUES ('2015-03-30', '2015-04-05', '14', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS');
INSERT INTO `temp` VALUES ('2015-04-06', '2015-04-12', '15', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL');
INSERT INTO `temp` VALUES ('2015-04-13', '2015-04-19', '16', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE');
INSERT INTO `temp` VALUES ('2015-04-20', '2015-04-26', '17', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA');
INSERT INTO `temp` VALUES ('2015-04-27', '2015-05-03', '18', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON');
INSERT INTO `temp` VALUES ('2015-05-04', '2015-05-10', '19', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA');
INSERT INTO `temp` VALUES ('2015-05-11', '2015-05-17', '20', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA');
INSERT INTO `temp` VALUES ('2015-05-18', '2015-05-24', '21', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA');
INSERT INTO `temp` VALUES ('2015-05-25', '2015-05-31', '22', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS');
INSERT INTO `temp` VALUES ('2015-06-01', '2015-06-07', '23', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL');
INSERT INTO `temp` VALUES ('2015-06-08', '2015-06-14', '24', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE');
INSERT INTO `temp` VALUES ('2015-06-15', '2015-06-21', '25', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA');
INSERT INTO `temp` VALUES ('2015-06-22', '2015-06-28', '26', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON');
INSERT INTO `temp` VALUES ('2015-06-29', '2015-07-05', '27', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA');
INSERT INTO `temp` VALUES ('2015-07-06', '2015-07-12', '28', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA');
INSERT INTO `temp` VALUES ('2015-07-13', '2015-07-19', '29', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA');
INSERT INTO `temp` VALUES ('2015-07-20', '2015-07-26', '30', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS');
INSERT INTO `temp` VALUES ('2015-07-27', '2015-08-02', '31', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL');
INSERT INTO `temp` VALUES ('2015-08-03', '2015-08-09', '32', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE');
INSERT INTO `temp` VALUES ('2015-08-10', '2015-08-16', '33', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA');
INSERT INTO `temp` VALUES ('2015-08-17', '2015-08-23', '34', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON');
INSERT INTO `temp` VALUES ('2015-08-24', '2015-08-30', '35', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA');
INSERT INTO `temp` VALUES ('2015-08-31', '2015-09-06', '36', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA');
INSERT INTO `temp` VALUES ('2015-09-07', '2015-09-13', '37', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA');
INSERT INTO `temp` VALUES ('2015-09-14', '2015-09-20', '38', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS');
INSERT INTO `temp` VALUES ('2015-09-21', '2015-09-27', '39', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL');
INSERT INTO `temp` VALUES ('2015-09-28', '2015-10-04', '40', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE');
INSERT INTO `temp` VALUES ('2015-10-05', '2015-10-11', '41', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA');
INSERT INTO `temp` VALUES ('2015-10-12', '2015-10-18', '42', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON');
INSERT INTO `temp` VALUES ('2015-10-19', '2015-10-25', '43', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA');
INSERT INTO `temp` VALUES ('2015-10-26', '2015-11-01', '44', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA');
INSERT INTO `temp` VALUES ('2015-11-02', '2015-11-08', '45', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA');
INSERT INTO `temp` VALUES ('2015-11-09', '2015-11-15', '46', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS');
INSERT INTO `temp` VALUES ('2015-11-16', '2015-11-22', '47', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL');
INSERT INTO `temp` VALUES ('2015-11-23', '2015-11-29', '48', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA', 'VERDE');
INSERT INTO `temp` VALUES ('2015-11-30', '2015-12-06', '49', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON', 'AMARILLA');
INSERT INTO `temp` VALUES ('2015-12-07', '2015-12-13', '50', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA', 'MARRON');
INSERT INTO `temp` VALUES ('2015-12-14', '2015-12-20', '51', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA', 'BLANCA');
INSERT INTO `temp` VALUES ('2015-12-21', '2015-12-27', '52', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA', 'ROJA');
INSERT INTO `temp` VALUES ('2015-12-28', '2016-01-03', '53', 'MARRON', 'AMARILLA', 'VERDE', 'AZUL', 'GRIS', 'NEGRA');

-- ----------------------------
-- Table structure for `unidades`
-- ----------------------------
DROP TABLE IF EXISTS `unidades`;
CREATE TABLE `unidades` (
  `idunidades` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`idunidades`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of unidades
-- ----------------------------
INSERT INTO `unidades` VALUES ('1', 'UNIDAD DE LONGITUD');
INSERT INTO `unidades` VALUES ('2', 'UNIDAD DE MASA');
INSERT INTO `unidades` VALUES ('3', 'UNIDAD DE CAPACIDAD');
INSERT INTO `unidades` VALUES ('4', 'UNIDAD DE SUPERFICIE');
INSERT INTO `unidades` VALUES ('5', 'UNIDAD DE SUPERFICIE AGRARIA');
INSERT INTO `unidades` VALUES ('6', 'UNIDAD DE VOLUMEN');

-- ----------------------------
-- Table structure for `unidadmedidas`
-- ----------------------------
DROP TABLE IF EXISTS `unidadmedidas`;
CREATE TABLE `unidadmedidas` (
  `id_unidad` int(11) NOT NULL AUTO_INCREMENT,
  `desc_unidad` varchar(50) NOT NULL,
  `abreviatura` varchar(50) DEFAULT ' ',
  `equivalencia` varchar(50) DEFAULT ' ',
  `tipounidad` int(11) NOT NULL,
  PRIMARY KEY (`id_unidad`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of unidadmedidas
-- ----------------------------
INSERT INTO `unidadmedidas` VALUES ('1', 'TAREAS', 'TA', '1 TA = 629 Metros Cuadrados.', '5');
INSERT INTO `unidadmedidas` VALUES ('2', 'METROS CUADRADOS', 'M2', '1 Metro Cuadrado = 0.01 Areas', '4');
INSERT INTO `unidadmedidas` VALUES ('3', 'YARDAS', 'yd', '1 YARDA = 0.9144 Metros', '1');
INSERT INTO `unidadmedidas` VALUES ('4', 'MILILITRO', 'ml', '1 Mililitro = 0.001 litros', '3');
INSERT INTO `unidadmedidas` VALUES ('5', 'KILOMETROS', 'km', '1 km = 1000 m', '1');
INSERT INTO `unidadmedidas` VALUES ('6', 'CENTILITRO', 'cl', '1 Centilitro = 0.01 litros', '3');
INSERT INTO `unidadmedidas` VALUES ('7', 'LITRO', 'l', '1 litro = 1 litro', '3');
INSERT INTO `unidadmedidas` VALUES ('8', 'CENTIMETRO', 'CM', '1 CM = 0.01 M', '1');

-- ----------------------------
-- Table structure for `usuarios`
-- ----------------------------
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(25) NOT NULL,
  `userpass` varchar(32) NOT NULL,
  `user` varchar(75) NOT NULL,
  `status` bit(1) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of usuarios
-- ----------------------------
INSERT INTO `usuarios` VALUES ('1', 'fausto', 'gkmr0414', 'Fausto Richardson', '');

-- ----------------------------
-- Table structure for `ventas`
-- ----------------------------
DROP TABLE IF EXISTS `ventas`;
CREATE TABLE `ventas` (
  `idregistro` int(11) NOT NULL AUTO_INCREMENT,
  `paletas` decimal(9,2) NOT NULL,
  `libras` decimal(9,2) NOT NULL,
  `cajas` decimal(9,2) NOT NULL,
  `racimos` int(11) NOT NULL,
  `precioventa` decimal(9,2) NOT NULL,
  `vendidoa` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `neveras` int(11) DEFAULT NULL,
  PRIMARY KEY (`idregistro`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of ventas
-- ----------------------------
INSERT INTO `ventas` VALUES ('1', '10.00', '20160.00', '480.00', '956', '7.60', '1', '2014-09-09', '1');
