## Async Data
This sample demonstrates one possible approach of handling async data. Being visual elements, the series' ItemsSources must only be altered on the UI thread. You can take advantage of the DispatchedViewModelBase class as demonstrated. It uses a UIActionDispatcher, which dispatches async actions on the UI thread and ensures that there is always a free frame, so that the UI will never freeze, no matter how busy the chart gets. Alternatively, if you cannot change the view model, you can use the custom DispatchedObservableCollection.

[//]: <keywords: lineseries, bitmaprenderoptions, live, update, uithread, dispatchertimer>