chcp 65001
@echo off

set projeto=%1

echo Criando projeto %projeto%...

dotnet dotnet new console -n %projeto%

echo Copiando Modelo.cs para %projeto%...
copy Modelo.cs  %projeto%\Program.cs

cd %projeto%

echo Tarefas concluídas com sucesso!
