using System;

namespace amuNewCrono.ViewModels.Interfaces
{
    public interface ICronoViewModel
    {
        TimeSpan timeCronoValOut { get; set; }
        void setCronoStop();
        void setCronoStart();
        void setCronoPause();
    }
}
