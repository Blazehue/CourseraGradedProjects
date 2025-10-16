#!/bin/bash

# Student Grade Management System - Run Script
# This script builds and runs the C# console application

echo "Student Grade Management System"
echo "==============================="
echo

# Check if .NET is installed
if ! command -v dotnet &> /dev/null
then
    echo "ERROR: .NET SDK is not installed."
    echo "Please install .NET 6.0 or later from https://dotnet.microsoft.com/download"
    exit 1
fi

# Display .NET version
echo "Found .NET version: $(dotnet --version)"
echo

# Check if project file exists
if [ ! -f "StudentGradeManagementSystem.csproj" ]; then
    echo "ERROR: Project file not found!"
    echo "Please run this script from the project directory."
    exit 1
fi

echo "Building the project..."
echo "-----------------------"
dotnet build

if [ $? -eq 0 ]; then
    echo
    echo "Build successful!"
    echo
    echo "Starting the application..."
    echo "---------------------------"
    echo
    dotnet run
else
    echo
    echo "Build failed. Please check the error messages above."
    exit 1
fi

echo
echo "Application finished."