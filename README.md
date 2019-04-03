# ContactUs
Full stack contact page app with ASP.NET Core and React

![alt text](https://github.com/adamflitney/ContactUs/blob/master/ContactUsSS.jpg "Screenshot")

## Installation
Requires recent versions of NodeJS, Visual Studio and SQL Server to be installed.
Created with .NET Core 2.2

1) `git clone` or download this project from github
Visual Studio should get all the required dependencies for the .NET part of the project automatically automatically
2) On the command line, `cd` to ContactUs/ClientApp/contact-us-client and run `npm install` to get the client dependencies (it may take a while)
3) Open up the appsettings file at ContactUs/appsettings.json and replace the "DefaultConnection" connection string with a valid conection string for your SQL Server instance.
4) In the main directory, run the command `update-database` (this command should have been installed as part of the dependencies) to run the migrations scripts and set up the required database table.

## Running
You can run the whole project straight from visual studio using the local iis server.

*If you want to run the client app seperately, you can but you will need to change the relative URL in src/api/ContactUsAPI.js to the full URL of your back-end instance in order for the form to work.*

## Testing
To run the tests for the main project you can do so from visual studio via the built in test tools.

For the client app, `cd` to ContactUs/ClientApp/contact-us-client and run `npm test`
