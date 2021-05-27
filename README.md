## Quick Package Install

#### Using UnityPackageManager (for Unity 2019.3 or later)
Open the package manager window (menu: Window > Package Manager)<br/>
Select "Add package from git URL...", fill in the pop-up with the following link:<br/>
https://github.com/SoprachevAK/set-target-frame-rate.git<br/>

#### Using UnityPackageManager (for Unity 2019.1 or later)

Find the manifest.json file in the Packages folder of your project and edit it to look like this:
```js
{
  "dependencies": {
    "com.soprachevak.set-target-frame-rate": "https://github.com/SoprachevAK/set-target-frame-rate.git",
    ...
  },
}
```

<!-- DOC-START -->
<!-- 
Changes between 'DOC START' and 'DOC END' will not be lost on package update 
-->

## Usage
 Add SetTargetFrameRate prefab to scene and configurate FPS in inspector.

<!-- DOC-END -->

## Author

**Soprachev Andrei**


## Show your support

Give a ⭐️ if this project helped you!