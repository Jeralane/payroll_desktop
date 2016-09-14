/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50148
Source Host           : localhost:3306
Source Database       : payroll

Target Server Type    : MYSQL
Target Server Version : 50148
File Encoding         : 65001

Date: 2014-04-11 12:11:27
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `tax_groups`
-- ----------------------------
DROP TABLE IF EXISTS `tax_groups`;
CREATE TABLE `tax_groups` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(50),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tax_groups
-- ----------------------------
INSERT INTO `tax_groups` VALUES ('1', 'Z');
INSERT INTO `tax_groups` VALUES ('2', 'S');
INSERT INTO `tax_groups` VALUES ('3', 'S1');
INSERT INTO `tax_groups` VALUES ('4', 'S2');
INSERT INTO `tax_groups` VALUES ('5', 'S3');
INSERT INTO `tax_groups` VALUES ('6', 'S4');
INSERT INTO `tax_groups` VALUES ('7', 'ME');
INSERT INTO `tax_groups` VALUES ('8', 'ME1');
INSERT INTO `tax_groups` VALUES ('9', 'ME2');
INSERT INTO `tax_groups` VALUES ('10', 'ME3');
INSERT INTO `tax_groups` VALUES ('11', 'ME4');
