# Lab 2: Windows Forms Applications with C#

## Overview

This lab explores the development of Windows Forms applications using C#. It involves creating multiple forms to gather user input, validate data, and display results.

## Tasks

### Lesson 1: Student Details Form

    Create a new Windows Forms project:
        Launch Visual Studio.
        Select File > New > Project.
        Choose Visual C# > Windows > Windows Forms Application.
        Name the project "Lab2-B1".

    Design the Student Details form:
        Add the following controls to the form:
            TextBoxes for name and year
            ListBox for class
            ComboBox for division
            CheckedListBox for hobbies
            Buttons for Confirm and Clear
        Set the properties of the controls as specified in the lab instructions.

    Implement event handlers:
        Handle the Click events of the Confirm and Clear buttons to process user input and clear the form, respectively.

    Build and run the application:
        Save the project.
        Build the solution (Build > Build Solution).
        Run the application (Debug > Start).
        Test the form's functionality.

### Lesson 2: Login and Employee Details Forms

    Create two forms:
        Login form (for authentication)
        Employee Details form (to collect employee information)

    Implement login functionality:
        Validate user credentials (username: Admin, password: Admin).
        Display error messages for invalid credentials.
        Navigate to the Employee Details form upon successful login.

    Design the Employee Details form:
        Add controls for name, address, date of employment, education, department, Save, Clear, and Exit buttons.
        Set properties as needed, including multiline support for the address field.

    Implement event handlers:
        Handle button clicks for Save (confirming user input), Clear (clearing data), and Exit (terminating the application).

### Lesson 3: Flight Reservation Form

    Create a new form for flight reservation details.

    Add controls:
        TextBoxes for ticket number, passenger name, passport number, and flight date
        ListBoxes for departure city and destination city
        ComboBox for ticket class
        CheckedListBox for additional services
        Buttons for Verify and Clear

    Implement event handlers:
        Handle the Verify button click to validate input (ensure different departure and destination cities) and display an error message if necessary.
        Handle the Clear button click to clear the form.