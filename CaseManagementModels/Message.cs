using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseManagementModels
{
    public class Message
    {
        public DateTime MessageDateTime = DateTime.Now;
        public string Prompt { get; set; } = string.Empty;
        public string Completion { get; set; } = string.Empty;
        public List<string> Citations { get; set; } = new List<string>();

        public Message(string prompt)
        {
            Prompt = prompt;
        }
    }
}
