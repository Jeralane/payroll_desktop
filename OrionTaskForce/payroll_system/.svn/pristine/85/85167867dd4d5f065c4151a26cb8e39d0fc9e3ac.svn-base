/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50148
Source Host           : localhost:3306
Source Database       : payroll

Target Server Type    : MYSQL
Target Server Version : 50148
File Encoding         : 65001

Date: 2014-04-11 12:34:34
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `payroll_periods`
-- ----------------------------
DROP TABLE IF EXISTS `payroll_periods`;
CREATE TABLE `payroll_periods` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(100) ,
  `from_date` datetime,
  `to_date` datetime,
  `period_id` int(11),
  `this_month` int(11),
  `this_year` int(11),
  `working_days` int(11),
  `remarks` varchar(255),
  `is_posted` tinyint(1),
  PRIMARY KEY (`id`),
  UNIQUE KEY `payroll_period_description` (`description`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of payroll_periods
-- ----------------------------
INSERT INTO `payroll_periods` VALUES ('49', 'January 1-15, 2012', '2012-01-01 00:00:00', '2012-01-15 00:00:00', '1', '1', '2012', '15', '', '1');
INSERT INTO `payroll_periods` VALUES ('50', 'January 16-31, 2012', '2012-01-16 00:00:00', '2012-01-31 00:00:00', '2', '1', '2012', '16', '', '1');
INSERT INTO `payroll_periods` VALUES ('51', 'February 1-15, 2012', '2012-02-01 00:00:00', '2012-02-15 00:00:00', '1', '2', '2012', '15', '', '1');
INSERT INTO `payroll_periods` VALUES ('52', 'February 16-29, 2012', '2012-02-16 00:00:00', '2012-02-29 00:00:00', '2', '2', '2012', '14', '', '1');
INSERT INTO `payroll_periods` VALUES ('53', 'March 1-15, 2012', '2012-03-01 00:00:00', '2012-03-15 00:00:00', '1', '3', '2012', '15', '', '1');
INSERT INTO `payroll_periods` VALUES ('54', 'March 16-31, 2012', '2012-03-16 00:00:00', '2012-03-31 00:00:00', '2', '3', '2012', '16', '', '1');
INSERT INTO `payroll_periods` VALUES ('55', 'April 1-15, 2012', '2012-04-01 00:00:00', '2012-04-15 00:00:00', '1', '4', '2012', '15', '', '1');
INSERT INTO `payroll_periods` VALUES ('56', 'April 16-30, 2012', '2012-04-16 00:00:00', '2012-04-30 00:00:00', '2', '4', '2012', '15', '', '1');
INSERT INTO `payroll_periods` VALUES ('57', 'May 1-15, 2012', '2012-05-01 00:00:00', '2012-05-15 00:00:00', '1', '5', '2012', '15', '', '1');
INSERT INTO `payroll_periods` VALUES ('58', 'May 16-31, 2012', '2012-05-16 00:00:00', '2012-05-31 00:00:00', '2', '5', '2012', '16', '', '1');
INSERT INTO `payroll_periods` VALUES ('59', 'June 1-15, 2012', '2012-06-01 00:00:00', '2012-06-15 00:00:00', '1', '6', '2012', '15', '', '1');
INSERT INTO `payroll_periods` VALUES ('60', 'June 16-30, 2012', '2012-06-16 00:00:00', '2012-06-30 00:00:00', '2', '6', '2012', '15', '', '1');
INSERT INTO `payroll_periods` VALUES ('61', 'July 1-15, 2012', '2012-07-01 00:00:00', '2012-07-15 00:00:00', '1', '7', '2012', '15', '', '1');
INSERT INTO `payroll_periods` VALUES ('62', 'July 16-31, 2012', '2012-07-16 00:00:00', '2012-07-31 00:00:00', '2', '7', '2012', '16', '', '1');
INSERT INTO `payroll_periods` VALUES ('63', 'August 1-15, 2012', '2012-08-01 00:00:00', '2012-08-15 00:00:00', '1', '8', '2012', '15', '', '1');
INSERT INTO `payroll_periods` VALUES ('64', 'August 16-31, 2012', '2012-08-16 00:00:00', '2012-08-31 00:00:00', '2', '8', '2012', '16', '', '1');
INSERT INTO `payroll_periods` VALUES ('65', 'September 1-15, 2012', '2012-09-01 00:00:00', '2012-09-15 00:00:00', '1', '9', '2012', '15', '', '1');
INSERT INTO `payroll_periods` VALUES ('66', 'September 16-30, 2012', '2012-09-16 00:00:00', '2012-09-30 00:00:00', '2', '9', '2012', '15', '', '1');
INSERT INTO `payroll_periods` VALUES ('67', 'October 1-15, 2012', '2012-10-01 00:00:00', '2012-10-15 00:00:00', '1', '10', '2012', '15', '', '1');
INSERT INTO `payroll_periods` VALUES ('68', 'October 16-31, 2012', '2012-10-16 00:00:00', '2012-10-31 00:00:00', '2', '10', '2012', '16', '', '1');
INSERT INTO `payroll_periods` VALUES ('69', 'November 1-15, 2012', '2012-11-01 00:00:00', '2012-11-15 00:00:00', '1', '11', '2012', '15', '', '1');
INSERT INTO `payroll_periods` VALUES ('70', 'November 16-30, 2012', '2012-11-16 00:00:00', '2012-11-30 00:00:00', '2', '11', '2012', '15', '', '1');
INSERT INTO `payroll_periods` VALUES ('71', 'December 1-15, 2012', '2012-12-01 00:00:00', '2012-12-15 00:00:00', '1', '12', '2012', '15', '', '1');
INSERT INTO `payroll_periods` VALUES ('72', 'December 16-31, 2012', '2012-12-16 00:00:00', '2012-12-31 00:00:00', '2', '12', '2012', '16', '', '0');
