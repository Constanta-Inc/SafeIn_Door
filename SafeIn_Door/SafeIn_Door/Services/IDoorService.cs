using SafeIn_Door.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SafeIn_Door.Services
{
    public interface IDoorService
    {
        Task<DoorOpenResult> DoorOpen(string doorID, string ScanResult);
    }
}
