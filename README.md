# C# Design Patterns Repository

This repository contains examples of various design patterns implemented in C#. Design patterns are reusable solutions to common problems encountered in software design and are categorized into three groups: Creational, Structural, and Behavioral.

Below, you'll find examples of each design pattern along with a brief explanation of its purpose:

## Structural Patterns

| Pattern   | Explanation                                                                                   | Short Description                                      | Example Code                                            |
|-----------|----------------------------------------------------------------------------------------------|---------------------------------------------------------|---------------------------------------------------------|
| Adapter   | [Explanation](Structural/Adapter/VP.DesignPatterns.Adapter/UML/Adapter.md)                   | Convert the interface of a class into another interface clients expect.                           | [Example Code](Structural/Adapter/VP.DesignPatterns.Adapter) |
| Bridge    | [Explanation](Structural/Bridge/VP.DesignPatterns.Bridge/UML/Bridge.md)                       | Decouple an abstraction from its implementation so that the two can vary independently.            | [Example Code](Structural/Bridge/VP.DesignPatterns.Bridge)   |
| Composite | [Explanation](Structural/Composite/VP.DesignPatterns.Composite/UML/Composite.md)             | Compose objects into tree structures to represent part-whole hierarchies.                          | [Example Code](Structural/Composite/VP.DesignPatterns.Composite) |
| Decorator | [Explanation](Structural/Decorator/VP.DesignPatterns.Decorator/UML/Decorator.md)             | Attach additional responsibilities to an object dynamically.                                       | [Example Code](Structural/Decorator/VP.DesignPatterns.Decorator) |
| Facade    | [Explanation](Structural/Facade/VP.DesignPatterns.Facade/UML/Facade.md)                       | Provide a unified interface to a set of interfaces in a subsystem.                                   | [Example Code](Structural/Facade/VP.DesignPatterns.Facade)   |
| Flyweight | [Explanation](Structural/Flyweight/VP.DesignPatterns.Flyweight/UML/Flyweight.md)             | Use sharing to support large numbers of fine-grained objects efficiently.                            | [Example Code](Structural/Flyweight/VP.DesignPatterns.Flyweight) |
| Proxy     | [Explanation](Structural/Proxy/VP.DesignPatterns.Proxy/UML/Proxy.md)                          | Provide a surrogate or placeholder for another object to control access to it.                        | [Example Code](Structural/Proxy/VP.DesignPatterns.Proxy)    |

## Behavioral Patterns

| Pattern     | Explanation                                                                               | Short Description                                      | Example Code                                            |
|-------------|------------------------------------------------------------------------------------------|---------------------------------------------------------|---------------------------------------------------------|
| Chain of Responsibility | [Explanation](Behavioural/ChainOfResponsibility/VP.DesignPatterns.ChainOfResponsibility/UML/ChainOfResponsibility.md) | Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. | [Example Code](Behavioural/ChainOfResponsibility/VP.DesignPatterns.ChainOfResponsibility) |
| Command     | [Explanation](Behavioural/Command/VP.DesignPatterns.Command/UML/Command.md)                | Encapsulate a request as an object, thereby parameterizing clients with queues, requests, and operations. | [Example Code](Behavioural/Command/VP.DesignPatterns.Command) |
| Interpreter | [Explanation](Behavioural/Interpreter/VP.DesignPatterns.Interpreter/UML/Interpreter.md)    | Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language. | [Example Code](Behavioural/Interpreter/VP.DesignPatterns.Interpreter) |
| Iterator    | [Explanation](Behavioural/Iterator/VP.DesignPatterns.Iterator/UML/Iterator.md)             | Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation. | [Example Code](Behavioural/Iterator/VP.DesignPatterns.Iterator)    |
| Mediator    | [Explanation](Behavioural/Mediator/VP.DesignPatterns.Mediator/UML/Mediator.md)             | Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly and allows their interaction to vary independently. | [Example Code](Behavioural/Mediator/VP.DesignPatterns.Mediator)    |
| Memento     | [Explanation](Behavioural/Memento/VP.DesignPatterns.Memento/UML/Memento.md)                | Without violating encapsulation, capture and externalize an object's internal state so that the object can be restored to this state later. | [Example Code](Behavioural/Memento/VP.DesignPatterns.Memento)    |
| Observer    | [Explanation](Behavioural/Observer/VP.DesignPatterns.Observer/UML/Observer.md)            | Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. | [Example Code](Behavioural/Observer/VP.DesignPatterns.Observer) |
| State       | [Explanation](Behavioural/State/VP.DesignPatterns.State/UML/State.md)                       | Allow an object to alter its behavior when its internal state changes. The object will appear to change its class. | [Example Code](Behavioural/State/VP.DesignPatterns.State)    |
| Strategy    | [Explanation](Behavioural/Strategy/VP.DesignPatterns.Strategy/UML/Strategy.md)             | Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it. | [Example Code](Behavioural/Strategy/VP.DesignPatterns.Strategy) |
| Template Method | [Explanation](Behavioural/TemplateMethod/VP.DesignPatterns.TemplateMethod/UML/TemplateMethod.md) | Define the skeleton of an algorithm in the superclass but let subclasses override specific steps of the algorithm without changing its structure. | [Example Code](Behavioural/TemplateMethod/VP.DesignPatterns.TemplateMethod) |
| Visitor     | [Explanation](Behavioural/Visitor/VP.DesignPatterns.Visitor/UML/Visitor.md)                | Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates. | [Example Code](Behavioural/Visitor/VP.DesignPatterns.Visitor)    |

## Creational Patterns

| Pattern            | Explanation                                                                                  | Short Description                                      | Example Code                                            |
|--------------------|---------------------------------------------------------------------------------------------|---------------------------------------------------------|---------------------------------------------------------|
| Abstract Factory   | [Explanation](Creational/AbstractMethodFactory/VP.DesignPatterns.AbstractMethodFactory/UML/AbstractMethodFactory.md) | Provide an interface for creating families of related or dependent objects without specifying their concrete classes. | [Example Code](Creational/AbstractMethodFactory/VP.DesignPatterns.AbstractMethodFactory) |
| Builder            | [Explanation](Creational/Builder/VP.DesignPatterns.Builder/UML/Builder.md)                   | Separate the construction of a complex object from its representation so that the same construction process can create different representations. | [Example Code](Creational/Builder/VP.DesignPatterns.Builder)    |
| Factory Method     | [Explanation](Creational/FactoryMethod/VP.DesignPatterns.FactoryMethod/UML/FactoryMethod.md) | Define an interface for creating an object, but let subclasses alter the type of objects that will be created. | [Example Code](Creational/FactoryMethod/VP.DesignPatterns.FactoryMethod) |
| Prototype          | [Explanation](Creational/Prototype/VP.DesignPatterns.Prototype/UML/Prototype.md)             | Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype. | [Example Code](Creational/Prototype/VP.DesignPatterns.Prototype) |
| Singleton          | [Explanation](Creational/Singleton/VP.DesignPatterns.Singleton/UML/Singleton.md)             | Ensure a class has only one instance and provide a global point of access to it. | [Example Code](Creational/Singleton/VP.DesignPatterns.Singleton) |


## License

This project is licensed under the [MIT License](LICENSE).
