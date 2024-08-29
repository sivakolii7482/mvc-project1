ASP.NET Core web App(mvc)
Model> add class -> Category.cs 
install packages efc 
sqlserver connection
appsettings.json
add new folder -> Data -> add class -> ApplicationDbContext.cs
inside ctor+tab writecode
program.cs> Add Services
tools -> Nuget Package manager -> Package Manager Console
> update-database
ApplicationDbContext.c ->
 public DbSet<Category> Categories{get;set;}
> add-migration AddCategoryTableToDB
> update-database
Controller> add controller mvc controller empty -> CategoryController.cs
Views> new folder -> Category -> add view -> Razor view empty -> Index.cshtml
ApplicationDbContext.cs
 here added override part then
     >ad-migration SeedCategoryTable
     >update-database
 Retrieving data :
CategoryController.cs > for now index()
view>category>index.cshtml> write code
CategoryController.cs> Create() -> right click -> add view ->razor view empty -> Create.cshtml
Models>Category.cs > add dispaynae, range etc..
CategoryController>edit() -> right click -> add view -> razor view : name : Edit, template : Empty(without model), tick use a layout page -> Add > write or paste code
same as delete
For Notification :
Shared>add view razor view empty -> _Notification.cshtml > write
add  toastr cdn and this partial at _Layout.cshtml
