# UnrealAPITesting

HTTPS Url: https://localhost:44319/api/choices

HTTP Url: http://localhost:50793/api/choices


Be sure to change connection string in appsettings.json to match your server, Script to make the table for this program is located in API/Database

Sample data for you to send with Postman and confirm that the API is functional:


GET https://localhost:44319/api/choices

POST https://localhost:44319/api/choices
with JSON Data:
{
	"firstName": "John",
	"number": 5
}