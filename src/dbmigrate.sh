#!/bin/bash

export ConnectionStrings__Default="Server=$MSSQL_SERVER; Database=FargateDemoDb; User=sa; Password=$SA_PASSWORD"

dotnet FargateDemo.Migrator.dll -q
