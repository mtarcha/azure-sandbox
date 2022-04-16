# azure-sandbox

Result: 
- Github repo with small app that includes ARM templates with some basic azure resources
- Basic resources to know:
  - App Service 
  - App Service Plan
  - Azure Function
  - Application Insights (Log ananlyses, KUSTO/kql, Alerts, Action Groups)
  - Sql
  - Storage account
  - Azure Service Bus
  - Key Vault
  
  Optional:
  - Logical App
  - Azure Cosmos DB
  - CDN
  
 
## Task #1
- Use Azure
  - App Service Plan
  - App Service/Web App
  - Sql
  - ARM
- Tech stack
  - WebApi
  - Blazor
  - EF

- Build application with several fields and button to publish input data to db
- Play around with azure portal 
  - Create manually necessary resources: web app, app service plan, sql
  - Try to export manual work to arm template
- Add arm templates to the project
- Create github build actions to deploy the app to azure

## Task #1.2
- Add Key Vault to the app and move secrets from appsettings and arm to the vault

## Task #2
- Use Azure
  - Cosmos Db
  - Cosmos Db Explorer (tool to view cosmos data)
  
- Add new page with the same functionality but to safe to cosmos db

## Task #3
- Use Azure
  - Storage account (table storage)
  - Storage explorer

- Add new page with the same functionality but to safe to Storage Account (table storage)

## Task #4
- Use Azure
  - Azure Monitor: Application Insights, Dashboards, kql
  
- Add button to generate exceptions
- Add Application Insights support to the app and ARM
- Create alert rule with alert action group
- Crate a dashboard using metrics and kql 

## Task #5
- Add Azure Service Bus support to arm and app
- Add page to pulish message to Azure Service bus
- Add Azure Function with bus trigger to consume the message from the bus

## Task #6
- Add page to pulish message to Storage account (queues)
- Add Azure Function with account trigger to consume the message from the queue

## Task #7
- Add page with image upload, use Storage account (files)
- Add Azure function to add watermark
- Add CDN support on top of the images to show the image in the blazor page
