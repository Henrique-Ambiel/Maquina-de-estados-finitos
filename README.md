# 🎮 Máquina de Estados Finitos para NPCs
Este repositório contém um projeto desenvolvido no âmbito da disciplina de Jogos Digitais do curso de Jogos Digitais da PUC Campinas 🎓. O objetivo principal foi implementar uma máquina de estados finitos (FSM) para gerenciar o comportamento de NPCs em jogos, utilizando recursos como enums e interfaces para facilitar a transição entre os estados e a execução das condições de cada um.

## 🕹️ Sobre o Projeto
O projeto simula o comportamento de um NPC dentro de um jogo, onde o NPC pode mudar de estado (ex: patrulhando, perseguindo, atacando) conforme condições pré-definidas são atendidas. A implementação usa a máquina de estados finitos para controlar essas transições de maneira modular e reutilizável, o que torna o código mais eficiente e fácil de gerenciar.

## 🚀 Tecnologias Utilizadas
- 💻 Linguagem: C#
- ⚙️ Estruturas: Enums, Interfaces
- 🔧 Conceitos: Máquina de Estados Finitos (FSM)

## ⚙️ Como Funciona
- 1️⃣ A máquina de estados finitos é composta por estados diferentes que o NPC pode assumir, como "Patrulha", "Perseguição" e "Ataque".
- 2️⃣ Cada estado possui suas próprias condições de transição, que são verificadas constantemente durante o jogo.
- 3️⃣ A lógica do código é estruturada em torno de enums para representar os estados e interfaces para definir a comunicação entre os diferentes estados e o NPC.
- 4️⃣ A cada atualização do jogo, o NPC verifica suas condições e transita entre os estados de acordo com os parâmetros definidos.

## 🎯 Objetivo
Este projeto tem como principal objetivo demonstrar o uso de Máquinas de Estados Finitos (FSM) para gerenciar o comportamento de NPCs de forma eficiente e escalável. A aplicação de enums e interfaces visa tornar o código modular, permitindo fácil manutenção e expansão. O projeto é parte das atividades acadêmicas do curso de Jogos Digitais da PUC Campinas, abordando conceitos importantes para o desenvolvimento de IA em jogos.
