# 🚗 Sistema de Estacionamento em C#

Projeto desenvolvido em **C#** com foco em **Programação Orientada a Objetos (POO)** e **Clean Code**.  
O sistema simula a gestão de um estacionamento, permitindo cadastrar, remover e listar veículos, além de calcular o valor da estadia.

---

## 📌 Funcionalidades
- Cadastrar veículos através da placa.  
- Remover veículos informando o tempo de permanência.  
- Calcular valor do estacionamento:  
  - **R$5,00** taxa base.  
  - **+ R$2,00** por hora excedente.  
- Listar todos os veículos cadastrados.  

---

## 🛠️ Tecnologias Utilizadas
- C#  
- .NET  

---

## 📂 Estrutura do Código
- `Veiculo.cs`: define a classe `Veiculo` (ex.: `Placa`) — representa um carro no sistema.  
- `Estacionamento.cs`: contém a lógica principal — gerencia a lista de veículos, cadastro, remoção (com cálculo do valor do estacionamento) e listagem.  
- `Menu.cs`: responsável pela interação com o usuário (exibe o menu e chama os métodos do `Estacionamento`).  
- `Programa.cs`: ponto de entrada (`Main`) que inicializa o sistema e executa o menu.

- 📖 Conceitos Aplicados

Programação Orientada a Objetos (POO).

Encapsulamento e responsabilidade única.

Boas práticas de Clean Code.


