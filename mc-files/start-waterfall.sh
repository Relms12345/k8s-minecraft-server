#!/bin/bash

if [ -z "$(ls .)" ];
  then
    echo Target dir is empty... Generating required files...
    mv /usr/src/jar/waterfall.jar /usr/src/server/waterfall.jar
    echo Done
else
  if [ -f waterfall.jar ];
    then
      echo Found Waterfall file...
  else
    echo Waterfall file not found... moving file to target dir...
    mv /usr/src/jar/waterfall.jar /usr/src/server/waterfall.jar
    echo Done
  fi
fi

echo Prechecks complete. Starting Minecraft server now.
java -Xms512M -Xmx512M -jar waterfall.jar