# ViewHandler
 ViewHandler is a .NET class library that provides a range of utility methods for working with user interface elements in desktop applications.


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
## Documentation of Methods
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### ChangeElementForeground
``ChangeElementForeground<T>(Color color,T element)``

Changes the ``Foreground`` color of a single ``FrameworkElement`` object element to the specified color parameter, which is of type ``Color``. If the element is of type ``Control``, its ``Foreground`` property will be set to a new ``SolidColorBrush`` object with the specified color. This method has a generic type parameter ``T``, which must be a subclass of ``FrameworkElement``.



Parameters:

`color`: The ``Color`` object to be used as the new color.

``element``: The ``FrameworkElement`` that will have its Foreground set to the new Color. 


To call this method, use the following syntax : ``ViewHandler.ChangeElementForeground<FrameworkElement>(colorObject, elementObject);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### ChangeElementsForeground
``ChangeElementsForeground<T>(Color color, params T[] elements)``

Changes the ``Foreground`` color of multiple ``FrameworkElement`` objects passed as parameters, using a ``params array`` of ``type T[]``. For each element in the array, the method checks if it is of type ``Control``, and if so, sets its ``Foreground`` property to a new ``SolidColorBrush`` with the specified color. This method has a generic type parameter ``T``, which must be a subclass of ``FrameworkElement``.


Parameters:

``color``: The ``Color`` object to be used as the new color.

``elements``: The ``FrameworkElement``s that will have their Foregrounds set to the new Color. 


To call this method, use the following syntax : ``ViewHandler.ChangeElementsForeground<FrameworkElement>(colorObject, elementObject1, elementObject2, elementObject3);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### ChangeElementBackground
``ChangeElementBackground<T>(T element, Color color)``

Changes the background color of a single ``FrameworkElement`` object element to the specified color parameter, which is of type ``Color``. If the element is of type ``Control``, its ``Background`` property will be set to a new ``SolidColorBrush`` object with the specified color. This method has a generic type parameter ``T``, which must be a subclass of ``FrameworkElement``.


Parameters:

``color``: The ``Color`` object to be used as the new color.

``element``: The ``FrameworkElement`` that will have its Background set to the new Color.


To call this method, use the following syntax :`` ViewHandler.ChangeElementBackground<FrameworkElement>(colorObject, elementObject);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
### ChangeElementsBackground
``ChangeElementsBackground<T>(Color color, params T[] elements)``

Changes the ``Background`` color of multiple ``FrameworkElement`` objects passed as parameters, using a ``params array`` of ``type T[]``. For each element in the array, the method checks if it is of type ``Control``, and if so, sets its ``Background`` property to a new ``SolidColorBrush`` with the specified color. This method has a generic type parameter ``T``, which must be a subclass of ``FrameworkElement``.


Parameters:

`color`: The `Color` object to be used as the new color.

``elements``: The ``FrameworkElement``s that will have their Backgrounds set to the new Color.


To call this method, use the following syntax : ``ViewHandler.ChangeElementsBackground<FrameworkElement>(colorObject, elementObject1, elementObject2, elementObject3);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### OpenNewWindow
``OpenNewWindow(Type window)`` 

Creates and shows a new ``Window`` object of the specified ``Type`` parameter, which must be a subclass of the ``Window`` class. The method checks if the ``Type`` parameter is a subclass of ``Window`` using the ``IsSubclassOf`` method. If not, an ``ArgumentException`` is thrown. The method uses reflection to create an instance of the specified ``Type`` parameter at runtime, and then shows the new window using its Show method.


Parameters:

``window``: The ``Type`` to open. 


To call this method, use the following syntax : ``ViewHandler.OpenNewWindow(typeof(MyWindowClass));``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### CloseWindow
``CloseWindow(Window window)``

Closes the specified ``Window`` object by calling its ``Close`` method.


Parameters:

``window``: The ``Window`` object to close. 


To call this method, use the following syntax : ``ViewHandler.CloseWindow(myWindowObject);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### DisableElements
``DisableElements<T>(params T[] elements)``

