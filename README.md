# Hell0_Web (C# Front-End UI with Figgle ASCII)

**Description:**  
Hell0_Web is a C# front-end web UI where users can input text into a form, click "Go", and see the Figgle ASCII art rendering of their input displayed below.

## Project Goals / Planned Features
[ ] Showcase front-end web UI development in C#
[ ] Demonstrate TDD for backend logic and integration
[ ] Reuse a TDD-tested NuGet package (`Hell0_TDD`)
[ ] Create a simple, readable, maintainable, and professional codebase
[ ] Display Figgle ASCII art output dynamically in a web page
[ ] Clean separation of controller, model, and view
[ ] Deploy to a live URL for easy testing and portfolio sharing

## Tech Stack
- **Backend / Web Framework:** ASP.NET Core (MVC or Razor Pages)
- **Frontend:** Razor views, minimal HTML/CSS
- **TDD / Testing:** xUnit + Moq for controller and integration tests
- **NuGet Package:** [https://www.nuget.org/packages/Hell0_TDD.Core]`Hell0_TDD.Core` for ASCII rendering
- **Deployment:** Azure App Service (free tier) with GitHub integration

## Project Structure
Hell0_Web/
│
├── Hell0_Web.sln
├── Hell0_Web/
│ ├── Controllers/
│ │ └── AsciiController.cs
│ ├── Views/
│ │ └── Home/Index.cshtml
│ ├── wwwroot/css/
│ ├── Models/AsciiInputModel.cs
│ ├── Program.cs
│ └── Hell0_Web.csproj
│
├── Hell0_Web.Tests/
│ ├── AsciiControllerTests.cs
│ └── Hell0_Web.Tests.csproj
│
└── README.md

## Planned Commit History
- [ ] feat(solution): create Hell0_Web solution and web project
- [ ] feat(tests): create Hell0_Web.Tests project with xUnit
- [ ] feat(core): add AsciiInputModel for user input validation
- [ ] feat(controller): scaffold AsciiController with action for input form
- [ ] test(controller): add unit tests for AsciiController input handling
- [ ] feat(view): add Home/Index.cshtml with text box and Go button
- [ ] feat(core): integrate Hell0_TDD NuGet package for ASCII rendering
- [ ] test(controller): add tests for ASCII rendering output using NuGet
- [ ] feat(view): display ASCII output under input box
- [ ] feat(core): add optional font selection support
- [ ] test(controller): add tests for font selection input
- [ ] chore: add basic CSS styling for readability
- [ ] feat(integration): add minimal integration test for controller + view
- [ ] docs: update README with instructions and demo screenshot

## Usage

On Your Laptop:
1. Clone the repository.
2. Open the solution in Visual Studio.
3. Build and run the project.
4. Open the web UI, enter text in the input box, and click "Go" to see ASCII art rendered below.

On the Web:
1. Open the live app URL in your browser (provided in the repository description or README).
2. Enter text in the input box.
3. Click the "Go" button to see your input rendered as Figgle ASCII art below the box.
4. Optionally, select a Figgle font if available.
5. Enjoy.

## License
This project is licensed under the MIT License.


