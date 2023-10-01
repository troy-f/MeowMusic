<p align="center">
  <!-- Build & Release -->
  <a href="https://github.com/Meowchestra/MeowMusic/actions/workflows/Build.yml">
    <img src="https://img.shields.io/github/actions/workflow/status/Meowchestra/MeowMusic/Build.yml?branch=no-remote&style=for-the-badge" alt="Build"/></a>
  <a href="https://github.com/Meowchestra/MeowMusic/releases">
    <img src="https://img.shields.io/github/v/tag/Meowchestra/MeowMusic?label=Release&logo=git&logoColor=ffffff&style=for-the-badge" alt="Release"/></a>
</p>

<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#about">About MeowMusic</a></li>
    <li><a href="#plugin">Whiskers</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
        <li><a href="#usage">Using Whiskers </a></li>
      </ul></li>
    <li><a href="#contributing">Contributing</a></li>
  </ol>
</details>

<section id="about">

# About MeowMusic
  <p> BardMusicPlayer is an automated music player for playing MIDI songs in FFXIV using the in-game bard performance mode. MeowMusic is a fork of BardMusicPlayer with fixes, improvements, and personal changes ahead of upstream -- with additional changes from various forks such as LightAmp.</p>
</section>

<section id="plugin">

# Whiskers
MeowMusic can be used with my custom <a href="https://github.com/Meowchestra/Whiskers">Whiskers</a> companion plugin for enhanced functionality.

<details>
<summary>Enhanced Features</summary>

    * Output lyrics.
    * Chat while performing.
    * Direct instrument open & close.
    * Direct ensemble ready / accept.
    * Improved note playing.
    * Set graphics toggle.
    * Mute sounds toggle.
    
    And much more!
</details>
</section>

<section id="prerequisites">

### Prerequisites

* Install <a href="https://www.finalfantasyxiv.com/" alt="Final Fantasy XIV">Final Fantasy XIV</a>
* Install <a href="https://github.com/goatcorp/FFXIVQuickLauncher#how-to-install-the-launcher" alt="XIVLauncher">XIVLauncher</a>
* Add the custom <a href="#installation" alt="repository">repository</a>
</section>

<section id="installation">

### Installation
* Copy the following repository link: <br>
  `https://raw.githubusercontent.com/Meowchestra/Whiskers/develop/data/pluginmaster.json` <br><br>
* Type `/xlsettings` in the game chat window to open the Dalamud Settings.
* Navigate to the "Experimental" tab.
  <br><br><a><img src="https://i.imgur.com/FDlwtbe.png" /></a><br><br>
* Paste the link copied into the available input box under "Custom Plugin Repositories".
* Ensure the box to the right of the link is checked.
  <br><br><a><img src="https://i.imgur.com/OyprlmR.png" height="180" /></a><br><br>
* Press the "Save changes & close" icon in the bottom right of the settings window.
* Navigate to the "All Plugins" tab inside the `/xlplugins` plugin browser and search for `Whiskers`.
* Click on "Whiskers" and select "Install".
* The companion plugin is now ready to be used.
</section>


<section id="usage">

### Using Whiskers
To enable all enhanced functionality, simply checkmark "Whiskers Compatibility" under Settings.
  <br><br><a><img src="https://i.imgur.com/ylf4TIW.png" alt="Settings"/></a><br>
</section>

<section id="contributing">

# Contributing
Contributions to MeowMusic are welcome - please feel free to submit a [pull request](https://github.com/Meowchestra/MeowMusic/pulls).
</section>
