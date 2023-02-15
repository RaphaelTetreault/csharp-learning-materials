:: Set up varaibles passed from caller
set root=%1
set target=%2
set language=%3
set extension=%4
:: Path to python script
set pythonScript=%root%make-code-markdown.py
:: Load custom CSS theme (JSON format)
set pandocStyle=%root%pandoc\tango.theme

:: DEBUG
echo.
echo ----------------------------------------------------------------------
:: PINT THIS FILE NAME
echo active script: %~n0%~x0
echo root %root%
echo target %target%
echo language %language%
echo extension %extension%
echo pythonScript %pythonScript%
echo ----------------------------------------------------------------------

:: Go to target directory
pushd %target%

:: Print all files found using search query
::forfiles /S /M "*%extension%" /C "cmd /C echo @PATH"
:: Process all input files into .md Markdown files
forfiles /S /M "*%extension%" /C "cmd /c python %pythonScript% @PATH %language% %extension%"
:: Process all Markdown files into HTML files
forfiles /S /M "*%extension%" /C "cmd /C pandoc -s -o @PATH.html @PATH.md --metadata lang=en-CA --highlight-style=%pandocStyle%"
:: Print all files HTML generated
echo.
echo Created HTML files:
forfiles /S /M "*%extension%.html" /C "cmd /C ECHO @path"

:: Return to previous directory
popd