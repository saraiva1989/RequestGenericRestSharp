# RequestGenericRestSharp
Feito uma classLibrary em .net core para testar request realizadas com o restsharp.

Foi feito um metodo que recebe o cabeçalho (headers), os parametros ou corpo (param or body), o tipo (get, post...) e a URL base.
Esse método irá retornar o json da request, após ter o retorno basta pegar os dados e deserializar utilizando uma modelo com Newtonsoft.Json.

Foi criado um projeto de teste apenas para facilitar no debugger. Não é coerente fazer teste de unidade validando retorno de banco de dados ou API, o teste de unidade deve ser feito apenas para validar a logica do metodo.

Esse é apenas um projeto de estudo e testes.
