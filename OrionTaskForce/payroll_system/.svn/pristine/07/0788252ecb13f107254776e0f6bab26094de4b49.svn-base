/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50148
Source Host           : localhost:3306
Source Database       : payroll

Target Server Type    : MYSQL
Target Server Version : 50148
File Encoding         : 65001

Date: 2014-04-11 12:13:56
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `employee_statuses`
-- ----------------------------
DROP TABLE IF EXISTS `employee_statuses`;
CREATE TABLE `employee_statuses` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `employee_status_description` (`description`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of employee_statuses
-- ----------------------------
INSERT INTO `employee_statuses` VALUES ('1', 'ACTIVE');
INSERT INTO `employee_statuses` VALUES ('2', 'INACTIVE');
INSERT INTO `employee_statuses` VALUES ('3', 'LEAVE');
INSERT INTO `employee_statuses` VALUES ('6', 'RESIGNED');
INSERT INTO `employee_statuses` VALUES ('7', 'RETIRED');
INSERT INTO `employee_statuses` VALUES ('5', 'SICKNESS');
INSERT INTO `employee_statuses` VALUES ('8', 'TERMINATED');
INSERT INTO `employee_statuses` VALUES ('4', 'VACATION');
