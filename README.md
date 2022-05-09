

<h3>Requirements<h3>

* MediatR 9.0.0
* MediatR.DependencyInjection 9.0.0
* EntityFrameworkCore
* Asp.NetCore.SQL
* Asp.NetCore.Tools
* Asp.NetCore.Identity

<h2>Command Query Responsibility Segregation<h2>

<p>CQRS is the idea that we should compose our systems of command and query operations and keep these separated whenever possible. </p>


![CQRS](https://i0.wp.com/codecoach.co.nz/wp-content/uploads/2020/06/CQRS.png?resize=705%2C403&ssl=1)


<h3>Command<h3>
<p>Commands, or writes, alter the data within a system. In this context, a ‘write’ has little to do with the traditional idea of writing to disk. Think of it more as a logical rather than a physical write. It’s a system state change—whether to memory, disk or remote service. All commands to be made in the application contain tariff classes.</p>
<br>

* Update , Insert , Delete 

<h3>Query<h3>
<p>Queries, or reads, are requests for data from a system. Again, we are referring to logical reads rather than physical reads. The data can be read from disk, memory.It contains classes that will describe all the queries that will be made in the application.</p>
<br>

* Select , List

<h3>Handlers<h3> 
-It contains classes that will process all Command or Query requests to be made in the application and return response objects as a result.

<h2>MediatR Design Pattern<h2>

* <p>In software engineering, the mediator pattern defines an object that encapsulates how a set of objects interact. This pattern is considered to be a behavioral pattern due to the way it can alter the program’s running behavior. In object-oriented programming, programs often consist of many classes.
In simply we can see Mediator pattern is another design pattern that dramatically reduces the coupling between various components of an application by making them communicate indirectly, usually via a special mediator object. We will dive deep into Mediator in another post. Essentially, the Mediator pattern is well suited for CQRS implementation.</p>
  
  
  
  
  

  
