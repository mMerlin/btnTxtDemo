# dotnet webapp demonstration project

As part of an interview process, I was asked to create small web application, with quite general specifications.

> Make a small web application. It will have one page with a large text input, 1 button, and an output area. The user will put text into the input, click one of the buttons, and the application will transform the text in some way and display the result in the output area. The work can be done by the server or the client.
>
> Requirements<br />
> The application must run on .NET Framework or .NET Core. You can use any language.<br />
> You don't have to put it online anywhere, I want to compile and run it locally.<br />
> Send me the source code as a link to a git repository I can clone.

This repository is the result.

This `transformation` being done, is to URI encode the input text.  To keep that from becoming one huge, non-wrapping line in the output, a space is inserted after each encoded character.  The processing is being done by a simple javascript (jQuery based) function that is attached to the button when DOM is available during page loading.  No global variables are used.  Everything is done with closures.

Here is a sample string that could be pasted in to exercise the processing a bit: `µ¿‽<br/>°`

The general functionality (cookie checking, navigation bar, privacy page) generated just by creating the project were left alone.  I saw no need to remove or enhance that for the demo.  I *did* do a bit of tweaking with css, to help format the generic html.

My main home system is currently running Fedora 30 Workstation.  It can dual boot to Windows 10, but I do not have Visual Studio there either.  The demonstration protect was done with dotnet (core) and Visual Studio Code.
