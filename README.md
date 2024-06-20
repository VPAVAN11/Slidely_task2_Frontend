Here's the updated `README.md` file including the section on searching submissions:

---

# Windows Forms Application Project

## Overview
This Windows Forms application allows users to view, edit, and create submissions. The project demonstrates the use of Visual Basic and .NET Framework in a Windows Forms application.

## Table of Contents
- [Overview](#overview)
- [Prerequisites](#prerequisites)
- [Downloading the Project](#downloading-the-project)
- [Running the Application](#running-the-application)
- [Viewing Submissions](#viewing-submissions)
- [Submitting Submissions](#submitting-submissions)
- [Searching Submissions](#searching-submissions)
- [Contributing](#contributing)
- [License](#license)

## Prerequisites
Before you begin, ensure you have the following installed on your local machine:
- [Visual Studio](https://visualstudio.microsoft.com/) (preferably the latest version)
- .NET Framework SDK (compatible with the project)

## Downloading the Project
1. **Visit the GitHub Repository:**
   - Navigate to the [GitHub Repository](https://github.com/VPAVAN11/Slidely_task2_Frontend.git).

2. **Download the Code:**
   - Click the green `Code` button.
   - Select `Download ZIP` and extract it to your desired location.
   - Alternatively, clone the repository using Git:
     ```bash
     git clone https://github.com/VPAVAN11/Slidely_task2_Frontend.git
     ```

## Running the Application
1. **Open the Project in Visual Studio:**
   - Launch Visual Studio.
   - Go to `File` > `Open` > `Project/Solution`.
   - Navigate to the folder where you extracted or cloned the repository.
   - Select the `.sln` file to open the project.

2. **Restore NuGet Packages:**
   - Go to `Tools` > `NuGet Package Manager` > `Package Manager Console`.
   - In the Package Manager Console, run:
     ```powershell
     Update-Package -reinstall
     ```
   - Alternatively, right-click on the solution in the Solution Explorer and select `Restore NuGet Packages`.

3. **Build the Solution:**
   - Go to `Build` > `Build Solution` or press `Ctrl+Shift+B`.
   - Ensure there are no build errors.

4. **Run the Application:**
   - Press `F5` or click the `Start` button in the toolbar.
   - 

    ![Screenshot 2024-06-20 152315](https://github.com/VPAVAN11/Slidely_task2_Frontend/assets/103198643/4181f0c9-4f13-4f25-9e9c-97d23c877e4c)

   
   ![Screenshot 2024-06-20 120441](https://github.com/VPAVAN11/Slidely_task2_Frontend/assets/103198643/9a19c624-e1e6-426f-aeac-385187fdc771)

   
   
   ![Screenshot 2024-06-20 120451](https://github.com/VPAVAN11/Slidely_task2_Frontend/assets/103198643/f7468924-c582-410d-9a85-e24531f69d58)

## Viewing Submissions
To view submissions within the application:
1. Open the application.
2. Navigate to the `Submissions` section from the main menu.
3. Select the desired submission to view details.

![Screenshot 2024-06-20 120504](https://github.com/VPAVAN11/Slidely_task2_Frontend/assets/103198643/524be663-7eea-4503-8360-f14020ef5ab8)

![Screenshot 2024-06-20 120513](https://github.com/VPAVAN11/Slidely_task2_Frontend/assets/103198643/2ae27950-cc3c-45ef-ab9c-ea8d1d07454f)

## Submitting Submissions
To submit a new entry:
1. Open the application.
2. Navigate to the `Submit` section from the main menu.
3. Fill out the necessary fields in the submission form.
4. Click the `Submit` button to save your entry.
   
![Screenshot 2024-06-20 120536](https://github.com/VPAVAN11/Slidely_task2_Frontend/assets/103198643/1a5a2b79-19c8-4ac2-a0e0-038d4528a547)

## Searching Submissions
To search for submissions by email:
1. Open the application.
2. Enter the email address in the search box.
3. Click the `SEARCH (CTRL + S)` button or use the shortcut `Ctrl + S`.


![Screenshot 2024-06-20 152528](https://github.com/VPAVAN11/Slidely_task2_Frontend/assets/103198643/5f32da49-cdbb-4b5c-8556-8ff716ebcf31)


4. The results will be displayed in the list view below the search box, formatted as follows:
   - **ID:** <submission_id>
   - **Name:** <submission_name>
   - **Email:** <submission_email>
   - **Phone:** <submission_phone>
   - **GitHub:** <submission_github_link>
   - **Stopwatch Time:** <submission_stopwatch_time>
   
## Contributing
We welcome contributions to the project! To contribute:
1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature-branch
   ```
3. Make your changes and commit them:
   ```bash
   git commit -m 'Add new feature'
   ```
4. Push to the branch:
   ```bash
   git push origin feature-branch
   ```
5. Open a Pull Request.



---
