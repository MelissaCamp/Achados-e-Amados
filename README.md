# 🐾 Achados e Amados – Sistema de Adoção de Animais

## 💡 Objetivo
O projeto **Achados e Amados** foi desenvolvido para uma ONG com o propósito de facilitar o processo de adoção de animais.  
A plataforma permite o gerenciamento de cadastros de clientes, funcionários e animais disponíveis, tornando a adoção mais acessível, organizada e eficiente.

---

## ⚙️ Funcionalidades

### 👤 Cadastro de Usuários e Funcionários
- Cadastro e login de clientes interessados em adoção  
- Cadastro de funcionários autorizados a gerenciar o sistema de acordo com suas funções

### 🐶 Gerenciamento de Animais
- Registro e gerenciamento de animais disponíveis para adoção  
  - Nome, raça, idade, sexo, porte, descrição, tipo, data de cadastro, status (vacinado, castrado), foto  
- Atualização do status do animal (disponível ou adotado)

### 📋 Processos Administrativos
- Controle de usuários com diferentes permissões (cliente vs. funcionário)  
- Aplicativo para desktop, acessível apenas aos funcionários, para acompanhamento do processo de adoção

---

## 🛠️ Tecnologias Utilizadas

- **Frontend:** HTML5, CSS3, JavaScript  
- **Backend:** C# e ASP.NET  
- **Banco de Dados:** MySQL  
- **Ferramentas Adicionais:**  
  - Visual Studio Code  
  - Visual Studio 2022  
  - Cloudinary (armazenamento de imagens)  
  - Azure (hospedagem e serviços em nuvem)

---

## 🧩 Estrutura do Sistema

### Interface (Site) e Aplicativo
- Páginas responsivas e intuitivas para clientes  
- Aplicativo móvel/desktop voltado para uso dos funcionários  
- Layout focado na visualização clara e no gerenciamento dos animais para adoção

### Regras de Negócio
- Apenas funcionários podem cadastrar e editar dados dos animais  
- Clientes só podem adotar animais com status "disponível"

### Banco de Dados Relacional
- Tabelas principais:  
  - `clientes`, `funcionarios`, `animais`, `adocoes`  
- Chaves estrangeiras e integridade referencial garantida

### Segurança
- Sistema de login com autenticação básica  
- Acesso diferenciado por tipo de usuário (cliente ou funcionário)

---

## 🌟 Impacto Esperado

- Auxiliar a ONG no controle e divulgação dos animais para adoção  
- Melhorar o relacionamento com adotantes por meio de um sistema transparente e organizado  
- Promover o bem-estar animal com mais rapidez e segurança nos processos de adoção
