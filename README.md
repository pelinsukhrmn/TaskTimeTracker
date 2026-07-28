# TaskTimeTracker

Personal Task Planner + Time Tracking App

A small C# WinForms app for tracking how long you spend on tasks. Start a task, stop it, and the app records how much time it took. Tasks are saved to a local JSON file, so history carries over between runs.

## What it does

- Type a task name and hit Start — a live `hh:mm:ss` timer begins counting on the main form.
- Hit Stop to end the task; the elapsed time is recorded and the entry is saved.
- Open the "history" dialog to see past tasks with their name, start time, and duration.
- Each task (`TaskItem`) stores a name, start time, end time, and a computed duration.
- Task history is persisted to `tasks.json` (next to the executable) via `FileDataAccess`, which serializes/deserializes the task list as JSON — so history survives restarts.
- If you start a new task while one is already running, the running one is ended automatically first.

## Tech stack

- C# / .NET, WinForms
- `System.Text.Json` for saving/loading task data
- Simple layered structure: `Models` (`TaskItem`), `Services` (`TaskManager`), `Data` (`FileDataAccess`)

## Running it

Open `TaskTimeTracker.sln` in Visual Studio and run it, or from the command line:

```
dotnet run --project TaskTimeTracker.csproj
```

Task data is read from and written to a local JSON file (`tasks.json`) next to the executable — no database or external service required.

## Status

This is an ongoing personal productivity project. A JS-based to-do list version is planned as a follow-up.
