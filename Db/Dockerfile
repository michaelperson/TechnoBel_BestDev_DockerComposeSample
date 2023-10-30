FROM mcr.microsoft.com/mssql/server:2022-latest

#Variables d'environement 
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=Test1234@
ENV MSSQL_PID=Developer
ENV MSSQL_TCP_PORT=1433

#Me déplacer dans le rep de travail
WORKDIR /src 
#Copier notre script de création dans le dossier
COPY ./scripts/GenerateDb.sql ./GenerateDb.sql
#Exécuter le script de création
#RUN (opt/mssql-tools/bin/sqlcmd -s 127.0.0.1 -U sa -P Test1234@ -i GenerateDb.sql)
 
#Enjoy :)