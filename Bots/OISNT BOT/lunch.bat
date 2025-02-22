@echo off
setlocal

:: Efface la fenêtre de commande
cls

:: Vérifiez si pip est installé
python -m pip --version >nul 2>&1
if %ERRORLEVEL% neq 0 (
    echo "pip n'est pas installé. Assurez-vous d'avoir Python installé correctement."
    pause
    exit /b 1
)

:: Met à jour pip
echo Mise à jour de pip...
python -m pip install --upgrade pip

:: Liste des packages à installer
set PACKAGES="discord.py" "aiohttp" "requests" "instaloader"

:: Installez les packages requis
echo Installation des packages nécessaires...
for %%p in (%PACKAGES%) do (
    python -m pip install --upgrade %%p
)

:: Efface la fenêtre de commande avant d'exécuter le script Python
cls

:: Exécutez le script Python
echo Exécution du script Python...
python main.py

endlocal
pause