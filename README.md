# FUTDC Symlink Repro

## Description:

This repository is intended to reproduce the following [issue](https://github.com/dotnet/project-system/issues/9548).

Please review `Directory.Build.props` and `Directory.Build.targets`, as they contain the main logic that enables Visual Studio to work with symbolic links.

## Steps to Reproduce:
1. Start Visual Studio (it might be helpful to run it as an administrator to ensure that symlinks are created successfully).
1. Build the project, then open the bin folder and verify that the symlinks are present.
1. Make changes in the constructor of `ClassA` to simulate a modification without breaking the public API of the assembly.
1. Build the project again; you should see output similar to the content in `BuildLogWithIssue.txt`.

