namespace RideSharingApplication.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {

        ITripRepository TripRepository { get; }

        ICarRepository CarRepository { get; }


        void Save();

    }
}
