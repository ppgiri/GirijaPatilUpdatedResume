


The MVC (Model-View-Controller) is an application development pattern or design pattern which separates an application into three main components:

Model
View
Controller
Model
Model: Model is a part of the application which implements the logic for the data domain of the application. It is used to retrieve and store model state in a database such as SQL Server database. It also used for business logic separation from the data in the application.

View
View: View is a component that forms the application's user interface. It is uses to create web pages for the application. An example would be an edit view of a Products table that displays text boxes, drop-down lists and check boxes based on the current state of a Product object.

Controller
Controller: Controller is the component which handles user interaction. It works with the model and selects the view to render the web page. In an MVC application, the view only displays information whereas the controller handles and responds to the user input and requests.
 

Types of Routing:-

There are 2 types of Routing in MVC application
Conventional or Traditional Routing (Using Routing Config)
Attribute Routing (Available in MVC 5) 

Conventional Routing:
Conventional or Traditional Routing also is a pattern matching system for URL that maps incoming request to the particular controller and action method.
We set all the routes in the RouteConfig file.
RouteConfig file is available in the App_Start folder.
We need to register all the routes to make them operational.


Conventional Routing:-

public class RouteConfig  
    {  
        public static void RegisterRoutes(RouteCollection routes)  
        {  
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");  
  
            routes.MapRoute(  
                name: "Default",  
                url: "{controller}/{action}/{id}",  
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }  
            );  
        }  
    }  




Attribute Routing:
It is a very simple routing method compared to conventional routing. 
All the concepts are just like the conventional approach but here, we define all the routes and attributes. 

In attribute, we define the routing on a simple controller or action method. 

public class RouteConfig  
    {  
        public static void RegisterRoutes(RouteCollection routes)  
        {  
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");  
  			routes.mapMvcAttributeRoutes();
            routes.MapRoute(  
                name: "Default",  
                url: "{controller}/{action}/{id}",  
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }  
            );  
        }  
    } 


Collections :

For many applications, we must create and manage groups of related objects. 
There are two ways to group objects: by creating arrays of objects, 
and by creating collections of objects. Arrays are most useful for creating and working with a fixed number of strongly typed objects. 
Collections provide a more flexible way to work with groups of objects. 
Unlike arrays, the group of objects you work with can grow and shrink dynamically as the needs of the application change. For some collections,
 you can assign a key to any object that you put into the collection so that you can quickly retrieve the object by using the key. A collection is a class,
 so you must declare an instance of the class before you can add elements to that collection.

// Create a list of strings. var salmons = new List(); salmons.Add("chinook"); salmons.Add("coho"); salmons.Add("pink"); salmons.Add("sockeye");

// Iterate through the list. foreach (var salmon in salmons) { Console.Write(salmon + " "); } // Output: chinook coho pink sockeye

Action Filters :-
 
Action Filter is an attribute that you can apply to a controller action or an entire controller. 
This filter will be called before and after the action starts executing and after the action has executed.
 Action filters implement the IActionFilter interface that has two methods OnActionExecuting andOnActionExecuted. 
OnActionExecuting runs before the Action and gives an opportunity to cancel the Action call. 
These filters contain logic that is executed before and after a controller action executes, you can use an action filter, for instance, to modify the view data that a controller action returns.


HTTP Verbs

POST
The POST verb is most-often utilized to **create** new resources. In particular, it's used to create subordinate resources. That is, subordinate to some other (e.g. parent) resource. In other words, when creating a new resource, POST to the parent and the service takes care of associating the new resource with the parent, assigning an ID (new resource URI), etc.

GET
he HTTP GET method is used to **read** (or retrieve) a representation of a resource. In the “happy” (or non-error) path, GET returns a representation in XML or JSON and an HTTP response code of 200 (OK). In an error case, it most often returns a 404 (NOT FOUND) or 400 (BAD REQUEST).

PUT 
PUT is most-often utilized for **update** capabilities, PUT-ing to a known resource URI with the request body containing the newly-updated representation of the original resource.

PATCH
PATCH is used for **modify** capabilities. The PATCH request only needs to contain the changes to the resource, not the complete resource.

DELETE
DELETE is pretty easy to understand. It is used to **delete** a resource identified by a URI.
