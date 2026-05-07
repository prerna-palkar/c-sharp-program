# Login to Azure
az login

# Create Resource Group
az group create \
--name MyResourceGroup \
--location centralindia

# Create App Service Plan
az appservice plan create \
--name MyAppServicePlan \
--resource-group MyResourceGroup \
--sku FREE

# Create Web App
az webapp create \
--resource-group MyResourceGroup \
--plan MyAppServicePlan \
--name MyDotNetWebApp \
--runtime "DOTNET|8.0"

# Publish .NET Application
dotnet publish -c Release

# Deploy ZIP Package
az webapp deploy \
--resource-group MyResourceGroup \
--name MyDotNetWebApp \
--src-path ./bin/Release/net8.0/publish
