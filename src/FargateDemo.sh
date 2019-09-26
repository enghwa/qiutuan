#!/bin/bash

export ConnectionStrings__Default="Server=$MSSQL_SERVER; Database=FargateDemoDb; User=sa; Password=$SA_PASSWORD"
cd /app
dotnet FargateDemo.Web.Host.dll