# MediaTRDemo

Introduction of CQRS Pattern
CQRS stands for Command and Query Responsibility Segregation and uses to separate read(queries) and write(commands).
In that, queries perform read operation, and command perform writes operation like create, update, delete, and return data.

![image](https://github.com/sayantan2017/MediaTRDemo/assets/26603086/b61be3ad-14ea-44fd-a07a-1164c248b864)

As we know, in our application we mostly use a single data model to read and write data, which will work fine and perform CRUD operations easily. But, when the application becomes a vast in that case, our queries return different types of data as an object so that become hard to manage with different DTO objects. Also, the same model is used to perform a write operation. As a result, the model becomes complex.
Also, when we use the same model for both reads and write operations the security is also hard to manage when the application is large and the entity might expose data in the wrong context due to the workload on the same model.
CQRS helps to decouple operations and make the application more scalable and flexible on large scale.

When to use CQRS
We can use Command Query Responsibility Segregation when the application is huge and access the same data in parallel. CQRS helps reduce merge conflicts while performing multiple operations with data.
In DDD terminology, if the domain data model is complex and needs to perform many operations on priority like validations and executing some business logic so in that case, we need the consistency that we will by using CQRS.

MediatR
MediatR pattern helps to reduce direct dependency between multiple objects and make them collaborative through MediatR.
In .NET Core MediatR provides classes that help to communicate with multiple objects efficiently in a loosely coupled manner.

