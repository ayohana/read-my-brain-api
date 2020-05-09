<div align=center>

# [Read My Brain API](https://github.com/ayohana/read-my-brain-api.git/)

#### API for Read My Brain, 05.08.2020

#### By [**Adela Darmansyah**](https://github.com/ayohana/)

[About](#About) | [What Brain](##What-Brain) | [Whose Brain](#Whose-Brain) | [Minimum Viable Product](#Minimum-Viable-Product) | [Future Product Roadmap](#Future-Product-Roadmap)

[Documentation](#Documentation) | [Bugs](#Known-Bugs) | [Installation Instructions](#Installation-Instructions) | [Screenshots](#Screenshots)  | [Technologies](#Technologies) | [Resources](#Resources) | [Contact and Support](#Contact-and-Support) | [License](#License)

![GitHub](https://img.shields.io/github/license/ayohana/read-my-brain-api?color=%23DE98B2&style=for-the-badge) ![GitHub last commit (branch)](https://img.shields.io/github/last-commit/ayohana/read-my-brain-api/master?color=%23DE98B2&style=for-the-badge) ![GitHub language count](https://img.shields.io/github/languages/count/ayohana/read-my-brain-api?color=%23DE98B2&style=for-the-badge) ![GitHub top language](https://img.shields.io/github/languages/top/ayohana/read-my-brain-api?color=%23DE98B2&style=for-the-badge)

</div>

## About

**A service API for Read My Brain, a web application for translating indecipherable nursing brain jargons into simple, readable text.**

## What Brain

For this project, I will be referring to nursing 'brain' sheets--or in the nursing world, simply known as _brains_. So what are these brains? **Nursing brains** are report sheets that contain handwritten information (most often chicken scratch) to remember about their patients. In a typical shift change routine in a hospital, a nurse only has 20 minutes to receive verbal report from the previous nurse and write down everything they need to know about all five patients assigned to them. Details on their diagnosis, medical history, current symptoms, lab values, medication administration times, treatment schedule, discharge plan, their preference of filling up a water pitcher with three quarters ice and a quarter water with two straws are among many things nurses have to write down for each patient within a few minutes. Nurses and other healthcare providers have to start using a whole lot of acronyms to write things down efficiently. Here's an example:

> `````
> 84F DNR pt from ED is A&Ox2
> c̅ Hx HTN, DM, RTKA & Ax pnc
> will need CXR STAT.
> `````

**Read My Brain** will translate this into layman's terms:

> `````
> 84 year old female Do Not Resuscitate patient from Emergency Department is alert and oriented x2
> with history of hypertension, diabetes mellitus, right total knee arthroplasty and allergy to penicillin
> will need chest x-ray immediately.
> `````

## Whose Brain

Users are primarily going to be **future health providers**, including nursing students and new nurses. Inspired by my own nursing experience, listed below are my **goals** for this project:
1. To help future caregivers understand medical charts quicker, better, easier and make their learning less stressful.
2. To enable nursing students and new nurses keep up with their preceptors' brains.
3. To empower future nurses via Read My Brain.

## Minimum Viable Product

<details>
  <summary>See what's under construction!</summary>

  - [x] Design the database structure using Draw.io.
  - [x] Build a back-end API using C#/.NET Core and MySQL with READ functionality.
      - [x] Read a sentence by sending the sentence as a query parameter and the API will return the translated sentence.
  - [ ] Build a front-end JavaScript/React application that allows users to enter a sentence and display the translated sentence.
      - [ ] The default view will be a form with a single text box and a submit button.
      - [ ] The user will be able to enter a sentence into the text box and submit it.
      - [ ] There will be a maximum number of 50 characters in a sentence.
      - [ ] Upon submission, the application will call the API to read the sentence.
      - [ ] The application will display the returned API response as a string.

</details>

## Future Product Roadmap

<details>
  <summary>Expand to see stretch goals!</summary>

  - [x] Build a back-end API using C#/.NET Core and MySQL with full CRUD functionality.
      - [x] Create a new term and its abbreviation into the API's database.
      - [x] Read a sentence by sending the sentence as a query parameter and the API will return the translated sentence.
      - [x] Update details of an term.
      - [x] Delete an term.
  - [x] Enable querying special characters. For instance, c̅ for with, ā for before and p̄ for after.
  - [x] Deploy API's database via Azure.
  - [x] Deploy the back-end API via Azure.
  - [ ] Deploy the front-end application via Firebase.
  - [ ] Use Quill's basic text editor for application UI.
  - [ ] Apply Quill's toolbar.
  - [ ] Modify Quill's toolbar by adding an option to insert special characters into user input. For instance, c̅ for with, ā for before and p̄ for after.
  - [ ] Users can enter longer sentences (max 200 characters per sentence).
  - [ ] Users can enter a paragraph (max 1000 characters).
  - [ ] There's an unlimited number of characters a user can enter.
  - [ ] Add an "About" section to the front end.
  - [ ] Add a footer to the front end with a link to my GitHub repo.
  - [ ] Add functionality to generate random sentences in the front end so that users can test/use the app right away.
  - [ ] Users can copy the translated result with a click of a button.
  - [ ] Users can add a new term via the front-end application for open contribution.
  - [ ] Users can update existing terms via the front-end application.
  - [ ] Warn users to be careful when translating real patient information to prevent violating their privacy (HIPAA).
  - [ ] The API can translate the vice versa (from layman’s terms to nursing jargons).
  - [ ] The API can translate live/real-time.
  - [ ] Apply Swagger API or add Views to API for http routes documentation.
  - [ ] Create an API key for users.
  - [ ] Use Redux in case the application's scale of state gets very large.

</details>

## Documentation

Base URL: http://readmybrain.azurewebsites.net/api

| Operations                        | Method | Route | `Raw JSON Body` |
| :-------------------------------- | :----- | :---- | :-------- |
| Retrieve a list of all terms      | GET    | | |
| Retrieve a specific term by their ID | GET | `/{id}` | |
| Create a new term                 | POST   | | `{ "name": "VS", "definition": "vitals" }` |
| Update a term by their ID         | PUT    | `/{id}` | `{ "name": "VS", "definition": "Vital Signs" }` |
| Translate my brain                | POST   | `/translate` |  
| Delete a term by their ID         | DELETE | `/{id}` | `"84F DNR pt from ED is A&Ox2 c̅ Hx HTN, DM, RTKA & Ax pnc will need CXR STAT!"` |


## Known Bugs

No known bugs at this time.

## Installation Instructions

### For local development:
* Download [.NET Core](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) (Mac/Windows OS) - _FREE!_
* Download [MySQL](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) (Mac/Windows OS) - _FREE!_
* Download [Postman](https://www.postman.com/downloads/) (Mac/Windows OS) - _FREE!_
* Clone this [repository](https://github.com/ayohana/read-my-brain-api.git/)
* Run the application by:
  * Entering `$ cd Desktop/read-my-brain-api/` to navigate into the `read-my-brain-api` directory 
    * Open `Startup.cs` and activate the correct configuration block of code for local development.
    * Enter the command `dotnet restore` to gather tools and dependencies for the application.
    * Enter the command `dotnet build` to build the project using its dependencies.
    * Enter the command `dotnet ef database update` to create a new database with seeded data. 
    * Enter `dotnet run` to run the application.
    * Enter URL `http://localhost:5000/api/` in Postman using one of the HTTP Methods [below](#HTTP-Methods-and-Routes). 

_Note: When running in Azure App Service, the connection string defined in Azure App Service takes precedence over the connection string defined in `appsettings.json`. For more details, click [here](https://docs.microsoft.com/en-us/azure/app-service/app-service-web-tutorial-dotnetcore-sqldb#configure-connection-string)._

## Screenshots

API Database Structure:

![Read My Brain API's Database Structure created using Draw.io](./Images/read-my-brain-api-database-structure.png/)

_More coming up soon!_

<!-- View all tenants in Postman:

![Get all tenants v. 2.0](./Screenshots/GetAll.JPG/)

View tenants with search query parameters:

![Get tenants with query string v. 2.0](./Screenshots/GetQueryString.JPG/)

Add new tenant:

![Add new tenant v. 2.0](./Screenshots/Post.JPG/)

Update a tenant:

![Update tenant v. 2.0](./Screenshots/Put.JPG/)

Remove a tenant:

![Remove tenant v. 2.0](./Screenshots/Delete.JPG/) -->


## Technologies

* C#
* [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/) (Windows OS)
* [MySQL](https://dev.mysql.com/downloads/file/?id=484919) (Windows OS)
* [EF Core](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql)
* [Postman](https://www.postman.com/downloads/)
* [Azure App Service](https://azure.microsoft.com/en-us/services/app-service/)
* [Draw.io](https://app.diagrams.net/)

## Resources

* [My Capstone Project Proposal](https://docs.google.com/document/d/1bxW7XzQk9xxoDU-CSc2oWtsvJcJJNuBybUBFhglaJDo/edit?usp=sharing)
* [Tutorial: Build an ASP.NET Core and SQL Database app in Azure App Service on Windows](https://docs.microsoft.com/en-us/azure/app-service/app-service-web-tutorial-dotnetcore-sqldb)
  * [Tenant API](https://github.com/ayohana/TenantAPI.git) - a successful test project for deploying SQL database and .NET app using Azure App Service
  * [Azure Tools for Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=ms-vscode.vscode-node-azure-pack)
  * [Azure CLI on Windows](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli-windows?view=azure-cli-latest#install-or-update)
* [Tutorial: Building an API](https://www.learnhowtoprogram.com/c-and-net/building-an-api)
* [Queries in LINQ to Entities: Method-Based Query Syntax](https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/ef/language-reference/queries-in-linq-to-entities#method-based-query-syntax)
* [Strings in C# - Microsoft Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/)

## Contact and Support

Feel free to provide feedback via email: [adela.yohana@gmail.com](mailto:adela.yohana@gmail.com).

## License

This application is licensed under the MIT license.

Copyright (c) 2020 **Adela Darmansyah**