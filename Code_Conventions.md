# Fall of Blackmoor - Code Convention

## Project Structure

- `Program.cs` - Startpunt van de applicatie.
- `Core/` - Algemene game-logica.
- `Scenes/` - Scenes en locaties van de game.
- `Services/` - Opslaan en laden van gegevens.
- `Docs/` - Projectdocumentatie.

## Naming

- Classes en methods gebruiken **PascalCase**.
  - `SaveGame()`
  - `ShowInventory()`
  - `CastleGate()`

- Variabelen gebruiken **camelCase**.
  - `choice`
  - `currentScene`

- Namen moeten duidelijk beschrijven wat de code doet.

## Formatting

- Code binnen methods, `if` en `else` wordt netjes ingesprongen.
- Accolades staan op een nieuwe regel.
- Elke scene staat in een aparte method.
- Comments worden alleen gebruikt als extra uitleg nodig is.

## Language

Code, variabelen en method-namen worden zoveel mogelijk in het Engels geschreven.
