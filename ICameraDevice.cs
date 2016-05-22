using System;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Media.Capture;

namespace Magellanic.Camera.Interfaces
{
    public interface ICameraDevice : IDisposable
    {
        MediaCapture ViewFinder { get; set; }

        Task<DeviceInformation> GetCameraAtPanelLocation(Panel cameraLocation);
        
        Task<DeviceInformation> GetDefaultCamera();

        Task InitialiseCameraAsync(DeviceInformation cameraToInitialise);
    }
}