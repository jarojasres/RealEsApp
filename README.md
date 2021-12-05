# RealEsApp
Real estate practice app with .net core 6 and React.

# Projects 

## Core
It is a class library where the domain entities and the application functionalities are mainly defined, additionally there are the interfaces which abstract the implementation functionality. With this I can, for example, define a generic interface for the repository and not be linked to a specific database, in addition to the "Repository" pattern, the "Specification" pattern is used, which allows defining criteria that we want an object to meet, or set of objects, regardless of how they are constructed and the mechanism used to obtain them. With this we can avoid the bad practice of creating and creating repositories because it is filtered by an X or Y field. The "CQRS" pattern is used which separates the query and data modification operations. Although the databases are not separated in the project, the door is left open for the performance of the application to be improved in the future, allowing one database for consultation and another for data modification.


# Infrastructure

# API

# Tests
