FROM microsoft/aspnet:4.6.2

RUN Add-WindowsFeature Web-Server; \
Add-WindowsFeature NET-WCF-TCP-Activation45; \
Add-WindowsFeature NET-WCF-HTTP-Activation45; \
Add-WindowsFeature Web-WebSockets

ARG source
WORKDIR /inetpub/wwwroot
COPY ${source:-obj/Docker/publish} .