Disables a set of UI elements passed as parameters. This method will set the ``IsEnabled`` property of each element to ``false``.


Parameters:

``elements``: The ``FrameworkElement``s that will have their ``IsEnabled`` properties set to ``false``. 


To call this method, use the following syntax : ``ViewHandler.DisableElements<FrameworkElement>(myTextBox, myButton1, myButton2, myLabel, myLabel2);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### EnableElements
``EnableElements<T>(params T[] elements)``

Enables a set of UI elements passed as parameters. This method will set the ``IsEnabled`` property of each element to ``true``


Parameters:

``elements``: The ``FrameworkElement``s that will have their ``IsEnabled`` properties set to ``true``.


To call this method, use the following syntax : ``ViewHandler.EnableElements<FrameworkElement>(myTextBox, myButton1, myButton2, myLabel, myLabel2);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### CollapseElements
``CollapseElements<T>(params T[] elements)``

Collapses a set of UI elements passed as parameters. This method will set the ``Visibility`` property of each element to ``Visibility.Collapsed``.


Parameters:

``elements``: The ``FrameworkElement``s that will have their ``Visibility`` properties set to ``Visibility.Collapsed``. 


To call this method, use the following syntax : ``ViewHandler.CollapseElements<FrameworkElement>(myTextBox, myButton1, myButton2, myLabel, myLabel2);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### ShowElements
``ShowElements<T>(params T[] elements)``

Shows a set of UI elements passed as parameters. This method will set the ``Visibility`` property of each element to ``Visibility.Visible``.


Parameters:

``elements``: The ``FrameworkElement``s that will have their ``Visibility`` properties set to ``Visibility.Visible``. 


To call this method, use the following syntax : ``ViewHandler.ShowElements<FrameworkElement>(myButton1, myButton2, myLabel, myLabel2);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### SetElementsFontSize

``SetElementsFontSize<T>(int newFontSize, params T[] elements)``

Sets the font size of a set of UI elements passed as parameters. This method will set the ``FontSize`` property of each element to the specified size.


Parameters:

``newFontSize`` : An ``Integer`` that sets the new ``FontSize``.

``elements``: The ``FrameworkElement``s that will have their ``FontSize`` set to the new size.


To call this method, use the following syntax : ``ViewHandler.SetElementsFontSize<FrameworkElement>(44, myLabel1, myLabel2, myButton);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### AreTextBoxesEmptyOrNull
``AreTextBoxesEmptyOrNull(params TextBox[] textBoxes)``

Checks whether a set of ``TextBox`` controls passed as parameters are empty or ``null``. This method returns a ``Boolean`` value indicating whether all ``TextBox`` controls are either empty or ``null``.



Parameters:
``textBoxes``: The ``TextBox``es that will be checked if they are empty or ``null``. 


To call this method, use the following syntax : ``if (ViewHandler.AreTextBoxesEmptyOrNull(myTextBox1, myTextBox2, myTextBox3))``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### LoadObjectsToComboBox
``LoadObjectsToComboBox<T>(ComboBox cbo, List<T> list)``

This method loads a ``List`` of objects into a ``ComboBox`` control. Each object in the list is converted to a string using its ``ToString()`` method and added to the ``ComboBox``'s ``Items`` collection.


Parameters:

``cbo``: The ``ComboBox`` control to load the objects into.

``list``: The ``List`` of objects to load into the ``ComboBox``.


To call this method, use the following syntax : ``ViewHandler.LoadObjectsToComboBox(myComboBox, myList);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### SetComboBoxPreviewItem
``SetComboBoxPreviewItem(ComboBox cbo, string textItem)``

This method sets an initial preview item to be displayed in a ``ComboBox`` control. The preview item is a non-selectable item that is displayed in the ``ComboBox`` when it is empty.


Parameters:

``cbo``: The ``ComboBox`` control to set the preview item for.

``textItem``: The text to display in the preview item.


