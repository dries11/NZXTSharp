# NZXTSharp Changelog

## 2.0.0-preview3
All KrakenX RGB effects are now implemented, but the breathing effect still has some intermittent issues.

No breaking changes known.

#### Details
 - DeviceLoader
   - Add IsInitialized Property
   - Add FilterDevices Method
   - Add operators
   - Add ToggleThrowExceptions Method
 - HuePlus
   - Add GetFirmwareVersion Method
 - KrakenX
   - Add FirmwareVersion Property
   - Some cleanup and refactoring
   - Update Dispose Method
 - Fix DCBWM Param Evaluation
 - Fix DCB Param Evaluation

## 2.0.0-preview2
DeviceLoader; The DeviceLoader provides a convenient interface for interacting with multiple NZXT devices at once.

The DeviceLoader can:
 - Apply RGB Effects
 - Set Pump/ Fan Speeds
to multiple NZXT devices with one line.

More XML docs have been added, the RTD page will be updated with the release of v2.0.0

## 2.0.0-preview1
Partial Kraken Support
 - Get Pump, Fan Speeds, Liquid Temp, Firmware Version
 - Set Pump, Fan Speeds
 - Some effects working, some partially working, some not implemented/ not working.

Major breaking changes because of a total refactor, docs will be updated with the release of v2.0.0

## 1.2
Added ability to create Fixed effect with custom RGB values for all LEDs. 
This feature offers great versatility for allowing users to create their own effects.

No breaking changes, docs will be updated soon.

## 1.1
All systems are working! This release is actually v1.0, but because of the way NuGet handles versions, it is 1.1.

This update includes full support for the Hue+ controller.

There are no breaking changes in this update.
New Things!
- Bug fixes 
- Input validation on more constructors
- The addition of XML docs to all methods, properties, constructors, and classes
- Little things here and there; cleanup, bits of refactoring, some performance improvements

## 1.0.3-beta
All effects are now working! Subdevices should also be working. 

- Breaking Changes - N/A

## 1.0.2-beta
- Breaking Changes
    - Renamed HexColor.cs to Color.cs

- New Features
    - Subdevices: Individually control fans, strips, and their individual leds! Documentation and getting started examples        
      coming soon.

- Behind the Scenes
    - Addition of COM system, will make it easier to add support for more devices.
    - Refactoring, moved some files around, cleanup.

Most effects still not working.