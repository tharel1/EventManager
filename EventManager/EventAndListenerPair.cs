﻿using Event.Listeners;
using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
   class EventAndListenerPair<T>
   {
      public EventType Event { get; }
      public Listener<T> Listener { get; }

      public EventAndListenerPair(EventType Event, Listener<T> listener)
      {
         this.Event = Event;
         Listener = listener;
      }
   }
}
