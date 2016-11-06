# WindowsApp
Testing various features on a Windows App

:memo: The following features are included in this example:

- [ ] Using WPF, .Net 4.5+
- [ ] Use of MVVM
- [ ] Navigation using MVVM
- [ ] 2 Way Binding
- [ ] Interacting with the Registry
- [ ] Interacting with Task Scheduler
- [ ] Interacting with File System

## WPF Overview

Official documentation from Microsoft
https://msdn.microsoft.com/en-us/library/ms750441(v=vs.110).aspx

All WPF components come from managed code. All display in WPF is done through the DirectX engine, allowing for efficient hardware and software rendering. WPF also required fine control over memory and execution.

Most objects in WPF derive from DispatcherObject, which provides the basic constructs for dealing with concurrency and threading. WPF is based on a messaging system implemented by the dispatcher. 

There are really two core concepts to understand when discussing concurrency in WPF – the dispatcher and thread affinity. Thread affinity happens when a component uses the identity of the executing thread to store some type of state.  In the end, WPF’s threading model was kept in sync with the existing User32 threading model (STA single thread affinity) of single threaded execution with thread affinity. Given that you have objects with STA threading, you need a way to communicate between threads, and validate that you are on the correct thread. Herein lies the role of the dispatcher. The dispatcher is a basic message dispatching system, with multiple prioritized queues. 

### XAML
XAML is a declarative markup language. XAML files are XML files that generally have the .xaml extension. The files can be encoded by any XML encoding, but encoding as UTF-8 is typical.

x:code
Directive element efined in XAML. 

... tbd

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

Another working example: http://www.markwithall.com/programming/2013/03/01/worlds-simplest-csharp-wpf-mvvm-example.html

### View

The view is responsible for defining the structure, layout, and appearance of what the user sees on the screen. Ideally, the view is defined purely with XAML, with a limited code-behind that does not contain business logic.

There are several options for executing code on the view model in response to interactions on the view, such as a button click or item selection. If the control is a Command Source, the control’s Command property can be data-bound to an ICommand property on the view model. 

### Model

The model in MVVM is an implementation of the application's domain model that includes a data model along with business and validation logic. Examples of model objects include repositories, business objects, data transfer objects (DTOs), Plain Old CLR Objects (POCOs), and generated entity and proxy objects.

### View Model 

The view model acts as an intermediary between the view and the model, and is responsible for handling the view logic. Typically, the view model interacts with the model by invoking methods in the model classes. The view model then provides data from the model in a form that the view can easily use. The view model retrieves data from the model and then makes the data available to the view, and may reformat the data in some way that makes it simpler for the view to handle.

## 2 Way Binding
The Model-View-ViewModel (MVVM) pattern is an application pattern that isolates the user interface from the underlying business logic. MVVM belongs to a class of patterns called Separated Presentation. These patterns provide a clean separation between the UI and the rest of the application. This improves the testability of the application and allows the application and its UI to evolve more easily and independently. The MVVM pattern consists of the following parts:
The Model, which provides a view-independent representation of your business entities. The design of the model is optimized for the logical relationships and operations between your business entities, regardless of how the data is presented in the user interface.
The View class which is the user interface. It displays information to the user and fires events in response to user interactions.
The ViewModel class, which is the bridge between the view and the model. Each View class has a corresponding ViewModel class. The ViewModel retrieves data from the Model and manipulates it into the format required by the View. It notifies the View if the underlying data in the model is changed, and it updates the data in the Model in response to UI events from the View.
![MSDN](https://i-msdn.sec.s-msft.com/dynimg/IC416621.png)

https://i-msdn.sec.s-msft.com/dynimg/IC416621.png

https://msdn.microsoft.com/en-us/library/ff798384.aspx


## Working with the File System

Use File libary (System.IO)

## Working with the Task Scheduler

Scheduled Tasks are stored in the Windows\System32\Tasks. Need authorization to read from this.

SCHTASKS.exe
Enables an administrator to create, delete, query, change, run, and end scheduled tasks on a local or remote computer. Running Schtasks.exe without arguments displays the status and next run time for each registered task.
https://msdn.microsoft.com/en-us/library/windows/desktop/bb736357(v=vs.85).aspx

TaskScheduler Class
Represents an object that handles the low-level work of queuing tasks onto threads.
https://msdn.microsoft.com/en-us/library/system.threading.tasks.taskscheduler(v=vs.110).aspx

The following table lists Task Scheduler 2.0 examples included in this section.
Example	Description
Starting an Executable at a Specific Time	Defines a task that starts Notepad at a specified time.
Starting an Executable Daily	Defines a task that starts Notepad daily.
Starting an Executable on System Boot	Defines a task that starts Notepad when the system is booted.
Starting an Executable Weekly	Defines a task that starts Notepad on a weekly basis.
Starting an Executable When a Task is Registered	Defines a task that starts Notepad when the task is registered.
Starting an Executable When a User Logs On	Defines a task that starts Notepad when a user logs on.
Enumerating Tasks and Displaying Task Information	Enumerates through all the tasks on the local computer and displays each task's state.
https://msdn.microsoft.com/en-us/library/windows/desktop/aa384006(v=vs.85).aspx

## Working with the registry

tbd
