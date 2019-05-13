# AirdropManager - RocketMod4 Plugin

## Commands
* /airdrop - Calls in an airdrop
* /whenairdrop - Shows time left to next airdrop
* /setairdrop \<airdrop id\> - Saves you current position as airdrop target

## Configuration

```xml
<?xml version="1.0" encoding="utf-8"?>
<AirdropManagerConfiguration xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <UseDefaultSpawns>true</UseDefaultSpawns>
  <UseDefaultAirdrops>false</UseDefaultAirdrops>
  <AirdropMessage>{size=17}{color=magenta}{i}Airdrop{/i} is coming!{/color}{/size}</AirdropMessage>
  <AirdropMessageIcon>https://i.imgur.com/JCDmlqI.png</AirdropMessageIcon>
  <AirdropInterval>3600</AirdropInterval>
  <Airdrops>
    <Airdrop>
      <AirdropId>1005</AirdropId>
      <Items>
        <AirdropItem>
          <ItemId>363</ItemId>
          <Chance>10</Chance>
        </AirdropItem>
        <AirdropItem>
          <ItemId>17</ItemId>
          <Chance>20</Chance>
        </AirdropItem>
      </Items>
    </Airdrop>
  </Airdrops>
  <AirdropSpawns>
    <AirdropSpawn>
      <AirdropId>1005</AirdropId>
      <Position>
        <X>1</X>
        <Y>1</Y>
        <Z>1</Z>
      </Position>
    </AirdropSpawn>
  </AirdropSpawns>
  <BlacklistedAirdrops />
</AirdropManagerConfiguration>
```

## Translation

**RocketMod 4**
```xml
<?xml version="1.0" encoding="utf-8"?>
<Translations xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <Translation Id="Next_Airdrop" Value="Next airdrop will be in {0}" />
</Translations>
```