# Shapes Colliders

A collider library for [Freya Holmér's](https://twitter.com/FreyaHolmer) '[Shapes](https://acegikmo.com/shapes/)' vector drawing asset on the Unity [Asset Store](https://assetstore.unity.com/packages/tools/particles-effects/shapes-173167).  

>This is an updated version of https://github.com/smundell/ShapesColliders to handle things like endcaps, install via UPM, simplify user interaction, and handle the new shapes in the Shapes package.

Limitations
* 2D only
* Meters only

Supports the following shapes:
* Line:
* Polyline: 
* Disc: flexible and fixed vertex counts, no endcaps
* Triangle:
* Polygon:
* Quad:



----------

# Installing

> **Note**: install Shapes from the Asset Store **first**.

To import the addon, use one of the following methods:

### Via Package Manager:

Open the Unity Package Manager, and click the "+" button in the top-left corner :

![](https://imgur.com/v92tiFD.png)

and add the following url:

> https://github.com/RealityStop/ShapesColliders.git


(for more information, or if errors are encountered, see https://docs.unity3d.com/Manual/upm-ui-giturl.html)

Once it installs, you're good to go!



### Manual install:
Alternatively, open Packages/manifest.json and add this line under dependencies:

	"dev.shapes.colliders": "https://github.com/RealityStop/ShapesColliders.git"
	
(for more information, or if errors are encountered, see https://docs.unity3d.com/Manual/upm-ui-giturl.html)
	
Once it installs, you're good to go!


# Updating
To update, open Packages/manifest.json and remove the dev.shapes.colliders entry under `lock` in the end of the file.  Unity will then redownload the package.


