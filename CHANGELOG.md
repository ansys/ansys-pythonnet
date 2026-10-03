# Changelog

This changelog documents changes specific to ansys-pythonnet which is a fork of pythonnet.

For changes inherited from the upstream Python.NET project, see the
[Python.NET changelog](https://github.com/pythonnet/pythonnet/blob/master/CHANGELOG.md).

This project follows [Semantic Versioning](https://semver.org/) and
[Keep a Changelog](https://keepachangelog.com/).

## Unreleased

### Added
- Merged upstream changes from Python.NET release 3.2.0

## 3.1.0-rc6 - 2025-01-15

### Added

- Added a runtime option to expose C# explicit interface implementations to Python ([#23](https://github.com/ansys/ansys-pythonnet/pull/23)).
- Added an option to bind PEP 8 aliases ([#24](https://github.com/ansys/ansys-pythonnet/pull/24)).

## 3.1.0-rc4 - 2024-10-23

### Changed

- Reverted the default wrapping of returned objects in their declared interface type introduced by upstream Python.NET [#1240](https://github.com/pythonnet/pythonnet/pull/1240).
- Made explicit interface wrapping opt-in through `ToPythonAs<T>` ([#19](https://github.com/ansys/ansys-pythonnet/pull/19)).
