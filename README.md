NHtmlUnit
=========

|                        | **Status**                |
| ---------------------: | :------------------------ |
|             **GitHub** | [![GitHub release][1]][2] |
|              **NuGet** | [![NuGet][3]][4]          |
|     **Travis** (Linux) | [![Master][5]][6]         |
| **AppVeyor** (Windows) | [![Master][7]][8]         |


NHtmlUnit is a .NET wrapper of [HtmlUnit](http://htmlunit.sourceforge.net/);
a "GUI-less browser for Java programs".

Introduction
----------

We really like the HtmlUnit project, which enables headless web testing without needing
to have a complete browser running. By using [IKVM](http://www.ikvm.net/) it is possible
to convert the HtmlUnit Java library for use on Microsoft's .NET platform.

However, it doesn't feel very natural to use a Java library in a .NET language,
and therefore we created an HtmlUnit wrapper written in C#, so you can write tests for
your web pages in clean C# code (or any code running on the .NET platform).

Downloading NHtmlUnit
---------------------

The recommended way to [download NHtmlUnit](https://nuget.org/packages/NHtmlUnit) is
through its NuGet package. If you want to build it yourself, read the next section.

Building NHtmlUnit
------------------

If you want to build your own version of NHtmlUnit, you can use MSBuild or Visual Studio
2010.

After building you can find `NHtmlUnit.dll` plus its dependencies here:

* `app\NHtmlUnit\bin\Debug`
* `app\NHtmlUnit\bin\Release`

Usage
-----

For now there is no manual or API reference written for NHtmlUnit. You can however use the
[HtmlUnit reference](http://htmlunit.sourceforge.net/gettingStarted.html), as this wrapper
almost completely reflects the original API.

The difference is that Java iterators, lists and collections are exposed as their
.NET-friendly counterparts (`IEnumerable`, `IList` and `ICollection`). In addition,
properties are "real" .NET properties, so `obj.getSomething()` and `obj.setSomething()` is
exposed as `obj.Something` with a public getter and setter.

NHtmlUnitGenerator
------------------

The `NHtmlUnitGenerator` executable only needs to be run when the HtmlUnit jar file has
changed. When `NHtmlUnitGenerator` is run it will overwrite all files in
`app\NHtmlUnit\Generated`.

Note that it doesn't do anything with the project files, so if classes are added or
removed from the origin HtmlUnit jar file this will not be synchronized. You have to
manually add new files to the project.

License
-------

NHtmlUnit is licensed under the Apache License Version 2.0, which is the same
license used for HtmlUnit.

Technical details
-----------------

NHtmlUnit has in large parts been auto-generated using the HtmlUnit jar file as input
to the excellent [IKVM](http://www.ikvm.net/) project. How it is generated can be seen
in the `Make.cmd` file located inside the `lib/NHtmlUnit` folder.

Although we consider NHtmlUnit itself to be of decent quality, the NHtmlUnitGenerator
is basically a large hack.

Future
------

A complete rewrite of the NHtmlUnitGenerator using [Mono.Cecil](http://www.mono-project.com/Cecil)
would be nice, although we're unsure exactly how much this would do for the final product.

Authours
--------

NHtmlUnit was written by @asbjornu and @beewarloc.

<!-- Footnote links: -->

[1]: https://img.shields.io/github/release/HtmlUnit/NHtmlUnit.svg
[2]: https://github.com/HtmlUnit/NHtmlUnit/releases/latest
[3]: https://img.shields.io/nuget/v/NHtmlUnit.svg
[4]: https://www.nuget.org/packages/NHtmlUnit
[5]: https://travis-ci.org/HtmlUnit/NHtmlUnit.svg?branch=master
[6]: https://travis-ci.org/HtmlUnit/NHtmlUnit
[7]: https://img.shields.io/appveyor/ci/HtmlUnit/NHtmlUnit/master.svg
[8]: https://ci.appveyor.com/project/HtmlUnit/NHtmlUnit/branch/master
