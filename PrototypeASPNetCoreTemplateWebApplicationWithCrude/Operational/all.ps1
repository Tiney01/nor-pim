﻿# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 4/25/2020 9:44:59 AM
# Template: sql2x.PrototypeDotNetCoreTwoOoneV3.Content_allDOTps1
# Create new .net core 2.1 project
Set-Location ..
# Fix packages
dotnet new razor# Fix packages
dotnet restore  PrototypeASPNetCoreTemplateWebApplicationWithCrude.csproj
# Build
dotnet build  PrototypeASPNetCoreTemplateWebApplicationWithCrude.csproj
# Run
dotnet publish  PrototypeASPNetCoreTemplateWebApplicationWithCrude.csproj
# Publish
# .\publish.bat
Read-Host 'Thats it'
