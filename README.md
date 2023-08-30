# 🎥 MovieReviewLib
Домашняя библиотека обзоров фильмов.

# 🔥 Возможности
* 💾 Хранение ваших воспоминаний о просмотренных произведениях в виде красивой коллекции карточек.
* 🔍 Быстрый поиск по библиотеке.
* 🏷️ Сортировка данных по множеству параметров.
* 📊 Анализ библиотеки и сводка данных в виде статистики.

# 🖼️ Скриншоты
![image](https://github.com/Neitralov/MovieReviewLib/assets/109409226/72dc7b93-117e-47cc-8fd5-45572d8e3767)
![image](https://github.com/Neitralov/MovieReviewLib/assets/109409226/f1d5debf-29c0-4519-a5c3-d4073c4980aa)

# 🚀 Как запустить?
Для запуска подготовлен Docker образ приложения:
```
docker run \
-d \
-p 7430:80 \
-v ./Data:/app/wwwroot/posters:Z \
-v ./Database:/app/Database:Z \
--name moviereviewlib \
neitralov/moviereviewlib:latest
```
После выполнения команды приложение будет доступно в браузере по адресу `localhost:7430`.

# 🛠️ Как собрать?
1. Убедитесь, что имеете установленный `.NET SDK 7`.
2. Скачайте исходники и из папки проекта выполните скрипт `Build-and-Run.sh`.

После выполнения команды приложение будет доступно в браузере по адресу `localhost:8000`.

# 🧰 Стек технологий
* Web-framework: [ASP.NET Core](https://dotnet.microsoft.com/en-us/apps/aspnet) + [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)
* CSS-framework: [TailwindCSS](https://tailwindcss.com)
* ORM: [EF Core](https://learn.microsoft.com/ru-ru/ef/core/)
* СУБД: [SQLite](https://www.sqlite.org/about.html)

Дополнительные пакеты:
* [Blazored/LocalStorage](https://github.com/Blazored/LocalStorage).

# 📃 Лицензия
Программа распространяется под лицензией [MIT](https://github.com/Neitralov/MovieReviewLib/blob/master/LICENSE).

За исключением шрифта приложения Inter [OFL](https://github.com/Neitralov/MovieReviewLib/blob/master/wwwroot/css/OFL.txt). 