To call this method, use the following syntax : ``ViewHandler.SetComboboxPreviewItem(myComboBox, "--- Preview Item ---" );``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### UpdateListView
``UpdateListView<T>(ListView lv, IEnumerable<T> collection)``

This method clears a ``ListView`` control and then iterates over an ``IEnumerable`` collection of objects, converting each object to a ``string`` using its ``ToString()`` method and adding it to the ``ListView``'s Items collection.


Parameters:

``lv``: The ``ListView`` control to update.

``collection``: An ``IEnumerable`` collection of objects to add to the ListView.


To call this method, use the following syntax : ``ViewHandler.UpdateListView(myListView, myList);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### ParseStringToEnum
``ParseStringToEnum<T>(string stringToParse)``

This method takes a string and tries to parse it into an enumeration value of a specific ``Enum`` type. If the parsing succeeds, the method returns the resulting ``Enum`` value. If the parsing fails, the method throws an ``ArgumentException``.


Parameters:

``stringToParse``: The string to parse into an ``Enum`` value.

Returns:

The ``Enum`` value corresponding to the parsed string.

Exceptions:

``ArgumentException``: If the ``T`` type parameter is not an ``Enum`` type or if the parsing fails.


To call this method, use the following syntax : ``MyEnum myEnum = ViewHandler.ParseStringToEnum<MyEnum>(myComboBox.SelectedItem.ToString());``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### GetEnumList
``GetEnumList<T>()``

This method returns a ``List`` of all possible values for the specified enum type. If ``T`` is not an enum type, an ``ArgumentException`` is thrown.

This method converts the contents of an enumeration type ``T`` to a ``List`` of ``T`` values.


Type Parameters:

``T``: The ``Type`` of enum to convert to a list.

Returns:

A list of ``T`` values representing the contents of the enumeration type ``T``.


To call this method, use the following syntax : ``List<MyEnum> myEnumList = ViewHandler.GetEnumList<MyEnum>();``


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### CreateListViewItem
``CreateListViewItem(Object obj, string objContent)``

Takes an ``Object`` and a ``string`` and creates a ``ListViewItem`` with the ``Tag`` property set to the ``Object``, and the ``Content`` property set to the ``string``. This method is useful when creating ``ListViewitem`` that need to have an ``Object`` associated with them, such as when building a ``List`` of selectable items in a UI.


Parameters:

``obj``: The ``Object`` to set as the ``Tag`` property of the ``ListViewItem``. This object can be any type of object.

``objContent``: The ``string`` to be set as the ``Content`` property of the ``ListViewItem``. 


To call this method, use the following syntax : ``ListViewItem myListViewItem = ViewHandler.CreateListViewItem(myObject, "This string will be displayed");``


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### AddLvItemToListView
``AddLvItemToListView(ListViewItem lvItem, ListView listView)``

Takes a ``ListViewItem`` and adds it to a ``ListView``. This method is useful when you need to programmatically add items to a ListView at runtime.


Parameters:

``lvItem``: The ``ListViewItem`` to add to the ``ListView``.

``listView``: The ``ListView`` to which the ``ListViewItem`` will be added.


To call this method, use the following syntax : ``ViewHandler.AddLvItemToListView(myListViewItem, myListView);``

To call this method with the ``CreateListViewItem`` method, use the following syntax : ``ViewHandler.AddLvItemToListView(ViewHandler.CreateListViewItem(myObject, "This string will be displayed"),myListView);``

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

### GetListFromListViewTags
`` GetListFromListViewTags<T>(ListView listView)``

Takes a ``ListView`` and tries to convert all items with a ``Tag`` property that matches with the specified ``Type`` to a list. If the object is not of the specified Type it is not converted.


Parameters:

``listView``: The ``ListView`` to retrieve items from.

Type Parameters:

``T``: The type to search for in the ``ListView`` items.

Returns:

``List<T>``: containing all the ``ListViewItem.Tag`` values that match the specified Type.


To call this method, use the following syntax : `` List<MyObject> myList = ViewHandler.GetListFromListViewTags<MyObject>(myListView);``


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
