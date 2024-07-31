using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace yasapp.Shared
{
    public class YasappExceptionModel
    {
        public YasappExceptionModel()
        {
            Messages = new List<string>();
        }

        public YasappExceptionModel(YasappException exception)
        {

            Title = exception.Title;
            Severity = exception.Severity;
            Messages = exception.Messages;
            PlaceOfOccurence = exception.PlaceOfOccurence;
            Description = exception.Description;
            TimeStamp = DateTime.UtcNow;
        }

        public YasappExceptionModel(Exception generalExc, string description, string placeOfOccurence)
        {
            Messages = new List<string>()
            {
                generalExc.Message
            };

            Title = "Allgemeiner Fehler";
            Severity = "error";
            PlaceOfOccurence = placeOfOccurence;
            Description = description;
            TimeStamp = DateTime.Now;

            if (generalExc.InnerException != null)
            {
                Messages.Add(generalExc.InnerException.Message);
            }
        }


        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("severity")]
        public string Severity { get; set; }

        [JsonPropertyName("messages")]

        public List<string>? Messages { get; set; }

        [JsonPropertyName("place_of_occurence")]
        public string? PlaceOfOccurence { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime TimeStamp { get; set; }
    }
}
