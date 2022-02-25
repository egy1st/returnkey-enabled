[Setup]
AppName=DynamicComponents Returnkey Enable v4.0
AppVerName=DC Returnkey Enable v4.0
AppPublisher=EgyFirst Software , Inc.
AppPublisherURL=http://www.egy1st.com
AppSupportURL=support@egy1st.com
DefaultDirName={pf}\Dynamic Components\Returnkey Enable\
DefaultGroupName=Dynamic Components\Returnkey Enable\
LicenseFile=License.txt
OutputBaseFilename=returnkey_enable
VersionInfoCompany=EgyFirst Software , LLC.
VersionInfoDescription=Dynamic Components Returnkey Enable
VersionInfoVersion=4.0.0.0
InfoAfterFile=How to order.txt
RestartIfNeededByRun = True
WizardImageFile = Big02.bmp
WizardSmallImageFile=logo.bmp
BackColorDirection =toptobottom
BackColor = clBlue
BackColor2= clgreen
BackSolid=false
WindowStartMaximized=yes
WindowVisible=yes
WindowShowCaption=no
AppCopyright=EgyFirst Software 2005-2016 Copyright


[Tasks]
Name: "desktopicon"; Description: "Create a &desktop icon"; GroupDescription: "Additional icons:"; Flags: unchecked


[Files]
Source: "DC_ReturnkeyEnable40.dll"; DestDir: "{app}"
Source: "DC ReturnKeyEnable v4.0.chm"; DestDir: "{app}"
Source: "License.txt"; DestDir: "{app}"
Source: "License Agreement.doc"; DestDir: "{app}"
Source: "DC_ReturnkeyEnable.exe"  ; DestDir: "{app}"
Source: "nWind.accdb"; DestDir: "{app}"


; Visual Studio 2010 ////////////////////////////////////////////////////////
Source: "Tutorials\Visual Studio 2010\*.*"; DestDir: "{app}\Tutorials\Visual Studio 2010\"
Source: "Tutorials\Visual Studio 2010\My Project\*.*"; DestDir: "{app}\Tutorials\Visual Studio 2010\My Project"
Source: "DC_ReturnkeyEnable40.dll"; DestDir: "{app}\Tutorials\Visual Studio 2010\bin\Debug"
Source: "nWind.accdb"; DestDir: "{app}\Tutorials\Visual Studio 2010\bin\Debug"
;////////////////////////////////////////////////////////


[LangOptions]
LanguageName=English
LanguageID=$0409
DialogFontName=
DialogFontSize=8
WelcomeFontName=Verdana
WelcomeFontSize=12
TitleFontName=Arial
TitleFontSize=29
CopyrightFontName=Arial
CopyrightFontSize=10

[Icons]

Name: "{group}\Help"; Filename: "{app}\DC ReturnkeyEnable v4.0.chm"
Name: "{group}\Tutorials"; Filename: "{app}\Tutorials\"
Name: "{group}\Register DC_ReturnkeyEnable35"; Filename: "{app}\DC_ReturnkeyEnable35_Registrar.exe"
Name: "{group}\Uninstall DC Returnkey Enable"; Filename: "{app}\unins000.exe"
Name: "{userdesktop}\DC Returnkey Enable v4.0"; Filename: "{app}"; Tasks: desktopicon

[Run]
; NOTE: The following entry contains an English phrase ("Launch"). You are free to translate it into another language if required.
Filename: "{app}\DC_ReturnkeyEnable35.exe"; Description: "Activate Trial"; Flags: shellexec postinstall skipifsilent
Filename: "{app}\DC ReturnkeyEnable v4.0.chm"; Description: "Launch Help"; Flags: shellexec postinstall skipifsilent
Filename: "{app}\Tutorials\"; Description: "Tutorials"; Flags: shellexec postinstall skipifsilent

