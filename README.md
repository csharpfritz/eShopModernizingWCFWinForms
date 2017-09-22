# eShopModernizingWCFWinForms

## Introduction
This sample project shows how to modernize a traditional Line of Business WinForms applications. The WinForms front-end is a fictional inventory app which allows it's users to track inventory for a variety of items being sold through their store. You can look at inventory counts for particular items at different calendar dates. 

The project showcases the following features:
- Containerizing a WCF Service and consuming it from a WinForms App
- Containerizing a SQL database back-end
- Publishing the SQL database to Azure
- Calling a ASP.NET Core Web API from a WinForms App
- Updating a WinForms App to High DPI compatibility
- Deploying a WinForms App via Centennial

## Prerequisites
System Requirements:
- Windows XX 
- Visual Studio 2017
- .NET Framework 4.7 Installed

## Architecture

![Architecture](assets/architecture.PNG)

The WCF Service exposes a contract to the front-end; the front-end has no understanding of the underlying data layer, but it doesn't care because it has the assurance of the data contract with WCF to get what it needs.

As for the API service, in normal production this service would call out to a back-end. For the purposes of this demo,the API returns a "canned" response.

## WinForms High DPI

High DPI here.

## Containertizing our Application

Containerize app.
