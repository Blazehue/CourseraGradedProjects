#!/bin/bash

# Student Grade Management System - Build and Run Script
# This script builds and runs the C# console application in one step

echo "Student Grade Management System - Build and Run"
echo "=============================================="
echo

# Function to check if .NET is installed
check_dotnet() {
    if ! command -v dotnet &> /dev/null
    then
        echo "ERROR: .NET SDK is not installed."
        echo "Please install .NET 6.0 or later from https://dotnet.microsoft.com/download"
        exit 1
    fi
}

# Function to check if project file exists
check_project() {
    if [ ! -f "StudentGradeManagementSystem.csproj" ]; then
        echo "ERROR: Project file not found!"
        echo "Please run this script from the project directory."
        exit 1
    fi
}

# Function to build the project
build_project() {
    echo "Building the project..."
    echo "-----------------------"
    dotnet build

    if [ $? -eq 0 ]; then
        echo
        echo "Build successful!"
        return 0
    else
        echo
        echo "Build failed. Please check the error messages above."
        exit 1
    fi
}

# Function to run the application
run_application() {
    echo
    echo "Starting the application..."
    echo "---------------------------"
    echo
    dotnet run
}

# Main execution flow
main() {
    check_dotnet
    # Display .NET version
    echo "Found .NET version: $(dotnet --version)"
    echo
    
    check_project
    build_project
    run_application
    
    echo
    echo "Application finished."
}

# Run main function
main