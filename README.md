# Minecraft Modlist Loader
tl;dr Twitch modlist loader and converter to text or CSV.

## About
MCMLL is a simple utility to convert the Twitch modpack HTML file into individual mods and their authors in list view, ordered alphabetically. From there you have the option of exporting the list into comma-separated values, or new line separated values. You also have the option of encasing each item with quotes which I use to perform set comprehension in Python on them. Finally you can export the author list also, which is ordered based on the alphabetical ordered mod list.

## Use case
In short, MCMLL was created to break down the Twitch modpack list into the individual mods and their authors, export these values into a CSV file, and use the CSV values in Python to perform set comprehension on different modpacks.

## Changelog
v1.0.0
 - Initial release.