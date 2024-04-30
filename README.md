# StreamDeck Tools Template for .NET8.0

This wrapper is designed to work with [StreamDeck-Tools](https://github.com/BarRaider/streamdeck-tools) in order to allow users to build their own plugins for StreamDeck in the C# language.

## Functionality

We are designing this wrapper with cross-platform development in mind. This way you will be able to develop on Windows, Mac, or Linux, and produce plugins for Windows and Mac. Currrently, plugins can only be developed on Windows due to a dependency in the StreamDeck-Tools wrapper. We are working with the developer in order to address this. Within our template, we provide [SkiaSharp](https://github.com/mono/SkiaSharp) as the graphics engine, such that any graphics you do need to produce with it, can be produced with this instead (and will work on Windows and Mac).

## Example

In this template, we will be providing fully working code for a stopwatch plugin that has functionality both on dials (the counter will be displayed on the screen above), and on keys. In doing so, we hope to showcase how to utilise the various functions within the plugin, and provide you with an example you can build yourself. Instructions on what you need to do will be provided in a Github Wiki.