## Alpha Alert!

It's a winding road to Camelot so please read the [YatterOfficial](https://github.com/yatterofficial) Overview and Raison d'être.

y@R and You-At-A-Resource are trademarks of Count Anthony Harrison, operating from the United Kingdom

Copyright © 2021

# Yatter.Net.ItemTemplates.DotNetNew

<a href="https://www.nuget.org/packages/Yatter.Net.ItemTemplates.DotNetNew/" target="_blank" rel="noreferrer noopener"><img alt="Nuget" src="https://img.shields.io/nuget/v/Yatter.Net.ItemTemplates.DotNetNew?color=blue&style=for-the-badge"></a>

![GitHub](https://img.shields.io/github/license/yatterofficial/Yatter.Net.ItemTemplates.DotNetNew?style=for-the-badge)

[![Yatter.UI.ListBuilder on fuget.org](https://www.fuget.org/packages/Yatter.Net.ItemTemplates.DotNetNew/badge.svg)](https://www.fuget.org/packages/Yatter.Net.ItemTemplates.DotNetNew)

## Installation

- ```dotnet new --install Yatter.Net.ItemTemplates.DotNetNew```

or by version number, e.g:

- ```dotnet new --install Yatter.Net.ItemTemplates.DotNetNew::0.0.2 ```

## Usage

List them by looking for ```yatter-```[name] in the results:

- ```dotnet new --list```

and for each of them add ```-h``` to the end to discover the syntax, e.g:

- ```dotnet new yatter-microsite -h```

which gives the following example output:_

```
username% dotnet new yatter-microsite -h
Yatter Default Microsite (YON)
Author: Anthony Harrison
Description: A default Yatter Microsite consisting of index, about, and contact, .yatr pages, using Yatter Object Notation (YON)
Options:                                                               
  -U|--Username              Renames yatter username                   
                             string - Required                         
                             Default: My Username                      

  -Y|--YouTubeVideoWatchUrl  Renames YouYube video's 'Watch Url'       
                             string - Required                         
                             Default: e-ORhEE9VVg                      

  -S|--Slogan                Renames Index page slogan                 
                             string - Required                         
                             Default: We host, you boast!              

  -M|--MissionStatement      Renames brief Mission Statement           
                             string - Required                         
                             Default: In for a win!                    

  -C|--CopyrightNotice       Renames brief Copyright notice            
                             string - Required                         
                             Default: Copyright (C) MMXXI              

  -A|--AboutUsStatement      Renames brief About Us statement          
                             string - Required                         
                             Default: We do stuff!!!                   

  -Co|--ContactName          Renames contact's Name                    
                             string - Required                         
                             Default: Mr John Doe                      

  -p:C|--ContactEmail        Renames contact's email address           
                             string - Required                         
                             Default: john.doe@doe.com                 

  -p:Co|--ContactPhone       Renames contact's phone number            
                             string - Required                         
                             Default: ++44123456789                    
```

## Update

- ```dotnet new --update-check```

- ```dotnet new --update-apply```

## Uninstall

- ```dotnet new --uninstall Yatter.Net.ItemTemplates.DotNetNew```

or by seeking the command by running

- ```dotnet new --uninstall``` and following the prompts

## Overview

```dotnet new <name>``` templates for Yatter content creation, as follows:

```
Yatter Default Microsite                      yatter-microsite         YON         Common/Code/Yatter/Yatter Object Notation/YON      
Yatter Empty Yatter Page                      yatter-yatterpage-empty  YON         Common/Code/Yatter/Yatter Object Notation/YON      
Yatter TActor file                            yatter-tactor            [C#]        Common/Code/Yatter/Invigoration/TActor             
Yatter TObject file                           yatter-tobject           [C#]        Common/Code/Yatter/Invigoration/TObject            
Yatter TResponse file                         yatter-tresponse         [C#]        Common/Code/Yatter/Invigoration/TResponse 
```

- **Yatter Default Microsite** creates three Yatter Pages, comprising a default Yatter Microsite, as follows:
  - index.yatr
  - about.yatr
  - contact.yatr
- **Yatter Empty Yatter Page** creates a single, empty, Yatter Page
- **Yatter TActor file** creates a single TActor C# file for Yatter's ```Invigoration Pattern```
- **Yatter TActor file** creates a single TObject C# file for Yatter's ```Invigoration Pattern```
- **Yatter TActor file** creates a single TResponse C# file for Yatter's ```Invigoration Pattern```

y@R and You-At-A-Resource are trademarks of Count Anthony Harrison, operating from the United Kingdom

Copyright © 2021
