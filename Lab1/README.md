Lab 1

Worth: 25 points

Due: May 18 (by 11:59 PM on Monday)

Purpose: This lab explores the use of LINQ to query an array of objects.

Access the CoB Virtual Computer Lab as directed in class. You should have access to a Persona-SQL virtual desktop and will use your ULink credentials to login. If you are not using a Persona-SQL desktop, no information saved to the virtual desktop's file system will be retained after you log out.
Open Visual Studio 2012 as directed in class using the Start menu. Under All Programs, Microsoft Visual Studio 2012, Visual Studio 2012.
If you are not using a Persona-SQL desktop (or this is your first time opening Visual Studio 2012 with a Persona-SQL desktop), the Choose Default Environment Settings dialog box will appear. If so, choose the Visual C# Development Settings and None for the Local Help Documentation settings. Next, click on the Start Visual Studio button. This initial configuration may take a few minutes to complete. When using a Persona-SQL virtual desktop, these settings will be retained for you on later logins.
Complete Exercise 9-3 (p. 370). Use the attached file "Lab1Start.zip" as your starting point.

"Class Invoice includes four properties— a PartNumber (type int), a PartDescription (type string), a Quantity of the item being purchased (type int) and a Price (type decimal). Perform the following queries on the array of Invoice objects and displays the results:

a) Use LINQ to sort the Invoice objects by PartDescription.
b) Use LINQ to sort the Invoice objects by Price.
c) Use LINQ to select the PartDescription and Quantity and sort the results by Quantity.
d) Use LINQ to select from each Invoice the PartDescription and the value of the Invoice (i.e., Quantity * Price). Name the calculated column InvoiceTotal. Order the results by Invoice value. [Hint: Use let to store the result of Quantity * Price in a new range variable total.]
e) Using the results of the LINQ query in Part d, select the InvoiceTotals in the range $200 to $500."

Be sure to label your output for each part of the assignment.
Remember, the comments required for each file include your name, lab number, due date, course section, and brief description of what the program does. You don't need to comment the Invoice class file but you are responsible for the entire test program.
When finished, close Visual Studio but remember where you saved your project.
Open Windows Explorer and browse to your project's location. You should find a folder named "Lab1" that contains all your project's files and folders (including a file named "Lab1.sln". Return to the top-level of your project's location, so that the folder named "Lab1" (with all your project's files and folders) is visible.
Next, we will create a compressed ZIP archive of the entire project. The steps for doing this will vary somewhat based on the ZIP utility being used. These instructions assume you using the Windows 7 built-in compression utility but there are many tools such as WinZip and WinRAR available online.
Right-click on the "Lab1" folder and the context menu will appear. Choose "Send To" and then "Compressed (zipped) Folder" and name the archive as "Lab1.zip". If you don't see an appropriate option in the context menu, ask your instructor or lab assistant for help.
Before you upload this .ZIP file, it's a good idea to make sure that everything was properly zipped. Again, these instructions assume you are using the Windows 7 built-in compression utility.
Copy your .ZIP file to another location, such as your computer's Desktop.
Right-click on the copied "Lab1.zip" file and the context menu will appear. Choose "Extract all..." and then "Extract". Your project's folder structure will be recreated here.
Open this newly extracted "Lab1" folder and double-click on the "Lab1.sln" file. Visual Studio should open your project. Make sure your code is present and you can run your file. Use the Solution Explorer to expand your project and double-click on your .cs source-code file to bring up in Edit View.
Once you have verified everything, close Visual Studio again and return to the Assignments area of Blackboard.
Click on "Lab 1" and the Upload Assignment page will appear. Add any comments you like in Comments field.
Click Browse next to File to Attach to browse the system for your file. Browse to the location of your .ZIP file and select it. Note, multiple files may be attached using the Add Another File option. For this lab, we just need the "Lab1.zip" file.
Make sure everything is correct in the form and then click Submit to complete the assignment and upload your file to be graded.
