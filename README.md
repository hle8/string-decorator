# Software Documentation

This software is designed using the Decorator design pattern. It consists of several classes and interfaces that work together to modify text in various ways.

## Components

### IComponent<T>

This is an interface with a single method `GetText()` that returns a generic type `T`.

### Decorator<T>

This is an abstract class that implements `IComponent<T>`. It contains a protected field `component` of type `IComponent<T>`, and a constructor that initializes this field. It also overrides the `GetText()` method to call the same method on the component.

### ConcreteComponent

This class implements `IComponent<string>`. It overrides the `GetText()` method to return a string.

### PlainDecorator, ColorDecorator, UpperCaseDecorator

These are decorator classes that inherit from `Decorator<string>`. Each decorator overrides the `GetText()` method to modify the text in some way.

## Main Program

The main program creates a `ConcreteComponent` and several decorators. It calls the `GetText()` method on each object and prints the result to the console.

## Usage

To use this software, create a `ConcreteComponent` and apply any number of decorators to it. Then, call the `GetText()` method to retrieve the modified text.

## License

This project is licensed under the MIT License - see the LICENSE.md file for details
