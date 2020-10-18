# Tools for Windows Desktop [![Build status](https://ci.appveyor.com/api/projects/status/d3bn7jnje8rtts7v?svg=true)](https://ci.appveyor.com/project/tewarid/nettools) [![Codacy Badge](https://api.codacy.com/project/badge/Grade/9272afa7d6494d7fa5a885e8e02a2999)](https://www.codacy.com/app/tewarid/net-tools?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=tewarid/net-tools&amp;utm_campaign=Badge_Grade) [![Join the chat at https://gitter.im/tewarid-net-tools/Lobby](https://badges.gitter.im/tewarid-net-tools/Lobby.svg)](https://gitter.im/tewarid-net-tools/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

Tools written primarily for Windows Desktop using C# .NET.

## Install

An app containing all the tools is available from the Microsoft Store, for a small fee, at https://www.microsoft.com/store/productId/9NT0G542BWLG.

## Build from source

To build all the tools, clone this repository, open the solution file `Tools.sln` using Visual Studio 2019, and build.

To build from the command line, open Developer Command Prompt for Visual Studio 2019, change to the `net-tools` directory, and run

```bash
msbuild /t:Restore Tools.sln
msbuild Tools.sln
```

### Mono

A solution file is available for building some of the tools for Linux using [Mono](https://www.mono-project.com/download/stable/).

Use the msbuild version supplied by Mono to build

```bash
msbuild Tools.Mono.sln
```

### .NET Core

A solution file is available to build some of the tools for Windows using .NET Core

```powershell
dotnet build Tools.NetCore.sln
```

## AMQP 1.0 Client Tool

A minimal interactive AMQP 1.0 client based on the [AMQPNetLite](https://github.com/Azure/amqpnetlite) library.

## Azure EventHub Client Tool

An interactive EventHub client for Azure based on the official library [Microsoft.Azure.EventHubs](https://docs.microsoft.com/en-us/dotnet/api/microsoft.azure.eventhubs). Contributed by [Anderson Urbano](https://github.com/urbanoanderson).

## Bluetooth Serial Client Tool

Interactive client that may be used to open a Bluetooth serial socket, send, and receive data. Based on [Windows.Devices.Bluetooth](https://docs.microsoft.com/en-us/uwp/api/Windows.Devices.Bluetooth) UWP API.

## Bluetooth Serial Server Tool

Interactive Bluetooth serial listener/server based on [Windows.Devices.Bluetooth](https://docs.microsoft.com/en-us/uwp/api/Windows.Devices.Bluetooth) UWP API.

## Encoding Tool

Convert data or text to or from various formats such as Base64, and encoded HTML, XML, or URL.

## Firewall Tool

Add exceptions to Windows Firewall using native COM library `NetFwTypeLib`. Contributed by Bruno Silveira.

## Font Tool

A tool to play with fonts. 

## GitLab Tool

A tool to query projects and their milestones in GitLab.

## Git Tool

A wrapper around command line Git, that allows running multiple commands on several cloned repos at once. A command can reference all or part of the output of the previous command with `{{OUT:start,length}}` where `start` is zero-indexed. Several repos can be cloned from GitHub or GitLab at once. A customizable cheatsheet is available in [cheatsheet.md](GitTool/cheatsheet.md). Any line starting with `$ git ` is assumed to be a git command and displayed in the tool.

## Globalization Tool

A tool to view information on locales, unicode characters, and do some basic conversions such as converting to upper and lower case.

## HID Tool

An interactive client for USB HID devices based on [HidSharp](https://www.nuget.org/packages/HidSharp/).

## HTTP Request Tool

Interactive HTTP(S) client built using [System.Net.HttpWebRequest](https://msdn.microsoft.com/en-us/library/system.net.httpwebrequest.aspx).

## HTTP Listener Tool

HTTP(S) server built using [System.Net.HttpListener](https://msdn.microsoft.com/en-us/library/system.net.httplistener.aspx).

## ICMP Tool

Interactive client that uses raw sockets to send/receive ICMP messages. Requires administrative privilege.

## Kafka Client Tool

An interactive Kafka client based on the Confluent.Kafka library. The tool has been tested with [cloudkarafka](https://www.cloudkarafka.com/) and [Docker](https://tewarid.github.io/2019/06/07/developing-with-kafka-using-docker.html).

## MQTT Client Tool

Interactive MQTT client based on the [MQTTnet](https://github.com/chkr1011/MQTTnet) library.

## Notification Tool

A tool used to show a notification to be reminded of something such as blinking your eyes.

## Network Route Tool

Interactive client to add, view, and delete IP v4 routes on Windows. Requires PowerShell. Requires administrative privilege.

Alternatives: [NetRouteView](https://www.nirsoft.net/utils/network_route_view.html)

## Serial Tool

Interactive client that may be used to open a serial port, send, and receive data.

## Service Discovery Tool

Sends out mDNS queries for the specified network service. Based on Windows.Devices.Enumeration UWP API.

## SMTP Client Tool

An SMTP client.

## SMTP Server Tool

An SMTP server based on the [SmtpServer](https://www.nuget.org/packages/SmtpServer/) library that logs messages to a text box.

## Sniffer Tool

An elementary tool that sniffs IPv4 packets using raw sockets. Requires administrative privilege.

## TCP Client Tool

Interactive TCP/IP client that may be used to establish IPv4 TCP sessions, send, and receive data.

## TCP Listener Tool

Interactive TCP/IP client that may be used as a rudimentary listener/server.

## UDP Tool

Interactive UDP/IP client that may be used to establish IPv4 UDP sockets, send, and receive datagrams.

## WebSocket Tool

Interactive [WebSocket](https://msdn.microsoft.com/en-us/library/system.net.websockets.websocket.aspx) client that may be used to establish WebSocket sessions, send, and receive data. It is built with .NET's native implementation of WebSockets.

## WebSocket Server Tool

Interactive WebSocket server based on System.Net.HttpListener. Supports SSL.

## WMI Query Tool

A simple tool to query WMI classes and their properties.
