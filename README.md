# WebApiTeknoRama

This Project  will be coded by the lead of  Tier Architecture
The Planned Layer are listed as belov

Local variables >> camelCase,
In fields >> _camelCase,
Property, Class, Methods >> PascalCase,
Layers will be named as Project."XXX",

BLL > SingletonPattern , GenericRepository
COMMON > Tools
DAL > Strategy Pattern
DTO > Models
ENTITIES > Enums, Models
MAP > Options
MVCUI > Controllers, Views
WEBAPI> Bank Payment Connection



Project Stages;

BLL>>
Design  Patterns
The Singleton pattern is a software design pattern that ensures that a class has only one instance, while providing a global point of access to that instance for the entire system. It is used to control the number of instances of a class that can be created, and to ensure that there is only one instance of a class available in the system, making it easier to manage resources and state throughout the system. The Singleton pattern can be implemented by creating a private constructor, making the class non-inheritable, and providing a static method that returns the instance of the class.

GenericRepository
The Base Repository is a class that provides common functionality for interacting with data in a database. It acts as a layer between the data access code and the business logic, helping to decouple the two and simplify the code. The Base Repository class is used as a blueprint for other repository classes and typically includes methods such as Create, Read, Update, and Delete (CRUD) operations. This allows for a consistent way of accessing and manipulating data in the database, making it easier to maintain and update codein the future.

COMMON>>

Crypto
The class is used for secure password storage and verification. It uses the BCrypt library for hashing and verifying passwords. The HashPassword method generates a random salt, adds it to the input password, and then hashes the resulting string. The resulting hash is stored in the database to protect the password. The VerifyPassword method takes in the original password and the hash stored in the database, and returns a boolean indicating if the password is correct. monitor critic problem assault chief essay prevent glance orient response air save

