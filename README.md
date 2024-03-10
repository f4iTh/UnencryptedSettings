**Unencrypted Settings** is a [Cult of the Lamb](https://www.cultofthelamb.com/) mod that prevents the `settings.json` file being saved in encrypted format.

## Motivation

The main purpose of this mod was to figure out whether it is possible to rebind the `Accept` and `Cancel` buttons, as these are locked in the in-game settings.

As it turns out, by manually editing the (unencrypted) `settings.json` file to add custom keybindings that are not possible to do in-game, 
the game will still gladly count them as proper keybindings, making it is possible to swap the `Accept` and `Cancel` keybindings (and more).

## Custom keybindings

The following custom keybindings will swap most (if not all) in the following manner:

- All `A` button actions are swapped with the `B` button and vice versa
- All `X` button actions are swapped with the `Y` button and vice versa

```json
"GamepadBindings": [
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 1,
    "Action": 38,
    "ElementIdentifierID": 7
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 1,
    "Action": 39,
    "ElementIdentifierID": 6
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 2,
    "Action": 76,
    "ElementIdentifierID": 7
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 2,
    "Action": 85,
    "ElementIdentifierID": 7
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 2,
    "Action": 89,
    "ElementIdentifierID": 9
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 2,
    "Action": 91,
    "ElementIdentifierID": 8
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 2,
    "Action": 88,
    "ElementIdentifierID": 8
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 2,
    "Action": 80,
    "ElementIdentifierID": 9
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 2,
    "Action": 90,
    "ElementIdentifierID": 9
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 2,
    "Action": 75,
    "ElementIdentifierID": 8
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 0,
    "Action": 64,
    "ElementIdentifierID": 7
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 0,
    "Action": 2,
    "ElementIdentifierID": 9
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 0,
    "Action": 16,
    "ElementIdentifierID": 6
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 0,
    "Action": 13,
    "ElementIdentifierID": 8
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 0,
    "Action": 73,
    "ElementIdentifierID": 6
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 0,
    "Action": 69,
    "ElementIdentifierID": 7
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 0,
    "Action": 70,
    "ElementIdentifierID": 9
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 0,
    "Action": 59,
    "ElementIdentifierID": 8
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 0,
    "Action": 9,
    "ElementIdentifierID": 7
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 0,
    "Action": 68,
    "ElementIdentifierID": 9
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 0,
    "Action": 67,
    "ElementIdentifierID": 8
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 0,
    "Action": 66,
    "ElementIdentifierID": 6
  },
  {
    "KeyCode": 0,
    "ControllerType": 2,
    "AxisContribution": 0,
    "AxisRange": 1,
    "AxisType": 0,
    "Category": 0,
    "Action": 26,
    "ElementIdentifierID": 12
  }
],
```