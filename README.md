# Clash Calculator using webapi-core-starterkit

This project intended to be a starter kit for a Asp.net Core MVC WebApi project. It will be composed by a layered architecture 
and it will have pretty much everything that you would want already set for you to start your development.

* Swashbuckle / Swagger - Providing automatic documentation for your Api
* Dependency Injection - Architecure in place to prevent developers on creating objects on their own.
* Global exception handling - Central point to handle generic exceptions
* Entity Framework + Sql Server 
* Log
* Validation - TBD
* Unit tests - Business and Data layer

Future:
* Profiling
* Auditing (crosscutting concern?).

Some of the main goals of this project:

* Provide a boilerplate solution for general WebApi applications.
* Try to avoid usage of Object to Object mappings.
* Try to avoid proxy methods. Eg. Methods on the business layer that may only call the data acess directly to retrieve data.
