# Copilot Instructions

## Project

* This is a C# console application using modern .NET.
* Keep the application simple, readable, and maintainable.
* Follow standard C# naming conventions and idiomatic .NET patterns.

## Code Style

* Use `PascalCase` for classes, methods, and public members.
* Use `camelCase` for local variables and parameters.
* Prefer clear, descriptive names over abbreviations.
* Keep methods small and focused on one responsibility.
* Use `var` when the type is obvious from the right-hand side.
* Avoid unnecessary abstractions or dependencies.

## Error Handling

* Validate user input where appropriate.
* Handle expected errors gracefully and provide useful console messages.
* Do not catch exceptions unless they can be handled meaningfully.
* Never silently ignore errors.

## Console UI

* Keep console output concise and easy to read.
* Separate user prompts, results, and errors clearly.
* Do not add unnecessary UI frameworks or dependencies.

## Dependencies

* Prefer the .NET standard library.
* Only add NuGet packages when there is a clear benefit.
* Keep dependencies up to date and minimal.

## Changes

* Make the smallest change necessary to satisfy the request.
* Preserve existing behavior unless the task explicitly requires changing it.
* Do not modify unrelated files or code.
* Before adding a new class or abstraction, check whether the existing structure can support the change simply.

## Testing

* Build the project after making changes.
* Add or update tests when behavior is non-trivial or test infrastructure already exists.
* Ensure the application has no compiler warnings introduced by the change.
