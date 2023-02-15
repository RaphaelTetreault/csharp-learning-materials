echo off

:: VARIABLES
:: Get the current directory of script
set curr=%~dp0
set examples=%curr%examples\
set exercises=%curr%exercises\
set language=csharp
set extension=.cs

:: Call script on the two folders to process
call make-markdown-html.bat %curr% %examples% %language% %extension%
call make-markdown-html.bat %curr% %exercises% %language% %extension%
