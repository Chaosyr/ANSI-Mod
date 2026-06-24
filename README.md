# ANSI Mod
This mod simply enables ANSI and UTF-8 for Windows Terminals e.g. the BepInEx Console, this relies on the Cecil.ANSI_Utils functionality.

This is released as Open-Source subject to the terms found within [SML-1.0.0](https://stoatgames.icu/license-repository/licenses/sml-1-0-0/#content)

## What does this do?

If not answered clear enough already, this enables Virtual Terminal Processing for Windows OS Terminals that don't have it enabled by default, for example, BepInEx. This mod also on runtime enables UTF8 for both Input and Output encoding.

This is ran during the Patchers phase meaning it runs prior to both MonoMod and Plugins. e.g. You don't need to depend on it in your code to use ANSI anymore you just need this package in your Thunderstore Dependencies and Cecil.ANSI_Utils in your NuGet.

## How do I utilize ANSI?

Our friends at the [Cecil Libraries Organization](https://stoatgames.icu/subsidiaries/cecil-libraries-organization/#header-container-subsite) made a library exactly for this purpose. It took Chaosyr's original code and turned it into something much more usable at larger scale. It may still have some subtle bugs, but it works a lot better than this mod ever did as a Library in usage.

While yes its **1** more dependency you need to keep track of, this mod in technicality is Optional. You don't need it to do ANSI unless your on Windows in a Terminal that doesn't natively support it.

[Cecil Libraries Organization](https://stoatgames.icu/subsidiaries/cecil-libraries-organization/#header-container-subsite) plans to put together a Dependency resolver, working with Thunderstore that way users don't need to install as many dependencies themselves, with direct to NuGet support. For more details you can contact them at `Contact&Support@stoatgames.icu` or via `Cecil.Libraries@gmail.com`.

If it helps Cecil.ANSI_Utils is automatically attached to this Mod because of the fact it depends on it for the test logo, so you don't even necessarily list the Cecil Libraries package on Thunderstore just this one. It's attached via dependency to the [Cecil Libraries Package](https://thunderstore.io/c/inscryption/p/Cecil_Libraries_Organization/Cecil_Libraries_Package/).

## Setup

## Installing the Package

### Manager
1. Open the Application, Navigate to the Game, Navigate to the Profile.
2. Press `Browse` or the Manager's equivalent
3. Install `Stoat_Games` - `ANSI Mod`.
4. When you launch ANSI Mod is now installed.

### Manual
1. Press `Download`
2. Extract the Zip to a new folder.
3. Take the files and folders under `BepInEx/patchers` of the zip and move them up a folder. 
4. Delete the `BepInEx` folder from the Extracted directory.
5. Now navigate to the location of your BepInEx install from your earlier setup for the API.
6. Navigate to `patchers` and add a folder entitled `Stoat_Games-ANSI_Mod`, if there's a previous version of ANSI Mod installed it should be fine, but I'd advise removing it to keep storage down.
7. Move the setup from steps `2-4` into the folder you created in step `7`.
8. Now if all went well you should see a new print message adjacent to the following near the top of your log, and it should be in color (A Neon Green):
   ```
   ┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐
   │                                                                                                                                                  │
   │          ┌─────┬─────┐   ┌         ┐   ┌─────────┐          ┌────────────┐   ┌         ┐   ┌───────────┐   ┌──────────┐   ┌─────┬─────┐          │
   │                │         │         │   │                    │                │         │   │           │   │                    │                │
   │                │         │         │   │                    │                │         │   │           │   │                    │                │
   │                │         │         │   │                    │                │         │   │           │   │                    │                │
   │                │         ├─────────┤   ├──────────          │       ┌────┐   ├─────────┤   │           │   └──────────┐         │                │
   │                │         │         │   │                    │            │   │         │   │           │              │         │                │
   │                │         │         │   │                    │            │   │         │   │           │              │         │                │
   │                │         │         │   │                    │            │   │         │   │           │              │         │                │
   │                └         └         ┘   └─────────┘          └────────────┘   └         ┘   └───────────┘   └──────────┘         └                │
   │                                                                                                                                                  │
   │                                ┌─────┬─────┐   ┌┐        ┐          ┌─────┬─────┐   ┌         ┐   ┌─────────┐                                    │
   │                                      │         │ ╎       │                │         │         │   │                                              │
   │                                      │         │  ╎      │                │         │         │   │                                              │
   │                                      │         │   ╎     │                │         │         │   │                                              │
   │                                      │         │    ╎    │                │         ├─────────┤   ├──────────                                    │
   │                                      │         │     ╎   │                │         │         │   │                                              │
   │                                      │         │      ╎  │                │         │         │   │                                              │
   │                                      │         │       ╎ │                │         │         │   │                                              │
   │                                └─────┴─────┘   └        └┘                └         └         ┘   └─────────┘                                    │
   │                                                                                                                                                  │
   │                                           ┌───────────┐   ┌───────────┐   ┌─────────┐     ┌─────────┐                                            │
   │                                           │               │           │   │          ╎    │                                                      │
   │                                           │               │           │   │           ╎   │                                                      │
   │                                           │               │     │     │   │     │      │  │                                                      │
   │                                           │               │    ─│─    │   │    ─│─     │  ├──────────                                            │
   │                                           │               │     │     │   │     │      │  │                                                      │
   │                                           │               │           │   │           ╎   │                                                      │
   │                                           │               │           │   │          ╎    │                                                      │
   │                                           └───────────┘   └───────────┘   └─────────┘     └─────────┘                                            │
   │                                                                                                                                                  │
   └──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘
   ```
   For those curious this originates from: https://github.com/Chaosyr/GhostInTheCodeLogo which was made for a Band called Ghost In The Code coming soon:tm:.

## How you can support our Projects and their Developers:

* You can donate to Chaosyr (The Primary Developer in this case) here:
    * Use code `Chaosyr` in Hytale Checkout, they will receive a portion of the Checkout proceeds.
    * Use their KO-FI and donate or commission: https://ko-fi.com/thincreator3483
* You can help Financially Support Stoat Games here:
    * Use our affiliate link with IONOS: https://aklam.io/thGxWQTD (This is the most powerful method for keeping The Docs site alive.)
    * Use our affiliate link with The Free Website Guys: https://thefreewebsiteguys.com/?js=a16638001b (Less powerful but it will support The Docs Site, and them)
    * When the Option opens you can choose US to host your Projects Docs or Your Organizations Subsite under [Stoat Games](https://stoatgames.icu)
* Contribute to our Projects
    * You can send Pull Requests to any of our Projects to help make them work better for future users.
    * You can submit Bug Reports so that we can help More Users have a better time with our Projects.
    * You can Translate our Project [Stoat Games](https://stoatgames.icu).
    * You can Contribute to the Project [Stoat Games](https://stoatgames.icu) by shooting us emails with Feedback and better code.

# LICENSED UNDER [SML-1.0.0](https://stoatgames.icu/license-repository/licenses/sml-1-0-0/#content)