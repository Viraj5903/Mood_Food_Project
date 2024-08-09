# Mood Food Project

## Overview
The **Mood Food Project** is a Windows Forms application developed in C# that helps users track their food intake and assess its impact on their mood. The application allows users to log detailed information about their meals, including food type, portion size, and timing, while also rating their mood before and after eating. Leveraging this data, the application provides personalized food recommendations aimed at improving mood based on observed patterns and trends.

Key features include a secure user authentication system, mood tracking capabilities to record mood fluctuations, and a recommendation engine that suggests foods likely to enhance the user’s mood. Through detailed analysis of the relationship between dietary choices and mood changes, the application empowers users to make informed decisions that contribute to their overall well-being.

## Description

### Features
- **User Authentication:** Secure login feature to access the application.
- **Mood Tracking:** Log mood ratings before and after eating.
- **Food Logging:** Enter details about food items including type, portion size, and timing.
- **Recommendation Engine:** Provides food recommendations to improve mood based on user data.

### Core Components
- **Food Class:** Represents food items with attributes such as name, type, and allergy information.
- **RecommendationFood Class:** Models the relationship between food intake and mood, including portion size and timing.
- **Timing Enum:** Defines the times of day when food can be consumed (Morning, Afternoon, Evening, Night).

## Technology Used
- **C#:** Programming language used for application development.
- **Windows Forms:** Framework for the graphical user interface.
- **Visual Studio:** IDE used for development and testing.

## Setup Instructions
1. **Install Visual Studio:**
   - Download and install [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) or any edition of your choice.
   - During installation, select the ".NET desktop development" workload to ensure that you have the necessary tools for Windows Forms applications.

2. **Clone the Repository:**
    ```
    git clone https://github.com/Viraj5903/Mood_Food_Project.git
    ```

3. **Open in Visual Studio:**
   - Open the `Mood_Food_Project.sln` solution file located in the cloned repository.

4. **Build the Project:**
   - Compile the application using Visual Studio’s build tools.

5. **Run the Application:**
   - Launch the application from Visual Studio or run the compiled executable.

6. **Login Credential:**
   - Username: Admin
   - Password: Admin123

## File Structure
- `Mood_Food_Project/`: Contains the main application files and folders.
    - `Login.cs` and `Rating_suggestion_form.cs`: Contains forms for user login and mood-food rating suggestions.
    - `Program.cs`: Entry point for the application.
    - `Classes/`: Contains core classes and enumerations.
      - `Food.cs`: Represents food items.
      - `RecommendationFood.cs`: Models the relationship between food intake and mood.
      - `Timing.cs`: Enum for time of day.
    - `Resources/`: Contains application resources.
    - `Properties/`: Contains configuration files.
    - `app.config`: Configuration file for application settings.
- `Pictures/`: Contains images used in the application.
- `User_and_Password.txt`: File containing the default login credentials for accessing the application.
- `README.md`: This README file.

## Author
[Viraj Patel \(@Viraj5903\)](https://github.com/Viraj5903)
- Creator and maintainer of the Mood Food Project. Responsible for designing and implementing the application’s features, including mood tracking, food recommendations, user authentication, and user interface design.