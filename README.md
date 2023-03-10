# Тестовое задание от versta24
Реализовать простое Web приложение для приемки заказа на доставку со следующим функционалом:

1. Форма создания нового заказа (все поля обязательны для заполнения):
- Город отправителя
- Адрес отправителя
- Город получателя
- Адрес получателя
- Вес груза
- Дата забора груза

2. Форма отображения списка заказов: все созданные заказы должны отображаться в отдельной форме. Помимо полей, введенных пользователем при создании заказа, должен отображаться автоматически сгенерированный номер заказа.

3. Форма просмотра созданного заказа в режиме чтения. Должна открываться при клике на заказ в списке заказов.

# Технологии
Использован следующий стек технологий:
- ASP.NET 7 на backend
- ASP.NET MVC
- Entity Framework
- localDB

# Инструкция по запуску
- Установить [.NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- Установить последнюю версию [Visual Studio 2022](https://visualstudio.microsoft.com/ru/vs/) 
- Загрузить и распаковать репозиторий
- Открыть проект
- Создать пустую базу данных с именем `versta24_Database` на сервере по умолчанию
- В консоль диспетчера пакетов ввести `update-database`
- Запустить проект через комбинацию `Ctrl+F5`
- После загрузки приложение будет доступно по адресу `https://localhost:7011/`

Если не запускается, возможно стоит обновить сервер:
- [SQL Server Express LocalDB](https://learn.microsoft.com/ru-ru/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver16)
База данных находится в `\versta24\_DataBase`

![image_2023-01-23_00-11-22](https://user-images.githubusercontent.com/29130600/213940826-0bbe7e3f-4cf7-48ac-9435-25b174cc6424.png)
![image_2023-01-23_00-12-34](https://user-images.githubusercontent.com/29130600/213940829-77888ff5-9326-4a63-af8c-e88b27848a36.png)
![image_2023-01-23_00-11-09](https://user-images.githubusercontent.com/29130600/213940830-d7896b75-97f1-49e1-aefa-4a8d8b836a65.png)
![image](https://user-images.githubusercontent.com/29130600/213940843-58109cb2-3cab-483d-af42-9979ee570bc0.png)
