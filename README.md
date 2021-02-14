# StoreApi
StoreApi is a .Net core project with a sole purpose of showing a sample of my coding experience.  
For accomplishing the goal of the task, in this project different technologies and utilities were used, such as:  ASP.NET Core Web API, Entity Framework Core, T-SQL as a database provider, Redis, etc..  
Project is based on a combination of repository and specification patterns, which enables repository generalisation and avoids code duplication.  
API is equipped with standard functionality you would expect from e-commerce style web application. Functionalities include: getting full list of brands, product types, products and user basket, creating, updating and deleting basket. For fast accessibility and reliable user experience, basket information is stored using Redis, which is in-memory data structure store that saves user information in-memory by key–value pairs. Moreover, Products controller is equipped with functionalities as, paging, filtering, sorting and searching. For enjoyable and user friendly experience project uses Swagger as its access point.

Please note..  
On first run, if proper connection to database is present, tables will get filled by sample data, with only purpose of early testing, primary and foreign keys may or may not be correctly assigned.  
For succesful use of basket functionality local machine needs to have a running Redis connection, as a Redis windows alternative Memurai was used during development.
