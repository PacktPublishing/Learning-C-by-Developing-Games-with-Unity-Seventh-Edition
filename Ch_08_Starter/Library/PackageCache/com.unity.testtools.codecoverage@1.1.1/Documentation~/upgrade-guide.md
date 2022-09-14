# Upgrading to Code Coverage package version 1.1.0
To upgrade to Code Coverage package version 1.1.0, you need to do the following:
- [Update path filtering globbing rules](upgrade-guide.md#update-path-filtering-globbing-rules)

## Update path filtering globbing rules
- Update the path filtering globbing rules in your batchmode commands and code coverage window. To keep the current behaviour when using [globbing](https://en.wikipedia.org/wiki/Glob_%28programming%29) to match any number of folders, the `*` character should be replaced with `**`. A single `*` character can be used to specify a single folder layer.

Examples:  

`pathFilters:+C:/MyProject/Assets/Scripts/*` will include all files in the `C:/MyProject/Assets/Scripts` folder. Files in subfolders will not be included.  
`pathFilters:+C:/MyProject/Assets/Scripts/**` will include all files under the `C:/MyProject/Assets/Scripts` folder and any of its subfolders.

For a full list of changes and updates in this version, see the [Code Coverage package changelog](../changelog/CHANGELOG.html).
