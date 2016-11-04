# WindowsApp
Testing various features on a Windows App

:memo: The following features are included in this example:

- [ ] Using WPF, .Net 4.5+
- [ ] Main window loads content from JSON
- [ ] Main window has button to open form
- [ ] Form window for submitting data
- [ ] Use of MVVM
- [ ] Basic styling and templates
- [ ] Reading from registry
- [ ] Reading from task scheduler
- [ ] Reading from file system

## WPF Overview

Official documentation from Microsoft
https://msdn.microsoft.com/en-us/library/ms750441(v=vs.110).aspx

All WPF components come from managed code. All display in WPF is done through the DirectX engine, allowing for efficient hardware and software rendering. WPF also required fine control over memory and execution.

Most objects in WPF derive from DispatcherObject, which provides the basic constructs for dealing with concurrency and threading. WPF is based on a messaging system implemented by the dispatcher. 

There are really two core concepts to understand when discussing concurrency in WPF – the dispatcher and thread affinity. Thread affinity happens when a component uses the identity of the executing thread to store some type of state.  In the end, WPF’s threading model was kept in sync with the existing User32 threading model (STA single thread affinity) of single threaded execution with thread affinity. Given that you have objects with STA threading, you need a way to communicate between threads, and validate that you are on the correct thread. Herein lies the role of the dispatcher. The dispatcher is a basic message dispatching system, with multiple prioritized queues. 

### XAML
XAML is a declarative markup language. XAML files are XML files that generally have the .xaml extension. The files can be encoded by any XML encoding, but encoding as UTF-8 is typical.

Syntax
- tbd

x:code
Directive element efined in XAML. 


## Using MVVM in WPF

Official documentation from Microsoft
https://msdn.microsoft.com/en-us/library/hh848246.aspx

Development technologies like Windows Forms, WPF, Silverlight, and Windows Phone provide a default experience that leads a developer down the path of dragging controls from a toolbox to a design surface, then writing code in the form's code-behind file. As such applications grow in size and scope and are modified, complex maintenance issues begin to arise.

The main motivations for implementing an application using the MVVM pattern are that:
- It provides separation of concerns. Tightly coupled, change resistant, brittle code causes all sorts of long-term maintenance issues that ultimately result in poor customer satisfaction with the delivered software. A clean separation between application logic and the UI will make an application easier to test, maintain, and evolve. It improves code re-use opportunities and enables the developer-designer workflow.
- It is a natural pattern for XAML platforms. The key enablers of the MVVM pattern are the rich data binding stack of the Silverlight platform, and dependency properties. The combination of these provides the means to connect a UI to a view model.
- It enables a developer-designer workflow. When the UI XAML is not tightly coupled to the code-behind, it is easy for designers to exercise the freedom they need to be creative and make a good product.
- It increases application testability. Moving the UI logic to a separate class that can be instantiated independently of a UI technology makes unit testing much easier.

There are three core components in the MVVM pattern: the model, the view, and the view model. 

### View

The view is responsible for defining the structure, layout, and appearance of what the user sees on the screen. Ideally, the view is defined purely with XAML, with a limited code-behind that does not contain business logic.

There are several options for executing code on the view model in response to interactions on the view, such as a button click or item selection. If the control is a Command Source, the control’s Command property can be data-bound to an ICommand property on the view model. 

### Model

The model in MVVM is an implementation of the application's domain model that includes a data model along with business and validation logic. Examples of model objects include repositories, business objects, data transfer objects (DTOs), Plain Old CLR Objects (POCOs), and generated entity and proxy objects.

### View Model 

The view model acts as an intermediary between the view and the model, and is responsible for handling the view logic. Typically, the view model interacts with the model by invoking methods in the model classes. The view model then provides data from the model in a form that the view can easily use. The view model retrieves data from the model and then makes the data available to the view, and may reformat the data in some way that makes it simpler for the view to handle.


 


## Working with the registry

tbd

## Working with the Task Scheduler

tbd

## Working with the File System

tbd