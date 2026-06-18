# BoxRoom Helper

A companion utility for **BOXROOM** that helps manage your local game
cache and create custom entries.

> **Current Status:** Work in Progress

The Steam scraping page has been temporarily disabled while development
focuses on custom games and cache maintenance.

------------------------------------------------------------------------

# Features

## Custom Game Creator

Create non-Steam entries that appear inside BOXROOM.

You can specify:

-   Game Name
-   Short Description
-   About Game
-   Release Date
-   Developer
-   Publisher
-   Genre

The helper automatically:

-   Generates a unique custom AppID (starting at `900000000`)
-   Creates the required cache folder
-   Generates:
    -   `meta.json`
    -   `meta.helper.json`
-   Updates `owned_games.json`

Artwork can simply be copied into the generated folder as:

``` text
boxart.jpg
```

------------------------------------------------------------------------

## Rebuild Steam Library

If BOXROOM is missing metadata, this tool can rebuild it using your
existing Steam library.

The helper will:

-   Scan your Steam Library Cache
-   Find every Steam AppID
-   Create matching folders inside BOXROOM
-   Download metadata from Steam
-   Generate:
    -   `meta.json`
    -   `meta.helper.json`
-   Update `owned_games.json`

Existing metadata is never overwritten.

------------------------------------------------------------------------

## Restore Missing Box Art

Copies Steam's cached cover art into BOXROOM.

For every game it will:

-   Skip games that already have `boxart.jpg`
-   Search Steam's cache for `library_600x900.jpg`
-   Copy it into the BOXROOM cache

This is useful after reinstalling BOXROOM or rebuilding metadata.

------------------------------------------------------------------------

# Default Paths

### BOXROOM Cache

``` text
%LocalAppData%\..\LocalLow\NestedLoop\BOXROOM\steam_cache_v2
```

### Steam Library Cache

``` text
%ProgramFiles(x86)%\Steam\AppCache\LibraryCache
```

These locations are detected automatically but can be changed if needed.

------------------------------------------------------------------------

# Current Limitations

-   Steam AppID scraping page is currently disabled.
-   Custom games currently create metadata only.
-   Artwork for custom games must be added manually.
-   Screenshots are not yet supported for custom titles.

------------------------------------------------------------------------

# Planned Features

-   Steam AppID scraper
-   Automatic artwork download for custom games
-   Screenshot support
-   Import/export custom titles
-   Better metadata editor
-   Plugin support
-   Additional cache repair tools

------------------------------------------------------------------------

# Notes

This project is intended to complement BOXROOM by providing maintenance
and customization tools that are not currently built into the
application.

