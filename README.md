# Dungeon Master's Companion App

The Dungeon Master's Companion App is a tool designed to assist Dungeon Masters in managing various aspects of their tabletop role-playing game sessions, including initiatives, creatures, status effects, rounds, and weather conditions.

## Features

- **Initiative Tracker**: Keep track of the order in which players and creatures take their turns in combat.

- **Creature Manager**: Maintain a list of creatures, their stats, and relevant information for encounters.

- **Status Effects**: Manage ongoing effects, buffs, debuffs, and conditions applied to creatures during the game.

- **Round Counter**: Monitor the progression of combat rounds to maintain a smooth gameplay experience.

- **Weather Conditions**: Track weather effects that can influence gameplay and add immersive elements to the story.

## Technologies Used

- **Front-end**: The front-end of the app is developed using C# Windows Presentation Foundation (WPF) for a rich and interactive user interface.

- **Back-end**: The back-end of the app is built on the Azure cloud platform. It utilizes Azure services such as Azure Functions for serverless logic and Azure SQL Database for data storage.

- **Full Stack**: The app is a full stack application that seamlessly integrates the C# WPF front end with the Azure back end.

## Getting Started

1. Clone this repository to your local machine.
git clone https://github.com/your-username/DM-Companion-App.git

2. Navigate to the project directory.
cd DM-Companion-App

3. Set up your Azure resources:
- Create an Azure SQL Database and configure the connection string in your C# code.
- Set up an Azure Function App for your serverless back-end logic.

4. Configure the app's settings, such as Azure connection details and any environment variables required.

5. Build and run the C# WPF front-end application.

6. Deploy your Azure Function App and Azure SQL Database.

7. Access the app through the deployed C# WPF front-end, which communicates with the Azure back end.

## Contributing

Contributions are welcome! If you'd like to contribute to the app, please follow these steps:

1. Fork the repository.

2. Create a new branch for your feature or bug fix.
git checkout -b feature/your-feature-name

3. Make your changes and commit them with descriptive commit messages.

4. Push your changes to your forked repository.

5. Create a pull request targeting the `main` branch of this repository.

## License

This project is licensed under the [MIT License](LICENSE).
