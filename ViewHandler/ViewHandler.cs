
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
        /// <param name="element"></param>
        /// <param name="color"></param>
        public static void ChangeElementForeground<T>(T element, Color color) where T : FrameworkElement
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
        public static void ChangeElementBackground<T>(T element, Color color) where T : FrameworkElement
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
    }
}