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
- Загрузить и распаковать репозиторий
- В распакованной папке `versta24-master` перейти в каталог `versta24`
- Нажать ПКМ в свободной области и открыть командную строку, ввести `dotnet run`
- После загрузки приложение будет доступно по адресу `https://localhost:7011/`