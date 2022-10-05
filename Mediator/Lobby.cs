namespace Mediator;

public class Lobby : IMediator
{
    private List<Room> _notReserveRooms = new List<Room>();
    private List<Room> _rooms = new List<Room>();

    public void ShowNotReserveRooms()
    {
        foreach (var room in this._notReserveRooms)
        {
            Console.WriteLine(room);
        }
    }

    public Lobby(params Room[] rooms)
    {
        foreach (var room in rooms)
        {
            room.Mediator = this;
        }

        this._rooms = rooms.ToList();
    }
    public void NotifyNotReserve(object sender)
    {
        if (sender is Room r)
        {
            _notReserveRooms.Add(r);
        }

    }

    public void CheckReserve()
    {
        _notReserveRooms = new List<Room>();

        foreach (var room in _rooms)
        {
            room.IsReserve();
        }
    }

        
}