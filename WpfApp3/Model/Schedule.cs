using DevExpress.Mvvm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace WpfApp3.Model
{

    public class ModelAppointment : BindableBase
    {
        public string Id
        {
            get {return GetValue<string>(nameof(Id)); }
            set {SetValue(value,nameof(Id)); }
        }
        public int AppointmentType
        {
            get { return GetValue<int>(nameof(AppointmentType)); }
            set { SetValue(value, nameof(AppointmentType)); }
        }
        public bool AllDay
        {
            get { return GetValue<bool>(nameof(AllDay)); }
            set { SetValue(value, nameof(AllDay)); }
        }
        public DateTime Start
        {
            get { return GetValue<DateTime>(nameof(Start)); }
            set { SetValue(value, nameof(Start)); }
        }
        public DateTime End
        {
            get { return GetValue<DateTime>(nameof(End)); }
            set { SetValue(value, nameof(End)); }
        }

        public string Subject
        {
            get { return GetValue<string>(nameof(Subject)); }
            set { SetValue(value, nameof(Subject)); }
        }
        public string Description
        {
            get { return GetValue<string>(nameof(Description)); }
            set { SetValue(value, nameof(Description)); }
        }

        public int Status
        {
            get { return GetValue<int>(nameof(Status)); }
            set { SetValue(value, nameof(Status)); }
        }
        public string Label
        {
            get { return GetValue<string>(nameof(Label)); }
            set { SetValue(value, nameof(Label)); }
        }
        public string Location
        {
            get { return GetValue<string>(nameof(Location)); }
            set { SetValue(value, nameof(Location)); }
        }
        public IEnumerable<string> CalendarIds
        {
            get {return GetValue<IEnumerable<string>>(nameof(CalendarIds)); }
            set { SetValue(value, nameof(CalendarIds)); }
        }
        public string CalendarId { set { CalendarIds = new string[] { value }; } }

        public string RecurrenceInfo
        {
            get { return GetValue<string>(nameof(RecurrenceInfo)); }
            set { SetValue(value, nameof(RecurrenceInfo)); }
        }
        public string ReminderInfo
        {
            get { return GetValue<string>(nameof(ReminderInfo)); }
            set { SetValue(value, nameof(ReminderInfo)); }
        }
        public bool IsPrivate
        {
            get { return GetValue<bool>(nameof(IsPrivate)); }
            set { SetValue(value, nameof(IsPrivate)); }
        }
    }

    public class ModelResource : BindableBase
    {
        public string Id
        {
            get { return GetValue<string>(nameof(Id)); }
            set { SetValue(value, nameof(Id)); }
        }
        public string Name
        {
            get { return GetValue<string>(nameof(Name)); }
            set { SetValue(value, nameof(Name)); }
        }
        public bool IsVisible
        {
            get { return GetValue<bool>(nameof(IsVisible)); }
            set { SetValue(value, nameof(IsVisible)); }
        }
        public string Group
        {
            get { return GetValue<string>(nameof(Group)); }
            set { SetValue(value, nameof(Group)); }
        }
        public object Tag
        {
            get { return GetValue<object>(nameof(Tag)); }
            set { SetValue(value, nameof(Tag)); }
        }
    }
}
