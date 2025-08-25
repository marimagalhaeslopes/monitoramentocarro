# 🚗 Desafio de Console – Monitoramento de Carros  

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)  
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)  
![Status](https://img.shields.io/badge/status-concluído-brightgreen?style=for-the-badge)  

Este projeto é um programa de **console em C#** que realiza o **monitoramento de informações de carros**, aplicando conceitos de **Lógica de Programação** e **Programação Orientada a Objetos (POO)**.  

O objetivo é verificar se um carro está **apto** ou **não apto** para uso, com base em sua idade.  

---

## 🛠️ Tecnologias Utilizadas
- **C#**
- **.NET Console Application**

---

## 📋 Descrição da Lógica
1. O usuário fornece como entrada:
   - Modelo do carro
   - Ano de fabricação
   - Ano atual

2. O programa calcula a idade do carro:
   ```csharp
   int idadeCarro = anoAtual - anoFabricacao;
3.Critério de aptidão:
Até 10 anos → Apto
Mais de 10 anos → Não apto

## 📌 Demonstração:
Entrada:
```bash
  Civic
  2016
  2025
```

Saída:
```bash
Civic: Apto
```

## 🚀 Conceitos Aplicados

  - Leitura de dados com Console.ReadLine
  - Conversão de tipos com int.Parse
  - Criação de métodos estáticos
  - Estrutura condicional (if/else)
  - Encapsulamento de lógica em métodos

## ▶️ Como Executar

Clone este repositório:
```
git clone https://github.com/seu-usuario/CarroMonitoramento.git
```

Entre na pasta do projeto:
```
cd CarroMonitoramento/src
```

Execute:
```
dotnet run
```

##📜 Licença

Este projeto foi desenvolvido para fins de estudo, fique à vontade para usar e modificar como quiser.
