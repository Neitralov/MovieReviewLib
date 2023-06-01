#!/bin/bash

echo "Tailwind генерирует стили..."
./tailwind -i Styles/app.css -o wwwroot/css/app.css --minify

echo "Запускается проект..."
electronize start

echo "Готово"