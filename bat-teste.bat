@echo off

echo Criando projeto cordova...
timeout /T 3
cd C:\Users\Aluno\Desktop
call start C:\Users\Aluno\Desktop && cordova create myApp
echo Adicionando android ao projeto...
timeout /T 3
cd MyApp
call start C:\Users\Aluno\Desktop\MyApp
timeout /T 3
echo CONFIGURACAO CONCLUIDA
timeout /T 3

