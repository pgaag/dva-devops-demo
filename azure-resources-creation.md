## The Azure Resources which are required for this project were created via the Azure-Command-Line (Azure CLI).

The following commands were used:

**Create AppService Plan**

- ` az appservice plan create -g 'DVA-DevOps' -n 'devops-demo-service-plan' --sku 'F1' --location 'Germany West Central'`

**Create Azure WebApp**

- `az webapp up --sku F1 --name 'dotnet-dva-devops-demo' --resource-group 'DVA-DevOps' --plan 'devops-demo-service-plan' --location 'Germany West Central' --os-type 'windows' `
