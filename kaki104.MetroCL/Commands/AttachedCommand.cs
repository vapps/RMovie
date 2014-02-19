//winRT에서는 이벤트를 다이나믹하게 추가할 수 없다고 나오는데..
//using System;
//using System.Reflection;
//using System.Windows.Input;
//using Windows.UI.Xaml;

//namespace kaki104.MetroCL
//{
//    public static class AttachedCommand
//    {
//        #region Command

//        /// <summary>
//        /// Command attached property
//        /// </summary>
//        public static readonly DependencyProperty CommandProperty =
//            DependencyProperty.RegisterAttached("Command",
//            typeof(Object),
//            typeof(AttachedCommand), new PropertyMetadata(DependencyProperty.UnsetValue));

//        public static ICommand GetCommand(DependencyObject d)
//        {
//            return (ICommand)d.GetValue(CommandProperty);
//        }
//        public static void SetCommand(DependencyObject d, ICommand value)
//        {
//            d.SetValue(CommandProperty, value);
//        }
//        #endregion

//        #region RoutedEvent

//        /// <summary>
//        /// RoutedEvent property
//        /// </summary>
//        public static readonly DependencyProperty RoutedEventProperty =
//            DependencyProperty.RegisterAttached("RoutedEvent",
//            typeof(String),
//            typeof(AttachedCommand),
//            new PropertyMetadata(String.Empty, new PropertyChangedCallback(OnRoutedEventChanged)));

//        public static String GetRoutedEvent(DependencyObject d)
//        {
//            return (String)d.GetValue(RoutedEventProperty);
//        }

//        public static void SetRoutedEvent(DependencyObject d, String value)
//        {
//            d.SetValue(RoutedEventProperty, value);
//        }

//        private static void OnRoutedEventChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
//        {
//            String routedEvent = (String)e.NewValue;

//            if (!String.IsNullOrEmpty(routedEvent))
//            {
//                EventHooker eventHooker = new EventHooker();
//                eventHooker.AttachedCommandObject = d;
//                EventInfo eventInfo = GetEventInfo(d.GetType(), routedEvent);

//                if (eventInfo != null)
//                {
//                    eventInfo.AddEventHandler(d, eventHooker.GetEventHandler(eventInfo));
//                }

//            }
//        }

//        /// <summary>
//        /// Search the EventInfo from the type and its base types
//        /// </summary>
//        /// <param name="type"></param>
//        /// <param name="eventName"></param>
//        /// <returns></returns>
//        private static EventInfo GetEventInfo(Type type, string eventName)
//        {
//            EventInfo eventInfo = null;
//            eventInfo = type.GetTypeInfo().GetDeclaredEvent(eventName);
//            if (eventInfo == null)
//            {
//                Type baseType = type.GetTypeInfo().BaseType;
//                if (baseType != null)
//                    return GetEventInfo(type.GetTypeInfo().BaseType, eventName);
//                else
//                    return eventInfo;
//            }
//            return eventInfo;
//        }
//        #endregion
//    }

//    internal sealed class EventHooker
//    {
//        public DependencyObject AttachedCommandObject { get; set; }

//        public Delegate GetEventHandler(EventInfo eventInfo)
//        {
//            Delegate del = null;
//            if (eventInfo == null)
//                throw new ArgumentNullException("eventInfo");

//            if (eventInfo.EventHandlerType == null)
//                throw new ArgumentNullException("eventInfo.EventHandlerType");

//            if (del == null)
//                del = this.GetType().GetTypeInfo().GetDeclaredMethod("OnEventRaised").CreateDelegate(eventInfo.EventHandlerType, this);

//            return del;
//        }

//        private void OnEventRaised(object sender, object e)
//        {
//            ICommand command = (ICommand)(sender as DependencyObject).GetValue(AttachedCommand.CommandProperty);

//            if (command != null)
//                command.Execute(null);
//        }
//    }
//}
