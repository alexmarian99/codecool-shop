<<<<<<< HEAD
# Codecool shop (sprint 2)

## Story

It's time to enhance the Online Shop, an online eCommerce web-application with Java,
where users can not only browse products, add them into a Shopping Cart,
checkout items and make payments, but can also log in and see the abandoned shopping cart or their order history.

> Did you know that the very first product on eBay was a broken laser pointer?
> If you don't believe, check their history: [eBay history](https://www.ebayinc.com/company/our-history/)

## What are you going to learn?

- Log properly.
- Use property files for separate project settings.
- Write tests and mock out dependencies to ensure the correct functionality and gain confidence at future  modification.
- Use databases to make the data persistent by using an ORM.
- Use the `DAO` design pattern in `Csharp`.
- Refresh your SQL knowledge.
=======
# Codecool shop (sprint 1)

## Story

Everyone loves to buy and sell stuff, but we need a shop for that! In this
project, the goal is to build one of the [most common type of websites on the
web](https://www.expertmarket.co.uk/web-design/different-types-of-websites): an
online eCommerce web-application, where users can browse products, add them into
a shopping cart, then check out and make payments.

## What are you going to learn?

- how to create an ASP.NET Core web application using an in-memory database.
- how to use the `DAO` design pattern and dependency injection.
- how to log data in a specified format.
- how to handle fractional monetary unit appropriately with decimal
>>>>>>> 00992d7f8957c07f194a3c931ada185c541852de


## Tasks

<<<<<<< HEAD
1. Create a new sprint tab on the existing backlog. Last week, you had a long list of stories, a few new stories this week.
    - The new items are added to the backlog.
    - The team has created a sprint 2 plan, based on the unified backlog.

2. As you work in a new repository but still need the code from the previous sprint, add the `codecool-shop-2` repository as a new remote to the repository of the previous sprint, then pull (merge) and push your changes into it.
    - There is a merge commit in the project repository that contains code from the previous sprint.

3. As a Developer, I want to cover the `ProductService` and any other Service objects with unit tests, so that I can safely change the implementation later.
    - All methods of the Services are tested, independently from their DAO dependencies, using mocking.
    - Both "happy-paths" and "sad-paths" are tested.
    - At least eleven unit tests pass.

4. As a Developer, I want to have proper log messages when any failure happens to make it possible to find any malfunction in the system and track back user complaints.
    - Serilog can be utilized for providing diagnostic logging.
    - All exceptions are logged with a proper description message.

5. As an Operator of the Shop, I want the product data to be persistent, so that I can restart the application without losing product data.
    - There is an empty MSSQL database, named `codecoolshop`.
    - The Entity Framework Core code-first approach is used for providing the database schema. The database is then seeded with products.
    - When the page is loaded and DB is used, suppliers, product categories, and products are loaded from the database using `ProductDao`, `ProductCategoryDao`, and `SupplierDao`.

6. As a Developer, I want to read the DAO settings and DB connection parameters (url, database name, usr, pwd) from a config file, so I can change the settings of the application on every environment without compiling again.
    - In the appsettings.json file, local database parameters are added with the following structure (exact values may vary). ```
 "Mode": "sql",
  "ConnectionStrings": {
    "DefaultConnection": "Server=(LocalDb)\\MSSQLLocalDB;Database=codecoolshop;Trusted_Connection=True;MultipleActiveResultSets=true"}```
    - The application reads the database type and either operates on the Entity Framework in-memory, or in SQL variations.
    - The application reads the DB settings and database type from the appsettings file.

7. As an Operator of the Shop, I want to keep Order data safe and persistent, so that I do not lose money due to technical issues.
    - If the user starts a checkout process, all Order data is saved into the database at every step (except the cart).

8. As a User, I want to sign up (make a personal account), so that I can store Orders on my personal account.
    - There is a `Sign up` option on the website.
    - There is a signup form with the following fields.
- `name`
- `email`
- `password`
    - When the user submits the form with valid information, the system saves the data as a new `User`.
    - The system sends a welcome email upon successful registration.
    - When the user submits the form with invalid information, the program displays the form with the invalid data, and some error descriptions.

9. As a User, I want to able to log in, so that I can and access my personal data. I also want to be able to log out.
    - There is a `Login` option on the website.
    - When the user selects "Login", a login form is displayed with the following fields.
- email address
- password
    - When the user submits the form with valid information, they are authenticated and given a new logged-in session.
    - When the user submits the form with invalid information, an error message is displayed.
    - If the user is logged in, a Logout option is displayed on the webpage. When the user selects "Logout", the session is reset, and the user is redirected to the login form.

10. As a logged-in User, I want to see my Order history, with my previous Orders and their statuses.
    - There is an `Order history` option on the webpage.
    - A list of all Orders of the user is displayed, with the following details.
- order date
- order status (checked / paid / confirmed / shipped)
- total price
- product list (with product name, price)

11. As a logged-in User, I want to save the current items of my Shopping cart so that I can order my selected Products later.
    - There is a `Save my cart` button (on the Shopping cart review page).
    - When clicking this button, the system saves the cart items into the database for the logged-in User.
    - When a User with a previously saved shopping cart logs in the shopping cart is refilled with the saved items.

12. As a logged-in User, I want to save my billing and shipping info to my personal account, so that I don't need to retype the data every time during checkout.
    - There is a `Billing info` option on the webpage.
    - Clicking `Billing info` displays a form asking for all personal billing and shipping information required for checkout.
    - On the Shopping Cart review page, clicking the "Checkout" button as a logged-in user, the billing and shipping info is pre-filled on the checkout form.

## General requirements

- Advanced OOP concepts are used in the project, such as inheritance.
There is at least one abstract class.
There is at least one interface implemented.
- The page does not show a server error anytime during the review.
- All code is pushed to GitHub repository in atomic commits. The implemented feature-related commits are managed on separated feature branches, and merged in a pull request to the `master` branch.

## Hints

- It's not required to integrate real payment services - you can use fake payment implementations.
- Use the DAO implementations via interfaces so that it will be easy to change the implementation behind the interface.
- You can use `decimal(20,2)` sql type to store your decimal values in the database

## Background materials

- <i class="far fa-exclamation"></i> [Serilog in ASP.NET Core 3.1](https://codewithmukesh.com/blog/serilog-in-aspnet-core-3-1/)
- <i class="far fa-exclamation"></i> [ASP.NET Core session basics](https://tutexchange.com/using-session-in-asp-net-core-3-0/)
- <i class="far fa-exclamation"></i> [Querying in Entity Framework](https://www.entityframeworktutorial.net/querying-entity-graph-in-entity-framework.aspx)
- <i class="far fa-exclamation"></i> [Learning Entity Framework Core](https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx)
- <i class="far fa-exclamation"></i> [ASP.NET Core Identity](https://www.tutorialspoint.com/asp.net_core/asp.net_core_identity_configuration.htm)
=======
1. As a Developer, I want to have a version-controlled project, where a webserver serves requests. This allows me to start developing in a sandboxed environment.
    - When starting up the ASP.NET Core IIS application web-server, the server returns an index page.

2. As a User, I want to have an index page, where I can see the list of Products in a default Product Category.
    - There are Products and a default Product Category in the application. Opening the root URL (`/`) displays a list of Products with details such as product title, description, image, price.

3. As a User, I want to have an index page, where I can filter Products by Product Categories.
    - There are Products and Product Categories listed on the index page. Clicking on the title of a Category displays Products only in the selected Category.

4. As a User, I want to have an index page where I can filter Products by Suppliers.
    - There are Products and Suppliers listed on the index page. Clicking on the name of a Supplier displays the Products only for the selected Supplier.

5. As a User, I want to have a Shopping Cart so that I can add products which I want to buy.
    - In the Product list, the Products have an "Add to cart" button. Clicking the "Add to cart" button creates a new Order for storing cart data and a new LineItem with the quantity (default: 1) and price of the Product. This data is stored on the server.
    - In the Product list, the Products have an "Add to cart" button. Clicking the "Add to cart" button displays the number of cart items in the Page header

6. As a User, I want to review the contents of my Shopping Cart before checking out.
    - When the Shopping Cart has items in it, clicking "Shopping cart" in the Page header displays the items (LineItems) with their data, such as name of the Product, quantity, unit price / subtotal price.
    - When the Shopping Cart has items in it, clicking "Shopping cart" in the Page header displays the total price of all the items in the cart.

7. As a User, I want to edit the quantity of items, or remove items from my Shopping Cart.
    - On the Shopping Cart review page, the LineItems are displayed in a form, and the quantities are displayed in input fields. Changing the quantity of an item stores the new quantity of the LineItem.
    - On the Shopping Cart review page, LineItems are displayed in a form, and the quantities are displayed in input fields. Changing the quantity of an item to 0 removes the LineItem from the cart.

8. As a User, I want to checkout the items from the Shopping Cart and order the Products.
    - On the Shopping Cart review page, clicking the "Checkout" button displays a form asking for user data, such as Name, Email, Phone number, Billing Address (Country, City, Zipcode, Address), and Shipping Address (Country, City, Zipcode, Address)
    - On the Shopping Cart review page, clicking the "Go to Payment" button validates the data on the checkout form.
    - After successful validatiion, the data on the checkout form is stored in the Order.
    - If the data on the checkout form is validated and stored successfully, the page redirects to the Payment page.

9. As a User, I want to pay for my Products online.
    - After checking out the items from the Shopping cart, the total price is displayed.
    - After checking out the items from the Shopping, the order can be paid for by credit card.
    - After checking out the items from the Shopping cart and choosing the payment method, a form is displayed, asking for the credentials for the payment provider, such as card number, card holder, expiry date, and CVV code.

10. As a User, I want to see the result of my payment and get a confirmation about my Order.
    - If there is an error while making a payment, the details of the error are displayed.
    - If the transaction is successful, the Confirmation page is displayed, with the details of the Order.
    - If the transaction is successful the Order is saved in a `JSON` file.
    - If the transaction is successful, an email is sent to the User about the Order.

11. As an Admin, I want to have a log file of the checkout processes (per Order), to see the steps of every Order and investigate issues.
    - If a checkout process is started, all the steps and details are saved into a JSON file. The filename is the Order ID and the Date.

## General requirements

- Advanced OOP concepts, such as inheritance, are used in the project. There is at least one abstract class and one interface implemented.
- The project maintains the three-layer structure of controllers handling HTTP, service objects handling business logic, and DAOs handling data access.
- The page does not show a server error anytime during the review.
- All code is pushed to GitHub repository in atomic commits. The implemented feature-related commits are managed on separated feature branches and merged in a pull request to the `master` branch.

## Hints

- Do not use a database. Use in-memory storage or file storage, but through the DAO (Data Access Object) pattern.
- Use fake payment implementations. It is not required to integrate real payment services.

## Background materials

- <i class="far fa-exclamation"></i> [Dependency Injection](https://www.tutorialsteacher.com/ioc/dependency-injection)
- <i class="far fa-exclamation"></i> [Create a shopping cart](https://learningprogramming.net/net/asp-net-core-mvc/build-shopping-cart-with-session-in-asp-net-core-mvc/)
- <i class="far fa-exclamation"></i> [Logging with Serilog](https://www.youtube.com/watch?v=_iryZxv8Rxw)
- <i class="far fa-exclamation"></i> [Entity Framework Core In-Memory Database](https://exceptionnotfound.net/ef-core-inmemory-asp-net-core-store-database/)
- <i class="far fa-exclamation"></i> [Intro to SQL relations in the database](https://www.sqlshack.com/learn-sql-types-of-relations/)
- <i class="far fa-exclamation"></i> [JSON serialization and deserialization](https://www.c-sharpcorner.com/article/json-serialization-and-deserialization-in-c-sharp/)
>>>>>>> 00992d7f8957c07f194a3c931ada185c541852de

