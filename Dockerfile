FROM openjdk:8u262-jdk

ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT 1

COPY ./Server/bin/Release/netcoreapp5.0/publish /usr/src/code
COPY ./mc-files/start-server.sh /usr/src/startup/start-server.sh
COPY ./mc-files/eula.txt /usr/src/prestart/eula.txt
COPY ./mc-files/paper.jar /usr/src/jar/paper.jar

WORKDIR /usr/src/server

CMD /usr/src/startup/start-server.sh
