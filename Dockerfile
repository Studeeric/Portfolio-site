# Base image
FROM mcr.microsoft.com/mssql/server

# Set environment variables
ENV ACCEPT_EULA=Y

# Copy the SQL Server database script to initialize the database
COPY init-database.sql /usr/src/app/

# Grant permissions to the script
USER root
RUN chown mssql /usr/src/app/init-database.sql
USER mssql

# Set the entrypoint to execute the script on container startup
ENTRYPOINT ["/bin/bash", "-c", "/opt/mssql/bin/sqlservr & /usr/src/app/init-database.sql"]
