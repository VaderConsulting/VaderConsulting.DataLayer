# VaderConsulting.DataLayer

C# .NET 4.0 class library: IDataLayer contract, DataLayer base with ObjectChanges audit fields, and Announcement events. `IDataLayer.GetBusinessApplications` returns `List<BusinessApplication>` from the sibling `VaderConsulting.Dependency` project; the base `DataLayer` implementation returns an empty list. `DataLayer` stores `VaderConsulting.Helper.Attribute` items, raises `AnnouncementHandler` when one is added, and comments show intended consumption from `VaderConsulting.Orbus.iServer`. Nested `ObjectChanges` keeps SQL-precision timestamps as strings plus created/modified user IDs for object history.

**Source last updated:** 2015-09-29 · **Language:** C# · **Target:** .NET Framework 4.0 · **Output:** class library (`Library`)

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `VaderConsulting.DataLayer` | C# | class library (`net40`) | `IDataLayer` plus `DataLayer` base (`ObjectChanges` audit DTO, attribute list, announcement events). |

## How to open

Open `VaderConsulting.DataLayer.csproj` in Visual Studio 2013 or later (ToolsVersion 12.0). There is no `.sln` in this folder. The project references sibling folders `..\DependencyCollection\VaderConsulting.Dependency.csproj` and `..\VaderConsulting.Helper\VaderConsulting.Helper.csproj`.

## Requirements

- Visual Studio 2013 or later, .NET Framework 4.0

## Attribution and provenance

Working copy from Dave Robinson's OneDrive Historical Dev folder `VaderConsulting.DataLayer`. Assembly title/product `DataLayer`; copyright `Copyright ©  2015`; company empty. Namespace `VaderConsulting.DataLayer`. `packages.config` lists AsyncBridge 0.1.1 (referenced by the `.csproj`). `App.config` has leftover Entity Framework 6 LocalDB section, not referenced by the project.

## License

MIT © 2026 VaderConsulting. See `LICENSE`.
