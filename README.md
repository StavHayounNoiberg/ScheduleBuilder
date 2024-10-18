# ScheduleBuilder
A schedule-building tool designed for Afeka students. This WinForms application, written in C#, utilizes the Selenium framework to scrape data from the Afeka portal. After retrieving the necessary data, a recursive backtracking algorithm is employed to generate all possible valid schedules, ensuring no course overlaps and that prerequisites are respected. The user can then conveniently view and filter through the generated schedules.

Installation file can be found under the releases section on the right -->  
After installation, open Start Menu (or type Schedule Builder in the search box) and open Schedule Builder:  
![image](https://github.com/user-attachments/assets/a246072f-a75d-40e4-89e6-053e347d6c76)

Upon launching the application, the user can choose to either create new schedules or view previously saved schedules from a file:
![image](https://github.com/user-attachments/assets/dacf9010-9ebc-4a0d-816b-01aab89afb10)

When opting to create new schedules, the user is prompted to enter their Afeka credentials along with the list of courses they want to schedule for a specific year and semester:

![image](https://github.com/user-attachments/assets/e799f943-ca1e-4b7d-aced-5347eea1355d)

After the schedule-building process is complete, or if the user has opted to load schedules from a file, a schedule view is displayed, presenting all the generated schedules. Each course is assigned a different color, with key details such as group number, instructor, time, and location shown within each course block.

At the top right, a counter displays the total number of schedules created and the index of the current schedule being viewed. Users can navigate through the schedules using the toolbar buttons or by entering a specific schedule index to jump directly to a desired schedule:
![image](https://github.com/user-attachments/assets/dcd71da2-dcce-4af6-9252-3e5f25f6edce)


The toolbar provides a range of helpful options, including saving schedules to a file for future use, copying the current schedule as an image, navigating between schedules, displaying exams associated with the schedule, checking for conflicts or overlaps, and filtering the results. These tools empower users to easily manage and refine their schedules.

When applying filters, users have the ability to customize their schedules by specifying start and end times for each day, selecting or excluding certain lecturers, or focusing on specific course groups. Multiple filters can be combined, giving users greater control over tailoring their schedules to fit their preferences and requirements:
![image](https://github.com/user-attachments/assets/6f4e0e16-f0e0-46b8-9bde-5768eb48f385)

## Breaking Changes
With the introduction of two-factor authentication (2FA) to Afeka's portal, the application can no longer be used as is.
To work around this, you can run the application in debug mode and manually intervene when the 2FA process is initiated.
