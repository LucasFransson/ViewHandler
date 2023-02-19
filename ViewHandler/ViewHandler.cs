
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace UIViewHandler
{


    public static class ViewHandler
    {
        /// <summary>
        /// Changes the foreground color of a single FrameworkElement to the specified Color
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element">The FrameworkElement</param>
        /// <param name="color">The new Color</param>
        public static void ChangeElementForeground<T>(Color color, T element) where T : FrameworkElement
        {
            if (element is Control control)
            {
                control.Foreground = new SolidColorBrush(color);
            }
        }

        /// <summary>
        /// Changes the foreground color of multiple FrameworkElement objects passed as parameters to the specified Color.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="color"></param>
        /// <param name="elements"></param>
        public static void ChangeElementsForeground<T>(Color color, params T[] elements) where T : FrameworkElement
        {
            foreach (T element in elements)
            {
                if (element is Control control)
                {
                    control.Foreground = new SolidColorBrush(color);
                }
            }
        }

        /// <summary>
        ///  Changes the background color of a single FrameworkElement to the specified Color.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element"></param>
        /// <param name="color"></param>
        public static void ChangeElementBackground<T>(Color color, T element) where T : FrameworkElement
        {
            if (element is Control control)
            {
                control.Background = new SolidColorBrush(color);
            }
        }

        /// <summary>
        /// Changes the background color of multiple FrameworkElement objects passed as parameters to the specified Color.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="color"></param>
        /// <param name="elements"></param>
        public static void ChangeElementsBackground<T>(Color color, params T[] elements) where T : FrameworkElement
        {
            foreach (T element in elements)
            {
                if (element is Control control)
                {
                    control.Background = new SolidColorBrush(color);
                }
            }
        }

        /// <summary>
        /// Creates and shows a new Window object of the specified Type parameter.
        /// </summary>
        /// <param name="window"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void OpenNewWindow(Type window)
        {
            if (!window.IsSubclassOf(typeof(Window)))    // Checks if the passed Type is derived from the Window Class
            {
                throw new ArgumentException("The type must be a derived class of the Window class.");
            }

            Window newWindow = (Window)Activator.CreateInstance(window);    // Using Reflection to resolve creation of instance at runtime. Tries to Cast the uknown passed Type into a subclass of Window, throws an Error if it's not derived from Window.
            newWindow.Show();
        }

        /// <summary>
        /// Closes the specified Window object.
        /// </summary>
        /// <param name="window"></param>
        public static void CloseWindow(Window window)
        {
            window.Close();
        }

        /// <summary>
        /// Changes multiple FrameworkElement objects IsEnabled property to false.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elements"></param>

        public static void DisableElements<T>(params T[] elements) where T : FrameworkElement
        {
            foreach (T element in elements)
            {
                if (element is FrameworkElement frameElement)
                {
                    frameElement.IsEnabled = false;
                }
            }
        }

        /// <summary>
        /// Changes multiple FrameworkElement objects IsEnabled property to true.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elements"></param>
        public static void EnableElements<T>(params T[] elements) where T : FrameworkElement
        {
            foreach (T element in elements)
            {
                if (element is FrameworkElement frameElement)
                {
                    frameElement.IsEnabled = true;
                }
            }
        }

        /// <summary>
        /// Changes multiple FrameworkElement objects Visibility property to Collapsed.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elements"></param>
        public static void CollapseElements<T>(params T[] elements) where T : FrameworkElement
        {
            foreach (T element in elements)
            {
                if (element is FrameworkElement frameElement)
                {
                    frameElement.Visibility = Visibility.Collapsed;
                }
            }
        }

        /// <summary>
        /// Changes multiple FrameworkElement objects Visibility property to Visible.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elements"></param>
        public static void ShowElements<T>(params T[] elements) where T : FrameworkElement
        {
            foreach (T element in elements)
            {
                if (element is FrameworkElement frameElement)
                {
                    frameElement.Visibility = Visibility.Visible;
                }
            }
        }

        /// <summary>
        /// Sets multiple FrameworkElement objects FontSize to the specified size.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="newFontSize"></param>
        /// <param name="elements"></param>
        public static void SetElementsFontSize<T>(int newFontSize, params T[] elements) where T : FrameworkElement
        {
            foreach (T element in elements)
            {
                if (element is Control control)
                {
                    control.FontSize = newFontSize;
                }
            }
        }

        /// <summary>
        /// Checks if each and every Textbox from the parameters is either null or empty. Returns true if any Textbox is not null or empty, else return false.
        /// </summary>
        /// <param name="textBoxes"></param>
        /// <returns></returns>

        public static bool AreTextBoxesEmptyOrNull(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    return true;    // If the current textbox from the parameters is null or empty, then return true and break the loop. Else check the next textbox.
                }
            }
            return false;    // If none of the textboxes was null or empty after iterating through all the parameters, then return false and break the loop
        }

        /// <summary>
        /// Sets the content of a list to a specified Combobox. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cbo"></param>
        /// <param name="list"></param>
        public static void LoadObjectsToComboBox<T>(ComboBox cbo, List<T> list)
        {
            foreach (var item in list)
            {
                cbo.Items.Add(item.ToString());
            }
        }

        /// <summary>
        /// Create an initial preview item displayed in a specific combobox.
        /// </summary>
        /// <param name="cbo"></param>
        /// <param name="textItem"></param>
        public static void SetComboBoxPreviewItem(ComboBox cbo, string textItem)
        {
            cbo.IsEditable = true;
            cbo.IsReadOnly = true;
            cbo.Text = textItem;
        }

        /// <summary>
        /// Clears a specific Listview, then iterates over an IEnumerable and adds each item.ToString().
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lv"></param>
        /// <param name="collection"></param>
        public static void UpdateListView<T>(ListView lv, IEnumerable<T> collection)
        {
            lv.Items.Clear();
            foreach (var item in collection)
            {
                lv.Items.Add(item.ToString());
            }
        }
        /// <summary>
        /// Takes a string and tries to convert it into an enum objecy of a specific enum type. Throws an error on failed conversion.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stringToParse"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static T ParseStringToEnum<T>(string stringToParse) where T : struct, Enum
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException($"{typeof(T).FullName} is not an enum type.");
            }

            if (Enum.TryParse<T>(stringToParse, out T result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException($"'{stringToParse}' is not a valid value of {typeof(T).FullName} enum.");
            }
        }

        /// <summary>
        /// Returns a list of all possible values for the specified enum type.
        /// </summary>
        /// <typeparam name="T">The type of the enum to get the list for.</typeparam>
        /// <returns>A list of all possible values for the specified enum type.</returns>
        /// <exception cref="ArgumentException">Thrown when T is not an enum type.</exception>
        public static List<T> GetEnumList<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T)).Cast<T>().ToList();
        }


        /// <summary>
        /// Creates a ListViewItem with the specified object and content.
        /// </summary>
        /// <param name="obj">The object to set as the Tag property of the ListViewItem.</param>
        /// <param name="objContent">The content to set as the Content property of the ListViewItem.</param>
        /// <returns>A new ListViewItem with the specified object and content.</returns>
        public static ListViewItem CreateListViewItem(Object obj, string objContent)
        {
            ListViewItem lvItem = new();
            lvItem.Tag = obj;
            lvItem.Content = objContent;
            return lvItem;
        }


        /// <summary>
        /// Adds the specified ListViewItem to the specified ListView.
        /// </summary>
        /// <param name="lvItem">The ListViewItem to add to the ListView.</param>
        /// <param name="listView">The ListView to add the ListViewItem to.</param>
        public static void AddLvItemToListView(ListViewItem lvItem, ListView listView)
        {
            listView.Items.Add(lvItem);
        }

        /// <summary>
        /// Returns a list of objects whose type matches T from all ListViewItems with a Tag property that can be cast to T.
        /// </summary>
        /// <typeparam name="T">The type of the objects to return.</typeparam>
        /// <param name="listView">The ListView to get the objects from.</param>
        /// <returns>A list of objects whose type matches T from all ListViewItems with a Tag property that can be cast to T.</returns>
        /// <remarks>
        /// If an object's Tag property cannot be cast to T, it will be ignored.
        /// </remarks>
        public static List<T> GetListFromListViewTags<T>(ListView listView) where T : class
        {
            if (listView.Items.Count == 0)
            {
                return new List<T>();
            }

            List<T> list = new List<T>();
            foreach (var item in listView.Items)
            {
                if (item is ListViewItem listViewItem)
                {
                    T tag = listViewItem.Tag as T;
                    if (tag != null)
                    {
                        list.Add(tag);
                    }
                }
            }
            return list;
        }
    }
}
    