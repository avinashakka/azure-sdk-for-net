// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Properties of an event published to an Event Grid topic using the EventGrid Schema. </summary>
    public partial class EventGridEvent
    {
        /// <summary> Initializes a new instance of EventGridEvent. </summary>
        /// <param name="id"> An unique identifier for the event. </param>
        /// <param name="subject"> A resource path relative to the topic path. </param>
        /// <param name="data"> Event data specific to the event type. </param>
        /// <param name="eventType"> The type of the event that occurred. </param>
        /// <param name="eventTime"> The time (in UTC) the event was generated. </param>
        /// <param name="dataVersion"> The schema version of the data object. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="subject"/>, <paramref name="data"/>, <paramref name="eventType"/>, or <paramref name="dataVersion"/> is null. </exception>
        public EventGridEvent(string id, string subject, object data, string eventType, DateTimeOffset eventTime, string dataVersion)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (subject == null)
            {
                throw new ArgumentNullException(nameof(subject));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            if (eventType == null)
            {
                throw new ArgumentNullException(nameof(eventType));
            }
            if (dataVersion == null)
            {
                throw new ArgumentNullException(nameof(dataVersion));
            }

            Id = id;
            Subject = subject;
            Data = data;
            EventType = eventType;
            EventTime = eventTime;
            DataVersion = dataVersion;
        }

        /// <summary> An unique identifier for the event. </summary>
        public string Id { get; }
        /// <summary> The resource path of the event source. </summary>
        public string Topic { get; set; }
        /// <summary> A resource path relative to the topic path. </summary>
        public string Subject { get; }
        /// <summary> Event data specific to the event type. </summary>
        public object Data { get; }
        /// <summary> The type of the event that occurred. </summary>
        public string EventType { get; }
        /// <summary> The time (in UTC) the event was generated. </summary>
        public DateTimeOffset EventTime { get; }
        /// <summary> The schema version of the event metadata. </summary>
        public string MetadataVersion { get; }
        /// <summary> The schema version of the data object. </summary>
        public string DataVersion { get; }
    }
}
