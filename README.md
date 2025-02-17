# Investment Management Platform

## Описание
Investment Management Platform - это комплексная система для управления инвестициями, включающая модули для анализа рынка, управления активами, оценки рисков, проведения сделок и отчетности.

## Структура проекта
Проект разделен на несколько слоев для улучшения читаемости и поддерживаемости кода:

- **Domain**: Основная бизнес-логика и правила.
- **Application**: Интерфейсы, юзкейсы и реализации для работы с данными.
- **Infrastructure**: Реализация деталей инфраструктуры, таких как модели данных, контроллеры и утилиты.
- **Presentation**: Визуализация данных и взаимодействие с пользователем.

## Установка
1. Клонируйте репозиторий:
    ```bash
    git clone <URL репозитария>
    ```
2. Перейдите в каталог проекта:
    ```bash
    cd investment_management
    ```
3. Откройте решение в Visual Studio:
    ```plaintext
    InvestmentManagement.sln
    ```

## Запуск
Для запуска проекта выполните следующие шаги:

1. Постройте проект в Visual Studio.
2. Запустите проект, нажав кнопку "Start" или нажав клавишу F5.

## Структура каталогов
```plaintext
investment_management/
├── InvestmentManagement.sln
├── src/
│   ├── Domain/
│   │   ├── Entities/
│   │   │   ├── Asset.cs
│   │   │   └── Transaction.cs
│   │   ├── Repositories/
│   │   │   └── IAssetRepository.cs
│   │   ├── Services/
│   │   │   └── AssetService.cs
│   │   └── UseCases/
│   │       └── ManageAsset.cs
│   ├── Infrastructure/
│   │   ├── Models/
│   │   │   └── AssetModel.cs
│   │   ├── Repositories/
│   │   │   └── AssetRepository.cs
│   │   ├── Controllers/
│   │   │   └── AssetController.cs
│   ├── Application/
│   │   ├── Program.cs
├── tests/
│   ├── DomainTests/
│   │   └── AssetServiceTests.cs
├── InvestmentManagement.sln
└── README.md
```

## Описание компонентов
### Domain
- **Asset.cs**: Класс сущности актива.
- **Transaction.cs**: Класс сущности транзакции.
- **IAssetRepository.cs**: Интерфейс репозитория активов.

### Application
- **ManageAsset.cs**: Юзкейс для управления активами.
- **AssetService.cs**: Сервис для управления активами.

### Infrastructure
- **AssetModel.cs**: Модель данных актива.
- **AssetRepository.cs**: Реализация репозитория активов.
- **AssetController.cs**: Контроллер для управления активами.

### Presentation
- **DataView.cs**: Представление для отображения активов (если необходимо).

## Лицензия
Этот проект лицензирован под лицензией MIT. Для получения дополнительной информации см. файл LICENSE.
