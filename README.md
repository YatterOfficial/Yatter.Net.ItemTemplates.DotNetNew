## Alpha Alert!

It's a winding road to Camelot so please read the [YatterOfficial](https://github.com/yatterofficial) Overview and Raison d'être.

y@R and You-At-A-Resource are trademarks of Count Anthony Harrison, operating from the United Kingdom

Copyright © 2021

# Yatter.Net.ItemTemplates.DotNetNew

<a href="https://www.nuget.org/packages/Yatter.Net.ItemTemplates.DotNetNew/" target="_blank" rel="noreferrer noopener"><img alt="Nuget" src="https://img.shields.io/nuget/v/Yatter.Net.ItemTemplates.DotNetNew?color=blue&style=for-the-badge"></a>

![GitHub](https://img.shields.io/github/license/yatterofficial/Yatter.Net.ItemTemplates.DotNetNew?style=for-the-badge)

[![Yatter.Net.ItemTemplates.DotNetNew on fuget.org](https://www.fuget.org/packages/Yatter.Net.ItemTemplates.DotNetNew/badge.svg)](https://www.fuget.org/packages/Yatter.Net.ItemTemplates.DotNetNew)

## Overview

```dotnet new <name>``` templates for Yatter content creation, as follows:

```
Yatter Default Microsite                      yatter-microsite         [C#]        Web                                                
Yatter Empty Yatter Page                      yatter-yatterpage-empty  [C#]        Web/Misc                                           
Yatter SDL2 Template for MacOS                yatter-sdl2-mac          C++         WASM                                               
Yatter TActor file                            yatter-tactor            [C#]        Web/Misc                                           
Yatter TObject file                           yatter-tobject           [C#]        Web                                                
Yatter TResponse file                         yatter-tresponse         [C#]        Web  
```

_Why have we identified yatter-microsite and yatter-yatterpage-empty as C#, and not YON?_

Although the .yatr pages are YON - Yatter Object Notation, a subset of JSON - we are listing them as C# because of the C# tools that we are building around them.

For example, although going ```dotnet new yatter-microsite``` will yield three yatter pages, index.yatr, about.yatr, and contact.yatr, they are rendered in a C# project that can be loaded into Visual Studio, where tools can be embedded in the Console App (for example, to pack them for uploading), and the built-in terminal is readily available to run our (and third party's) dotnet tools.

- **Yatter Default Microsite** creates three Yatter Pages, comprising a default Yatter Microsite, as follows:
  - index.yatr
  - about.yatr
  - contact.yatr
- **Yatter Empty Yatter Page** creates a single, empty, Yatter Page
- **Yatter SDL2 Template for MacOS** creates an SDL2 C++ template project as a basis of creating y@Wasm items
- **Yatter TActor file** creates a single TActor C# file for Yatter's ```Invigoration Pattern```
- **Yatter TActor file** creates a single TObject C# file for Yatter's ```Invigoration Pattern```
- **Yatter TActor file** creates a single TResponse C# file for Yatter's ```Invigoration Pattern```


## Installation

- ```dotnet new --install Yatter.Net.ItemTemplates.DotNetNew```

or by version number, e.g:

- ```dotnet new --install Yatter.Net.ItemTemplates.DotNetNew::0.0.5```

## Usage

List them by looking for ```yatter-```[name] in the results:

- ```dotnet new --list```

and for each of them add ```-h``` to the end to discover the syntax, e.g:

- ```dotnet new yatter-microsite -h```

which gives the following example output:_

```
username% dotnet new yatter-microsite -h
Yatter Default Microsite (C#)
Author: Anthony Harrison
Description: A default Yatter Microsite consisting of index, about, and contact, .yatr pages, using Yatter Object Notation (YON)
Options:                                                               
  -F|--Filename              Renames YatterMicrosite.csproj file name  
                             string - Optional                         
                             Default: YatterMicrosite                  

  -U|--Username              Renames yatter username                   
                             string - Optional                         
                             Default: My Username                      

  -Y|--YouTubeVideoWatchUrl  Renames YouYube video's 'Watch Url'       
                             string - Optional                         
                             Default: e-ORhEE9VVg                      

  -S|--Slogan                Renames Index page slogan                 
                             string - Optional                         
                             Default: We host, you boast!              

  -M|--MissionStatement      Renames brief Mission Statement           
                             string - Optional                         
                             Default: In for a win!                    

  -C|--CopyrightNotice       Renames brief Copyright notice            
                             string - Optional                         
                             Default: Copyright (C) MMXXI              

  -A|--AboutUsStatement      Renames brief About Us statement          
                             string - Optional                         
                             Default: We do stuff!!!                   

  -Co|--ContactName          Renames contact's Name                    
                             string - Optional                         
                             Default: Mr John Doe                      

  -p:C|--ContactEmail        Renames contact's email address           
                             string - Optional                         
                             Default: john.doe@doe.com                 

  -p:Co|--ContactPhone       Renames contact's phone number            
                             string - Optional                         
                             Default: ++44123456789  
```

## Update

- ```dotnet new --update-check```

- ```dotnet new --update-apply```

## Uninstall

- ```dotnet new --uninstall Yatter.Net.ItemTemplates.DotNetNew```

or by seeking the command by running

- ```dotnet new --uninstall``` and following the prompts

y@R and You-At-A-Resource are trademarks of Count Anthony Harrison, operating from the United Kingdom

Copyright © 2021
