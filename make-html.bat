:: Get the current directory of script
SET root=%1
SET mypath=%2
SET pythonScript=%root%make-cs-markdown-html.py

:: Load custom CSS theme (JSON format)
SET pandocStyle=%root%pandoc\tango.theme

echo ROOT %root% ---------------------------------------------------------------------
echo PATH %mypath% ---------------------------------------------------------------------

:: 
CD %mypath%
echo ROOT: %root%
echo SCRIPT: %pythonScript%

::ECHO FOUND FILES:
forfiles /S /M "*.cs" /C "cmd /C echo @PATH"

::ECHO PYTHON SCRIPT
forfiles /S /M "*.cs" /C "cmd /c python %pythonScript% @PATH csharp .cs"

::ECHO PANDOC
forfiles /S /M "*.cs" /C "cmd /C pandoc -s -o @PATH.html @PATH.md --verbose --metadata lang=en-CA --highlight-style=%pandocStyle%"
forfiles /S /M "*.cs.html" /C "cmd /C ECHO @path"
::ECHO PANDOC DONE

:: return to root
CD %root% 