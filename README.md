# Vendor and Order Tracker

#### By _Seung Lee_

#### _A simple website that lets a user to add vendors and orders for the vendors._

## Technologies Used

* _C#_
* _MSTest_
* _Razor_
* _HTML_
* _CSS_
* _Bootstrap_

## Description

A simple website where a user can add vendors and orders for the vendors that were added. Users can click on the names of vendors they've added to create an order with title, description, price and order date. Clicking on the order on vendor page lets users to be able to see the details of the order. Users can also delete the orders or vendors by clicking on a button on respective pages.

## Setup/Installation Requirements
_Requires console application such as Git Bash, Terminal, or PowerShell_

1. Open Git Bash or PowerShell if on Windows and Terminal if on Mac
2. Run the command

    ``git clone https://github.com/leark/VendorOrderTracker.Solution.git``

3. Run the command

    ``cd VendorOrderTracker.Solution``

* You should now have a folder `VendorOrderTracker.Solution` with the following structure.
    <pre>VendorOrderTracker.Solution
    ├── VendorOrderTracker
    └── VendorOrderTracker.Tests</pre>

<details>
<summary><strong>To Run</strong></summary>
Navigate to the following directory in the console
   <pre>VendorOrderTracker.Solution
   ├── <strong>VendorOrderTracker</strong>
   └── VendorOrderTracker.Tests</pre>

Run the following command in the console

  ``dotnet build``

Then run the following command in the console

  ``dotnet run``

</details>

<details>
<summary><strong>For Testing</strong></summary>
Navigate to the following directory in the console
    <pre>VendorOrderTracker.Solution
    ├── VendorOrderTracker
    └── <strong>VendorOrderTracker.Tests</strong></pre>

Run the following command in the console

  ``dotnet restore``

Then run the following command in the console

  ``dotnet test``

</details>

This program was built using _`Microsoft .NET SDK 5.0.401`_, and may not be compatible with other versions. Your milage may vary.

## Known Bugs

* _No known issues_

## License

[GNU](/LICENSE)

Copyright (c) 2022 Seung Lee