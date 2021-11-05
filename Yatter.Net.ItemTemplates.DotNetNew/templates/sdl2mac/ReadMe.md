# Yatter Development using SDL2.WASM

## Introduction

- This solution is a default SDL2 starter project for MacOS that has empty `include` and `lib` directories, but which directories are easily hydrated with SDL2 artefacts by starting with the command `brew install sdl2 --verbose` and following the instructions below.
- This solution is made available in the `Yatter.Net.ItemTemplates.DotNetNew` new templates Nuget package to facilitate creating WASM that can be included in `.yatr` files in Base64.

This template is in it's infancy however is going to be developed further along a track where the ultimate object is to convert SDL2 programs into WASM for inclusion in Yatter Pages in a format similar to:

```
    {
      "DataType": "y@Wasm",
      "Base64": "AGFzbQEAAAABBAFgAAADAwIAAAQFAXABAQEFAwEAFwZBCn8BQZD62wALfwBBkAgLfwBBgAgLfwBBhAgLfwBBgAgLfwBBkPrXAAt/AEGACAt/AEGQ+tsAC38AQQALfwBBAQsHlgEMBm1lbW9yeQIAEV9fd2FzbV9jYWxsX2N0b3JzAAACZ28AAQZCVUZGRVIDAQVXSURUSAMCBkhFSUdIVAMDDF9fZHNvX2hhbmRsZQMECl9fZGF0YV9lbmQDBQ1fX2dsb2JhbF9iYXNlAwYLX19oZWFwX2Jhc2UDBw1fX21lbW9yeV9iYXNlAwgMX190YWJsZV9iYXNlAwkKYQICAAtcAQR/QQAhAEGQiICAACEBA0AgASECQQAhAwNAIAJBqoGAeEGqgXwgA0GsAkkbNgIAIAJBBGohAiADQQFqIgNB2ARHDQALIAFB4BJqIQEgAEEBaiIAQdgERw0ACwsLDwEAQYAICwhYAgAAWAIAAAAfBG5hbWUBGAIAEV9fd2FzbV9jYWxsX2N0b3JzAQJnbwB2CXByb2R1Y2VycwEMcHJvY2Vzc2VkLWJ5AQVjbGFuZ1YxMS4wLjAgKGh0dHBzOi8vZ2l0aHViLmNvbS9sbHZtL2xsdm0tcHJvamVjdCAxNzYyNDliZDY3MzJhODA0NGQ0NTcwOTJlZDkzMjc2ODcyNGE2ZjA2KQ==",
      "InlinePrefix": "data:application/wasm;base64,",
      "Visibility": "visible",
      "HeightWidthRatio": 0.75
    }
```

_N.B. If the HeightWidthRatio is 0, fullscreen is implied, otherwise the HeightWidthRatio will be used to define a WASM screen height that will be based upon the .yatr page screen width._

Although this DataType is not yet included as a ListItem in the public release of Yatter.UI.ListBuilder, the Yatter.UI.ListBuilder.ListItems.Wasm DataType will be supported by an interface that will allow it to access various mobile and desktop resources, such as the Camera, Microphone, and Storage.

## SDL2 Quickstart

### Install SDL2 include and lib artefacts into the `include` and `lib` folders in this project, as follows:

Do the following, so that the empty `include` and `lib` directories in this project, contain all the SDL2 files that it needs:

- Run the following command `brew install sdl2 --verbose` and notice the installation directory, for us it was `/opt/homebrew/Cellar/sdl2/2.0.16`
  - if you already have it installed, the easiest way of finding the installation directory, is perhaps `brew reinstall sdl2 --verbose`
- There should be a folder called `SDL2` in the root of `<installation directory>/include`, copy the SDL2 folder and it's contents, into the include directory in this project.
  - for us this was `/opt/homebrew/Cellar/sdl2/2.0.16/include` so we copied `/opt/homebrew/Cellar/sdl2/2.0.16/include/SDL2` and it's contents, into the `include` directory in this project, so that the paths in this directory look like `include/SDL2/SDL2_<*>.h` and `include/SDL2/<*>.h`.
- Now look for the `<installation directory>/lib` directory, for us it was `/opt/homebrew/Cellar/sdl2/2.0.16/lib` and copy the contents of that `lib` directory into the `lib` folder in this project.
  - Once we had done this, the paths in this directory looked like `lib/libSDL2<*>.a`, `lib/libSDL2<*>.dylib`, and a couple of folders.
- That's it!

### To compile

- `make project`

### To Run

- `./project`

### Wikis

- Old Wiki
  - https://web.archive.org/web/20210210110800/https://wiki.libsdl.org/
- New Wiki
  - https://wiki.libsdl.org/

### Videos

These are just random videos that we don't want to lose!

- Compile C into Web Assembly: https://www.youtube.com/watch?v=_pHgILVlx3c
- Drawing To a Canvas With Webassembly (Without Emscripten): https://www.youtube.com/watch?v=9lxnm9a-Yi8

y@R and You-At-A-Resource are trademarks of Count Anthony Harrison, operating from the United Kingdom
