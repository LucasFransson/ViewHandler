# ViewHandler
 ViewHandler is a .NET class library that provides a range of utility methods for working with user interface elements in desktop applications.


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
##Documentation of Methods
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

``ChangeElementForeground<T>(T element, Color color):``

Changes the foreground color of a single FrameworkElement object element to the specified color parameter, which is of type Color. If the element is of type Control, its Foreground property will be set to a new SolidColorBrush object with the specified color. This method has a generic type parameter T, which must be a subclass of FrameworkElement.

To call this method, use the following syntax : ``ViewHandler.ChangeElementForeground<FrameworkElement>(colorObject, elementObject);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

``ChangeElementsForeground<T>(Color color, params T[] elements): ``

Changes the foreground color of multiple FrameworkElement objects passed as parameters, using a params array of type T[]. For each element in the array, the method checks if it is of type Control, and if so, sets its Foreground property to a new SolidColorBrush with the specified color. This method has a generic type parameter T, which must be a subclass of FrameworkElement.

To call this method, use the following syntax : ``ViewHandler.ChangeElementsForeground<FrameworkElement>(colorObject, elementObject1, elementObject2, elementObject3);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
``ChangeElementBackground<T>(T element, Color color): ``

Changes the background color of a single FrameworkElement object element to the specified color parameter, which is of type Color. If the element is of type Control, its Background property will be set to a new SolidColorBrush object with the specified color. This method has a generic type parameter T, which must be a subclass of FrameworkElement.

To call this method, use the following syntax :`` ViewHandler.ChangeElementBackground<FrameworkElement>(colorObject, elementObject);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

``ChangeElementsBackground<T>(Color color, params T[] elements): ``

Changes the background color of multiple FrameworkElement objects passed as parameters, using a params array of type T[]. For each element in the array, the method checks if it is of type Control, and if so, sets its Background property to a new SolidColorBrush with the specified color. This method has a generic type parameter T, which must be a subclass of FrameworkElement.

To call this method, use the following syntax : ``ViewHandler.ChangeElementsBackground<FrameworkElement>(colorObject, elementObject1, elementObject2, elementObject3);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

OpenNewWindow(Type window): 

Creates and shows a new Window object of the specified Type parameter, which must be a subclass of the Window class. The method checks if the Type parameter is a subclass of Window using the IsSubclassOf method. If not, an ArgumentException is thrown. The method uses reflection to create an instance of the specified Type parameter at runtime, and then shows the new window using its Show method.

To call this method, use the following syntax : ``ViewHandler.OpenNewWindow(typeof(WindowClass));``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

CloseWindow(Window window): 

Closes the specified Window object by calling its Close method.

To call this method, use the following syntax : ``ViewHandler.CloseWindow(windowObject);``
