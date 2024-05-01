# StreamDeck Tools Template for .NET8.0

This wrapper is designed to work with [StreamDeck-Tools](https://github.com/BarRaider/streamdeck-tools) in order to allow users to build their own plugins for StreamDeck in the C# language.

## Functionality

We are designing this wrapper with cross-platform development in mind. This way you will be able to develop on Windows, Mac, or Linux, and produce plugins for Windows and Mac. Currrently, plugins can only be developed on Windows due to a dependency in the StreamDeck-Tools wrapper. We are working with the developer in order to address this. Within our template, we provide [SkiaSharp](https://github.com/mono/SkiaSharp) as the graphics engine, such that any graphics you do need to produce with it, can be produced with this instead (and will work on Windows and Mac).

## Example

In this template, we will be providing fully working code for a stopwatch plugin that has functionality both on dials (the counter will be displayed on the screen above), and on keys. In doing so, we hope to showcase how to utilise the various functions within the plugin, and provide you with an example you can build yourself. Instructions on what you need to do will be provided in a Github Wiki.

### Manifest help

When using the manifest, you will want to ensure the plugin action UUIDs are changed to match those in your plugin. You will also want to ensure your codepath is correct. Remember to do your plugins in the reverse URL category (e.g. "com.developer.csharptemplate" for the code path, which would be classed as a reverse-URL of "csharptemplate.developer.com"). Ensure your CodePathWin finishes with .exe (for example "com.developer.csharptemplate.exe") and your CodePathMac has no file suffix (so it's just the reverse-URL such as "com.developer.csharptemplate"). More details about the Manifest stuff will be provided in the Wiki and details can also be found on the [Elgato SDK](https://docs.elgato.com/sdk/plugins/manifest)