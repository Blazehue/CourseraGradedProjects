@echo off
echo Building Student Grade Management System...
echo.

if exist "bin\Debug\net6.0" (
    echo Cleaning previous build...
    rmdir /s /q bin\Debug\net6.0
)

echo Compiling...
dotnet build

if %errorlevel% == 0 (
    echo.
    echo Build successful!
    echo.
    echo To run the application, use: dotnet run
) else (
    echo.
    echo Build failed. Please check the error messages above.
)

pause