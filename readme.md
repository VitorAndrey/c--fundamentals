## C# compilation and execution

Quando você executa um projeto no Visual Studio, várias etapas são envolvidas, muitas das quais utilizam o .NET CLI. Primeiro, o Visual Studio chama o .NET CLI para buildar o projeto, verificando erros de sintaxe e garantindo que todas as funções sejam chamadas corretamente.

O código é então convertido para uma linguagem intermediária, que é independente da plataforma. O Common Language Runtime (CLR) converte essa linguagem intermediária em código nativo, adaptando-o ao sistema operacional e à arquitetura do processador em uso. O código resultante pode ser executado diretamente no terminal usando um arquivo .dll com o comando .net ou um arquivo .exe.

O CLR age como uma máquina virtual que faz essa conversão, e o Just-In-Time (JIT) compila o código em tempo de execução, enquanto o Ahead-Of-Time (AOT) faz a compilação antes da execução. Além disso, o comando publish pode ser utilizado para disponibilizar o projeto na nuvem.
