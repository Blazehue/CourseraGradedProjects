#!/bin/bash

# Student Grade Management System - Build Script
# This script builds the C# console application

echo "Student Grade Management System - Build Script"
echo "============================================="
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

# Clean previous build
echo "Cleaning previous build..."
dotnet clean

if [ $? -eq 0 ]; then
    echo "Clean successful!"
else
    echo "Clean failed."
fi

echo
echo "Building the project..."
echo "-----------------------"
dotnet build

if [ $? -eq 0 ]; then
    echo
    echo "Build successful!"
    echo "To run the application, use: dotnet run"
    echo "Or execute the run.sh script"
else
    echo
    echo "Build failed. Please check the error messages above."
    exit 1
fi