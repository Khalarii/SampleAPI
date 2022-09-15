# .NET Core Sample API

This project is a sample API using .NET Core and Entity Framework Core.

## Running the app

To run the app, press `F5` or `Ctrl+F5`. Alter the URL of your browser to be `https://localhost:<port>/api/people`.

You may use the [http-repl](https://docs.microsoft.com/en-us/aspnet/core/web-api/http-repl/?view=aspnetcore-6.0&tabs=windows) tool to test the application.

### Adding a person
Run the following commands:
1. `httprepl https://localhost:<port>/api/people`
1. `post -h Content-Type=application/json -c "{"name":"Jane Doe","email":"jane@mail.com", "riskLevel":1}"`

### Getting the record of a single person

#### Browser
Alter the URL to be `https://localhost:<port>/api/people/<id>`

#### Http Repl
Run the following commands:
1. `connect https://localhost:<port>/api/people/<id>`
1. `get`

### Editing the record of a person

Using http-repl, run the following commands:
1. `connect https://localhost:<port>/api/people/<id>`
1. `put -h Content-Type=application/json -c "{"id":1,"name":"Jack Dorothy","email":"jack@mail.com", "riskLevel":0}"`

### Deleting the record of a person

Using http-repl, run the following commands:
1. `connect https://localhost:<port>/api/people/<id>`
1. `delete`

### Unit tests

From the `SampleAPI.Tests` directory, run the following command: `dotnet test`
