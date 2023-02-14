ECHO OFF

:: Get the current directory of script
SET curr=%~dp0
SET examples=%curr%examples\
SET exercises=%curr%exercises\

CALL make-html.bat %curr% %examples%
CALL make-html.bat %curr% %exercises%
