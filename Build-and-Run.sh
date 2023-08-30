#!/bin/bash

cd src/Web

echo "Tailwind генерирует стили..."
./tailwind -i Styles/app.css -o wwwroot/css/app.css --minify

echo "Компилируется проект..."
dotnet publish -c Release 

echo "Остановка предыдущего контейнера..."
podman stop test

echo "Собирается Docker образ программы..."
podman build . -t blazortest

echo "Запускается контейнер с программой..."
podman run \
-d \
--rm \
-p 8000:80 \
-v ./tmp/Data:/app/wwwroot/posters:Z \
-v ./tmp/Database:/app/Database:Z \
--name test \
--env TZ=Asia/Barnaul \
blazortest

echo "Готово"