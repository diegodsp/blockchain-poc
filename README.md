# Testes com o conceito de Blockchain

## Criado em .net core 5.0

Para rodar este projeto, sem intenção de ensinar padre a rezar missa, segue o comando.
```
dotnet run
```

A idéia é criar uma sequência que não pode ser alterada, devido a verificação do bloco anterior em conjunto com o bloco atual.
Basicamente criar um bloco inicial, chamado de gênesis, e a partir dele criar os demais blocos. Sempre usando a chave criada anteriormente para criar a chave do bloco atual.

## Primeiros resultados
![image](https://user-images.githubusercontent.com/15212240/125945836-582565dd-aaea-4379-a82e-ae8bf15d91de.png)

----

Para testar o projeto, segue o comando.
```
dotnet test
```

## Primeiros testes

```bash
➜  Test git:(main) ✗ dotnet test
  Determinando os projetos a serem restaurados...
  Todos os projetos estão atualizados para restauração.
  BlockchainPoc -> ./blockchain-poc/Console/bin/Debug/netcoreapp5.0/BlockchainPoc.dll
  BlockchainPoc-Test -> ./blockchain-poc/Test/bin/Debug/net5.0/BlockchainPoc-Test.dll
Execução de teste para ./blockchain-poc/Test/bin/Debug/net5.0/BlockchainPoc-Test.dll (.NETCoreApp,Version=v5.0)
Ferramenta de Linha de Comando de Execução de Teste da Microsoft (R) Versão 16.10.0
Copyright (c) Microsoft Corporation. Todos os direitos reservados.

Iniciando execução de teste, espere...
1 arquivos de teste no total corresponderam ao padrão especificado.
  Com falha AlteraUmItem(3,"Teste alterado") [32 ms]
  Mensagem de erro:
   System.Exception : Sequência inválida no índice #3
  Rastreamento de pilha:
     at Blockchain.Sequence.Validate() in ./blockchain-poc/Console/Blockchain/Sequence.cs:line 19
   at BlockchainPoc.Tests.AlteraUmItem(Int32 idx, String content) in ./blockchain-poc/Test/MainTest.cs:line 35
  Com falha RemoveUmItem(2) [< 1 ms]
  Mensagem de erro:
   System.Exception : Sequência inválida no índice #2
  Rastreamento de pilha:
     at Blockchain.Sequence.Validate() in ./blockchain-poc/Console/Blockchain/Sequence.cs:line 19
   at BlockchainPoc.Tests.RemoveUmItem(Int32 idx) in ./blockchain-poc/Test/MainTest.cs:line 27

Com falha! – Com falha:     2, Aprovado:     1, Ignorado:     0, Total:     3, Duração: 84 ms - ./blockchain-poc/Test/bin/Debug/net5.0/BlockchainPoc-Test.dll (net5.0)
```

|Teste|Resultado|
|---|---|
|Remover um item do início|ok|
|Remover um item do meio|falha|
|Alterar um item|falha|
