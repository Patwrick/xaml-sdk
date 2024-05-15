## Numeric Indicator Size
To manipulate the indicator's size, simply use the ScaleObject.RelativeHeight and ScaleObject.RelativeWidth attachable properties. As the names suggest, their value are relative to the cell size of the scale. The cell size of the scale is determined by the size of the container it is placed in. For the radial scales it is equal to the radius of the container. However, when placed inside a LinearScale or inside a NumericScale, then the ScaleObject.RelativeHeight value is relative to the height and the ScaleObject.RelativeWidth to the width of the scale's container.

[//]: <keywords: numericscale, numericindicator, fontnumberposition, cornerradius, scaleobject, relativewidth, relativeheight>
