@ECHO off

IF EXIST ReleaseBuilder RD ReleaseBuilder /S /Q
IF EXIST TestResults RD TestResults /S /Q

SET CURDIR=%CD%

FOR /F %%i IN (!projects.txt) DO (
CD %%i\
CALL !cleanup.bat
CHDIR /d %CURDIR%
)



PAUSE


