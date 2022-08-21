# What's new in version 1.1

Summary of changes in Code Coverage package version 1.1.

The main updates in this release include:

## Added

- Added `Code Coverage session Events` [API](https://docs.unity3d.com/Packages/com.unity.testtools.codecoverage@1.1/api/UnityEditor.TestTools.CodeCoverage.Events.html) to subscribe to events invoked during a Code Coverage session.
- Added `useProjectSettings` in *-coverageOptions* for [batchmode](https://docs.unity3d.com/Packages/com.unity.testtools.codecoverage@1.1/manual/CoverageBatchmode.html) which allows using the settings specified in `ProjectSettings/Settings.json`.
- Added `pathStrippingPatterns` in *-coverageOptions* for [batchmode](https://docs.unity3d.com/Packages/com.unity.testtools.codecoverage@1.1/manual/CoverageBatchmode.html) which allows stripping specific sections from the paths that are stored in the coverage results xml files.
- Added `sourcePaths` in *-coverageOptions* for [batchmode](https://docs.unity3d.com/Packages/com.unity.testtools.codecoverage@1.1/manual/CoverageBatchmode.html) which allows specifying the source directories which contain the corresponding source code.
- Added support for [ExcludeFromCoverage/ExcludeFromCodeCoverage](https://docs.unity3d.com/Packages/com.unity.testtools.codecoverage@1.0/manual/UsingCodeCoverage.html#excluding-code-from-code-coverage) for lambda expressions and yield statements (case [1338636](https://issuetracker.unity3d.com/issues/code-coverage-excludefromcoverage-attribute-doesnt-exclude-lambda-expressions-and-yield-statements-from-coverage))
- Added support for [ExcludeFromCodeCoverage](https://docs.unity3d.com/Packages/com.unity.testtools.codecoverage@1.0/manual/UsingCodeCoverage.html#excluding-code-from-code-coverage) for getter/setter properties (case [1338665](https://issuetracker.unity3d.com/issues/code-coverage-get-and-set-accessors-are-still-marked-as-coverable-when-property-has-excludefromcodecoverage-attribute))


For a full list of changes and updates in this version, see the [Code Coverage package changelog](../changelog/CHANGELOG.html).
