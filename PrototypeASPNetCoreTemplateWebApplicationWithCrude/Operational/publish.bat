rem SQL2X Generated code based on a SQL Server Schema
rem SQL2X Version: 1.0
rem http://sql2x.org/
rem Generated Date: 4/23/2020 11:49:39 AM
rem Template: sql2x.PrototypeDotNetCoreTwoOoneV3.Content_publishStartDOTbat
@echo off
set path=%path%;C:\Program Files (x86)\IIS\Microsoft Web Deploy V3\
@echo on
msdeploy.exe ^
	-source:manifest='SourceManifest.xml' ^
	-dest:manifest='DestinationManifest.xml',^
ComputerName='https://NorSolutionPimCore.scm.azurewebsites.net/msdeploy.axd?site=NorSolutionPimCore',^
UserName='$NorSolutionPimCore',^
Password='xxx',^
IncludeAcls='False',^
AuthType='Basic' ^
	-verb:sync ^
	-enablerule:AppOffline ^
	-retryAttempts:20
