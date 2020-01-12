# SaaS-Products
SaaS Products Repo

"Installation steps and How to run your code / tests"
Open the Project in Visual Studio.
Build the project, it will install all the dependencies.
Run the app, go to "http://localhost:47649/product/getproductsfeed" url.
To see the output, check the output window of VS.
To run the test cases, use the "Run All" button of Test Explorer.

"Where to find your code"
Open Solution Explorer of VS
There are two projects in one solution, one for code and another one for test cases.
I kept the feed-product(all files) folder into the wwwroot folder because we keep all the static files of application into the wwwroot folder. we can change the location according to the requirement.
I have read all the files from folder to keep in mind that we can have more files in future.

"Was it your first time writing a unit test, using a particular framework, etc?"
No, I am using xunit in my current project for the test cases.

"What would you have done differently if you had had more time"
I would have used the files in more dynamic way for example create a method which will read all the json/ymal/csv file.
I would have used key/value pair to show the content in dynamic way.
I have showed the product detail on UI instead of using "System.Diagnostics.Debug.WriteLine". As I had shortage of time I used this.



