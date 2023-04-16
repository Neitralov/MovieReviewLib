#!/bin/bash

dotnet publish -c Release 
podman stop test
podman build . -t blazortest

podman run \
-d \
--rm \
-p 8000:80 \
-v ./tmp/Data:/app/wwwroot/posters:Z \
-v ./tmp/Database:/app/Database:Z \
--name test \
--env TZ=Asia/Barnaul \
blazortest