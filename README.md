# ViewHandler
 ViewHandler is a .NET class library that provides a range of utility methods for working with user interface elements in desktop applications.


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
## Documentation of Methods
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### ChangeElementForeground
``ChangeElementForeground<T>(T element, Color color)``

Changes the foreground color of a single FrameworkElement object element to the specified color parameter, which is of type Color. If the element is of type Control, its Foreground property will be set to a new SolidColorBrush object with the specified color. This method has a generic type parameter T, which must be a subclass of FrameworkElement.

To call this method, use the following syntax : ``ViewHandler.ChangeElementForeground<FrameworkElement>(colorObject, elementObject);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### ChangeElementsForeground
``ChangeElementsForeground<T>(Color color, params T[] elements)``

Changes the foreground color of multiple FrameworkElement objects passed as parameters, using a params array of type T[]. For each element in the array, the method checks if it is of type Control, and if so, sets its Foreground property to a new SolidColorBrush with the specified color. This method has a generic type parameter T, which must be a subclass of FrameworkElement.

To call this method, use the following syntax : ``ViewHandler.ChangeElementsForeground<FrameworkElement>(colorObject, elementObject1, elementObject2, elementObject3);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### ChangeElementBackground
``ChangeElementBackground<T>(T element, Color color)``

Changes the background color of a single FrameworkElement object element to the specified color parameter, which is of type Color. If the element is of type Control, its Background property will be set to a new SolidColorBrush object with the specified color. This method has a generic type parameter T, which must be a subclass of FrameworkElement.

To call this method, use the following syntax :`` ViewHandler.ChangeElementBackground<FrameworkElement>(colorObject, elementObject);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
#### ChangeElementsBackground
``ChangeElementsBackground<T>(Color color, params T[] elements)``

Changes the background color of multiple FrameworkElement objects passed as parameters, using a params array of type T[]. For each element in the array, the method checks if it is of type Control, and if so, sets its Background property to a new SolidColorBrush with the specified color. This method has a generic type parameter T, which must be a subclass of FrameworkElement.

To call this method, use the following syntax : ``ViewHandler.ChangeElementsBackground<FrameworkElement>(colorObject, elementObject1, elementObject2, elementObject3);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### OpenNewWindow
``OpenNewWindow(Type window)`` 

Creates and shows a new Window object of the specified Type parameter, which must be a subclass of the Window class. The method checks if the Type parameter is a subclass of Window using the IsSubclassOf method. If not, an ArgumentException is thrown. The method uses reflection to create an instance of the specified Type parameter at runtime, and then shows the new window using its Show method.

To call this method, use the following syntax : ``ViewHandler.OpenNewWindow(typeof(WindowClass));``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### CloseWindow
``CloseWindow(Window window)``

Closes the specified Window object by calling its Close method.

To call this method, use the following syntax : ``ViewHandler.CloseWindow(windowObject);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### DisableElements
``DisableElements<T>(params T[] elements)``

Disables a set of UI elements passed as parameters. This method will set the IsEnabled property of each element to false.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### EnableElements
``EnableElements<T>(params T[] elements)``

Enables a set of UI elements passed as parameters. This method will set the IsEnabled property of each element to true

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### CollapseElements
``CollapseElements<T>(params T[] elements)``

Collapses a set of UI elements passed as parameters. This method will set the Visibility property of each element to Visibility.Collapsed.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### ShowElements
``ShowElements<T>(params T[] elements)``

Shows a set of UI elements passed as parameters. This method will set the Visibility property of each element to Visibility.Visible.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### SetElementsFontSize

``SetElementsFontSize<T>(int newFontSize, params T[] elements)``

Sets the font size of a set of UI elements passed as parameters. This method will set the FontSize property of each element to the specified size.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### AreTextBoxesEmptyOrNull
``AreTextBoxesEmptyOrNull(params TextBox[] textBoxes)``

Checks whether a set of TextBox controls passed as parameters are empty or null. This method returns a Boolean value indicating whether all TextBox controls are either empty or null.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### LoadObjectsToComboBox
``LoadObjectsToComboBox<T>(ComboBox cbo, List<T> list)``

This method loads a ``List`` of objects into a ``ComboBox`` control. Each object in the list is converted to a string using its ``ToString()`` method and added to the ``ComboBox``'s ``Items`` collection.

##### Parameters:
``cbo``: The ``ComboBox`` control to load the objects into.
``list``: The ``List`` of objects to load into the ``ComboBox``.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### SetComboBoxPreviewItem
``SetComboBoxPreviewItem(ComboBox cbo, string textItem)``

This method sets an initial preview item to be displayed in a ``ComboBox`` control. The preview item is a non-selectable item that is displayed in the ``ComboBox`` when it is empty.

##### Parameters:
``cbo``: The ``ComboBox`` control to set the preview item for.
``textItem``: The text to display in the preview item.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### UpdateListView
``UpdateListView<T>(ListView lv, IEnumerable<T> collection)``

This method clears a ``ListView`` control and then iterates over an ``IEnumerable`` collection of objects, converting each object to a string using its ``ToString()`` method and adding it to the ListView's Items collection.

##### Parameters:
lv: The ``ListView`` control to update.
collection: An ``IEnumerable`` collection of objects to add to the ``ListView``.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### ParseStringToEnum
``ParseStringToEnum<T>(string stringToParse)``

This method takes a string and tries to parse it into an enumeration value of a specific ``Enum`` type. If the parsing succeeds, the method returns the resulting ``Enum`` value. If the parsing fails, the method throws an ``ArgumentException``.

##### Parameters:
``stringToParse``: The string to parse into an ``Enum`` value.
##### Returns:
The ``Enum`` value corresponding to the parsed string.

##### Exceptions:
``ArgumentException``: If the ``T`` type parameter is not an ``Enum`` type or if the parsing fails.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### GetEnumList
``GetEnumList<T>()``

This method returns a ``List`` of all possible values for the specified enum type. If ``T`` is not an enum type, an ``ArgumentException`` is thrown.
This method converts the contents of an enumeration type ``T`` to a ``List`` of ``T`` values.

##### Type Parameters:
T: The ``Enum`` type to convert to a list.
##### Returns:
A ``List`` of ``T`` values representing the contents of the enumeration type ``T``.


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### CreateListViewItem
``CreateListViewItem(Object obj, string objContent)``

The CreateListViewItem method takes an object and a string and creates a ListViewItem object with the Tag property set to the object and the Content property set to the string. This method is useful when creating ListView items that need to have an object associated with them, such as when building a list of selectable items in a UI.

##### Parameters:
obj: The object to set as the Tag property of the ListViewItem. This object can be any type of object.
objContent: The string to be as the Content property of the ListViewItem. This string can be any valid string.


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### AddLvItemToListView
``AddLvItemToListView(ListViewItem lvItem, ListView listView)``

The AddLvItemToListView method takes a ListViewItem and adds it to a ListView. This method is useful when you need to programmatically add items to a ListView at runtime.

##### Parameters:
lvItem: The ListViewItem to add to the ListView. This parameter should not be null.
listView: The ListView to which the ListViewItem will be added. This parameter should not be null.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

#### GetListFromListViewTags
`` GetListFromListViewTags<T>(ListView listView)``

Takes a ListView item and tries to convert all items with a Tag property that matches with the specified Type to a list. If the object is not of the specified type it is not converted.

##### Parameters:
listView: The ListView to retrieve items from.
##### Type Parameters
T: The type to search for in the ListView items.
##### Returns
A List<T> containing all the ListViewItem.Tag values that match the specified Type.



-----------------------------------------------------------------------------------------------------------------------------------------------------------------------


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
