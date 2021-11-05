# Yatter Development using SDL2.WASM

## Introduction

- This solution is a default SDL2 starter project for MacOS that has empty `include` and `lib` directories, but which directories are easily symlinked by following the instructions that are below.
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

### To Configure

See this video:

- https://www.youtube.com/watch?v=Dyz9O7s7B8w
- Please note that in the Makefile, we diverged by appending an additional value to make it work: `LIBRARY_PATHS = -Llib -L/opt/homebrew/lib`

### To compile

- `make`

### To Run

- `./build/debug/play`

### Wikis

- Old Wiki
  - https://web.archive.org/web/20210210110800/https://wiki.libsdl.org/
- New Wiki
  - https://wiki.libsdl.org/

### Videos

These are just random videos that we don't want to lose!

- How to Setup SDL2 and VSCode to Start Programming OpenGL on a Mac: https://www.youtube.com/watch?v=Dyz9O7s7B8w
- Compile C into Web Assembly: https://www.youtube.com/watch?v=_pHgILVlx3c
- Drawing To a Canvas With Webassembly (Without Emscripten): https://www.youtube.com/watch?v=9lxnm9a-Yi8

### Credits

We modified our initial 'Hello SDL2' template (which we are progressively building into a SDL2.WASM template) to closely reflect Julio Fausto's SDL2-Starter template at https://github.com/jcfausto/sdl2-starter - which was published under an MIT License - doing so because of his excellent SDL2 on MacOS setup video at [How to Setup SDL2 and VSCode to Start Programming OpenGL on a Mac](https://www.youtube.com/watch?v=Dyz9O7s7B8w).

y@R and You-At-A-Resource are trademarks of Count Anthony Harrison, operating from the United Kingdom
