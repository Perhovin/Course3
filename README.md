# Object Collections & Iteration

A C# console application focused on managing collections of objects using generic lists, iterating through them, and applying conditional logic.

## Features
* **Custom Object Structure:** A `Course` class that stores `Name` and `Room` data, initialized securely through a constructor.
* **List Implementation:** Uses a `List<Course>` collection to store multiple course objects in a single structured variable.
* **Anonymous Instantiation:** Instantiates objects directly inside the list using `Courses.Add(new Course(...))` for entries like "Math" and "Physics", saving code lines and memory.
* **Data Iteration:** Utilizes a `foreach` loop to systematically iterate through every object stored in the `Courses` list.
* **Conditional Filtering:** Implements an `if-else` statement inside the loop to validate data, specifically printing an "Error" message if a course's room number strictly exceeds 400.

## What I learned in this project
* How to create, populate, and manage a `List<T>` containing custom objects instead of basic data types.
* The efficiency of using `foreach` loops to handle collections without needing manual index counters.
* How to access specific object properties (`course.Room`, `course.Name`) dynamically during iteration to apply business logic (like error checking).
