#!/bin/bash

if [ -z "$(ls .)" ];
  then
    echo Target dir is empty... Generating required files...
    cd /usr/src/code
    chmod +x ./Server
    ./Server
    cd /usr/src/server
    mv /usr/src/Build/spigot-1.16.1.jar /usr/src/server/spigot.jar
    mv /usr/src/code/server.properties /usr/src/server/server.properties
    mv /usr/src/prestart/eula.txt /usr/src/server/eula.txt
    echo Done
else
  if [ -f spigot.jar ];
    then
      echo Found spigot file...
  else
    echo Spigot file not found... moving file to target dir...
    mv /usr/src/Build/spigot-1.16.1.jar /usr/src/server/spigot.jar
    echo Done
  fi

  cd /usr/src/code
  chmod +x ./Server
  ./Server
  cd /usr/src/server
  
  if [ -f server.properties ];
    then
      echo Regenerating server.properties file...
      rm server.properties
      mv /usr/src/code/server.properties /usr/src/server/server.properties
      echo Done
  else
    echo sever.properties file not found! Moving to target dir...
    mv /usr/src/code/server.properties /usr/src/server/server.properties
    echo Done
  fi
fi

echo Prechecks complete. Starting Minecraft server now.
java -Xms1G -Xmx1G -XX:+UseConcMarkSweepGC -jar spigot.jar nogui