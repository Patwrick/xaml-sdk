##  Custom floating block properties dialog 
This example demonstrates how custom dialogs can be created and wired to work with the commands of the editor using MEF. The FloatingBlockProperties dialog is invoked from the context menu when clicking on an image and selecting the Text Wrapping -> More Layout Options option.
Note that all that is needed to have the commands of the editor use the custom dialog is to implement the respective interface and mark the class with the attribute [CustomFloatingBlockPropertiesDialog].

[//]: <keywords: replace, inherit, modify>