Email Service
The EmailService class is a static class that provides a method called Send to send emails to a recipient. The method takes parameters for the recipient email address, password (for the sender's email account), email body, subject, and sender email address. The method uses the SmtpClient class and MailMessage class from the System.Net.Mail namespace to send the email. The SmtpClient class is configured with the host, port, SSL settings, delivery method, and credentials sender email address and password) to connect to the email server. The MailMessage class is used to create the email with the sender, recipient, subject, and body. Finally, the email is sent using the smtp.Send method.

ImageUpload
The code path is a static class named "ImageUpload" in the "Project.COMMON.Tools" namespace. This class has a single public static method named "UploadImage" which is used to upload an image file to a server path. The method takes two parameters, a "serverPath" string that specifies the path to store the image file on the server, and an "HttpPostedFileBase" object named "file" that represents the image file to be uploaded. The method first checks if the file is not null, and then generates a unique name for the image file by creating a new Guid and concatenating it with the file extension. The method then checks if the extension of the file is one of the allowed formats (jpg, png,jpeg, gif) and if a file with the same name already exists in the server path. If the extension is not allowed, the method returns "2", if a file with the same name alreadyexists, the method returns "1", and if the file is null, the method returns "3". If all conditions are met, the method saves the image file to the specified server path and returns the full path to the image file.

DAL>>

Context
This is a class definition for a DbContext class named MyContext. The class inherits from the DbContext class in the Entity Framework and is used as a bridge between the application and the database. The constructor for this class sets the name of the database connection string to "MyConnection" and initializes it with a custom database initializer MyInit. The OnModelCreating method is used to add configurations for different entities (AppUser, Category, Employee, Order, etc.). This method is used to define the relationship between the entities and their corresponding tables in the database. The class also defines several DbSet properties, one for each of the entities defined in the model. These properties represent the sets of entities stored in the database and are used to interact with the data stored in the database.

Strategy Pattern

The Strategy Pattern is a behavioral design pattern that allows you to define a set of algorithms, encapsulate them, and make them interchangeable. The key idea behind this pattern is to abstract behavior and encapsulate it into individual objects, known as strategies. The client code can then dynamically switch between different strategies based on the needs at runtime. This pattern promotes the open-closed principle, as new algorithms can be added without affecting the existing code, making it easier to maintain and extend. The method creates new instances of several objects, including an "AppUser" object for an admin, a regular user, a branch manager, a sales representative, and a warehouse person. These objects are then added to the "AppUsers" and "Employees" DbSets in the database context. For each user, the user name, email, and hashed password are specified. The password is hashed using the "Crypto.HashPassword" method, which is probably a custom method for password hashing. The method also checks the password hash using "Crypto.VerifyPassword" method, which is probably a custom method for password verification, and throws an exception if the password verification fails. For each profile, various personal information such as first name, last name, age, gender, salary, etc. are specified and added to the "UserProfiles" DbSet in the database context. Finally, the method saves all changes to the database using the "SaveChanges" method.

DTO>>

PaymentDTO

DTO stands for Data Transfer Object, which is a plain old data structure used to transport data between different layers of an application, such as between the UI and business logic layers. It's a simple, lightweight class that holds data without any behavior. The purpose of a DTO is to allow data to be passed between different parts of an application without exposing the underlying implementation details of the data or its storage. By using DTO classes, it's possible to decouple the different parts of the application and make them more loosely coupled and easier to maintain and modify.

ENTITIES>>
In a Tier architecture, the Entities classes represent the data objects or domain entities of an application. They typically encapsulate the business logic and behavior of the application, and are responsible for managing the data and state of the application.

The Entities classes are generally used in the Model layer of the architecture, where they interact with the database or data access layer to retrieve, update, and persist data. Their main responsibilities can include:

Defining the structure and properties of the data objects that are used by the application
Enforcing business rules and constraints on the data, ensuring data integrity and consistency
Managing the relationships and associations between different data objects
Providing methods and behavior for manipulating and working with the data, such as validation, calculation, and transformation
Interacting with the data access layer to retrieve, update, and persist data to the database
Entities classes can also be used to represent data transfer objects (DTOs) that are passed between different layers of the application, or between the application and external systems or services. In this case, the Entities classes may not include behavior or business logic, but instead focus on defining the structure and properties of the data objects that are being transferred.

Overall, the Entities classes are an important component of a Tier architecture, as they provide a means of encapsulating and managing the data and behavior of an application, and help to ensure that the business logic and data access layers are decoupled and modular.

The ENTITIES class is likely a namespace within a software application that contains model classes that define the structure of data objects used within the system. These classes are used to define the properties, fields, and relationships of data that will be stored and manipulated within the application. The ENTITIES classes represent the domain or business objects of the system and are typically used by the data access layer to interact with a database or other data storage mechanism. These classes may also be used in the presentation layer of the application to transfer data between different parts of the system.

Enums
A DataStatus class could be an Enum class that defines a set of possible values for the status of some data, such as "Active", "Inactive", "Deleted", etc. Enum classes are useful for defining and enforcing a set of possible values in an application, making it easier to manage and ensure that the correct values are being used throughout the code. ExpenseType , Gender, IssueStatus, MessageType, OrderStatus, UserRole are the rest of the useful enum classes


MAP>>
In a Tier architecture, the MAP (Model-View-Controller/Presenter) classes are typically responsible for handling the interaction between the business logic layer (Model) and the presentation layer (View or UI).

Specifically, the MAP classes serve as a mediator or translator between the Model and the View, allowing data to be passed between the two layers without coupling them together. This helps to maintain a clear separation of concerns and makes it easier to modify or update either layer without affecting the other.

In more detail, the responsibilities of the MAP classes can vary depending on the specific implementation and framework being used, but generally they involve:

Retrieving data from the Model layer and preparing it for presentation in the View layer
Handling user input from the View layer and passing it to the Model layer for processing
Updating the View layer with changes made to the Model layer
Managing the flow of information between the Model and View layers, including any data transformation or conversion required
Overall, the MAP classes are an important component of a Tier architecture, helping to ensure a clear separation of concerns between the business logic and presentation layers and making it easier to develop and maintain complex applications.


WEBUI>>
AppUserController:



The AppUserController class is a controller class in the Administration area of a web application. It is responsible for managing the AppUser entity, which represents users of the application. The class uses an instance of the AppUserRepository class, which implements the generic repository pattern to perform CRUD (Create, Read, Update, and Delete) operations on the AppUser entity.

The class defines several methods, including:

AppUserList: Retrieves a list of active AppUser entities and displays them in a view. The method accepts an optional ID parameter, which can be used to filter the list to a specific AppUser.
AddAppUser: Accepts an AppUser object as a parameter and adds it to the database. The method sets the Active flag to true and redirects to the AppUserList action.
UpdateAppUser: Accepts an AppUser object as a parameter and updates the corresponding record in the database. The method sets the Active flag to true and redirects to the AppUserList action.
DeleteAppUser: Accepts an ID parameter and deletes the corresponding AppUser record from the database. The method redirects to the AppUserList action.
The AppUserController class also includes an [AdminAuthentication] attribute, which restricts access to the controller to authenticated administrators. Overall, the AppUserController class provides basic CRUD functionality for the AppUser entity and is a fundamental component of the web application's user management system.

CategoryController:


The CategoryController class is another controller class in the Administration area of a web application. This class is responsible for managing the Category entity, which represents the different categories used to classify items in the application.

The class uses an instance of the CategoryRepository class, which implements the generic repository pattern to perform CRUD operations on the Category entity.

The class defines several methods, including:

CategoryList: Retrieves a list of active Category entities and displays them in a view. The method accepts an optional ID parameter, which can be used to filter the list to a specific category.
AddCategory: Displays a view to add a new Category entity to the database. The method accepts a Category object as a parameter and adds it to the database.
UpdateCategory: Displays a view to update an existing Category entity in the database. The method accepts a Category object as a parameter and updates the corresponding record in the database.
DeleteCategory: Deletes a specific Category entity from the database. The method accepts an ID parameter, deletes the corresponding Category record from the database, and redirects to the CategoryList action.
The CategoryController class also includes a [ManagerAuthentication] attribute, which restricts access to the controller to authenticated managers.

Overall, the CategoryController class provides basic CRUD functionality for the Category entity and is an important component of the web application's category management system.


EmployeeController:
The EmployeeController is a controller class that handles the employee-related operations and requests in the administration area of the web application. It includes the following methods:

EmployeeList: This action method returns a list of active employees. It takes an optional parameter 'id' that specifies the ID of a specific employee to retrieve. It creates an instance of the EmployeeVM view model and passes the employee list to it before rendering the corresponding view.

AddEmployee: This action method renders the view that allows the manager to add a new employee to the system. If the form is submitted, it adds the employee to the database by calling the Add method of the _eRep object, which is an instance of the EmployeeRepository.

UpdateEmployee: This action method is responsible for updating an existing employee's information. It retrieves the employee with the specified ID, creates an instance of the EmployeeVM view model, and passes the employee information to it. If the form is submitted, it updates the employee's details by calling the Update method of the _eRep object.

DeleteEmployee: This action method deletes an existing employee from the system by calling the Delete method of the _eRep object after retrieving the employee with the specified ID.


The EmployeeTerritoryController:
The EmployeeTerritoryController class is a controller in an ASP.NET MVC application. It is responsible for managing the CRUD (Create, Read, Update, Delete) operations of employee territory assignments. It uses the EmployeeTerritoryRepository, EmployeeRepository, and TerritoryRepository classes to perform the necessary data operations. The class has an EmployeeTerritoryList action method to display a list of employee territories, and an AddEmployeeTerritory action method to add new employee territory assignments. The class is decorated with a ManagerAuthentication attribute to restrict access to authenticated users with the Manager role.


ExpenseController:
The code defines an ExpenseController class, which is used for handling requests related to managing expenses. The class contains actions for displaying a list of expenses, adding new expenses, updating existing expenses, and deleting expenses. It uses a repository pattern to interact with the database, and it also applies authentication using custom attributes. Additionally, the class defines several properties to hold currency exchange rates, which are used to display currency values on the view.


IssueController:    
The IssueController is a class in the Administration area of a web application that is responsible for handling CRUD (create, read, update, delete) operations for issues. It uses a repository pattern to interact with the data layer and retrieve issue data, and has methods to display the list of issues, add an issue, update an issue, and delete an issue. The controller also has an authentication attribute that allows only users with the TechService role to access its actions.


MessageController:
MessageController in the Administration area of a web application. The class is decorated with the ManagerAuthentication attribute to restrict access to authorized managers. The MessageController has an MessageRepository object to interact with the message data. The MessageList action method returns a view that displays all messages if the id parameter is null, otherwise it returns only the message with the specified id. The class does not have any methods to create, update or delete messages.

OrderController:

OrderController class which is located in the Administration area. The class contains an OrderList action that returns a view with a list of orders, with an optional id parameter to filter the results. The class uses three repositories: OrderRepository, AppUserRepository, and ShipperRepository. It also has the [ManagerAuthentication] attribute which means that the controller requires the user to be authenticated as a manager to access it.

OrderDetailsController:
This is a controller class named OrderDetailController located in the Administration area of a web application. It is decorated with the ManagerAuthentication attribute to restrict access to authenticated managers. It has a dependency on an OrderDetailRepository instance to perform CRUD operations on the OrderDetail entity. The class has an action method named OrderDetailList which retrieves the active order details using the _odRep instance and returns them in a view model to the corresponding view.

Product Controller:
This is a controller class for managing products in an e-commerce application. It includes actions for displaying a product list and details, adding, updating, and deleting products. The controller uses repositories for the Product, Category, and Supplier entities to interact with the database. The manager, warehouse, and sales roles are allowed to access this controller. Additionally, the controller uses a ViewModel class to pass data to views. The AddProduct and UpdateProduct actions use the ImageUpload class to upload and store images. The view for AddProduct contains a form to add a new product and includes a drop-down list for selecting a category. The view for UpdateProduct allows users to modify existing product information, including the product image. Finally, the ProductList view includes currency conversion information for display purposes.

SupplierController:
SupplierController class in the Administration area of a web application. The class includes methods to handle requests related to managing suppliers, such as viewing a list of suppliers, adding a new supplier, updating an existing supplier, and deleting a supplier. The controller class uses a SupplierRepository object to interact with the data layer and a SupplierVM view model to pass data to views. The WareAuthentication attribute is applied to the class to ensure that only users with the appropriate authorization can access its methods.

TerritoryController:
TerritoryController under the Administration area. It includes actions for TerritoryList, AddTerritory, UpdateTerritory, and DeleteTerritory. The actions use the TerritoryRepository to perform CRUD (Create, Read, Update, Delete) operations on the Territory model. The actions also use the TerritoryVM view model to display the list of territories and the form for adding and updating a territory. The controller is decorated with the ManagerAuthentication attribute to restrict access to authorized users.

ContactController:
Contact Controller that handles user contact and support issues for TeknoRama. It uses two repositories, IssueRepository and MessageRepository, to store data. There are two methods for adding tech issues and messages respectively, and both methods use EmailService to send support emails to the user. The code is written in ASP.NET MVC framework.

ShoppingController:
ShoppingController This code includes the controller's constructor, which initializes four repositories: OrderRepository, OrderDetailRepository, ProductRepository, and CategoryRepository. The controller contains several actions, such as "ShoppingList," "AddToCart," "CardPage," "DeleteFromCard," and "ConfirmOrder," which perform different functions related to shopping. The "ShoppingList" action lists the products and allows the user to browse them, and it also offers the option to filter the list by category. The "AddToCart" action adds a product to the shopping cart, and the "CardPage" action shows the shopping cart's content. The "DeleteFromCard" action deletes a product from the shopping cart, and the "ConfirmOrder" action initiates the order confirmation process. The "ConfirmOrderAsync" method is used to send an HTTP request to the API endpoint, "Payment/ReceivePayment," to confirm the order and then adds the order and order details to the database. After that, the "ConfirmOrderAsync" method sends an email to the customer to notify them about their order's confirmation.

VM Classes
a View Model (VM) class is a class that serves as an intermediary between a View and a Model, usually used in Model-View-Controller (MVC) and Model-View-ViewModel (MVVM) architecture patterns. It contains the data that a View needs for display purposes, and often exposes methods or commands for the View to interact with the Model. The purpose of a VM class is to separate the concerns of data presentation and manipulation from the underlying business logic of the Model, and to provide a more modular and testable architecture.


