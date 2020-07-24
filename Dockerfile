FROM openjdk:8u262-jdk

ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT 1

COPY ./Server/bin/Release/netcoreapp5.0/publish /usr/src/code
COPY ./start-server.sh /usr/src/startup/start-server.sh
COPY ./eula.txt /usr/src/prestart/eula.txt

RUN mkdir /usr/src/Build
RUN curl -o /usr/src/Build/BuildTools.jar https://hub.spigotmc.org/jenkins/job/BuildTools/lastSuccessfulBuild/artifact/target/BuildTools.jar

WORKDIR /usr/src/Build

RUN java -jar  /usr/src/Build/BuildTools.jar --rev 1.16.1

WORKDIR /usr/src/server

CMD /usr/src/startup/start-server.sh
