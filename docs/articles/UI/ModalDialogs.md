---
uid: ModalDialogs
---
# Modal Dialogs

The DialogManager manages multiple modal dialogs for the default shell. You can show MessageBoxes or custom views.

````cs
public interface IDialogManager
{
    void ShowDialog(IScreen dialogViewModel);
    Task ShowDialogAsync<T>(T dialogViewModel);
    void ShowDialog(IScreen dialogViewModel, Action<IScreen> callback);

    void ShowMessageBox(string message, string title, MessageBoxOptions options, MessageBoxImage image);
    Task<MessageBoxOptions> ShowMessageBoxAsync(string message, string title, MessageBoxOptions options, MessageBoxImage image);
    void ShowMessageBox(string message, string title, MessageBoxOptions options, MessageBoxImage image, Action<IMessageBox> callback);

    Task ShowMessageBoxAsync(string message, string title);
    void ShowMessageBox(string message, string title);
    void ShowMessageBox(string message, string title, Action<IMessageBox> callback);
}
````

Every ClientModule container has a default implementation of the manager. Just inject it.

## MessageBoxes

````cs
DialogManager.ShowMessageBox("This is my TestMessage", "This is my Title", Callback);
````

## Custom Modal Dialogs

````cs
DialogManager.ShowDialog(new DefaultAboutViewModel());
````

### Sample

![Sample DialogBox](images/dialogBox.png)
