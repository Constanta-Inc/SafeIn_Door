using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SafeIn_Door.Helpers
{
    public static class DoorID_Validation
    {
        public static async Task<bool> Validate_door_id(string door_id)
        {
            if (string.IsNullOrWhiteSpace(door_id))
                return false;
            try
            {
                return Regex.IsMatch(door_id, "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[1-5][a-fA-F0-9]{3}-[89aAbB][a-fA-F0-9]{3}-[a-fA-F0-9]{12}$");
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
