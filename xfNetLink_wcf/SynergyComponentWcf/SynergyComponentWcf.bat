IF EXIST "SynergyComponentWcf.dll" del "SynergyComponentWcf.dll"
IF NOT EXIST "SynergyComponentWcf.snk" sn -k "SynergyComponentWcf.snk"
if '%1' == '-p' goto pooling
csc /nologo /target:library /out:"SynergyComponentWcf.dll" /reference:"%XFNLNET%\xfnlnet.dll" /optimize /keyfile:"SynergyComponentWcf.snk" %SYNCSCOPT% @SynergyComponentWcf.rsp
goto done
:pooling
csc /nologo /target:library /define:POOLING /out:"SynergyComponentWcf.dll" /reference:"%XFNLNET%\xfnlnet.dll" /optimize /keyfile:"SynergyComponentWcf.snk" %SYNCSCOPT% @SynergyComponentWcf.rsp
:done
