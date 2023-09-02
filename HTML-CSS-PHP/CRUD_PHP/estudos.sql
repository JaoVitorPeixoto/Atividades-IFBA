-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Tempo de geração: 02/09/2023 às 15:36
-- Versão do servidor: 10.5.20-MariaDB
-- Versão do PHP: 7.3.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `id21014617_crud`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `cliente`
--

CREATE TABLE `cliente` (
  `id` int(11) NOT NULL,
  `login` varchar(30) NOT NULL,
  `senha` varchar(30) NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `hierarquia` enum('ADM','Cliente') NOT NULL DEFAULT 'Cliente',
  `nome` varchar(255) NOT NULL,
  `telefone` varchar(14) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `data_adicionado` date NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `cliente`
--

INSERT INTO `cliente` (`id`, `login`, `senha`, `cpf`, `hierarquia`, `nome`, `telefone`, `email`, `data_adicionado`) VALUES
(25, 'adm', '1234', '232124', 'ADM', 'Administrador', '8478625632', 'adm@gmail.com', '2023-06-30'),
(28, 'jvfp', '1234', '5648585', 'ADM', 'João Vitor Ferreira Peixoto', '1548962', 'jao@gmail.com', '2023-06-30'),
(29, 'edric15', '1234', '84956156484', 'Cliente', 'Edric Guilherme Bahia de Souza', '51548263151', 'edric@gmail.com', '2023-07-01'),
(44, 'Cleiton', '', '1478479215', 'Cliente', 'Cleiton dos Santos', '178795484', 'Cleiton@gmail.com', '2023-07-02'),
(48, 'Tacio0101', '', '1412312312', 'Cliente', 'TACIOOOO', '71997332171', 'tacio0101@gmail.com', '2023-07-08'),
(53, 'Cucabeludo', 'batpunheta', '12345678910', 'Cliente', 'José astolfo', '41028922', 'giselepequena198@gmail.com', '2023-07-08'),
(54, 'testando', '1234', '123123', 'Cliente', 'Testado', '12312312', 'testando@gmail.com.br', '2023-07-08'),
(55, 'edric', 'edric15', '99999999999', 'Cliente', 'Edric Guilherme', '7199145584', 'edric.bahiasouza@gmail.com', '2023-07-08');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `cpf` (`cpf`),
  ADD UNIQUE KEY `login` (`login`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=56;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
