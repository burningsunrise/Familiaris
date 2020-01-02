# Monster Hunter World DB Lookup Discord Bot - dotnet core 2.0+

A dotnet core 2.0+ application used for discord that looks up the requested search string in a monster hunter world database and returns all the information available to the user in a discord channel. The bot accepts partial matches such as `bleed` for `Bleeding` and `luna` for `Lunastra`, different commands are available with the `!familiaris` command that will display how the bot works and what you can do with it.

## Basic Usage

If you wish to use this bot for your own you will need to add your own App.config file with a clientKey key with the value of your bots secret for discord.

```cs
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <appSettings>
        <add key="clientKey" value="YOURKEY" />
    </appSettings>
</configuration>
```

After this all you need to do is build/compile for your target system and let it run! (Don't forget to add your bot to your discord server)

## TODO

- [ ] Add all command models
- [ ] Better formatting for the text
- [ ] Need more test cases

If there are any questions, bugs, or feature requests please open an issue on gitlab/github! :dog:
