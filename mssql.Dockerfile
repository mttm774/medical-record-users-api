FROM mcr.microsoft.com/azure-sql-edge:latest
RUN mkdir -p /usr/config

COPY docker/create_db.sql /usr/config/

EXPOSE 1433
