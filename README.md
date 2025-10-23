# Hell0_Web (C# Front-End UI with Figgle ASCII)

Hell0_Web is a C# front-end web UI where users can input text into a form, click "Go", and see the Figgle ASCII art rendering of their input displayed below.

## Goals
- [x] Showcase front-end web UI development in C#
- [x] Demonstrate TDD for backend logic and integration
- [x] Maintain clean separation of controller, model, and view
- [x] Create a simple, readable, maintainable, and professional codebase
- [x] Display Figgle ASCII art output dynamically in a web page
- [ ] (Stretch goal) add one client-side feature (AJAX to render ASCII without full reload)
- [ ] (Stretch goal) add font selection buttons
- [ ] Deploy to a live URL for easy testing and portfolio sharing

## Tech Stack
- **Backend / Web Framework:** ASP.NET Core (MVC or Razor Pages)
- **Frontend:** Razor views, minimal HTML/CSS
- **TDD / Testing:** xUnit + Moq for controller and integration tests
- **NuGet Package:** [`Hell0_TDD.Core`](https://www.nuget.org/packages/Hell0_TDD.Core) for ASCII rendering
- **Deployment:** Azure App Service (free tier) with GitHub integration

## Structure
```
Hell0_Web/
│
├── Hell0_Web.sln
├── Hell0_Web/
│ ├── Controllers/
│ │ └── AsciiController.cs
│ ├── Views/
│ │ └── Home/Index.cshtml
│ ├── wwwroot/css/
│ ├── Models/
│ │ └── AsciiInputModel.cs
| │ └── MaxLengthAttribute.cs
│ ├── Program.cs
│ └── Hell0_Web.csproj
│
├── Hell0_Web.Tests/
│ ├── AsciiControllerTests.cs
│ ├── AsciiInputModelTests.cs
│ └── Hell0_Web.Tests.csproj
│
└── README.md
```

## Planned Commit History
- [x] feat(solution): create Hell0_Web solution and web project
- [x] feat(tests): create Hell0_Web.Tests project with xUnit
- [x] feat(core): add AsciiInputModel for user input validation
- [x] feat(controller): scaffold AsciiController with action for input form
- [x] test(controller): add unit tests for AsciiController input handling
- [x] feat(view): add Ascii/Input.cshtml with text box and Go button
- [x] feat(core): integrate Hell0_TDD NuGet package for ASCII rendering
- [x] test(controller): add tests for ASCII rendering output using NuGet
- [x] feat(view): display ASCII output under input box
- [ ] fix(routing): make /Ascii/Input the default homepage
- [ ] chore: add basic CSS styling for readability
- [ ] feat(core): add optional font selection support (stretch)
- [ ] test(controller): add tests for font selection input (stretch)
- [ ] feat(frontend): add optional JavaScript/AJAX (stretch)
- [ ] feat(integration): add minimal integration test (stretch - optional for portfolio)
- [ ] docs: update README with instructions and demo screenshot
- [ ] chore: deploy to Azure (stretch)

## Usage
1. Open the live app URL in your browser.
2. Enter text in the input box.
3. Click the "Go" button to see your input rendered as Figgle ASCII art below the box.
<!-- Stretch Goal: select a Figgle font. -->

## License
This project is licensed under the MIT License.


