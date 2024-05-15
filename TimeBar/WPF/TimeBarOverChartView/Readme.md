## Time Bar Over Chart View
The example demonstrates one possible approach for implementing a mixed functionality between TimeBar and ChartView. One way to achieve this goal is to set the chart to be the Content of the time bar, but this way the chart grows in size when zooming and the virtualization optimizations do not work.
This is why simply overlaying them and syncing the visible period is a much more preferred solution.

[//]: <keywords: radverticaldataaxis, databinding, lineseries, sliderstyle, chartview>