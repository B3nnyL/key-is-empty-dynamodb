# dynamodb-csharp-api

To replicate `key is empty` error when fetching item from dynamodb

## How to use
- Run docker-compose to start localstack
- Run `terraform -chdir=infra apply` to create a new table (table name `weather`)
- Run app, the app will target at localstack
- POST `http://localhost:5000/weatherforecast/` to create a new item to table
- GET `http://localhost:5000/weatherforecast/` to get item from table
    - see the infamous `key is empty` error
    - this is because hash key is null
