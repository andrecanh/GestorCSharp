-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 29-Jan-2022 às 19:58
-- Versão do servidor: 10.4.21-MariaDB
-- versão do PHP: 7.3.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `gestaofinanceira`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `cli_id` int(11) NOT NULL,
  `cli_cpf` varchar(25) NOT NULL,
  `cli_nome` varchar(100) NOT NULL,
  `cli_dataCadastro` datetime DEFAULT NULL,
  `cli_cep` varchar(12) DEFAULT NULL,
  `cli_endereco` varchar(100) DEFAULT NULL,
  `cli_numero` int(11) DEFAULT NULL,
  `cli_complemento` varchar(70) DEFAULT NULL,
  `cli_bairro` varchar(70) DEFAULT NULL,
  `cli_cidade` varchar(70) DEFAULT NULL,
  `cli_estado` varchar(50) DEFAULT NULL,
  `cli_email` varchar(150) DEFAULT NULL,
  `cli_foneCelular` varchar(25) NOT NULL,
  `cli_observacao` text DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 ROW_FORMAT=FIXED;

-- --------------------------------------------------------

--
-- Estrutura da tabela `contapagar`
--

CREATE TABLE `contapagar` (
  `pag_id` int(11) NOT NULL,
  `pag_numDoc` int(11) NOT NULL,
  `pag_dataDoc` datetime NOT NULL,
  `pag_descDoc` varchar(150) NOT NULL,
  `pag_formaPag` varchar(50) DEFAULT NULL,
  `pag_valorPrincipal` decimal(10,2) DEFAULT NULL,
  `pag_valorJuros` decimal(10,2) DEFAULT NULL,
  `pag_valorMulta` decimal(10,2) DEFAULT NULL,
  `pag_valorTotal` decimal(10,2) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 ROW_FORMAT=FIXED;

-- --------------------------------------------------------

--
-- Estrutura da tabela `contareceber`
--

CREATE TABLE `contareceber` (
  `rec_id` int(11) NOT NULL,
  `rec_numDoc` int(11) NOT NULL,
  `rec_dataDoc` datetime NOT NULL,
  `rec_descricaoDoc` varchar(150) DEFAULT NULL,
  `rec_formaPagto` varchar(50) DEFAULT NULL,
  `rec_valorPrincipal` decimal(10,2) DEFAULT NULL,
  `rec_valorJuros` decimal(10,2) DEFAULT NULL,
  `rec_valorMulta` decimal(10,2) DEFAULT NULL,
  `rec_valorTotal` decimal(10,2) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 ROW_FORMAT=FIXED;

-- --------------------------------------------------------

--
-- Estrutura da tabela `empresa`
--

CREATE TABLE `empresa` (
  `emp_id` int(11) NOT NULL,
  `emp_cnpj` varchar(35) NOT NULL,
  `emp_razao` varchar(200) NOT NULL,
  `emp_dataCadastro` datetime DEFAULT NULL,
  `emp_cep` varchar(12) DEFAULT NULL,
  `emp_endereco` varchar(100) DEFAULT NULL,
  `emp_numero` int(11) NOT NULL,
  `emp_complemento` varchar(70) DEFAULT NULL,
  `emp_bairro` varchar(70) DEFAULT NULL,
  `emp_cidade` varchar(50) DEFAULT NULL,
  `emp_estado` varchar(50) DEFAULT NULL,
  `emp_email` varchar(150) DEFAULT NULL,
  `emp_fonefixo` varchar(15) DEFAULT NULL,
  `emp_fonecelular` varchar(15) DEFAULT NULL,
  `emp_observacao` text DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 ROW_FORMAT=FIXED;

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `user_id` int(11) NOT NULL,
  `user_usuario` varchar(50) NOT NULL,
  `user_password` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`user_id`, `user_usuario`, `user_password`) VALUES
(1, 'Admin', '1234');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`cli_id`);

--
-- Índices para tabela `contapagar`
--
ALTER TABLE `contapagar`
  ADD PRIMARY KEY (`pag_id`);

--
-- Índices para tabela `contareceber`
--
ALTER TABLE `contareceber`
  ADD PRIMARY KEY (`rec_id`);

--
-- Índices para tabela `empresa`
--
ALTER TABLE `empresa`
  ADD PRIMARY KEY (`emp_id`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `cli_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `contapagar`
--
ALTER TABLE `contapagar`
  MODIFY `pag_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `contareceber`
--
ALTER TABLE `contareceber`
  MODIFY `rec_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `empresa`
--
ALTER TABLE `empresa`
  MODIFY `emp_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
