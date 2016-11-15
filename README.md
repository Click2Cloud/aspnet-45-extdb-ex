# ASP.NET 4.5 and MSSQL Sample Application
This is MSSQL Example Application which demonstrate connectivity between ASP.NET 4.5 and MSSQL on OpenShift 3 Cloud.

## How to run this sample on OpenShift 3

1) To run this sample application on OpenShift 3 Environment, deploy Click2Cloud's ASP.NET Templates on OpenShift 3 environment as specified instructions at https://github.com/Click2Cloud/DotNetOnOpenShift3.

Once ASP.NET Templates availble in OpenShift Web Console, create application using `aspnet-45-mssqlextdb` template and provide this as a source repository url. 

2) Now create table with dummy records in MSSQL Pod running in OpenShift. Connect to MSSQL Database using Port Forwarding and run `CreateTable.sql` script under `DatabaseScript` folder to create table and insert dummy records.
