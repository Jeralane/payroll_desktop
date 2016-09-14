/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50148
Source Host           : localhost:3306
Source Database       : payroll

Target Server Type    : MYSQL
Target Server Version : 50148
File Encoding         : 65001

Date: 2014-04-11 12:05:15
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `detachments`
-- ----------------------------
DROP TABLE IF EXISTS `detachments`;
CREATE TABLE `detachments` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `address` varchar(255) DEFAULT NULL,
  `hours_per_day` decimal(5,2) DEFAULT NULL,
  `number_of_guards` int(11) DEFAULT NULL,
  `monthly_contract_amount` decimal(10,2) DEFAULT NULL,
  `monthly_rate` decimal(10,2) DEFAULT NULL,
  `monthly_allowance` decimal(10,2) DEFAULT NULL,
  `daily_rate` decimal(10,2) DEFAULT NULL,
  `cost_of_living_allowance` decimal(10,2) DEFAULT NULL,
  `night_differential_rate` decimal(10,2) DEFAULT NULL,
  `adjustment` decimal(10,2) DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL,
  `is_billing_exempted` tinyint(1) DEFAULT NULL,
  `is_tax_exempted` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `detachment_name` (`name`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=106 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of detachments
-- ----------------------------
INSERT INTO `detachments` VALUES ('1', 'Admin', '', '8.00', '3', '1.00', '1.00', '0.00', '0.00', '0.00', '0.00', '0.00', '', '1', '1');
INSERT INTO `detachments` VALUES ('2', 'Office Staff', '', '8.00', '7', '1.00', '1.00', '0.00', '0.00', '0.00', '0.00', '0.00', '', '1', '1');
INSERT INTO `detachments` VALUES ('3', 'Topway International Industrial, Inc.', 'No. 2 Donesa St., Canumay, Valenzuela City', '12.00', '3', '10066.67', '7000.00', '700.00', '200.00', '30.00', '0.00', '450.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('4', 'Sacred Peak Marketing, Inc. - Malabo', '3rd Flr. Jupiter Ctr., #22 Jupiter St., Bel Air Vill., Makati City', '12.00', '1', '11600.00', '7000.00', '0.00', '200.00', '30.00', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('5', 'Sacred Peak Manufacturing, Inc.', 'Unit 8 Metro Sotanghon Compound, Bo. Malabo, Maysan, Valenzuela City', '12.00', '2', '7346.73', '7000.00', '0.00', '200.00', '30.00', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('6', 'Sacred Peak Marketing, Inc. - Rincon', '3rd Flr., Jupiter Ctr., #22 Jupiter St., Bel Air Vill., Makati City', '12.00', '1', '11600.00', '7000.00', '0.00', '200.00', '30.00', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('7', 'Asbuilt Metal Facilities', '#3 Servando St., Mapulang Lupa, Valenzuela City', '12.00', '3', '14333.34', '7666.67', '1000.00', '250.00', '0.00', '0.00', '0.00', '1 SO and 2 SG', '0', '0');
INSERT INTO `detachments` VALUES ('8', 'ESP Value Zone - Pampanga', 'Jomaper Supercenter, Gapan Olongapo Rd., San Matias, Guagua, Pampanga', '12.00', '6', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('9', 'Go Shoppe - Pampanga', 'Mangga Cacutod, Arayat, Pampanga', '12.00', '4', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('10', 'Shop N More - Pampanga', 'Moujies Bldg., Mc Arthur Highway, San Vicente, Apalit, Pampanga', '12.00', '4', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('11', 'Best Budget Plaza - Pampanga', 'R. Sta. Rita, Poblacion, Macabebe, Pampanga', '12.00', '3', '7333.33', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('12', 'Mega Savers Dept. Store', 'Fiesta Mart Bldg., V. Tiomico St., San Fernando, Pampanga', '12.00', '4', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('13', 'Skyline Warehouse - Pampanga', 'Kenji Bldg., Mc Arthur Highway, Sampaloc, Apalit, Pampanga', '12.00', '2', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('14', 'Megashoppe Dept. Store', 'Malinta, Valenzuela City', '12.00', '4', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('15', 'Star Budget Plaza - Arcade', 'Meycauayan, Bulacan', '12.00', '3', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('16', 'Starshop Plaza', 'Meycauayan, Bulacan', '12.00', '4', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('17', 'Budget Plaza Marketing', 'Sto. Nino, Meycauayan, Bulacan', '12.00', '2', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('18', 'Woodhaven Corp.- Cavite', 'No. 13 Governors Drive, Paliparan 1, DasmariÃ±as, Cavite', '12.00', '4', '18750.00', '10665.00', '0.00', '237.00', '118.50', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('19', 'Woodhaven Corporation', '259 Mc Arthur Highway, Karuhatan, Valenzuela City', '8.00', '9', '13920.00', '9000.00', '0.00', '404.00', '0.00', '40.40', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('20', 'Woodhaven Corp. - Roques Residence', 'Karuhatan, Valenzuela City', '12.00', '2', '20880.00', '9750.00', '0.00', '404.00', '0.00', '40.40', '0.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('21', 'Ritefill Corporation', 'S-141 South Ave., South Triangle, Quezon City', '12.00', '2', '20880.00', '9750.00', '0.00', '404.00', '0.00', '40.40', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('22', 'Seapointe Corporation - Castro Farm', 'Karuhatan, Valenzuela City', '12.00', '1', '18750.00', '10665.00', '0.00', '237.00', '118.50', '0.00', '0.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('23', 'Seapointe Corporation - Nixin And Jary Farm', 'Karuhatan, Valenzuela City', '12.00', '1', '10000.00', '10665.00', '0.00', '237.00', '118.50', '0.00', '0.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('24', 'Great Western Corp.', 'Pansol, Calamba, Laguna', '12.00', '4', '23568.80', '10665.00', '0.00', '315.00', '0.00', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('25', 'Golden Dame Food Center, Inc. -  Malolos', 'Malolos City, Bulacan', '12.00', '1', '12880.00', '7260.00', '0.00', '217.00', '25.00', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('26', 'Golden Dame Food Center, Inc. - Meyc.', 'Km. 19, Mc Arthur Highway, Calvario, Meycauayan, Bulacan', '12.00', '2', '14300.00', '7260.00', '0.00', '217.00', '25.00', '0.00', '0.00', 'No vat and ewt on billing', '0', '1');
INSERT INTO `detachments` VALUES ('27', 'Meneses Residence', 'Bambang, Bulacan, Bulacan', '12.00', '2', '15000.00', '7260.00', '0.00', '217.00', '25.00', '0.00', '0.00', 'No vat and ewt', '0', '1');
INSERT INTO `detachments` VALUES ('28', 'Fabtech Kitchen Unlimited, Inc. - Gen. Lim', 'Gen. Lim St., Heroes Hill Subd., Quezon Ave., Quezon City', '8.00', '1', '20182.00', '12494.58', '0.00', '382.00', '34.49', '0.00', '0.00', 'Holidays is an additional amount in the billing', '0', '0');
INSERT INTO `detachments` VALUES ('29', 'Fabtech Kitchen Unlimited, Inc. - QA', '1229 Quezon Ave., Quezon City', '8.00', '3', '20182.00', '12494.58', '0.00', '382.00', '34.49', '0.00', '0.00', 'Holidays are added in the billing', '0', '0');
INSERT INTO `detachments` VALUES ('30', 'Fabtech Kitchen Unlimited, Inc. - Val', 'No. 59 ITC, Bagbaguin, Valenzuela City', '8.00', '2', '15136.50', '12494.58', '0.00', '382.00', '34.49', '0.00', '0.00', 'Holidays are added in the billing', '0', '0');
INSERT INTO `detachments` VALUES ('31', 'Fabtech Export Industries, Inc.', 'Batino Industrial Park, Calamba, Laguna', '8.00', '1', '20182.00', '12794.70', '0.00', '382.00', '34.49', '0.00', '0.00', 'with overtime, holidays are added in the billing', '0', '0');
INSERT INTO `detachments` VALUES ('32', 'Jackie Sy Go & Associates', 'Lapu Lapu Village, Makaty City', '12.00', '1', '26236.08', '18741.88', '0.00', '382.00', '242.73', '0.00', '0.00', 'Holidays are added in the billing', '0', '0');
INSERT INTO `detachments` VALUES ('33', 'Creative Bakers Co. Inc.', '50-60 San Rafael St. Ext., Mandaluyong City', '12.00', '7', '8000.00', '7000.00', '0.00', '200.00', '30.00', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('34', 'Rizal Funeral Homes Inc. - Pasay', 'No. 438 Cementina City, Pasay City', '12.00', '2', '11000.00', '6500.00', '0.00', '185.00', '30.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('35', 'Rizal Funeral Homes Inc. - Sucat', 'No. 438 Cementina City, Pasay City', '12.00', '2', '11000.00', '6500.00', '0.00', '185.00', '30.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('36', 'Radio Mindanao Networks, Inc.', 'Taliptip, Bulacan, Bulacan', '12.00', '3', '13000.00', '6500.00', '0.00', '185.00', '30.00', '0.00', '275.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('37', 'Provident International Resources Corporation', 'Main Floor PIRC Bldg., Ninoy Aquino Ave., ParaÃ±aque City', '12.00', '11', '14200.00', '8400.00', '0.00', '250.00', '30.00', '0.00', '0.00', 'No vat and ewt', '0', '0');
INSERT INTO `detachments` VALUES ('38', 'Family Savers Department Store', 'Balagtas Bulacan', '12.00', '3', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('39', 'Angel Wheel', '166 Boncare Compound, Sta. Rosa II, Marilao, Bulacan', '12.00', '3', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('40', 'HJ Lucky Shopping Center', 'Angelica A. Morales St., Poblacion, Sta Maria, Bulacan', '12.00', '4', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('41', 'Family Choice Shopping Mall', 'Bolos Bldg., Bagong Buhay 2, Sampol, San Jose Del Monte, Bulacan', '12.00', '4', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('42', 'WKG Residence', 'Urdaneta Village, Makati City', '12.00', '1', '12109.20', '9370.94', '0.00', '382.00', '242.73', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('43', 'Special Duty', '', '1.00', '3', '1.00', '1.00', '0.00', '1.00', '1.00', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('44', 'Ritefill Corporation - Bustos', 'San Pedro, Bustos, Bulacan', '12.00', '1', '18750.00', '10665.00', '0.00', '302.00', '0.00', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('45', 'Joaquin Real Estate', 'Galauran Compound, 382 Edsa, Caloocan City', '12.00', '1', '10000.00', '6500.00', '500.00', '216.67', '0.00', '0.00', '0.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('46', 'Woodhaven Corp. Augmentation', '', '8.00', '1', '3596.00', '9000.00', '0.00', '404.00', '0.00', '0.00', '0.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('47', 'Fabtech - Lapulapu Vill.', 'Lapu-lapu Vill., Makati City', '8.00', '3', '20182.00', '12494.58', '0.00', '382.00', '34.49', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('48', 'Seapointe Corporation - Ace Farm (Magalang, Pampanga)', '259 Karuhatan, Valenzuela City', '12.00', '1', '3750.00', '10665.00', '0.00', '237.00', '118.50', '0.00', '0.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('49', 'Sacred Peak Manufacturing - Augmentation', 'Unit 8 Metro Sotanghon Compound, Bo. Malabo, Maysan, Valenzuela City', '12.00', '8', '9061.25', '7000.00', '0.00', '200.00', '30.00', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('50', 'Sacred Peak Marketing - Rincon Augmentation', 'Ricon, Malinta, Valenzuela City', '12.00', '1', '10053.33', '7000.00', '0.00', '200.00', '30.00', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('51', 'Sacred Peak Marketing Inc. - Malabo Augmentation', '3rd Flr. Jupiter Ctr., #22 Jupiter St., Bel Air Vill., Makati City', '12.00', '6', '9344.44', '7000.00', '0.00', '200.00', '30.00', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('52', 'Seapoint Corporation-Peter Pan Farm', 'Karuhatan, Valenzuela City', '12.00', '1', '3750.00', '5688.00', '0.00', '237.00', '118.50', '0.00', '0.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('53', 'Fabtech Kitchen Unlimited - OIC', '1229 Quezon Ave., Q.C.', '8.00', '1', '22571.00', '13247.83', '1000.00', '404.00', '37.59', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('54', 'Starshop Plaza -  2nd Floor', 'Meycauayan, Bulacan', '12.00', '1', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('55', 'Lucky Sister General Merchandise', 'Wawa, Balagtas, Bulacan', '12.00', '3', '10666.56', '7000.00', '0.00', '233.33', '0.00', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('56', 'Galauran Compound', '382 EDSA, Caloocan City', '12.00', '1', '4020.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('57', 'White Feather Corporation', 'Brgy. Turo, Bocaue, Bulacan', '12.00', '3', '20880.00', '9750.00', '0.00', '302.00', '0.00', '30.20', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('58', 'Fabtech Warehouse', '# 6 Lapu-Lapu St. Magallanes, Makati City', '8.00', '3', '20182.00', '12794.70', '0.00', '382.00', '34.49', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('59', 'White Feather Corporation - Ocampo Farm', 'Gen. Tinio, Nueva Ecija', '12.00', '1', '18976.00', '9750.00', '0.00', '250.00', '75.00', '0.00', '0.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('60', 'White Feather Corporation - Villanueva Farm', 'Magalang, Pampanga', '12.00', '1', '20880.00', '9750.00', '0.00', '250.00', '75.00', '0.00', '0.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('61', 'White Feather Corporation - Wycoco Ocampo Farm', 'Cabanatuan City', '12.00', '1', '13920.00', '9750.00', '0.00', '250.00', '75.00', '0.00', '0.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('62', 'Deato Subdivision', 'Lawa, Obando, Bulacan', '12.00', '1', '1200.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('63', 'Woodhaven Corporation - Fiesta Gas', 'Marigold Subdivision San Jose Del Monte, Bulacan', '12.00', '1', '20880.00', '9000.00', '0.00', '302.00', '0.00', '30.20', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('64', 'Fabtech Head Office Honda', 'Honda Bldg., Magallanes, Makati City', '8.00', '1', '20182.00', '12794.70', '0.00', '382.00', '34.49', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('65', 'Asbuilt Metal Facilities - OIC', '#3 Servando St., Mapulang Lupa, Valenzuela City', '12.00', '1', '13000.00', '7280.00', '2600.00', '280.00', '0.00', '0.00', '1500.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('66', 'Asbuilt Metal Facilities - Regular Guards', '#3 Servando St., Mapulang Lupa, Valenzuela City', '12.00', '2', '13000.00', '7500.00', '1500.00', '250.00', '0.00', '0.00', '750.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('67', 'Ritefill Splash', '259 Mc Arthur Highway, Karuhatan, Valenzuela City', '8.00', '1', '13920.00', '9000.00', '0.00', '404.00', '0.00', '40.40', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('68', 'Starshop Plaza - Augmentation', 'Meycauayan, Bulacan', '12.00', '6', '10555.55', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('69', 'Family Savers Department Store - Augmentation', 'Balagtas Bulacan', '12.00', '1', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('70', 'Budget Plaza Marketing - Augmentation', 'Sto. NiÃ±o, Meycauayan,  Bulacan', '12.00', '3', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('71', 'Family Choice Shopping Mall - Augmentation', 'Bolos Bldg., Bagong Buhay 2,  Sampol, San Jose Del Monte, Bulacan', '12.00', '1', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('72', 'Megashoppe Dept. Store - Augmentation', 'Malinta, Valenzuela City', '12.00', '1', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('74', 'HJ Lucky Shopping Center - Augmentation', 'Angelica A. Morales St., Poblacion, Sta. Maria, Bulacan', '12.00', '1', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('75', 'Shop N More - Augmentation', 'Moujies Bldg., McArthur Highway, San Vicente, Apalit, Pampanga', '12.00', '1', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('76', 'Go Shoppe - Augmentation', 'Mangga Cacutod, Arayat, Pampanga', '12.00', '1', '1333.34', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('77', 'Best Budget Plaza - Augmentation', 'R. Sta. rita, Poblacion, Macabebe, Pampanga', '12.00', '1', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('78', 'ESP Value Zone - Augmentation', 'Jomaper Supercenter, Gapan, Olongapo Rd., San Matias, Guagua, Pampanga', '12.00', '2', '10000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('79', 'Mega Savers Dept. Store - Augmentation', 'Fiesta Mart Bldg., V. Tiomico St., San Fernado, Pampanga', '12.00', '1', '8666.67', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('80', 'Ritefill Corporation - Augmentation', 'S-141 South Ave., South Triangle, Quezon City', '12.00', '2', '20880.00', '9750.00', '0.00', '404.00', '0.00', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('81', 'Beaudry Builders Corporation', 'N. Domingo cor. Paterno,San Juan', '12.00', '2', '20880.00', '9750.00', '0.00', '404.00', '0.00', '40.40', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('83', 'Navarro Residence', 'Maypajo, Caloocan City', '8.00', '1', '2784.00', '9000.00', '0.00', '404.00', '0.00', '40.40', '0.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('84', 'White Feather Corp. - Marilao', 'Marilao, Bulacan', '12.00', '2', '20880.00', '9750.00', '0.00', '302.00', '0.00', '30.20', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('85', 'L.P.M.T. Trading', '# 10 Arellano St., Bagong Barrio, Caloocan City', '12.00', '1', '11000.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('86', '98 Ideal Ways Development Corp.', '5th Floor Victory Mall, Caloocan City', '12.00', '1', '3333.33', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('87', 'Woodhaven Corporation - Globe', 'Malolos, Bulacan', '12.00', '1', '20880.00', '9000.00', '0.00', '302.00', '0.00', '30.20', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('88', 'Seapointe Corporation', 'Bantay Sinabahan, Vigan, Ilocos Sur', '12.00', '1', '15312.00', '9750.00', '0.00', '302.00', '0.00', '30.20', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('89', 'See Put', '882 Elosco Road Brgy, Calawaan, Pasig City', '12.00', '2', '12000.00', '7000.00', '0.00', '233.33', '0.00', '0.00', '250.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('90', 'Asbuilt Metal Facilities - Shop', 'Ugong', '12.00', '1', '13000.00', '7500.00', '1500.00', '250.00', '0.00', '0.00', '750.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('91', 'Ignacio Superette Inc', 'Sta. Rita, Macabebe, Pampanga', '12.00', '1', '9600.00', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('92', 'Wisdom Site Building', '27 Jhocson St., Legarda, Manila', '12.00', '2', '14500.00', '7500.00', '0.00', '250.00', '0.00', '0.00', '1110.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('93', 'Ultra Builders Enterprises', 'Ugong, Valenzuela City', '8.00', '1', '12746.56', '7000.00', '0.00', '233.33', '0.00', '0.00', '500.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('94', 'Beaudry Builders Corp.-Bataan', 'Bataan', '12.00', '1', '8352.00', '9750.00', '0.00', '302.00', '0.00', '30.20', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('95', 'Indo Phil Textile Mills Inc.', 'Bo. Lambakin, Marilao, Bulacan', '12.00', '7', '9501.00', '6000.00', '0.00', '200.00', '0.00', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('96', 'Tea Kitchen', 'No. 2 Wilson St. cor. Barasoin, Greenhills, San Juan City', '8.00', '1', '13000.00', '8000.00', '0.00', '266.67', '0.00', '0.00', '500.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('97', 'Astrotel - Monumento/SG', 'Samson Rd., Caloocan City', '12.00', '2', '11500.00', '7000.00', '0.00', '233.33', '0.00', '0.00', '500.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('98', 'Astrotel - Cubao', 'Arayat, Cubao, Quezon City', '12.00', '4', '11500.00', '7000.00', '0.00', '233.33', '0.00', '0.00', '500.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('99', 'Astrotel - Avenida', 'Sta. Cruz, Avenida, Manila City', '12.00', '2', '11500.00', '7000.00', '0.00', '233.33', '0.00', '0.00', '500.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('100', 'Indo Phil Acrylic', 'Bo. Lambakin, Marilao, Bulacan', '12.00', '7', '9501.00', '6000.00', '0.00', '200.00', '0.00', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('101', 'Indo Phil Cotton', 'Bo. Lambakin, Marilao, Bulacan', '12.00', '7', '9501.00', '6000.00', '0.00', '200.00', '0.00', '0.00', '0.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('102', 'Astrotel - Monumento/Civilian', 'Samson Rd., Caloocan City', '12.00', '1', '11500.00', '7000.00', '0.00', '233.33', '0.00', '0.00', '500.00', '', '0', '1');
INSERT INTO `detachments` VALUES ('103', 'JC Electrofield Power System Inc.', 'Lamesa St., Ugong Valenzuela City', '12.00', '2', '12000.00', '7000.00', '0.00', '233.33', '0.00', '0.00', '500.00', '', '0', '0');
INSERT INTO `detachments` VALUES ('104', 'Star Budget Plaza - Arcade Augmentation', 'Meycauyan, Bulacan', '12.00', '1', '1333.32', '6500.00', '0.00', '216.67', '0.00', '0.00', '250.00', '', '0', '0');
